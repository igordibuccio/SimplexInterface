namespace SimplexInterface
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.dgvSimplex = new System.Windows.Forms.DataGridView();
         this.rbMax = new MetroFramework.Controls.MetroRadioButton();
         this.rbMin = new MetroFramework.Controls.MetroRadioButton();
         this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
         this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
         this.txtQtVariaveis = new MetroFramework.Controls.MetroTextBox();
         this.btCalcular = new MetroFramework.Controls.MetroTile();
         this.btIniciar = new MetroFramework.Controls.MetroTile();
         this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
         this.labelX1 = new DevComponents.DotNetBar.LabelX();
         this.labelX2 = new DevComponents.DotNetBar.LabelX();
         this.labelX3 = new DevComponents.DotNetBar.LabelX();
         this.labelX4 = new DevComponents.DotNetBar.LabelX();
         ((System.ComponentModel.ISupportInitialize)(this.dgvSimplex)).BeginInit();
         this.SuspendLayout();
         // 
         // dgvSimplex
         // 
         this.dgvSimplex.BackgroundColor = System.Drawing.Color.White;
         this.dgvSimplex.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.dgvSimplex.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
         this.dgvSimplex.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
         dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dgvSimplex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dgvSimplex.ColumnHeadersHeight = 28;
         this.dgvSimplex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.dgvSimplex.Enabled = false;
         this.dgvSimplex.EnableHeadersVisualStyles = false;
         this.dgvSimplex.Location = new System.Drawing.Point(65, 203);
         this.dgvSimplex.MultiSelect = false;
         this.dgvSimplex.Name = "dgvSimplex";
         this.dgvSimplex.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
         this.dgvSimplex.RowHeadersWidth = 25;
         this.dgvSimplex.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
         this.dgvSimplex.RowsDefaultCellStyle = dataGridViewCellStyle2;
         this.dgvSimplex.Size = new System.Drawing.Size(598, 192);
         this.dgvSimplex.TabIndex = 6;
         this.dgvSimplex.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSimplex_RowLeave);
         this.dgvSimplex.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvSimplex_RowValidating);
         // 
         // rbMax
         // 
         this.rbMax.AutoSize = true;
         this.rbMax.Checked = true;
         this.rbMax.Location = new System.Drawing.Point(244, 134);
         this.rbMax.Name = "rbMax";
         this.rbMax.Size = new System.Drawing.Size(92, 15);
         this.rbMax.Style = MetroFramework.MetroColorStyle.Black;
         this.rbMax.TabIndex = 2;
         this.rbMax.TabStop = true;
         this.rbMax.Text = "Maximização";
         this.rbMax.UseSelectable = true;
         // 
         // rbMin
         // 
         this.rbMin.AutoSize = true;
         this.rbMin.Location = new System.Drawing.Point(342, 134);
         this.rbMin.Name = "rbMin";
         this.rbMin.Size = new System.Drawing.Size(91, 15);
         this.rbMin.Style = MetroFramework.MetroColorStyle.Black;
         this.rbMin.TabIndex = 3;
         this.rbMin.Text = "Minimização";
         this.rbMin.UseSelectable = true;
         // 
         // metroLabel1
         // 
         this.metroLabel1.AutoSize = true;
         this.metroLabel1.Location = new System.Drawing.Point(244, 107);
         this.metroLabel1.Name = "metroLabel1";
         this.metroLabel1.Size = new System.Drawing.Size(147, 19);
         this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
         this.metroLabel1.TabIndex = 65459;
         this.metroLabel1.Text = "Tipo de função objetiva";
         // 
         // metroLabel2
         // 
         this.metroLabel2.AutoSize = true;
         this.metroLabel2.Location = new System.Drawing.Point(69, 107);
         this.metroLabel2.Name = "metroLabel2";
         this.metroLabel2.Size = new System.Drawing.Size(143, 19);
         this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
         this.metroLabel2.TabIndex = 65460;
         this.metroLabel2.Text = "Quant. variáveis da F.O";
         // 
         // txtQtVariaveis
         // 
         // 
         // 
         // 
         this.txtQtVariaveis.CustomButton.Image = null;
         this.txtQtVariaveis.CustomButton.Location = new System.Drawing.Point(136, 1);
         this.txtQtVariaveis.CustomButton.Name = "";
         this.txtQtVariaveis.CustomButton.Size = new System.Drawing.Size(21, 21);
         this.txtQtVariaveis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
         this.txtQtVariaveis.CustomButton.TabIndex = 1;
         this.txtQtVariaveis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
         this.txtQtVariaveis.CustomButton.UseSelectable = true;
         this.txtQtVariaveis.CustomButton.Visible = false;
         this.txtQtVariaveis.Lines = new string[0];
         this.txtQtVariaveis.Location = new System.Drawing.Point(69, 130);
         this.txtQtVariaveis.MaxLength = 32767;
         this.txtQtVariaveis.Name = "txtQtVariaveis";
         this.txtQtVariaveis.PasswordChar = '\0';
         this.txtQtVariaveis.ScrollBars = System.Windows.Forms.ScrollBars.None;
         this.txtQtVariaveis.SelectedText = "";
         this.txtQtVariaveis.SelectionLength = 0;
         this.txtQtVariaveis.SelectionStart = 0;
         this.txtQtVariaveis.ShortcutsEnabled = true;
         this.txtQtVariaveis.Size = new System.Drawing.Size(158, 23);
         this.txtQtVariaveis.Style = MetroFramework.MetroColorStyle.Black;
         this.txtQtVariaveis.TabIndex = 1;
         this.txtQtVariaveis.UseSelectable = true;
         this.txtQtVariaveis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
         this.txtQtVariaveis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
         // 
         // btCalcular
         // 
         this.btCalcular.ActiveControl = null;
         this.btCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btCalcular.Enabled = false;
         this.btCalcular.Location = new System.Drawing.Point(567, 107);
         this.btCalcular.Name = "btCalcular";
         this.btCalcular.Size = new System.Drawing.Size(100, 42);
         this.btCalcular.Style = MetroFramework.MetroColorStyle.White;
         this.btCalcular.TabIndex = 5;
         this.btCalcular.Text = "Calcular";
         this.btCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btCalcular.TileImage = ((System.Drawing.Image)(resources.GetObject("btCalcular.TileImage")));
         this.btCalcular.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btCalcular.UseCustomForeColor = true;
         this.btCalcular.UseSelectable = true;
         this.btCalcular.UseTileImage = true;
         this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
         // 
         // btIniciar
         // 
         this.btIniciar.ActiveControl = null;
         this.btIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btIniciar.Location = new System.Drawing.Point(458, 107);
         this.btIniciar.Name = "btIniciar";
         this.btIniciar.Size = new System.Drawing.Size(100, 42);
         this.btIniciar.Style = MetroFramework.MetroColorStyle.White;
         this.btIniciar.TabIndex = 4;
         this.btIniciar.Text = "Iniciar";
         this.btIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.btIniciar.TileImage = ((System.Drawing.Image)(resources.GetObject("btIniciar.TileImage")));
         this.btIniciar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.btIniciar.UseCustomForeColor = true;
         this.btIniciar.UseSelectable = true;
         this.btIniciar.UseTileImage = true;
         this.btIniciar.Click += new System.EventHandler(this.button1_Click);
         // 
         // metroLabel3
         // 
         this.metroLabel3.AutoSize = true;
         this.metroLabel3.Location = new System.Drawing.Point(65, 181);
         this.metroLabel3.Name = "metroLabel3";
         this.metroLabel3.Size = new System.Drawing.Size(174, 19);
         this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
         this.metroLabel3.TabIndex = 65464;
         this.metroLabel3.Text = "Função objetiva e Restrições";
         // 
         // labelX1
         // 
         // 
         // 
         // 
         this.labelX1.BackgroundStyle.Class = "";
         this.labelX1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX1.ForeColor = System.Drawing.Color.Black;
         this.labelX1.Location = new System.Drawing.Point(100, 398);
         this.labelX1.Name = "labelX1";
         this.labelX1.SingleLineColor = System.Drawing.SystemColors.ControlText;
         this.labelX1.Size = new System.Drawing.Size(218, 23);
         this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
         this.labelX1.TabIndex = 65465;
         this.labelX1.Text = "[ <b> PRIMEIRA LINHA </b> ] - Função objetiva.";
         // 
         // labelX2
         // 
         // 
         // 
         // 
         this.labelX2.BackgroundStyle.Class = "";
         this.labelX2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX2.ForeColor = System.Drawing.Color.Black;
         this.labelX2.Location = new System.Drawing.Point(324, 398);
         this.labelX2.Name = "labelX2";
         this.labelX2.SingleLineColor = System.Drawing.SystemColors.ControlText;
         this.labelX2.Size = new System.Drawing.Size(304, 23);
         this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
         this.labelX2.TabIndex = 65466;
         this.labelX2.Text = "[ <b> SEGUNDA LINHA EM DIANTE </b> ] -Restrições da F.O.";
         // 
         // labelX3
         // 
         // 
         // 
         // 
         this.labelX3.BackgroundStyle.Class = "";
         this.labelX3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX3.ForeColor = System.Drawing.Color.Black;
         this.labelX3.Location = new System.Drawing.Point(352, 418);
         this.labelX3.Name = "labelX3";
         this.labelX3.SingleLineColor = System.Drawing.SystemColors.ControlText;
         this.labelX3.Size = new System.Drawing.Size(148, 23);
         this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
         this.labelX3.TabIndex = 65467;
         this.labelX3.Text = "[ <b> DELETE </b> ] - Excluir linha.";
         // 
         // labelX4
         // 
         // 
         // 
         // 
         this.labelX4.BackgroundStyle.Class = "";
         this.labelX4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelX4.ForeColor = System.Drawing.Color.Black;
         this.labelX4.Location = new System.Drawing.Point(100, 418);
         this.labelX4.Name = "labelX4";
         this.labelX4.SingleLineColor = System.Drawing.SystemColors.ControlText;
         this.labelX4.Size = new System.Drawing.Size(246, 23);
         this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
         this.labelX4.TabIndex = 65468;
         this.labelX4.Text = "[ <b> ESC </b> ] - Limpar dados / Finalizar aplicação.";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(728, 456);
         this.Controls.Add(this.labelX4);
         this.Controls.Add(this.labelX3);
         this.Controls.Add(this.labelX2);
         this.Controls.Add(this.labelX1);
         this.Controls.Add(this.metroLabel3);
         this.Controls.Add(this.btIniciar);
         this.Controls.Add(this.btCalcular);
         this.Controls.Add(this.txtQtVariaveis);
         this.Controls.Add(this.metroLabel2);
         this.Controls.Add(this.metroLabel1);
         this.Controls.Add(this.rbMin);
         this.Controls.Add(this.rbMax);
         this.Controls.Add(this.dgvSimplex);
         this.KeyPreview = true;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Form1";
         this.Resizable = false;
         this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
         this.Style = MetroFramework.MetroColorStyle.Black;
         this.Text = "Interface Simplex";
         this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
         ((System.ComponentModel.ISupportInitialize)(this.dgvSimplex)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private  System.Windows.Forms.DataGridView dgvSimplex;
      private MetroFramework.Controls.MetroRadioButton rbMax;
      private MetroFramework.Controls.MetroRadioButton rbMin;
      private MetroFramework.Controls.MetroLabel metroLabel1;
      private MetroFramework.Controls.MetroLabel metroLabel2;
      private MetroFramework.Controls.MetroTextBox txtQtVariaveis;
      private MetroFramework.Controls.MetroTile btCalcular;
      private MetroFramework.Controls.MetroTile btIniciar;
      private MetroFramework.Controls.MetroLabel metroLabel3;
      private DevComponents.DotNetBar.LabelX labelX1;
      private DevComponents.DotNetBar.LabelX labelX2;
      private DevComponents.DotNetBar.LabelX labelX3;
      private DevComponents.DotNetBar.LabelX labelX4;
   }
}

