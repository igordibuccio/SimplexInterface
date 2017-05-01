using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimplexInterface
{
   public partial class frmResultado : MetroFramework.Forms.MetroForm
   {
      public frmResultado(string pResultado)
      {
         InitializeComponent();

         txtResultado.Text = TraduzResultado(pResultado, 1);
         txtResultado.SelectionStart = txtResultado.Text.Length;
      }

      private void frmResultado_Load(object sender, EventArgs e)
      {
         //Chama o Form de Awaiting Process (Apenas Visual) - 5 Segundos de espera.
         frmProcesso frm = new frmProcesso();
         frm.ShowDialog();
         frm.Dispose();
         frm = null;
      }

      //Pega apenas o valor retornado pelo WS.
      public string TraduzResultado(string pResultadoIni, int pos)
      {
         string[] Vet = pResultadoIni.Split(':');

         if (pos <= Vet.Length)
            return LimpaStr(Vet[pos]);

         return "";
      }


      //Limpa a String de retorno.
      public string LimpaStr(string pString)
      {
         string ret = "";

         ret = pString;
         ret = ret.Replace('{', ' ');
         ret = ret.Replace('}', ' ');
         ret = ret.Replace('\"', ' ');

         return ret;
      }

      private void frmResultado_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == (char) Keys.Escape)
         {
            if (txtResultado.Text.Length > 0)
            {
               if (MessageBox.Show("Deseja abandonar o resultado ?", "Interface Simplex", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               {
                  this.Close();
               }
            }
            else
            {
               this.Close();
            }
         }
      }
   }
}
