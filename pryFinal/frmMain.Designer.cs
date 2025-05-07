namespace pryFinal
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSaludo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbReporte = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbAgenda = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbStock = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbProductos = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblProductos = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAgenda = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblStock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblReporte = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelMain.Controls.Add(this.lblSaludo);
            this.panelMain.Controls.Add(this.logo);
            this.panelMain.Location = new System.Drawing.Point(0, -9);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1036, 98);
            this.panelMain.TabIndex = 0;
            // 
            // lblSaludo
            // 
            this.lblSaludo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaludo.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSaludo.Location = new System.Drawing.Point(130, 40);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(86, 23);
            this.lblSaludo.TabIndex = 73;
            this.lblSaludo.Text = "Hola, Astro";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageRotate = 0F;
            this.logo.Location = new System.Drawing.Point(22, 19);
            this.logo.Name = "logo";
            this.logo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.logo.Size = new System.Drawing.Size(74, 76);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // pbReporte
            // 
            this.pbReporte.Image = global::pryFinal.Properties.Resources.Reportes;
            this.pbReporte.ImageRotate = 0F;
            this.pbReporte.Location = new System.Drawing.Point(747, 398);
            this.pbReporte.Name = "pbReporte";
            this.pbReporte.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbReporte.Size = new System.Drawing.Size(154, 178);
            this.pbReporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReporte.TabIndex = 4;
            this.pbReporte.TabStop = false;
            this.pbReporte.Click += new System.EventHandler(this.pbReporte_Click);
            // 
            // pbAgenda
            // 
            this.pbAgenda.Image = global::pryFinal.Properties.Resources.Contactos;
            this.pbAgenda.ImageRotate = 0F;
            this.pbAgenda.Location = new System.Drawing.Point(158, 398);
            this.pbAgenda.Name = "pbAgenda";
            this.pbAgenda.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbAgenda.Size = new System.Drawing.Size(154, 178);
            this.pbAgenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgenda.TabIndex = 3;
            this.pbAgenda.TabStop = false;
            this.pbAgenda.Click += new System.EventHandler(this.pbAgenda_Click);
            // 
            // pbStock
            // 
            this.pbStock.Image = global::pryFinal.Properties.Resources.Stock;
            this.pbStock.ImageRotate = 0F;
            this.pbStock.Location = new System.Drawing.Point(738, 128);
            this.pbStock.Name = "pbStock";
            this.pbStock.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbStock.Size = new System.Drawing.Size(154, 178);
            this.pbStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStock.TabIndex = 2;
            this.pbStock.TabStop = false;
            this.pbStock.Click += new System.EventHandler(this.pbStock_Click);
            // 
            // pbProductos
            // 
            this.pbProductos.Image = global::pryFinal.Properties.Resources.Productos;
            this.pbProductos.ImageRotate = 0F;
            this.pbProductos.Location = new System.Drawing.Point(158, 128);
            this.pbProductos.Name = "pbProductos";
            this.pbProductos.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbProductos.Size = new System.Drawing.Size(154, 178);
            this.pbProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProductos.TabIndex = 1;
            this.pbProductos.TabStop = false;
            this.pbProductos.Click += new System.EventHandler(this.pbProductos_Click);
            // 
            // lblProductos
            // 
            this.lblProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblProductos.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProductos.Location = new System.Drawing.Point(189, 327);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(80, 23);
            this.lblProductos.TabIndex = 74;
            this.lblProductos.Text = "Productos";
            // 
            // lblAgenda
            // 
            this.lblAgenda.BackColor = System.Drawing.Color.Transparent;
            this.lblAgenda.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenda.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgenda.Location = new System.Drawing.Point(189, 582);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(68, 23);
            this.lblAgenda.TabIndex = 75;
            this.lblAgenda.Text = "Agenda";
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStock.Location = new System.Drawing.Point(803, 317);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(45, 23);
            this.lblStock.TabIndex = 76;
            this.lblStock.Text = "Stock";
            // 
            // lblReporte
            // 
            this.lblReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblReporte.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.ForeColor = System.Drawing.SystemColors.Control;
            this.lblReporte.Location = new System.Drawing.Point(785, 589);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(63, 23);
            this.lblReporte.TabIndex = 77;
            this.lblReporte.Text = "Reporte";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1028, 624);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblAgenda);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.pbReporte);
            this.Controls.Add(this.pbAgenda);
            this.Controls.Add(this.pbStock);
            this.Controls.Add(this.pbProductos);
            this.Controls.Add(this.panelMain);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2CirclePictureBox logo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSaludo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbProductos;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbStock;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbAgenda;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbReporte;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductos;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAgenda;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStock;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReporte;
    }
}