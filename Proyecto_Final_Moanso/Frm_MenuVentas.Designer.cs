namespace Proyecto_Final_Moanso
{
    partial class Frm_MenuVentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuVentas));
            this.pnTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrarPrograma1 = new System.Windows.Forms.PictureBox();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnSalirDeMenu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMantClientes = new System.Windows.Forms.Button();
            this.pbLogo1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReportesVenta = new System.Windows.Forms.Button();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.pbLogo2 = new System.Windows.Forms.PictureBox();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarPrograma1)).BeginInit();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).BeginInit();
            this.pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.DarkOrange;
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Controls.Add(this.pbMinimizar);
            this.pnTop.Controls.Add(this.pbCerrarPrograma1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1290, 64);
            this.pnTop.TabIndex = 1;
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú de Ventas";
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = global::Proyecto_Final_Moanso.Properties.Resources.minimazar;
            this.pbMinimizar.Location = new System.Drawing.Point(1128, 3);
            this.pbMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(71, 56);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 2;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbCerrarPrograma1
            // 
            this.pbCerrarPrograma1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrarPrograma1.Image = global::Proyecto_Final_Moanso.Properties.Resources.cerrar;
            this.pbCerrarPrograma1.Location = new System.Drawing.Point(1216, 3);
            this.pbCerrarPrograma1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCerrarPrograma1.Name = "pbCerrarPrograma1";
            this.pbCerrarPrograma1.Size = new System.Drawing.Size(71, 56);
            this.pbCerrarPrograma1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrarPrograma1.TabIndex = 1;
            this.pbCerrarPrograma1.TabStop = false;
            this.pbCerrarPrograma1.Click += new System.EventHandler(this.pbCerrarPrograma1_Click);
            this.pbCerrarPrograma1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCerrarPrograma_MouseDown);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Black;
            this.pnMenu.Controls.Add(this.btnSalirDeMenu);
            this.pnMenu.Controls.Add(this.panel5);
            this.pnMenu.Controls.Add(this.btnMantClientes);
            this.pnMenu.Controls.Add(this.pbLogo1);
            this.pnMenu.Controls.Add(this.panel3);
            this.pnMenu.Controls.Add(this.panel2);
            this.pnMenu.Controls.Add(this.btnReportesVenta);
            this.pnMenu.Controls.Add(this.btnRealizarVenta);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 64);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(344, 610);
            this.pnMenu.TabIndex = 4;
            // 
            // btnSalirDeMenu
            // 
            this.btnSalirDeMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirDeMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSalirDeMenu.FlatAppearance.BorderSize = 2;
            this.btnSalirDeMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnSalirDeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirDeMenu.Image = global::Proyecto_Final_Moanso.Properties.Resources.retroceder_48;
            this.btnSalirDeMenu.Location = new System.Drawing.Point(113, 516);
            this.btnSalirDeMenu.Name = "btnSalirDeMenu";
            this.btnSalirDeMenu.Size = new System.Drawing.Size(120, 64);
            this.btnSalirDeMenu.TabIndex = 1;
            this.btnSalirDeMenu.UseVisualStyleBackColor = true;
            this.btnSalirDeMenu.Click += new System.EventHandler(this.btnSalirDeMenu_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrange;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(0, 318);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(43, 70);
            this.panel5.TabIndex = 4;
            // 
            // btnMantClientes
            // 
            this.btnMantClientes.BackColor = System.Drawing.Color.White;
            this.btnMantClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMantClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMantClientes.FlatAppearance.BorderSize = 2;
            this.btnMantClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnMantClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantClientes.Image = global::Proyecto_Final_Moanso.Properties.Resources.clientes_40;
            this.btnMantClientes.Location = new System.Drawing.Point(43, 318);
            this.btnMantClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnMantClientes.Name = "btnMantClientes";
            this.btnMantClientes.Size = new System.Drawing.Size(302, 71);
            this.btnMantClientes.TabIndex = 5;
            this.btnMantClientes.Text = "Mantenedor clientes";
            this.btnMantClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantClientes.UseVisualStyleBackColor = false;
            this.btnMantClientes.Click += new System.EventHandler(this.btnMantClientes_Click);
            // 
            // pbLogo1
            // 
            this.pbLogo1.BackgroundImage = global::Proyecto_Final_Moanso.Properties.Resources.logorubio;
            this.pbLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo1.Location = new System.Drawing.Point(8, 13);
            this.pbLogo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo1.Name = "pbLogo1";
            this.pbLogo1.Size = new System.Drawing.Size(329, 139);
            this.pbLogo1.TabIndex = 1;
            this.pbLogo1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(0, 407);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 70);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 229);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 70);
            this.panel2.TabIndex = 1;
            // 
            // btnReportesVenta
            // 
            this.btnReportesVenta.BackColor = System.Drawing.Color.White;
            this.btnReportesVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportesVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReportesVenta.FlatAppearance.BorderSize = 2;
            this.btnReportesVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnReportesVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesVenta.Image = global::Proyecto_Final_Moanso.Properties.Resources.reporte_40;
            this.btnReportesVenta.Location = new System.Drawing.Point(43, 406);
            this.btnReportesVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportesVenta.Name = "btnReportesVenta";
            this.btnReportesVenta.Size = new System.Drawing.Size(302, 71);
            this.btnReportesVenta.TabIndex = 3;
            this.btnReportesVenta.Text = " Reportes de venta";
            this.btnReportesVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportesVenta.UseVisualStyleBackColor = false;
            this.btnReportesVenta.Click += new System.EventHandler(this.btnReportesVenta_Click);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.BackColor = System.Drawing.Color.White;
            this.btnRealizarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRealizarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRealizarVenta.FlatAppearance.BorderSize = 2;
            this.btnRealizarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnRealizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarVenta.Image = global::Proyecto_Final_Moanso.Properties.Resources.Dinero_efectivo_40;
            this.btnRealizarVenta.Location = new System.Drawing.Point(43, 229);
            this.btnRealizarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(302, 71);
            this.btnRealizarVenta.TabIndex = 2;
            this.btnRealizarVenta.Text = " Realizar venta";
            this.btnRealizarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRealizarVenta.UseVisualStyleBackColor = false;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.Gainsboro;
            this.pnPrincipal.Controls.Add(this.pbLogo2);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(344, 64);
            this.pnPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(946, 610);
            this.pnPrincipal.TabIndex = 5;
            // 
            // pbLogo2
            // 
            this.pbLogo2.Image = global::Proyecto_Final_Moanso.Properties.Resources.Corporacion_Rubio;
            this.pbLogo2.Location = new System.Drawing.Point(361, 14);
            this.pbLogo2.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo2.Name = "pbLogo2";
            this.pbLogo2.Size = new System.Drawing.Size(221, 177);
            this.pbLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo2.TabIndex = 0;
            this.pbLogo2.TabStop = false;
            // 
            // Frm_MenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 674);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_MenuVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Ventas";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarPrograma1)).EndInit();
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).EndInit();
            this.pnPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo2;
        private System.Windows.Forms.Button btnReportesVenta;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbLogo1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnMantClientes;
        private System.Windows.Forms.PictureBox pbCerrarPrograma1;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirDeMenu;
    }
}

