namespace SimplexInterface
{
   partial class frmResultado
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
         this.txtResultado = new MetroFramework.Controls.MetroTextBox();
         this.SuspendLayout();
         // 
         // txtResultado
         // 
         // 
         // 
         // 
         this.txtResultado.CustomButton.Image = null;
         this.txtResultado.CustomButton.Location = new System.Drawing.Point(225, 2);
         this.txtResultado.CustomButton.Name = "";
         this.txtResultado.CustomButton.Size = new System.Drawing.Size(203, 203);
         this.txtResultado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
         this.txtResultado.CustomButton.TabIndex = 1;
         this.txtResultado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
         this.txtResultado.CustomButton.UseSelectable = true;
         this.txtResultado.CustomButton.Visible = false;
         this.txtResultado.Lines = new string[0];
         this.txtResultado.Location = new System.Drawing.Point(24, 64);
         this.txtResultado.MaxLength = 32767;
         this.txtResultado.Multiline = true;
         this.txtResultado.Name = "txtResultado";
         this.txtResultado.PasswordChar = '\0';
         this.txtResultado.ReadOnly = true;
         this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.None;
         this.txtResultado.SelectedText = "";
         this.txtResultado.SelectionLength = 0;
         this.txtResultado.SelectionStart = 0;
         this.txtResultado.ShortcutsEnabled = true;
         this.txtResultado.Size = new System.Drawing.Size(431, 208);
         this.txtResultado.TabIndex = 0;
         this.txtResultado.UseSelectable = true;
         this.txtResultado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
         this.txtResultado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
         // 
         // frmResultado
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(478, 295);
         this.Controls.Add(this.txtResultado);
         this.KeyPreview = true;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmResultado";
         this.Resizable = false;
         this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
         this.Style = MetroFramework.MetroColorStyle.Black;
         this.Text = "Resultado Simplex";
         this.Load += new System.EventHandler(this.frmResultado_Load);
         this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmResultado_KeyPress);
         this.ResumeLayout(false);

      }

      #endregion

      private MetroFramework.Controls.MetroTextBox txtResultado;
   }
}