using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace pryFinal
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();

            dgvProductos.CellBeginEdit += dgvProductos_CellBeginEdit;

            CargarDesdeCSV("productos.csv");
        }
        private void GuardarEnCSV(string archivo)
        {
            var lines = new List<string>();

            foreach (var producto in clsData.ListaProductos)
            {
                lines.Add($"{producto.ID},{producto.Nombre},{producto.Categoria},{producto.Precio},{producto.Stock},{producto.Descripcion}");
            }

            File.WriteAllLines(archivo, lines);
        }

        private void CargarDesdeCSV(string archivo)
        {
            if (File.Exists(archivo))
            {
                var lines = File.ReadAllLines(archivo);
                clsData.ListaProductos.Clear();

                foreach (var line in lines)
                {
                    var values = line.Split(',');

                    var producto = new clsProductos
                    {
                        ID = int.Parse(values[0]),
                        Nombre = values[1],
                        Categoria = values[2],
                        Precio = decimal.Parse(values[3]),
                        Stock = int.Parse(values[4]),
                        Descripcion = values[5]
                    };

                    clsData.ListaProductos.Add(producto);
                }

                ActualizarGrilla();
            }
        }


        private void ActualizarGrilla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = clsData.ListaProductos;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número decimal válido.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("El stock debe ser un número entero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (clsData.ListaProductos.Any(p => p.ID == id))
            {
                MessageBox.Show("Ya existe un producto con ese ID.");
                return;
            }

            clsProductos nuevo = new clsProductos
            {
                ID = id,
                Nombre = txtNombre.Text,
                Categoria = txtCategoria.Text,
                Precio = precio,
                Stock = stock,
                Descripcion = txtDescripcion.Text
            };

            clsData.ListaProductos.Add(nuevo);
            ActualizarGrilla();
            LimpiarCampos();


            GuardarEnCSV("productos.csv");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            clsProductos prod = clsData.ListaProductos.FirstOrDefault(p => p.ID == id);

            if (prod == null)
            {
                MessageBox.Show("No se encontró un producto con ese ID.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número decimal válido.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("El stock debe ser un número entero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            prod.Nombre = txtNombre.Text;
            prod.Categoria = txtCategoria.Text;
            prod.Precio = precio;
            prod.Stock = stock;
            prod.Descripcion = txtDescripcion.Text;

            ActualizarGrilla();
            LimpiarCampos();


            GuardarEnCSV("productos.csv");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int idEliminar))
            {
                clsProductos prod = clsData.ListaProductos.FirstOrDefault(p => p.ID == idEliminar);

                if (prod != null)
                {
                    clsData.ListaProductos.Remove(prod);
                    ActualizarGrilla();
                    LimpiarCampos();


                    GuardarEnCSV("productos.csv");
                }
                else
                {
                    MessageBox.Show("producto no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("El ID ingresado no es válido. Por favor, ingrese un número.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text.Trim(), out int idBuscado))
            {
                var resultado = clsData.ListaProductos.FirstOrDefault(p => p.ID == idBuscado);

                if (resultado != null)
                {
                    dgvProductos.DataSource = new List<clsProductos> { resultado };
                }
                else
                {
                    MessageBox.Show("No se encontró un producto con ese ID.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
        }
        private void ValidarTodo()
        {
            bool todoCorrecto =
                int.TryParse(txtID.Text, out _) &&
                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtCategoria.Text) &&
                decimal.TryParse(txtPrecio.Text, out _) &&
                int.TryParse(txtStock.Text, out _) &&
                !string.IsNullOrWhiteSpace(txtDescripcion.Text);

            btnAgregar.Enabled = todoCorrecto;

            Console.WriteLine($"Validación: {todoCorrecto}");
        }
        private void dgvProductos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            MessageBox.Show("No se puede agregar o modificar desde aquí. Use los campos de texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.Cancel = true;
        }
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtCategoria.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtDescripcion.Clear();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out _))
            {
                txtID.BackColor = Color.LightGreen;
                txtNombre.Enabled = true;
                toolTip.SetToolTip(txtID, "");
            }
            else
            {
                txtID.BackColor = Color.LightCoral;
                txtNombre.Enabled = false;
                toolTip.SetToolTip(txtID, "Debe ser un número entero.");
            }

            ValidarTodo();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.BackColor = Color.LightGreen;
                txtPrecio.Enabled = true;
                toolTip.SetToolTip(txtNombre, "");
            }
            else
            {
                txtNombre.BackColor = Color.LightCoral;
                txtPrecio.Enabled = false;
                toolTip.SetToolTip(txtNombre, "Debe ingresar un nombre.");
            }

            ValidarTodo();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecio.Text, out _))
            {
                txtPrecio.BackColor = Color.LightGreen;
                txtStock.Enabled = true;
                toolTip.SetToolTip(txtPrecio, "");
            }
            else
            {
                txtPrecio.BackColor = Color.LightCoral;
                txtStock.Enabled = false;
                toolTip.SetToolTip(txtPrecio, "Debe ingresar un precio válido.");
            }

            ValidarTodo();
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtStock.Text, out _))
            {
                txtStock.BackColor = Color.LightGreen;
                txtDescripcion.Enabled = true;
                toolTip.SetToolTip(txtStock, "");
            }
            else
            {
                txtStock.BackColor = Color.LightCoral;
                txtDescripcion.Enabled = false;
                toolTip.SetToolTip(txtStock, "Solo se permite formato numérico.");
            }

            ValidarTodo();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                txtDescripcion.BackColor = Color.LightGreen;
                txtCategoria.Enabled = true;
                toolTip.SetToolTip(txtDescripcion, "");
            }
            else
            {
                txtDescripcion.BackColor = Color.LightCoral;
                txtCategoria.Enabled = false;
                toolTip.SetToolTip(txtDescripcion, "Debe ingresar una descripción.");
            }

            ValidarTodo();
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                txtCategoria.BackColor = Color.LightGreen;
                toolTip.SetToolTip(txtCategoria, "");
            }
            else
            {
                txtCategoria.BackColor = Color.LightCoral;
                toolTip.SetToolTip(txtCategoria, "Debe ingresar una categoría.");
            }

            ValidarTodo();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
