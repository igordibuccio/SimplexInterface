using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SimplexInterface
{
   public partial class Form1 : MetroFramework.Forms.MetroForm
   {
      int _qtVariaveis = 0;
      public Form1()
      {
         InitializeComponent();
      }
      private void CriaGridSimplex()
      {
         // Cria as colunas (variáveis) de acordo o valor inserido pelo usuário.
         for (int i = 0; i < _qtVariaveis; i++)
         {
            dgvSimplex.Columns.Add("x" + (i + 1), "x" + (i + 1));
            dgvSimplex.Columns[i].Width = 50;
         }

         //Cria uma coluna de Igualdade, que servirá apenas para as restrições.
         DataGridViewComboBoxColumn cboGrid = new DataGridViewComboBoxColumn();
         cboGrid.Name = "Igualdade";
         cboGrid.HeaderText = "Igualdade";
         cboGrid.Width = 120;

         //Define os valores para incluir na Coluna de Igualdade.
         cboGrid.Items.Add("IGUAL");
         cboGrid.Items.Add("MAIOR");
         cboGrid.Items.Add("MAIOR_IGUAL");
         cboGrid.Items.Add("MENOR");
         cboGrid.Items.Add("MENOR_IGUAL");
         dgvSimplex.Columns.Add(cboGrid);

         //Cria coluna para resultado da igualdade das restrições.
         DataGridViewTextBoxColumn cTxtResultado = new DataGridViewTextBoxColumn();
         cTxtResultado.Name = "Resultado";
         cTxtResultado.HeaderText = "Resultado";
         dgvSimplex.Columns.Add(cTxtResultado);

         //Coloca as colunas Igualdade e Resultado como somente leitura na linha da função objetiva.
         dgvSimplex.Rows[0].Cells["Igualdade"].ReadOnly = true;
         dgvSimplex.Rows[0].Cells["Resultado"].ReadOnly = true;

         //Configura os objetos para continuar o procedimento para calcular.
         dgvSimplex.Enabled = true;
         txtQtVariaveis.Enabled = false;
         btIniciar.Enabled = false;
         btIniciar.UseCustomBackColor = true;
         btIniciar.BackColor = Color.Gainsboro;
         btCalcular.Enabled = true;
      }
      private void button1_Click(object sender, EventArgs e)
      {
         if (txtQtVariaveis.Text != "")
         {
            _qtVariaveis = Convert.ToInt32(txtQtVariaveis.Text);

            if (_qtVariaveis > 0)
            {
               CriaGridSimplex();
               dgvSimplex.Rows[0].Cells[0].Selected = true;
            }
            else
            {
               MessageBox.Show("A quantidades de variáveis deve ser informada.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtQtVariaveis.Focus();
            }
         }
         else
         {
            MessageBox.Show("A quantidades de variáveis deve ser informada.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtQtVariaveis.Focus();
         }
      }
      private void Form1_KeyPress(object sender, KeyPressEventArgs e)
      {
         //Valida se o que o usuário está digitando é um número.
         if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && (e.KeyChar != 45) && !(e.KeyChar == (char)Keys.Back) &&
            !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Tab) && !(e.KeyChar == (char)Keys.Escape) && (e.KeyChar !=46))
            e.Handled = true;
         else if (e.KeyChar == (char)Keys.Enter)
         {
            e.KeyChar = (char)Keys.Tab;
            SendKeys.Send(e.KeyChar.ToString());
         }
         else if (e.KeyChar == (char)Keys.Escape)
         {
            if (dgvSimplex.Rows.Count > 0  && MessageBox.Show("Deseja abandonar os dados ?", "Interface Simplex", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               LimpaForm();
            }
            else
            {
               Application.Exit();
            }
         }
      }
      public void LimpaForm()
      {
         dgvSimplex.Columns.Clear();
         dgvSimplex.Rows.Clear();
         dgvSimplex.Enabled = false;
         txtQtVariaveis.Enabled = true;
         txtQtVariaveis.Clear();
         rbMax.Checked = true;
         btIniciar.UseCustomBackColor = false;
         //btIniciar.BackColor = Color.Gainsboro;
         btIniciar.Enabled = true;
         btCalcular.Enabled = false;
      }
      private void txtQtVariaveis_KeyPress(object sender, KeyPressEventArgs e)
      {
         //Valida se o que o usuário está digitando é um número.
         if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Enter) && !(e.KeyChar == (char)Keys.Tab))
            e.Handled = true;
         else if (e.KeyChar == (char)Keys.Enter)
         {
            e.KeyChar = (char)Keys.Tab;
            SendKeys.Send(e.KeyChar.ToString());
         }
      }
      private void dgvSimplex_RowLeave(object sender, DataGridViewCellEventArgs e)
      {
         //Valida se o GRID tem linhas para realizar as validações.
         if (dgvSimplex.Rows.Count > 0)
         {
            //Tratamento para inserir o valor zero nas celulas que o usuário deixou em branco da nova linha inserida.
            if (dgvSimplex.Rows.Count - 1 != dgvSimplex.CurrentRow.Index)
            {
               for (int i = 0; i < dgvSimplex.Columns.Count - 2; i++)
               {
                  if (dgvSimplex.Rows[dgvSimplex.CurrentRow.Index].Cells[i].Value == null)
                  {
                     dgvSimplex.Rows[dgvSimplex.CurrentRow.Index].Cells[i].Value = 0;
                  }
               }
            }

            //Se a linha corrente que o usuário estiver é a indice 0 = linha da função objetiva, o sistema coloca ela de uma cor diferente.
            if (dgvSimplex.CurrentRow.Index == 0)
            {
               if (dgvSimplex.Rows[dgvSimplex.CurrentRow.Index].Cells[0].Value != null)
               {
                  dgvSimplex.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
               }
            }         
         }
      }
      private void dgvSimplex_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
      {
         //Valida se os valores das celulas Igualdade e Resultado das RESTRIÇÕES foram informados.
         if (dgvSimplex.CurrentRow.Index > 0 && dgvSimplex.Rows.Count - 1 != dgvSimplex.CurrentRow.Index)
         {
            if (dgvSimplex.CurrentRow.Cells[dgvSimplex.Columns.Count - 1].Value == null || dgvSimplex.CurrentRow.Cells[dgvSimplex.Columns.Count - 2].Value == null)
            {
               MessageBox.Show("Os valores de Igualdade e Resultado devem ser informados.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
               dgvSimplex.CurrentCell = dgvSimplex.CurrentRow.Cells[dgvSimplex.Columns.Count - 1];
               e.Cancel = true;
            }
         }
      }

      /// <summary>
      /// Função que ira valida os valores inseridos no GRID.
      /// </summary>
      /// <returns></returns>
      public bool ValidaGrid()
      {
         if (dgvSimplex.Rows.Count >= 2)
            return true;
         else
            return false;
      }

      /// <summary>
      /// Função para criar o JSON no formato que o WS espera os valores.
      /// </summary>
      /// <returns></returns>
      public string CriaJSON()
      {
         string StrJson = "";
         string TipoFO = "";

         //Define se o Problema é de Minimização ou Maximização
         if (rbMax.Checked)
            TipoFO = "MAX";
         else if (rbMin.Checked)
            TipoFO = "MIN";

         //Define os valores da Função objetiva
         StrJson = "{";
         StrJson += "\"tipoFuncaoObjetivo\":\"" + TipoFO + "\",";
         StrJson += "\"listaSentencasFuncaoObjetiva\":[";
         for (int i = 0; i < dgvSimplex.Columns.Count - 2; i++)
         {
            StrJson += "{\"valor\":" + dgvSimplex.Rows[0].Cells[i].Value + "," + "\"nome\"" + ":\"" + dgvSimplex.Columns[i].HeaderText + "\"}";
            if (i != dgvSimplex.Columns.Count - 3)
               StrJson += ",";
         }
         StrJson += "],";

         //Define os valores das restrições
         StrJson += "\"listaDadosRestricoes\":[";
         for (int i = 1; i < dgvSimplex.Rows.Count - 1; i++)
         {
            StrJson += "{";
            StrJson += "\"listaValoresRestricoes\":[";
            for (int j = 0; j < dgvSimplex.Columns.Count - 2; j++)
            {
               StrJson += "{\"valor\":" + dgvSimplex.Rows[i].Cells[j].Value + "," + "\"nome\"" + ":\"" + dgvSimplex.Columns[j].HeaderText + "\"}";
               if (j != dgvSimplex.Columns.Count - 3)
                  StrJson += ",";
            }
            StrJson += "],";
            StrJson += "\"sinalOperacao\":" + "\"" + dgvSimplex.Rows[i].Cells[dgvSimplex.Columns.Count - 2].Value + "\",";
            StrJson += "\"resultado\":" + dgvSimplex.Rows[i].Cells[dgvSimplex.Columns.Count - 1].Value;
            StrJson += "}";

            if (i != dgvSimplex.Rows.Count - 2)
               StrJson += ",";
         }
         StrJson += "]}";

         return StrJson;
      }
      public string EnviaJSON()
      {
         //Cria o objeto para fazer requisição ao servidor.
         var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://54.207.22.117:8080/Simplex-1.0.0/simplex");

         //Define o tipo de requisição
         httpWebRequest.ContentType = "application/json";
         httpWebRequest.Method = "POST";

         //Envia os dados do JSON ao Servidor.
         using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
         {
            streamWriter.Write(CriaJSON());
         }

         //Pega o Response retornado pelo Servidor.
         var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
         var result = "";
         using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
         {
            result = streamReader.ReadToEnd();
         }

         return result;
      }

      private void btCalcular_Click(object sender, EventArgs e)
      {
         //Valida se os dados inseridos estão validos para realizar o calculo.
         if (!ValidaGrid())
         {
            MessageBox.Show("Dados insuficientes para realizar o calculo.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }
         else
         {
            //Faz a requisição ao WS para o Calculo do Simplex.
            string ResultadoJson = "";
            ResultadoJson = EnviaJSON();

            //Chama o form que irá exibir o resultado.
            frmResultado frm = new frmResultado(ResultadoJson);
            frm.ShowDialog();
            frm.Dispose();
            frm = null;

            //MessageBox.Show(EnviaJSON(), "Result");
         }
      }
   }
}
