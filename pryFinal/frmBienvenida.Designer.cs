namespace pryFinal
{
    partial class frmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenida));
            this.logo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblSaludo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBienvenida = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageRotate = 0F;
            this.logo.Location = new System.Drawing.Point(24, 31);
            this.logo.Name = "logo";
            this.logo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.logo.Size = new System.Drawing.Size(83, 95);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // lblSaludo
            // 
            this.lblSaludo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaludo.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSaludo.Location = new System.Drawing.Point(113, 31);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(360, 35);
            this.lblSaludo.TabIndex = 73;
            this.lblSaludo.Text = "¡Bienvenido a libreria Astro!";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.Navy;
            this.lblBienvenida.Location = new System.Drawing.Point(174, 466);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(266, 20);
            this.lblBienvenida.TabIndex = 74;
            this.lblBienvenida.Text = "Presiona una tecla para continuar :)";
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryFinal.Properties.Resources._5300_6_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 535);
            this.ControlBox = false;
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBienvenida";
            this.Text = "Bienvenida";
            this.Load += new System.EventHandler(this.frmBienvenida_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBienvenida_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox logo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSaludo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBienvenida;
    }
}