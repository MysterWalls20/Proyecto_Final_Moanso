namespace Proyecto_Final_Moanso
{
    partial class Frm_MenuAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuAlmacen));
            this.pnTop = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrarPrograma2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReOrdenCompra = new System.Windows.Forms.Button();
            this.btnMantenedoresProd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalirDeMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMantProductos = new System.Windows.Forms.Button();
            this.pbLogo1 = new System.Windows.Forms.PictureBox();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarPrograma2)).BeginInit();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.DarkOrange;
            this.pnTop.Controls.Add(this.pbMinimizar);
            this.pnTop.Controls.Add(this.pbCerrarPrograma2);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1302, 64);
            this.pnTop.TabIndex = 2;
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = global::Proyecto_Final_Moanso.Properties.Resources.minimazar;
            this.pbMinimizar.Location = new System.Drawing.Point(1137, 4);
            this.pbMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(71, 56);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 5;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbCerrarPrograma2
            // 
            this.pbCerrarPrograma2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrarPrograma2.Image = global::Proyecto_Final_Moanso.Properties.Resources.cerrar;
            this.pbCerrarPrograma2.Location = new System.Drawing.Point(1225, 3);
            this.pbCerrarPrograma2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCerrarPrograma2.Name = "pbCerrarPrograma2";
            this.pbCerrarPrograma2.Size = new System.Drawing.Size(71, 56);
            this.pbCerrarPrograma2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrarPrograma2.TabIndex = 4;
            this.pbCerrarPrograma2.TabStop = false;
            this.pbCerrarPrograma2.Click += new System.EventHandler(this.pbCerrarPrograma2_Click);
            this.pbCerrarPrograma2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCerrarPrograma2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú de Almacen";
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Black;
            this.pnMenu.Controls.Add(this.panel3);
            this.pnMenu.Controls.Add(this.btnReOrdenCompra);
            this.pnMenu.Controls.Add(this.btnMantenedoresProd);
            this.pnMenu.Controls.Add(this.panel1);
            this.pnMenu.Controls.Add(this.btnSalirDeMenu);
            this.pnMenu.Controls.Add(this.panel2);
            this.pnMenu.Controls.Add(this.btnMantProductos);
            this.pnMenu.Controls.Add(this.pbLogo1);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 64);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(354, 610);
            this.pnMenu.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(0, 313);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 74);
            this.panel3.TabIndex = 9;
            // 
            // btnReOrdenCompra
            // 
            this.btnReOrdenCompra.BackColor = System.Drawing.Color.White;
            this.btnReOrdenCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReOrdenCompra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReOrdenCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnReOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReOrdenCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReOrdenCompra.Image = global::Proyecto_Final_Moanso.Properties.Resources.crear_ordenReq_40;
            this.btnReOrdenCompra.Location = new System.Drawing.Point(43, 312);
            this.btnReOrdenCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnReOrdenCompra.Name = "btnReOrdenCompra";
            this.btnReOrdenCompra.Size = new System.Drawing.Size(311, 75);
            this.btnReOrdenCompra.TabIndex = 10;
            this.btnReOrdenCompra.Text = " Orden de Compra";
            this.btnReOrdenCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReOrdenCompra.UseVisualStyleBackColor = false;
            this.btnReOrdenCompra.Click += new System.EventHandler(this.btnReOrdenCompra_Click);
            // 
            // btnMantenedoresProd
            // 
            this.btnMantenedoresProd.BackColor = System.Drawing.Color.White;
            this.btnMantenedoresProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMantenedoresProd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMantenedoresProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnMantenedoresProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenedoresProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenedoresProd.Image = global::Proyecto_Final_Moanso.Properties.Resources.editar_categ_color_42;
            this.btnMantenedoresProd.Location = new System.Drawing.Point(43, 404);
            this.btnMantenedoresProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnMantenedoresProd.Name = "btnMantenedoresProd";
            this.btnMantenedoresProd.Size = new System.Drawing.Size(311, 79);
            this.btnMantenedoresProd.TabIndex = 8;
            this.btnMantenedoresProd.Text = " Mantenedores del producto";
            this.btnMantenedoresProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantenedoresProd.UseVisualStyleBackColor = false;
            this.btnMantenedoresProd.Click += new System.EventHandler(this.btnMantenedoresProd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 78);
            this.panel1.TabIndex = 7;
            // 
            // btnSalirDeMenu
            // 
            this.btnSalirDeMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirDeMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSalirDeMenu.FlatAppearance.BorderSize = 2;
            this.btnSalirDeMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnSalirDeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirDeMenu.Image = global::Proyecto_Final_Moanso.Properties.Resources.retroceder_48;
            this.btnSalirDeMenu.Location = new System.Drawing.Point(135, 516);
            this.btnSalirDeMenu.Name = "btnSalirDeMenu";
            this.btnSalirDeMenu.Size = new System.Drawing.Size(95, 68);
            this.btnSalirDeMenu.TabIndex = 6;
            this.btnSalirDeMenu.UseVisualStyleBackColor = true;
            this.btnSalirDeMenu.Click += new System.EventHandler(this.btnSalirDeMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 220);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 74);
            this.panel2.TabIndex = 4;
            // 
            // btnMantProductos
            // 
            this.btnMantProductos.BackColor = System.Drawing.Color.White;
            this.btnMantProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMantProductos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMantProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnMantProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantProductos.Image = global::Proyecto_Final_Moanso.Properties.Resources.productos_40;
            this.btnMantProductos.Location = new System.Drawing.Point(43, 219);
            this.btnMantProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMantProductos.Name = "btnMantProductos";
            this.btnMantProductos.Size = new System.Drawing.Size(311, 75);
            this.btnMantProductos.TabIndex = 5;
            this.btnMantProductos.Text = " Mantenedor productos";
            this.btnMantProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantProductos.UseVisualStyleBackColor = false;
            this.btnMantProductos.Click += new System.EventHandler(this.btnMantProductos_Click);
            // 
            // pbLogo1
            // 
            this.pbLogo1.BackgroundImage = global::Proyecto_Final_Moanso.Properties.Resources.logorubio;
            this.pbLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo1.Location = new System.Drawing.Point(10, 13);
            this.pbLogo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo1.Name = "pbLogo1";
            this.pbLogo1.Size = new System.Drawing.Size(329, 154);
            this.pbLogo1.TabIndex = 2;
            this.pbLogo1.TabStop = false;
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.Gainsboro;
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(354, 64);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(948, 610);
            this.pnPrincipal.TabIndex = 4;
            // 
            // Frm_MenuAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 674);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_MenuAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Almacen";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarPrograma2)).EndInit();
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCerrarPrograma2;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbLogo1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMantProductos;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Button btnSalirDeMenu;
        private System.Windows.Forms.Button btnMantenedoresProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReOrdenCompra;
    }
}