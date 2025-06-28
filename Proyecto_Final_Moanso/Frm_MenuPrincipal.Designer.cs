namespace Proyecto_Final_Moanso
{
    partial class Frm_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuPrincipal));
            this.pnTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMVentas = new System.Windows.Forms.Button();
            this.btnMAlmacen = new System.Windows.Forms.Button();
            this.btnMCompras = new System.Windows.Forms.Button();
            this.pbCerrarMenuP = new System.Windows.Forms.PictureBox();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrarPrograma = new System.Windows.Forms.PictureBox();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarMenuP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarPrograma)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.DarkOrange;
            this.pnTop.Controls.Add(this.pbCerrarMenuP);
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Controls.Add(this.pbMinimizar);
            this.pnTop.Controls.Add(this.pbCerrarPrograma);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(850, 64);
            this.pnTop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú Principal";
            // 
            // btnMVentas
            // 
            this.btnMVentas.BackColor = System.Drawing.Color.Orange;
            this.btnMVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMVentas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMVentas.FlatAppearance.BorderSize = 2;
            this.btnMVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnMVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnMVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMVentas.Location = new System.Drawing.Point(293, 118);
            this.btnMVentas.Name = "btnMVentas";
            this.btnMVentas.Size = new System.Drawing.Size(280, 80);
            this.btnMVentas.TabIndex = 3;
            this.btnMVentas.Text = "Menú Ventas";
            this.btnMVentas.UseVisualStyleBackColor = false;
            this.btnMVentas.Click += new System.EventHandler(this.btnMVentas_Click);
            // 
            // btnMAlmacen
            // 
            this.btnMAlmacen.BackColor = System.Drawing.Color.Orange;
            this.btnMAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMAlmacen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMAlmacen.FlatAppearance.BorderSize = 2;
            this.btnMAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnMAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnMAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAlmacen.Location = new System.Drawing.Point(293, 241);
            this.btnMAlmacen.Name = "btnMAlmacen";
            this.btnMAlmacen.Size = new System.Drawing.Size(280, 80);
            this.btnMAlmacen.TabIndex = 4;
            this.btnMAlmacen.Text = "Menú Almacen";
            this.btnMAlmacen.UseVisualStyleBackColor = false;
            this.btnMAlmacen.Click += new System.EventHandler(this.btnMAlmacen_Click);
            // 
            // btnMCompras
            // 
            this.btnMCompras.BackColor = System.Drawing.Color.Orange;
            this.btnMCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMCompras.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMCompras.FlatAppearance.BorderSize = 2;
            this.btnMCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnMCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnMCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCompras.Location = new System.Drawing.Point(293, 364);
            this.btnMCompras.Name = "btnMCompras";
            this.btnMCompras.Size = new System.Drawing.Size(280, 80);
            this.btnMCompras.TabIndex = 5;
            this.btnMCompras.Text = "Menú Compras";
            this.btnMCompras.UseVisualStyleBackColor = false;
            this.btnMCompras.Click += new System.EventHandler(this.btnMCompras_Click);
            // 
            // pbCerrarMenuP
            // 
            this.pbCerrarMenuP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrarMenuP.Image = global::Proyecto_Final_Moanso.Properties.Resources.cerrar;
            this.pbCerrarMenuP.Location = new System.Drawing.Point(775, 3);
            this.pbCerrarMenuP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCerrarMenuP.Name = "pbCerrarMenuP";
            this.pbCerrarMenuP.Size = new System.Drawing.Size(71, 56);
            this.pbCerrarMenuP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrarMenuP.TabIndex = 4;
            this.pbCerrarMenuP.TabStop = false;
            this.pbCerrarMenuP.Click += new System.EventHandler(this.pbCerrarMenuP_Click);
            this.pbCerrarMenuP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCerrarMenuP_MouseDown);
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMinimizar.Image = global::Proyecto_Final_Moanso.Properties.Resources.minimazar;
            this.pbMinimizar.Location = new System.Drawing.Point(1123, 3);
            this.pbMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(71, 56);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimizar.TabIndex = 2;
            this.pbMinimizar.TabStop = false;
            // 
            // pbCerrarPrograma
            // 
            this.pbCerrarPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrarPrograma.Image = global::Proyecto_Final_Moanso.Properties.Resources.cerrar;
            this.pbCerrarPrograma.Location = new System.Drawing.Point(1210, 3);
            this.pbCerrarPrograma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCerrarPrograma.Name = "pbCerrarPrograma";
            this.pbCerrarPrograma.Size = new System.Drawing.Size(71, 56);
            this.pbCerrarPrograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCerrarPrograma.TabIndex = 1;
            this.pbCerrarPrograma.TabStop = false;
            // 
            // Frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.btnMCompras);
            this.Controls.Add(this.btnMAlmacen);
            this.Controls.Add(this.btnMVentas);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Frm_MenuPrincipal_Load);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarMenuP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarPrograma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbCerrarPrograma;
        private System.Windows.Forms.Button btnMVentas;
        private System.Windows.Forms.Button btnMAlmacen;
        private System.Windows.Forms.Button btnMCompras;
        private System.Windows.Forms.PictureBox pbCerrarMenuP;
    }
}