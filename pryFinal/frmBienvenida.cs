using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFinal
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(frmBienvenida_KeyDown);
        }

        private void frmBienvenida_KeyDown(object sender, KeyEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide(); 
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
