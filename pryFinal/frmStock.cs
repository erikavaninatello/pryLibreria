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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            var stockBajo = clsData.ListaProductos.Where(p => p.Stock <= 5).ToList();

            if (stockBajo.Any())
            {
                Grilla.DataSource = null;
                Grilla.DataSource = stockBajo;
            }
            else
            {
                MessageBox.Show("No hay productos con stock bajo.");
            }
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            Grilla.DataSource = null;
            Grilla.DataSource = clsData.ListaProductos;
        }
    }
}
