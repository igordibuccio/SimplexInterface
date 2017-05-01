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
   public partial class frmProcesso : MetroFramework.Forms.MetroForm 
   {
      public frmProcesso()
      {
         InitializeComponent();
      }

      private void frmProcesso_Load(object sender, EventArgs e)
      {

      }

      private void frmProcesso_Shown(object sender, EventArgs e)
      {
         mpProgress.Maximum = 100;
         mpProgress.Value = 0;

         for (int i = 0; i < 10; i++)
         {
            Application.DoEvents();
            System.Threading.Thread.Sleep(100);
            mpProgress.Value = i;
         }
         this.Close(); 
      }
   }
}
