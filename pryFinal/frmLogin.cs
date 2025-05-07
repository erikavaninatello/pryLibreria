using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace pryFinal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //frmAddUser frmAddUser = new frmAddUser();
            //frmAddUser.Show();
            //this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text;

            var usuarios = clsUserManager.CargarUsuarios();
            var usuarioExistente = usuarios.FirstOrDefault(u => u.Usuario == usuario);

            if (usuarioExistente == null)
            {
                lblMensaje.Text = "El usuario no existe.";
                return;
            }

           
            if (usuarioExistente.Bloqueado)
            {
                lblMensaje.Text = "El usuario está bloqueado. Contactá al administrador.";
                return;
            }

        
            if (usuarioExistente.Clave != clave)
            {
                usuarioExistente.IntentosFallidos++;

           
                int intentosRestantes = 3 - usuarioExistente.IntentosFallidos;
                lblMensaje.Text = $"Contraseña incorrecta. Te quedan {intentosRestantes} intentos.";

             
                if (usuarioExistente.IntentosFallidos >= 3)
                {
                    usuarioExistente.Bloqueado = true;
                    lblMensaje.Text = "Usuario bloqueado por intentos fallidos.";
                }

                clsUserManager.GuardarUsuarios(usuarios);
                return;
            }

        
            usuarioExistente.IntentosFallidos = 0;
            clsUserManager.GuardarUsuarios(usuarios);

            
            frmMain frm = new frmMain();
            frm.Show();
            this.Hide();

        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            new frmAddUser().ShowDialog();
        }


        private void lblRecuperarClave_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor, ingresá tu nombre de usuario para recuperar la contraseña.");
                return;
            }

            var usuarios = clsUserManager.CargarUsuarios();
            var user = usuarios.FirstOrDefault(u => u.Usuario == usuario);

            if (user == null)
            {
                MessageBox.Show("Usuario no encontrado.");
                return;
            }

            if (user.Bloqueado)
            {
                MessageBox.Show("Este usuario está bloqueado. Contactá al administrador.");
                return;
            }

            MessageBox.Show($"Tu contraseña es: {user.Clave}", "Recuperar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblDesbloquear_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim(); 

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Por favor, ingresá el nombre de usuario.");
                return;
            }

            var usuarios = clsUserManager.CargarUsuarios();
            var user = usuarios.FirstOrDefault(u => u.Usuario == usuario);

            if (user == null)
            {
                MessageBox.Show("Usuario no encontrado.");
                return;
            }

            if (!user.Bloqueado)
            {
                MessageBox.Show("El usuario no está bloqueado.");
                return;
            }

          
            user.Bloqueado = false;
            user.IntentosFallidos = 0;  

           
            clsUserManager.GuardarUsuarios(usuarios);

            
            lblMensaje.Text = "Tu cuenta ha sido desbloqueada. Ahora podés iniciar sesión.";
            lblDesbloquear.Text = "Cuenta desbloqueada";  

            MessageBox.Show("El usuario ha sido desbloqueado.");
        }
    }
}

