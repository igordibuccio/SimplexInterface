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

         txtResultado.Text = pResultado;
      }

      private void frmResultado_Load(object sender, EventArgs e)
      {
         frmProcesso frm = new frmProcesso();
         frm.ShowDialog();
         frm.Dispose();
         frm = null;
      }
   }
}
