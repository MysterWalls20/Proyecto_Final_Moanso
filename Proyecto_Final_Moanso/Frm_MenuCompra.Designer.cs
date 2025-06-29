namespace Proyecto_Final_Moanso
{
    partial class Frm_MenuCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuCompra));
            this.pnTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.btnOrdenCompra = new System.Windows.Forms.Button();
            this.pbLogo1 = new System.Windows.Forms.PictureBox();
            this.btnMantProveedor = new System.Windows.Forms.Button();
            this.btnSalirDeMenu = new System.Windows.Forms.Button();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrarPrograma = new System.Windows.Forms.PictureBox();
            this.pnTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarPrograma)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.DarkOrange;
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Controls.Add(this.pbMinimizar);
            this.pnTop.Controls.Add(this.pbCerrarPrograma);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(968, 52);
            this.pnTop.TabIndex = 8;
            this.pnTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTop_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú de Compras";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnOrdenCompra);
            this.panel1.Controls.Add(this.pbLogo1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnMantProveedor);
            this.panel1.Controls.Add(this.btnSalirDeMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 496);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 251);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 57);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(0, 180);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 57);
            this.panel3.TabIndex = 8;
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.Gainsboro;
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(258, 52);
            this.pnPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(710, 496);
            this.pnPrincipal.TabIndex = 10;
            // 
            // btnOrdenCompra
            // 
            this.btnOrdenCompra.BackColor = System.Drawing.Color.White;
            this.btnOrdenCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenCompra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrdenCompra.FlatAppearance.BorderSize = 2;
            this.btnOrdenCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenCompra.Image = global::Proyecto_Final_Moanso.Properties.Resources.orden_de_compra_40;
            this.btnOrdenCompra.Location = new System.Drawing.Point(32, 250);
            this.btnOrdenCompra.Name = "btnOrdenCompra";
            this.btnOrdenCompra.Size = new System.Drawing.Size(226, 58);
            this.btnOrdenCompra.TabIndex = 12;
            this.btnOrdenCompra.Text = " Orden de Compra";
            this.btnOrdenCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdenCompra.UseVisualStyleBackColor = false;
            // 
            // pbLogo1
            // 
            this.pbLogo1.BackgroundImage = global::Proyecto_Final_Moanso.Properties.Resources.logorubio;
            this.pbLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo1.Location = new System.Drawing.Point(7, 10);
            this.pbLogo1.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo1.Name = "pbLogo1";
            this.pbLogo1.Size = new System.Drawing.Size(248, 114);
            this.pbLogo1.TabIndex = 10;
            this.pbLogo1.TabStop = false;
            // 
            // btnMantProveedor
            // 
            this.btnMantProveedor.BackColor = System.Drawing.Color.White;
            this.btnMantProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMantProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMantProveedor.FlatAppearance.BorderSize = 2;
            this.btnMantProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnMantProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantProveedor.Image = global::Proyecto_Final_Moanso.Properties.Resources.proveedor_40;
            this.btnMantProveedor.Location = new System.Drawing.Point(32, 179);
            this.btnMantProveedor.Name = "btnMantProveedor";
            this.btnMantProveedor.Size = new System.Drawing.Size(226, 58);
            this.btnMantProveedor.TabIndex = 9;
            this.btnMantProveedor.Text = " Mantenedor Proveedor";
            this.btnMantProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMantProveedor.UseVisualStyleBackColor = false;
            this.btnMantProveedor.Click += new System.EventHandler(this.btnMantProveedor_Click);
            // 
            // btnSalirDeMenu
            // 
            this.btnSalirDeMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirDeMenu.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSalirDeMenu.FlatAppearance.BorderSize = 2;
            this.btnSalirDeMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnSalirDeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirDeMenu.Image = global::Proyecto_Final_Moanso.Properties.Resources.retroceder_48;
            this.btnSalirDeMenu.Location = new System.Drawing.Point(92, 418);
            this.btnSalirDeMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirDeMenu.Name = "btnSalirDeMenu";
            this.btnSalirDeMenu.Size = new System.Drawing.Size(73, 54);
            this.btnSalirDeMenu.TabIndex = 7;
            this.btnSalirDeMenu.UseVisualStyleBackColor = true;
            this.btnSalirDeMenu.Click += new System.EventHandler(this.btnSalirDeMenu_Click);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = global::Proyecto_Final_Moanso.Properties.Resources.minimazar;
            this.pbMinimizar.Location = new System.Drawing.Point(846, 2);
            this.pbMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(53, 46);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 2;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pbMinimizar_Click);
            // 
            // pbCerrarPrograma
            // 
            this.pbCerrarPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrarPrograma.Image = global::Proyecto_Final_Moanso.Properties.Resources.cerrar;
            this.pbCerrarPrograma.Location = new System.Drawing.Point(912, 2);
            this.pbCerrarPrograma.Margin = new System.Windows.Forms.Padding(2);
            this.pbCerrarPrograma.Name = "pbCerrarPrograma";
            this.pbCerrarPrograma.Size = new System.Drawing.Size(53, 46);
            this.pbCerrarPrograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrarPrograma.TabIndex = 1;
            this.pbCerrarPrograma.TabStop = false;
            this.pbCerrarPrograma.Click += new System.EventHandler(this.pbCerrarPrograma_Click);
            this.pbCerrarPrograma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCerrarPrograma_MouseDown);
            // 
            // Frm_MenuCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 548);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_MenuCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Compras";
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarPrograma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalirDeMenu;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbCerrarPrograma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMantProveedor;
        private System.Windows.Forms.PictureBox pbLogo1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOrdenCompra;
        private System.Windows.Forms.Panel pnPrincipal;
    }
}