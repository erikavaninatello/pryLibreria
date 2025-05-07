namespace pryFinal
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelStock = new Guna.UI2.WinForms.Guna2Panel();
            this.logo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblSaludo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnStock = new Guna.UI2.WinForms.Guna2Button();
            this.Grilla = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStock
            // 
            this.panelStock.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelStock.Controls.Add(this.logo);
            this.panelStock.Controls.Add(this.lblSaludo);
            this.panelStock.Location = new System.Drawing.Point(-2, -3);
            this.panelStock.Name = "panelStock";
            this.panelStock.Size = new System.Drawing.Size(811, 95);
            this.panelStock.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageRotate = 0F;
            this.logo.Location = new System.Drawing.Point(44, 15);
            this.logo.Name = "logo";
            this.logo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.logo.Size = new System.Drawing.Size(74, 76);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 75;
            this.logo.TabStop = false;
            // 
            // lblSaludo
            // 
            this.lblSaludo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaludo.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSaludo.Location = new System.Drawing.Point(158, 39);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(86, 23);
            this.lblSaludo.TabIndex = 74;
            this.lblSaludo.Text = "Hola, Astro";
            // 
            // btnStock
            // 
            this.btnStock.BorderRadius = 6;
            this.btnStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStock.FillColor = System.Drawing.Color.DarkViolet;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(364, 404);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(86, 30);
            this.btnStock.TabIndex = 81;
            this.btnStock.Text = "Ver Stock";
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // Grilla
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Grilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grilla.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grilla.ColumnHeadersHeight = 4;
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grilla.DefaultCellStyle = dataGridViewCellStyle3;
            this.Grilla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Grilla.Location = new System.Drawing.Point(25, 120);
            this.Grilla.Name = "Grilla";
            this.Grilla.RowHeadersVisible = false;
            this.Grilla.Size = new System.Drawing.Size(743, 259);
            this.Grilla.TabIndex = 80;
            this.Grilla.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Grilla.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Grilla.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Grilla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Grilla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Grilla.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.Grilla.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Grilla.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Grilla.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Grilla.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grilla.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Grilla.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Grilla.ThemeStyle.HeaderStyle.Height = 4;
            this.Grilla.ThemeStyle.ReadOnly = false;
            this.Grilla.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Grilla.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Grilla.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grilla.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Grilla.ThemeStyle.RowsStyle.Height = 22;
            this.Grilla.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Grilla.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(801, 480);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.panelStock);
            this.Name = "frmStock";
            this.Text = "frmStock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.panelStock.ResumeLayout(false);
            this.panelStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelStock;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSaludo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox logo;
        private Guna.UI2.WinForms.Guna2Button btnStock;
        private Guna.UI2.WinForms.Guna2DataGridView Grilla;
    }
}