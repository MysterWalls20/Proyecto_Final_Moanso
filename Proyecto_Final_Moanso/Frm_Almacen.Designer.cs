namespace Proyecto_Final_Moanso
{
    partial class Frm_Almacen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Almacen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProductosAlm = new System.Windows.Forms.DataGridView();
            this.IDp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoriaLP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAlm)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "exit_closethesession_close_6317.png");
            this.imageList1.Images.SetKeyName(1, "new_file256_25213(1).png");
            this.imageList1.Images.SetKeyName(2, "Product-sale-report_25407.png");
            this.imageList1.Images.SetKeyName(3, "save_file_disk_open_searsh_loading_clipboard_1513(1).png");
            this.imageList1.Images.SetKeyName(4, "task_update_folder_progress_icon_142270.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(272, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Listado de Productos";
            // 
            // dgvProductosAlm
            // 
            this.dgvProductosAlm.AllowUserToAddRows = false;
            this.dgvProductosAlm.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProductosAlm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosAlm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductosAlm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductosAlm.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosAlm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductosAlm.ColumnHeadersHeight = 35;
            this.dgvProductosAlm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductosAlm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDp,
            this.CategP,
            this.NombreP,
            this.MarcaP,
            this.ColorP,
            this.PrecioP,
            this.StockP});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosAlm.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductosAlm.EnableHeadersVisualStyles = false;
            this.dgvProductosAlm.GridColor = System.Drawing.Color.Orange;
            this.dgvProductosAlm.Location = new System.Drawing.Point(10, 145);
            this.dgvProductosAlm.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductosAlm.Name = "dgvProductosAlm";
            this.dgvProductosAlm.ReadOnly = true;
            this.dgvProductosAlm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosAlm.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductosAlm.RowHeadersVisible = false;
            this.dgvProductosAlm.RowHeadersWidth = 60;
            this.dgvProductosAlm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductosAlm.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductosAlm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosAlm.Size = new System.Drawing.Size(868, 345);
            this.dgvProductosAlm.TabIndex = 2;
            // 
            // IDp
            // 
            this.IDp.HeaderText = "Id:";
            this.IDp.MinimumWidth = 6;
            this.IDp.Name = "IDp";
            this.IDp.ReadOnly = true;
            this.IDp.Width = 61;
            // 
            // CategP
            // 
            this.CategP.HeaderText = "Categoria:";
            this.CategP.MinimumWidth = 6;
            this.CategP.Name = "CategP";
            this.CategP.ReadOnly = true;
            this.CategP.Width = 126;
            // 
            // NombreP
            // 
            this.NombreP.HeaderText = "Nombre:";
            this.NombreP.MinimumWidth = 6;
            this.NombreP.Name = "NombreP";
            this.NombreP.ReadOnly = true;
            this.NombreP.Width = 113;
            // 
            // MarcaP
            // 
            this.MarcaP.HeaderText = "Marca:";
            this.MarcaP.MinimumWidth = 6;
            this.MarcaP.Name = "MarcaP";
            this.MarcaP.ReadOnly = true;
            this.MarcaP.Width = 97;
            // 
            // ColorP
            // 
            this.ColorP.HeaderText = "Color:";
            this.ColorP.MinimumWidth = 6;
            this.ColorP.Name = "ColorP";
            this.ColorP.ReadOnly = true;
            this.ColorP.Width = 89;
            // 
            // PrecioP
            // 
            this.PrecioP.HeaderText = "Precio U:";
            this.PrecioP.MinimumWidth = 6;
            this.PrecioP.Name = "PrecioP";
            this.PrecioP.ReadOnly = true;
            this.PrecioP.Width = 115;
            // 
            // StockP
            // 
            this.StockP.HeaderText = "Stock:";
            this.StockP.MinimumWidth = 6;
            this.StockP.Name = "StockP";
            this.StockP.ReadOnly = true;
            this.StockP.Width = 91;
            // 
            // txtBuscarProduct
            // 
            this.txtBuscarProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProduct.Location = new System.Drawing.Point(9, 97);
            this.txtBuscarProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarProduct.MaxLength = 30;
            this.txtBuscarProduct.Multiline = true;
            this.txtBuscarProduct.Name = "txtBuscarProduct";
            this.txtBuscarProduct.Size = new System.Drawing.Size(390, 38);
            this.txtBuscarProduct.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto:";
            // 
            // cbCategoriaLP
            // 
            this.cbCategoriaLP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaLP.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaLP.FormattingEnabled = true;
            this.cbCategoriaLP.Items.AddRange(new object[] {
            "Herramientas/Accesorios",
            "Calzado de Seguridad",
            "Protección Manual",
            "Protección Anticaidas",
            "Proteccion Auditiva",
            "Protección Corporal",
            "Proteccion De Cabeza",
            "Protección Respiratoria",
            "Protección para Soldadura",
            "Ropa De Protección Textiles",
            "Prootección Facial",
            "Proteccion Visual",
            "Reflectivos y Señalización",
            "Bloqueo y Mas Seguridad",
            "Equipo de Bioseguridad",
            "Equipo de Desinfeccion",
            "Equipo de Seguridad"});
            this.cbCategoriaLP.Location = new System.Drawing.Point(531, 98);
            this.cbCategoriaLP.Name = "cbCategoriaLP";
            this.cbCategoriaLP.Size = new System.Drawing.Size(347, 37);
            this.cbCategoriaLP.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Categoria :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::Proyecto_Final_Moanso.Properties.Resources.search_26px;
            this.btnBuscar.Location = new System.Drawing.Point(407, 97);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 38);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMostrar.FlatAppearance.BorderSize = 2;
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.ImageKey = "Product-sale-report_25407.png";
            this.btnMostrar.ImageList = this.imageList1;
            this.btnMostrar.Location = new System.Drawing.Point(605, 517);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(124, 100);
            this.btnMostrar.TabIndex = 11;
            this.btnMostrar.Text = "\r\n\r\n\r\nMostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.ImageKey = "task_update_folder_progress_icon_142270.png";
            this.btnEliminar.ImageList = this.imageList1;
            this.btnEliminar.Location = new System.Drawing.Point(450, 517);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 100);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "\r\n\r\n\r\nEliminar-";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatAppearance.BorderSize = 2;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.ImageKey = "new_file256_25213(1).png";
            this.btnNuevo.ImageList = this.imageList1;
            this.btnNuevo.Location = new System.Drawing.Point(137, 517);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(124, 100);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "\r\n\r\n\r\nNuevo+";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizar.FlatAppearance.BorderSize = 2;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.ImageKey = "save_file_disk_open_searsh_loading_clipboard_1513(1).png";
            this.btnActualizar.ImageList = this.imageList1;
            this.btnActualizar.Location = new System.Drawing.Point(294, 517);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(124, 100);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "\r\n\r\n\r\nActualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Frm_Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(889, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategoriaLP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarProduct);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductosAlm);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Almacen";
            this.Load += new System.EventHandler(this.Frm_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosAlm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvProductosAlm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoriaLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDp;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioP;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockP;
    }
}