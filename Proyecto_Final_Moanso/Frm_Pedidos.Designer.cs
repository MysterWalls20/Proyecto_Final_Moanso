namespace Proyecto_Final_Moanso
{
    partial class Frm_Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvPerReparto = new System.Windows.Forms.DataGridView();
            this.IDemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direcped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEnvio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEntrega = new System.Windows.Forms.DateTimePicker();
            this.chConfirmaDiaEnv = new System.Windows.Forms.CheckBox();
            this.dgvPerAlmacen = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlmacenAsig1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlmacenAsig2 = new System.Windows.Forms.TextBox();
            this.txtRepartidorAsig = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnVerEstadosPed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerReparto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerAlmacen)).BeginInit();
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
            // dgvPerReparto
            // 
            this.dgvPerReparto.AllowUserToAddRows = false;
            this.dgvPerReparto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPerReparto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvPerReparto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPerReparto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPerReparto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerReparto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvPerReparto.ColumnHeadersHeight = 35;
            this.dgvPerReparto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPerReparto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDemp,
            this.NomEmp,
            this.Direcped});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerReparto.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvPerReparto.EnableHeadersVisualStyles = false;
            this.dgvPerReparto.GridColor = System.Drawing.Color.Orange;
            this.dgvPerReparto.Location = new System.Drawing.Point(485, 45);
            this.dgvPerReparto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPerReparto.Name = "dgvPerReparto";
            this.dgvPerReparto.ReadOnly = true;
            this.dgvPerReparto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerReparto.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvPerReparto.RowHeadersVisible = false;
            this.dgvPerReparto.RowHeadersWidth = 60;
            this.dgvPerReparto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPerReparto.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvPerReparto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerReparto.Size = new System.Drawing.Size(366, 321);
            this.dgvPerReparto.TabIndex = 11;
            // 
            // IDemp
            // 
            this.IDemp.HeaderText = "Id:";
            this.IDemp.MinimumWidth = 6;
            this.IDemp.Name = "IDemp";
            this.IDemp.ReadOnly = true;
            this.IDemp.Width = 61;
            // 
            // NomEmp
            // 
            this.NomEmp.HeaderText = "Nombre:";
            this.NomEmp.MinimumWidth = 6;
            this.NomEmp.Name = "NomEmp";
            this.NomEmp.ReadOnly = true;
            this.NomEmp.Width = 113;
            // 
            // Direcped
            // 
            this.Direcped.HeaderText = "Disponible:";
            this.Direcped.MinimumWidth = 6;
            this.Direcped.Name = "Direcped";
            this.Direcped.ReadOnly = true;
            this.Direcped.Width = 134;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hora de Envio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Hora de Entrega:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Fecha de Entrega:";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.CalendarFont = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.Enabled = false;
            this.dtpFechaEntrega.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(203, 548);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(156, 29);
            this.dtpFechaEntrega.TabIndex = 24;
            // 
            // dtpHoraEnvio
            // 
            this.dtpHoraEnvio.CalendarFont = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEnvio.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEnvio.Location = new System.Drawing.Point(177, 440);
            this.dtpHoraEnvio.Name = "dtpHoraEnvio";
            this.dtpHoraEnvio.ShowUpDown = true;
            this.dtpHoraEnvio.Size = new System.Drawing.Size(132, 29);
            this.dtpHoraEnvio.TabIndex = 25;
            // 
            // dtpHoraEntrega
            // 
            this.dtpHoraEntrega.CalendarFont = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrega.Enabled = false;
            this.dtpHoraEntrega.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEntrega.Location = new System.Drawing.Point(202, 495);
            this.dtpHoraEntrega.Name = "dtpHoraEntrega";
            this.dtpHoraEntrega.ShowUpDown = true;
            this.dtpHoraEntrega.Size = new System.Drawing.Size(132, 29);
            this.dtpHoraEntrega.TabIndex = 26;
            // 
            // chConfirmaDiaEnv
            // 
            this.chConfirmaDiaEnv.AutoSize = true;
            this.chConfirmaDiaEnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chConfirmaDiaEnv.Location = new System.Drawing.Point(67, 393);
            this.chConfirmaDiaEnv.Name = "chConfirmaDiaEnv";
            this.chConfirmaDiaEnv.Size = new System.Drawing.Size(192, 26);
            this.chConfirmaDiaEnv.TabIndex = 27;
            this.chConfirmaDiaEnv.Text = "¿SE ENVIA HOY?";
            this.chConfirmaDiaEnv.UseVisualStyleBackColor = true;
            this.chConfirmaDiaEnv.CheckedChanged += new System.EventHandler(this.chConfirmaDiaEnv_CheckedChanged);
            // 
            // dgvPerAlmacen
            // 
            this.dgvPerAlmacen.AllowUserToAddRows = false;
            this.dgvPerAlmacen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPerAlmacen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvPerAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPerAlmacen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPerAlmacen.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerAlmacen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvPerAlmacen.ColumnHeadersHeight = 35;
            this.dgvPerAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPerAlmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerAlmacen.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvPerAlmacen.EnableHeadersVisualStyles = false;
            this.dgvPerAlmacen.GridColor = System.Drawing.Color.Orange;
            this.dgvPerAlmacen.Location = new System.Drawing.Point(26, 45);
            this.dgvPerAlmacen.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPerAlmacen.Name = "dgvPerAlmacen";
            this.dgvPerAlmacen.ReadOnly = true;
            this.dgvPerAlmacen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerAlmacen.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvPerAlmacen.RowHeadersVisible = false;
            this.dgvPerAlmacen.RowHeadersWidth = 60;
            this.dgvPerAlmacen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPerAlmacen.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvPerAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerAlmacen.Size = new System.Drawing.Size(366, 321);
            this.dgvPerAlmacen.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id:";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 61;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre:";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 113;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Disponible:";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Personal de almacen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Personal de Reparto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Per. Almacen 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Per. Repartidor:";
            // 
            // txtAlmacenAsig1
            // 
            this.txtAlmacenAsig1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlmacenAsig1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlmacenAsig1.Location = new System.Drawing.Point(634, 392);
            this.txtAlmacenAsig1.Name = "txtAlmacenAsig1";
            this.txtAlmacenAsig1.Size = new System.Drawing.Size(169, 27);
            this.txtAlmacenAsig1.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Per. Almacen 2:";
            // 
            // txtAlmacenAsig2
            // 
            this.txtAlmacenAsig2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlmacenAsig2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlmacenAsig2.Location = new System.Drawing.Point(634, 440);
            this.txtAlmacenAsig2.Name = "txtAlmacenAsig2";
            this.txtAlmacenAsig2.Size = new System.Drawing.Size(169, 27);
            this.txtAlmacenAsig2.TabIndex = 35;
            // 
            // txtRepartidorAsig
            // 
            this.txtRepartidorAsig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepartidorAsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepartidorAsig.Location = new System.Drawing.Point(634, 495);
            this.txtRepartidorAsig.Name = "txtRepartidorAsig";
            this.txtRepartidorAsig.Size = new System.Drawing.Size(169, 27);
            this.txtRepartidorAsig.TabIndex = 36;
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.Orange;
            this.btnAsignar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAsignar.FlatAppearance.BorderSize = 2;
            this.btnAsignar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnAsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(634, 553);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(169, 62);
            this.btnAsignar.TabIndex = 37;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnVerEstadosPed
            // 
            this.btnVerEstadosPed.BackColor = System.Drawing.Color.Orange;
            this.btnVerEstadosPed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerEstadosPed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerEstadosPed.FlatAppearance.BorderSize = 2;
            this.btnVerEstadosPed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnVerEstadosPed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnVerEstadosPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEstadosPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEstadosPed.Location = new System.Drawing.Point(407, 553);
            this.btnVerEstadosPed.Name = "btnVerEstadosPed";
            this.btnVerEstadosPed.Size = new System.Drawing.Size(182, 62);
            this.btnVerEstadosPed.TabIndex = 38;
            this.btnVerEstadosPed.Text = "Estado de pedidos";
            this.btnVerEstadosPed.UseVisualStyleBackColor = false;
            this.btnVerEstadosPed.Click += new System.EventHandler(this.btnVerEstadosPed_Click);
            // 
            // Frm_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(889, 649);
            this.Controls.Add(this.btnVerEstadosPed);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txtRepartidorAsig);
            this.Controls.Add(this.txtAlmacenAsig2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAlmacenAsig1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPerAlmacen);
            this.Controls.Add(this.chConfirmaDiaEnv);
            this.Controls.Add(this.dtpHoraEntrega);
            this.Controls.Add(this.dtpHoraEnvio);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPerReparto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerReparto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerAlmacen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvPerReparto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpHoraEnvio;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrega;
        private System.Windows.Forms.CheckBox chConfirmaDiaEnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direcped;
        private System.Windows.Forms.DataGridView dgvPerAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlmacenAsig1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlmacenAsig2;
        private System.Windows.Forms.TextBox txtRepartidorAsig;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnVerEstadosPed;
    }
}