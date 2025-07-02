namespace Proyecto_Final_Moanso
{
    partial class Frm_MantProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProductosAlm = new System.Windows.Forms.DataGridView();
            this.txtBuscarProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoriaLP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnBuscarCat = new System.Windows.Forms.Button();
            this.btnBuscarNom = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lbNumRegPro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.imageList1.Images.SetKeyName(5, "Deshabilitar-30.png");
            this.imageList1.Images.SetKeyName(6, "Habilitar-30.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(324, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tabla de Productos";
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
            this.dgvProductosAlm.Location = new System.Drawing.Point(10, 130);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductosAlm.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductosAlm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosAlm.Size = new System.Drawing.Size(925, 294);
            this.dgvProductosAlm.TabIndex = 2;
            this.dgvProductosAlm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosAlm_CellContentClick);
            this.dgvProductosAlm.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosAlm_CellContentDoubleClick);
            // 
            // txtBuscarProduct
            // 
            this.txtBuscarProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProduct.Location = new System.Drawing.Point(10, 84);
            this.txtBuscarProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarProduct.MaxLength = 30;
            this.txtBuscarProduct.Multiline = true;
            this.txtBuscarProduct.Name = "txtBuscarProduct";
            this.txtBuscarProduct.Size = new System.Drawing.Size(339, 38);
            this.txtBuscarProduct.TabIndex = 1;
            this.txtBuscarProduct.TextChanged += new System.EventHandler(this.txtBuscarProduct_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbCategoriaLP
            // 
            this.cbCategoriaLP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaLP.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoriaLP.FormattingEnabled = true;
            this.cbCategoriaLP.Location = new System.Drawing.Point(515, 83);
            this.cbCategoriaLP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoriaLP.Name = "cbCategoriaLP";
            this.cbCategoriaLP.Size = new System.Drawing.Size(347, 37);
            this.cbCategoriaLP.TabIndex = 32;
            this.cbCategoriaLP.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaLP_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Buscar por Categoria :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(684, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 39);
            this.button1.TabIndex = 49;
            this.button1.Text = "Mostrar Deshabilitados";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHabilitar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHabilitar.FlatAppearance.BorderSize = 2;
            this.btnHabilitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitar.ForeColor = System.Drawing.Color.White;
            this.btnHabilitar.ImageKey = "Habilitar-30.png";
            this.btnHabilitar.ImageList = this.imageList1;
            this.btnHabilitar.Location = new System.Drawing.Point(743, 491);
            this.btnHabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(130, 98);
            this.btnHabilitar.TabIndex = 39;
            this.btnHabilitar.Text = "\r\n\r\n\r\nHabilitar";
            this.btnHabilitar.UseVisualStyleBackColor = false;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDeshabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshabilitar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeshabilitar.FlatAppearance.BorderSize = 2;
            this.btnDeshabilitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitar.ImageKey = "Deshabilitar-30.png";
            this.btnDeshabilitar.ImageList = this.imageList1;
            this.btnDeshabilitar.Location = new System.Drawing.Point(578, 491);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(130, 98);
            this.btnDeshabilitar.TabIndex = 38;
            this.btnDeshabilitar.Text = "\r\n\r\n\r\nDeshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click_1);
            // 
            // btnBuscarCat
            // 
            this.btnBuscarCat.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscarCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnBuscarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCat.Image = global::Proyecto_Final_Moanso.Properties.Resources.search_26px;
            this.btnBuscarCat.Location = new System.Drawing.Point(871, 82);
            this.btnBuscarCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCat.Name = "btnBuscarCat";
            this.btnBuscarCat.Size = new System.Drawing.Size(64, 38);
            this.btnBuscarCat.TabIndex = 34;
            this.btnBuscarCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarCat.UseVisualStyleBackColor = false;
            this.btnBuscarCat.Click += new System.EventHandler(this.btnBuscarCat_Click);
            // 
            // btnBuscarNom
            // 
            this.btnBuscarNom.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBuscarNom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarNom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarNom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnBuscarNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNom.Image = global::Proyecto_Final_Moanso.Properties.Resources.search_26px;
            this.btnBuscarNom.Location = new System.Drawing.Point(358, 84);
            this.btnBuscarNom.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarNom.Name = "btnBuscarNom";
            this.btnBuscarNom.Size = new System.Drawing.Size(64, 38);
            this.btnBuscarNom.TabIndex = 3;
            this.btnBuscarNom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarNom.UseVisualStyleBackColor = false;
            this.btnBuscarNom.Click += new System.EventHandler(this.btnBuscarNom_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMostrar.FlatAppearance.BorderSize = 2;
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.ImageKey = "Product-sale-report_25407.png";
            this.btnMostrar.ImageList = this.imageList1;
            this.btnMostrar.Location = new System.Drawing.Point(412, 491);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(130, 98);
            this.btnMostrar.TabIndex = 11;
            this.btnMostrar.Text = "\r\n\r\n\r\nMostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatAppearance.BorderSize = 2;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.ImageKey = "new_file256_25213(1).png";
            this.btnNuevo.ImageList = this.imageList1;
            this.btnNuevo.Location = new System.Drawing.Point(79, 491);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 98);
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
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.ImageKey = "save_file_disk_open_searsh_loading_clipboard_1513(1).png";
            this.btnActualizar.ImageList = this.imageList1;
            this.btnActualizar.Location = new System.Drawing.Point(246, 491);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 98);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "\r\n\r\n\r\nActualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lbNumRegPro
            // 
            this.lbNumRegPro.AutoSize = true;
            this.lbNumRegPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRegPro.Location = new System.Drawing.Point(216, 437);
            this.lbNumRegPro.Name = "lbNumRegPro";
            this.lbNumRegPro.Size = new System.Drawing.Size(24, 25);
            this.lbNumRegPro.TabIndex = 53;
            this.lbNumRegPro.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Total de Registros:";
            // 
            // Frm_Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(950, 610);
            this.Controls.Add(this.lbNumRegPro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHabilitar);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnBuscarCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategoriaLP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarNom);
            this.Controls.Add(this.txtBuscarProduct);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProductosAlm);
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
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscarNom;
        private System.Windows.Forms.DataGridView dgvProductosAlm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoriaLP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarCat;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnHabilitar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbNumRegPro;
        private System.Windows.Forms.Label label5;
    }
}