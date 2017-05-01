namespace SimplexInterface
{
   partial class frmProcesso
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
         this.mpProgress = new MetroFramework.Controls.MetroProgressSpinner();
         this.SuspendLayout();
         // 
         // mpProgress
         // 
         this.mpProgress.Location = new System.Drawing.Point(175, 91);
         this.mpProgress.Maximum = 100;
         this.mpProgress.Name = "mpProgress";
         this.mpProgress.Size = new System.Drawing.Size(84, 84);
         this.mpProgress.Style = MetroFramework.MetroColorStyle.Black;
         this.mpProgress.TabIndex = 0;
         this.mpProgress.UseSelectable = true;
         // 
         // frmProcesso
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(435, 210);
         this.Controls.Add(this.mpProgress);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmProcesso";
         this.Resizable = false;
         this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
         this.Style = MetroFramework.MetroColorStyle.Black;
         this.Text = "Aguarde o fim do processo";
         this.Shown += new System.EventHandler(this.frmProcesso_Shown);
         this.ResumeLayout(false);

      }

      #endregion

      private MetroFramework.Controls.MetroProgressSpinner mpProgress;
   }
}