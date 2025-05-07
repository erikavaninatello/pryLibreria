using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryFinal
{
    public partial class frmAgenda : Form
    {
        private clsConexion conexion = new clsConexion();
        int contactoSeleccionadoId = -1;
        public frmAgenda()
        {
            InitializeComponent();

            txtNombre.TextChanged += txtNombre_TextChanged;
            txtApellido.TextChanged += txtApellido_TextChanged;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            CargarContactos();
            CargarCategorias();

            txtNombre.Enabled = true;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            cmbCategoria.Enabled = false;
            btnAgregar.Enabled = false;


            toolTipC.AutoPopDelay = 5000;
            toolTipC.InitialDelay = 300;
            toolTipC.ReshowDelay = 300;
            toolTipC.ShowAlways = true;

            toolTipC.SetToolTip(txtNombre, "Ingrese el nombre del contacto (obligatorio)");
            toolTipC.SetToolTip(txtApellido, "Ingrese el apellido del contacto (obligatorio)");
            toolTipC.SetToolTip(txtTelefono, "Ingrese solo números. Ejemplo: 1123456789");
            toolTipC.SetToolTip(txtCorreo, "Ingrese un correo válido. Ejemplo: nombre@mail.com");
            toolTipC.SetToolTip(cmbCategoria, "Seleccione una categoría para el contacto");

        }
        private void CargarContactos()
        {

            treeViewContactos.Nodes.Clear();

            string consulta = "SELECT * FROM Contactos";
            DataTable tabla = conexion.EjecutarConsulta(consulta);


            foreach (DataRow fila in tabla.Rows)
            {
                string categoria = fila["Categoria"].ToString();
                string nombreCompleto = $"{fila["Nombre"]} {fila["Apellido"]}";
                string telefono = fila["Telefono"].ToString();
                string correo = fila["Correo"].ToString();
                string contactoCompleto = $"Nombre: {fila["Nombre"]} {fila["Apellido"]} | Tel: {telefono} | Correo: {correo} | Categoria: {categoria}";  // Línea nueva para mostrar todos los datos


                TreeNode nodoCategoria = null;
                foreach (TreeNode nodo in treeViewContactos.Nodes)
                {
                    if (nodo.Text == categoria)
                    {
                        nodoCategoria = nodo;
                        break;
                    }
                }
                if (nodoCategoria == null)
                {
                    nodoCategoria = new TreeNode(categoria);
                    treeViewContactos.Nodes.Add(nodoCategoria);
                }


                TreeNode nodoContacto = new TreeNode(contactoCompleto);
                nodoContacto.Tag = fila;
                nodoCategoria.Nodes.Add(nodoContacto);
            }

            treeViewContactos.ExpandAll();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            cmbCategoria.SelectedIndex = -1;
            contactoSeleccionadoId = -1;
        }

        private void CargarCategorias()
        {
            cmbCategoria.Items.Clear();
            string consulta = "SELECT DISTINCT Categoria FROM Contactos";
            DataTable tabla = conexion.EjecutarConsulta(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                cmbCategoria.Items.Add(fila["Categoria"].ToString());
            }
        }

        private void ValidarTodo()
        {
            bool todoCorrecto =
                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtApellido.Text) &&
                long.TryParse(txtTelefono.Text, out _) &&
                txtCorreo.Text.Contains("@") && txtCorreo.Text.Contains(".") &&
                cmbCategoria.SelectedIndex >= 0;

            btnAgregar.Enabled = todoCorrecto;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (contactoSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un contacto del TreeView para eliminar.");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este contacto?", "Confirmación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                string consulta = "DELETE FROM Contactos WHERE Id = @Id";
                var parametros = new Dictionary<string, object>
                {
                    { "@Id", contactoSeleccionadoId }
                };

                conexion.EjecutarComando(consulta, parametros);


                MessageBox.Show("Contacto eliminado exitosamente.");
                LimpiarCampos();
                CargarContactos();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (contactoSeleccionadoId == -1)
            {
                MessageBox.Show("Selecciona un contacto del TreeView para modificar.");
                return;
            }

            string consulta = "UPDATE Contactos SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Correo = @Correo, Categoria = @Categoria " + "WHERE Id = @Id";

            var parametros = new Dictionary<string, object>
            {
               { "@Nombre", txtNombre.Text },
               { "@Apellido", txtApellido.Text },
               { "@Telefono", txtTelefono.Text },
               { "@Correo", txtCorreo.Text },
               { "@Categoria", cmbCategoria.Text },
               { "@Id", contactoSeleccionadoId }
            };

            conexion.EjecutarComando(consulta, parametros);
            MessageBox.Show("Contacto modificado exitosamente.");
            LimpiarCampos();
            CargarContactos();

            conexion.EjecutarComando(consulta, parametros);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || cmbCategoria.Text == "")
            {
                MessageBox.Show("Nombre, Apellido y Categoría son obligatorios.");
                return;
            }

            string consulta = "INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo, Categoria) " + "VALUES (@Nombre, @Apellido, @Telefono, @Correo, @Categoria)";

            var parametros = new Dictionary<string, object>
            {
               { "@Nombre", txtNombre.Text },
               { "@Apellido", txtApellido.Text },
               { "@Telefono", txtTelefono.Text },
               { "@Correo", txtCorreo.Text },
               { "@Categoria", cmbCategoria.Text }

            };
            conexion.EjecutarComando(consulta, parametros);
            MessageBox.Show("Contacto agregado exitosamente.");
            LimpiarCampos();
            CargarContactos();

            conexion.EjecutarComando(consulta, parametros);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.BackColor = Color.LightGreen;
                txtApellido.Enabled = true;
            }
            else
            {
                txtNombre.BackColor = Color.LightCoral;
                txtApellido.Enabled = false;
            }
            ValidarTodo();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                txtApellido.BackColor = Color.LightGreen;
                txtTelefono.Enabled = true;
            }
            else
            {
                txtApellido.BackColor = Color.LightCoral;
                txtTelefono.Enabled = false;
            }
            ValidarTodo();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(txtTelefono.Text, out _))
            {
                txtTelefono.BackColor = Color.LightGreen;
                txtCorreo.Enabled = true;
            }
            else
            {
                txtTelefono.BackColor = Color.LightCoral;
                txtCorreo.Enabled = false;
            }
            ValidarTodo();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Contains("@") && txtCorreo.Text.Contains("."))
            {
                txtCorreo.BackColor = Color.LightGreen;
                cmbCategoria.Enabled = true;
            }
            else
            {
                txtCorreo.BackColor = Color.LightCoral;
                cmbCategoria.Enabled = false;
            }
            ValidarTodo();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbCategoria.SelectedIndex >= 0)
            {
                cmbCategoria.BackColor = Color.LightGreen;
            }
            else
            {
                cmbCategoria.BackColor = Color.LightCoral;
            }
            ValidarTodo();
        }

        private void treeViewContactos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Tag is DataRow fila)
            {
                contactoSeleccionadoId = Convert.ToInt32(fila["Id"]);
                txtNombre.Text = fila["Nombre"].ToString();
                txtApellido.Text = fila["Apellido"].ToString();
                txtTelefono.Text = fila["Telefono"].ToString();
                txtCorreo.Text = fila["Correo"].ToString();
                cmbCategoria.Text = fila["Categoria"].ToString();
            }
            else
            {
                contactoSeleccionadoId = -1;
                LimpiarCampos();

            }
        }
    }

}



