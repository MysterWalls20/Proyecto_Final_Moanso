namespace Proyecto_Final_Moanso
{
    partial class Frm_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Clientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDniC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApeC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomC = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnEliminarCli = new System.Windows.Forms.Button();
            this.btnNuevoCli = new System.Windows.Forms.Button();
            this.btnActualizarCli = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDc = new System.Windows.Forms.TextBox();
            this.txtFechaR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
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
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(23, 46);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.MaxLength = 30;
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(269, 38);
            this.txtBuscar.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre del cliente:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.ColumnHeadersHeight = 35;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.Orange;
            this.dgvClientes.Location = new System.Drawing.Point(23, 98);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 60;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(836, 276);
            this.dgvClientes.TabIndex = 21;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 26);
            this.label6.TabIndex = 36;
            this.label6.Text = "Fecha de registro :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(337, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "DNI :";
            // 
            // txtDniC
            // 
            this.txtDniC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDniC.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniC.Location = new System.Drawing.Point(403, 511);
            this.txtDniC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDniC.Name = "txtDniC";
            this.txtDniC.Size = new System.Drawing.Size(165, 33);
            this.txtDniC.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 31;
            this.label3.Text = "Número :";
            // 
            // txtNumC
            // 
            this.txtNumC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumC.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumC.Location = new System.Drawing.Point(123, 511);
            this.txtNumC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumC.Name = "txtNumC";
            this.txtNumC.Size = new System.Drawing.Size(181, 33);
            this.txtNumC.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "Apellido :";
            // 
            // txtApeC
            // 
            this.txtApeC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApeC.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeC.Location = new System.Drawing.Point(413, 462);
            this.txtApeC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApeC.Name = "txtApeC";
            this.txtApeC.Size = new System.Drawing.Size(153, 33);
            this.txtApeC.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 464);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "Nombre :";
            // 
            // txtNomC
            // 
            this.txtNomC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomC.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomC.Location = new System.Drawing.Point(121, 462);
            this.txtNomC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomC.Name = "txtNomC";
            this.txtNomC.Size = new System.Drawing.Size(170, 33);
            this.txtNomC.TabIndex = 26;
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
            this.btnMostrar.Location = new System.Drawing.Point(735, 524);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(124, 100);
            this.btnMostrar.TabIndex = 25;
            this.btnMostrar.Text = "\r\n\r\n\r\nMostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEliminarCli
            // 
            this.btnEliminarCli.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCli.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarCli.FlatAppearance.BorderSize = 2;
            this.btnEliminarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCli.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCli.ImageKey = "task_update_folder_progress_icon_142270.png";
            this.btnEliminarCli.ImageList = this.imageList1;
            this.btnEliminarCli.Location = new System.Drawing.Point(735, 402);
            this.btnEliminarCli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarCli.Name = "btnEliminarCli";
            this.btnEliminarCli.Size = new System.Drawing.Size(124, 100);
            this.btnEliminarCli.TabIndex = 24;
            this.btnEliminarCli.Text = "\r\n\r\n\r\nEliminar-";
            this.btnEliminarCli.UseVisualStyleBackColor = false;
            this.btnEliminarCli.Click += new System.EventHandler(this.btnEliminarCli_Click);
            // 
            // btnNuevoCli
            // 
            this.btnNuevoCli.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNuevoCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCli.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoCli.FlatAppearance.BorderSize = 2;
            this.btnNuevoCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnNuevoCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCli.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCli.ImageKey = "new_file256_25213(1).png";
            this.btnNuevoCli.ImageList = this.imageList1;
            this.btnNuevoCli.Location = new System.Drawing.Point(589, 402);
            this.btnNuevoCli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevoCli.Name = "btnNuevoCli";
            this.btnNuevoCli.Size = new System.Drawing.Size(124, 100);
            this.btnNuevoCli.TabIndex = 22;
            this.btnNuevoCli.Text = "\r\n\r\n\r\nNuevo+";
            this.btnNuevoCli.UseVisualStyleBackColor = false;
            this.btnNuevoCli.Click += new System.EventHandler(this.btnNuevoCli_Click);
            // 
            // btnActualizarCli
            // 
            this.btnActualizarCli.BackColor = System.Drawing.Color.DarkOrange;
            this.btnActualizarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarCli.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizarCli.FlatAppearance.BorderSize = 2;
            this.btnActualizarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnActualizarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCli.ForeColor = System.Drawing.Color.White;
            this.btnActualizarCli.ImageKey = "save_file_disk_open_searsh_loading_clipboard_1513(1).png";
            this.btnActualizarCli.ImageList = this.imageList1;
            this.btnActualizarCli.Location = new System.Drawing.Point(589, 524);
            this.btnActualizarCli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarCli.Name = "btnActualizarCli";
            this.btnActualizarCli.Size = new System.Drawing.Size(124, 100);
            this.btnActualizarCli.TabIndex = 23;
            this.btnActualizarCli.Text = "\r\n\r\n\r\nActualizar";
            this.btnActualizarCli.UseVisualStyleBackColor = false;
            this.btnActualizarCli.Click += new System.EventHandler(this.btnActualizarCli_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Proyecto_Final_Moanso.Properties.Resources.search_26px;
            this.button1.Location = new System.Drawing.Point(299, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = " Buscar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 26);
            this.label5.TabIndex = 35;
            this.label5.Text = "ID :";
            // 
            // txtIDc
            // 
            this.txtIDc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDc.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDc.Location = new System.Drawing.Point(67, 414);
            this.txtIDc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDc.Name = "txtIDc";
            this.txtIDc.ReadOnly = true;
            this.txtIDc.Size = new System.Drawing.Size(85, 33);
            this.txtIDc.TabIndex = 34;
            // 
            // txtFechaR
            // 
            this.txtFechaR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaR.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaR.Location = new System.Drawing.Point(207, 567);
            this.txtFechaR.Name = "txtFechaR";
            this.txtFechaR.ReadOnly = true;
            this.txtFechaR.Size = new System.Drawing.Size(166, 33);
            this.txtFechaR.TabIndex = 37;
            this.txtFechaR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(889, 649);
            this.Controls.Add(this.txtFechaR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIDc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDniC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApeC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomC);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEliminarCli);
            this.Controls.Add(this.btnNuevoCli);
            this.Controls.Add(this.btnActualizarCli);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnEliminarCli;
        private System.Windows.Forms.Button btnNuevoCli;
        private System.Windows.Forms.Button btnActualizarCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDniC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApeC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDc;
        private System.Windows.Forms.TextBox txtFechaR;
    }
}