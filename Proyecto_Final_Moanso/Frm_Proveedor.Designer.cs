namespace Proyecto_Final_Moanso
{
    partial class Frm_Proveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Proveedor));
            this.btnMostrarDesh = new System.Windows.Forms.Button();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.btnBusProveedor = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnHabilitadProv = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminarProv = new System.Windows.Forms.Button();
            this.btnNuevoProv = new System.Windows.Forms.Button();
            this.btnActualizarProv = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRazSoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbmRubro = new System.Windows.Forms.ComboBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarDesh
            // 
            this.btnMostrarDesh.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMostrarDesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMostrarDesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarDesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDesh.Location = new System.Drawing.Point(637, 37);
            this.btnMostrarDesh.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarDesh.Name = "btnMostrarDesh";
            this.btnMostrarDesh.Size = new System.Drawing.Size(300, 39);
            this.btnMostrarDesh.TabIndex = 59;
            this.btnMostrarDesh.Text = "Mostrar Deshabilitados";
            this.btnMostrarDesh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarDesh.UseVisualStyleBackColor = false;
            this.btnMostrarDesh.Click += new System.EventHandler(this.btnMostrarDesh_Click);
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToAddRows = false;
            this.dgvProveedor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProveedor.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProveedor.ColumnHeadersHeight = 35;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedor.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProveedor.EnableHeadersVisualStyles = false;
            this.dgvProveedor.GridColor = System.Drawing.Color.Orange;
            this.dgvProveedor.Location = new System.Drawing.Point(13, 82);
            this.dgvProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            this.dgvProveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvProveedor.RowHeadersVisible = false;
            this.dgvProveedor.RowHeadersWidth = 60;
            this.dgvProveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProveedor.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedor.Size = new System.Drawing.Size(924, 225);
            this.dgvProveedor.TabIndex = 52;
            this.dgvProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellContentClick);
            // 
            // btnBusProveedor
            // 
            this.btnBusProveedor.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBusProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBusProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusProveedor.Image = global::Proyecto_Final_Moanso.Properties.Resources.search_26px;
            this.btnBusProveedor.Location = new System.Drawing.Point(289, 37);
            this.btnBusProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusProveedor.Name = "btnBusProveedor";
            this.btnBusProveedor.Size = new System.Drawing.Size(67, 38);
            this.btnBusProveedor.TabIndex = 51;
            this.btnBusProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusProveedor.UseVisualStyleBackColor = false;
            this.btnBusProveedor.Click += new System.EventHandler(this.btnBusProveedor_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(13, 37);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.MaxLength = 30;
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(269, 38);
            this.txtBuscar.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nombre del Proveedor:";
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
            this.imageList1.Images.SetKeyName(5, "Habilitar-30.png");
            this.imageList1.Images.SetKeyName(6, "Deshabilitar-30.png");
            // 
            // btnHabilitadProv
            // 
            this.btnHabilitadProv.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHabilitadProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHabilitadProv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHabilitadProv.FlatAppearance.BorderSize = 2;
            this.btnHabilitadProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnHabilitadProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitadProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitadProv.ForeColor = System.Drawing.Color.White;
            this.btnHabilitadProv.ImageKey = "Habilitar-30.png";
            this.btnHabilitadProv.ImageList = this.imageList1;
            this.btnHabilitadProv.Location = new System.Drawing.Point(748, 494);
            this.btnHabilitadProv.Margin = new System.Windows.Forms.Padding(4);
            this.btnHabilitadProv.Name = "btnHabilitadProv";
            this.btnHabilitadProv.Size = new System.Drawing.Size(124, 98);
            this.btnHabilitadProv.TabIndex = 64;
            this.btnHabilitadProv.Text = "\r\n\r\n\rHabilitar";
            this.btnHabilitadProv.UseVisualStyleBackColor = false;
            this.btnHabilitadProv.Click += new System.EventHandler(this.btnHabilitadProv_Click);
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
            this.btnMostrar.Location = new System.Drawing.Point(245, 494);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(124, 98);
            this.btnMostrar.TabIndex = 63;
            this.btnMostrar.Text = "\r\n\r\n\r\nMostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEliminarProv
            // 
            this.btnEliminarProv.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarProv.FlatAppearance.BorderSize = 2;
            this.btnEliminarProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnEliminarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProv.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProv.ImageKey = "Deshabilitar-30.png";
            this.btnEliminarProv.ImageList = this.imageList1;
            this.btnEliminarProv.Location = new System.Drawing.Point(578, 494);
            this.btnEliminarProv.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarProv.Name = "btnEliminarProv";
            this.btnEliminarProv.Size = new System.Drawing.Size(128, 98);
            this.btnEliminarProv.TabIndex = 62;
            this.btnEliminarProv.Text = "\r\n\r\n\r\nDeshabilitar";
            this.btnEliminarProv.UseVisualStyleBackColor = false;
            this.btnEliminarProv.Click += new System.EventHandler(this.btnEliminarProv_Click);
            // 
            // btnNuevoProv
            // 
            this.btnNuevoProv.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNuevoProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoProv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoProv.FlatAppearance.BorderSize = 2;
            this.btnNuevoProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnNuevoProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProv.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProv.ImageKey = "new_file256_25213(1).png";
            this.btnNuevoProv.ImageList = this.imageList1;
            this.btnNuevoProv.Location = new System.Drawing.Point(80, 494);
            this.btnNuevoProv.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoProv.Name = "btnNuevoProv";
            this.btnNuevoProv.Size = new System.Drawing.Size(124, 98);
            this.btnNuevoProv.TabIndex = 60;
            this.btnNuevoProv.Text = "\r\n\r\n\r\nNuevo";
            this.btnNuevoProv.UseVisualStyleBackColor = false;
            this.btnNuevoProv.Click += new System.EventHandler(this.btnNuevoProv_Click);
            // 
            // btnActualizarProv
            // 
            this.btnActualizarProv.BackColor = System.Drawing.Color.DarkOrange;
            this.btnActualizarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarProv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizarProv.FlatAppearance.BorderSize = 2;
            this.btnActualizarProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnActualizarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProv.ForeColor = System.Drawing.Color.White;
            this.btnActualizarProv.ImageKey = "save_file_disk_open_searsh_loading_clipboard_1513(1).png";
            this.btnActualizarProv.ImageList = this.imageList1;
            this.btnActualizarProv.Location = new System.Drawing.Point(412, 494);
            this.btnActualizarProv.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarProv.Name = "btnActualizarProv";
            this.btnActualizarProv.Size = new System.Drawing.Size(124, 98);
            this.btnActualizarProv.TabIndex = 61;
            this.btnActualizarProv.Text = "\r\n\r\n\r\nActualizar";
            this.btnActualizarProv.UseVisualStyleBackColor = false;
            this.btnActualizarProv.Click += new System.EventHandler(this.btnActualizarProv_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(401, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 26);
            this.label11.TabIndex = 65;
            this.label11.Text = "Razon S";
            // 
            // txtRazSoc
            // 
            this.txtRazSoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazSoc.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazSoc.Location = new System.Drawing.Point(500, 380);
            this.txtRazSoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRazSoc.MaxLength = 20;
            this.txtRazSoc.Name = "txtRazSoc";
            this.txtRazSoc.Size = new System.Drawing.Size(206, 33);
            this.txtRazSoc.TabIndex = 66;
            this.txtRazSoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 26);
            this.label1.TabIndex = 67;
            this.label1.Text = "Ruc";
            // 
            // txtRuc
            // 
            this.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRuc.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuc.Location = new System.Drawing.Point(470, 331);
            this.txtRuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRuc.MaxLength = 20;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(203, 33);
            this.txtRuc.TabIndex = 68;
            this.txtRuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 69;
            this.label3.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(479, 427);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.MaxLength = 20;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(260, 33);
            this.txtDireccion.TabIndex = 70;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(755, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 71;
            this.label4.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(760, 428);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(177, 33);
            this.txtTelefono.TabIndex = 72;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(726, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 75;
            this.label6.Text = "Rubro:";
            // 
            // cbmRubro
            // 
            this.cbmRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmRubro.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmRubro.FormattingEnabled = true;
            this.cbmRubro.Location = new System.Drawing.Point(729, 355);
            this.cbmRubro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbmRubro.Name = "cbmRubro";
            this.cbmRubro.Size = new System.Drawing.Size(208, 31);
            this.cbmRubro.TabIndex = 76;
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(102, 437);
            this.cboDistrito.Margin = new System.Windows.Forms.Padding(4);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(254, 30);
            this.cboDistrito.TabIndex = 81;
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(121, 395);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(4);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(260, 30);
            this.cboProvincia.TabIndex = 80;
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(165, 352);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(225, 30);
            this.cboDepartamento.TabIndex = 79;
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 26);
            this.label9.TabIndex = 84;
            this.label9.Text = "Distrito\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 26);
            this.label8.TabIndex = 83;
            this.label8.Text = "Provincia\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 26);
            this.label7.TabIndex = 82;
            this.label7.Text = "Departamento";
            // 
            // Frm_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(950, 610);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboDistrito);
            this.Controls.Add(this.cboProvincia);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.cbmRubro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRazSoc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnHabilitadProv);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEliminarProv);
            this.Controls.Add(this.btnNuevoProv);
            this.Controls.Add(this.btnActualizarProv);
            this.Controls.Add(this.btnMostrarDesh);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.btnBusProveedor);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Proveedor";
            this.Text = "Frm_Proveedor";
            this.Load += new System.EventHandler(this.Frm_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarDesh;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Button btnBusProveedor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnHabilitadProv;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminarProv;
        private System.Windows.Forms.Button btnNuevoProv;
        private System.Windows.Forms.Button btnActualizarProv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRazSoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbmRubro;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}