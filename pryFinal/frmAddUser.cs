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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = txtNuevoUsuario.Text.Trim();
            string nuevaClave = txtNuevaClave.Text;
            string confirmarClave = txtConfirmarClave.Text;


            if (nuevaClave != confirmarClave)
            {
                lblMensaje.Text = "Las contraseñas no coinciden.";
                return;
            }

            var usuarios = clsUserManager.CargarUsuarios();


            if (usuarios.Any(u => u.Usuario == nuevoUsuario))
            {
                lblMensaje.Text = "Ese usuario ya existe.";
                return;
            }

            var nuevo = new clsUser
            {
                Usuario = nuevoUsuario,
                Clave = nuevaClave,
                IntentosFallidos = 0,
                Bloqueado = false
            };

            try
            {
                usuarios.Add(nuevo);
                clsUserManager.GuardarUsuarios(usuarios);
                lblMensaje.Text = "Usuario registrado con éxito.";


                MessageBox.Show("Registro exitoso. Ahora puedes iniciar sesión.");
                this.Close();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Hubo un error al registrar el usuario.";
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}

