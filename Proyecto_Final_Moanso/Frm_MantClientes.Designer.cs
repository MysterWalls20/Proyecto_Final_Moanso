namespace Proyecto_Final_Moanso
{
    partial class Frm_MantClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MantClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtBuscarCli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnMostrarDesh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumRegCli = new System.Windows.Forms.Label();
            this.btnHabilitarCli = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnDeshabilitarCli = new System.Windows.Forms.Button();
            this.btnNuevoCli = new System.Windows.Forms.Button();
            this.btnModificarCli = new System.Windows.Forms.Button();
            this.btnBusCliente = new System.Windows.Forms.Button();
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
            this.imageList1.Images.SetKeyName(5, "Habilitar-30.png");
            this.imageList1.Images.SetKeyName(6, "Deshabilitar-30.png");
            // 
            // txtBuscarCli
            // 
            this.txtBuscarCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCli.Location = new System.Drawing.Point(13, 70);
            this.txtBuscarCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarCli.MaxLength = 30;
            this.txtBuscarCli.Multiline = true;
            this.txtBuscarCli.Name = "txtBuscarCli";
            this.txtBuscarCli.Size = new System.Drawing.Size(269, 38);
            this.txtBuscarCli.TabIndex = 19;
            this.txtBuscarCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 41);
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
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvClientes.ColumnHeadersHeight = 35;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.Color.Orange;
            this.dgvClientes.Location = new System.Drawing.Point(13, 117);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidth = 60;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(916, 297);
            this.dgvClientes.TabIndex = 21;
            // 
            // btnMostrarDesh
            // 
            this.btnMostrarDesh.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMostrarDesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMostrarDesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarDesh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMostrarDesh.FlatAppearance.BorderSize = 2;
            this.btnMostrarDesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDesh.Location = new System.Drawing.Point(637, 423);
            this.btnMostrarDesh.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarDesh.Name = "btnMostrarDesh";
            this.btnMostrarDesh.Size = new System.Drawing.Size(290, 40);
            this.btnMostrarDesh.TabIndex = 48;
            this.btnMostrarDesh.Text = "Mostrar Deshabilitados";
            this.btnMostrarDesh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarDesh.UseVisualStyleBackColor = false;
            this.btnMostrarDesh.Click += new System.EventHandler(this.btnMostrarDesh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(349, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 32);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tabla de Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Total de registros:";
            // 
            // lbNumRegCli
            // 
            this.lbNumRegCli.AutoSize = true;
            this.lbNumRegCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRegCli.Location = new System.Drawing.Point(220, 427);
            this.lbNumRegCli.Name = "lbNumRegCli";
            this.lbNumRegCli.Size = new System.Drawing.Size(24, 25);
            this.lbNumRegCli.TabIndex = 51;
            this.lbNumRegCli.Text = "0";
            // 
            // btnHabilitarCli
            // 
            this.btnHabilitarCli.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHabilitarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHabilitarCli.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHabilitarCli.FlatAppearance.BorderSize = 2;
            this.btnHabilitarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnHabilitarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarCli.ForeColor = System.Drawing.Color.White;
            this.btnHabilitarCli.ImageKey = "Habilitar-30.png";
            this.btnHabilitarCli.ImageList = this.imageList1;
            this.btnHabilitarCli.Location = new System.Drawing.Point(745, 497);
            this.btnHabilitarCli.Margin = new System.Windows.Forms.Padding(4);
            this.btnHabilitarCli.Name = "btnHabilitarCli";
            this.btnHabilitarCli.Size = new System.Drawing.Size(124, 98);
            this.btnHabilitarCli.TabIndex = 44;
            this.btnHabilitarCli.Text = "\r\n\r\n\rHabilitar";
            this.btnHabilitarCli.UseVisualStyleBackColor = false;
            this.btnHabilitarCli.Click += new System.EventHandler(this.btnHabilitarCli_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLeer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLeer.FlatAppearance.BorderSize = 2;
            this.btnLeer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.ForeColor = System.Drawing.Color.White;
            this.btnLeer.ImageKey = "Product-sale-report_25407.png";
            this.btnLeer.ImageList = this.imageList1;
            this.btnLeer.Location = new System.Drawing.Point(237, 497);
            this.btnLeer.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(124, 98);
            this.btnLeer.TabIndex = 25;
            this.btnLeer.Text = "\r\n\r\n\r\nLeer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnDeshabilitarCli
            // 
            this.btnDeshabilitarCli.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDeshabilitarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshabilitarCli.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeshabilitarCli.FlatAppearance.BorderSize = 2;
            this.btnDeshabilitarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnDeshabilitarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshabilitarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitarCli.ForeColor = System.Drawing.Color.White;
            this.btnDeshabilitarCli.ImageKey = "Deshabilitar-30.png";
            this.btnDeshabilitarCli.ImageList = this.imageList1;
            this.btnDeshabilitarCli.Location = new System.Drawing.Point(568, 497);
            this.btnDeshabilitarCli.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeshabilitarCli.Name = "btnDeshabilitarCli";
            this.btnDeshabilitarCli.Size = new System.Drawing.Size(136, 98);
            this.btnDeshabilitarCli.TabIndex = 24;
            this.btnDeshabilitarCli.Text = "\r\n\r\n\r\nDeshabilitar";
            this.btnDeshabilitarCli.UseVisualStyleBackColor = false;
            this.btnDeshabilitarCli.Click += new System.EventHandler(this.btnDeshabilitarCli_Click);
            // 
            // btnNuevoCli
            // 
            this.btnNuevoCli.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNuevoCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCli.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoCli.FlatAppearance.BorderSize = 2;
            this.btnNuevoCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnNuevoCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCli.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCli.ImageKey = "new_file256_25213(1).png";
            this.btnNuevoCli.ImageList = this.imageList1;
            this.btnNuevoCli.Location = new System.Drawing.Point(71, 497);
            this.btnNuevoCli.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoCli.Name = "btnNuevoCli";
            this.btnNuevoCli.Size = new System.Drawing.Size(124, 98);
            this.btnNuevoCli.TabIndex = 22;
            this.btnNuevoCli.Text = "\r\n\r\n\r\nNuevo";
            this.btnNuevoCli.UseVisualStyleBackColor = false;
            this.btnNuevoCli.Click += new System.EventHandler(this.btnNuevoCli_Click);
            // 
            // btnModificarCli
            // 
            this.btnModificarCli.BackColor = System.Drawing.Color.DarkOrange;
            this.btnModificarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCli.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnModificarCli.FlatAppearance.BorderSize = 2;
            this.btnModificarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnModificarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCli.ForeColor = System.Drawing.Color.White;
            this.btnModificarCli.ImageKey = "save_file_disk_open_searsh_loading_clipboard_1513(1).png";
            this.btnModificarCli.ImageList = this.imageList1;
            this.btnModificarCli.Location = new System.Drawing.Point(403, 497);
            this.btnModificarCli.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarCli.Name = "btnModificarCli";
            this.btnModificarCli.Size = new System.Drawing.Size(124, 98);
            this.btnModificarCli.TabIndex = 23;
            this.btnModificarCli.Text = "\r\n\r\n\r\nModificar";
            this.btnModificarCli.UseVisualStyleBackColor = false;
            this.btnModificarCli.Click += new System.EventHandler(this.btnModificarCli_Click);
            // 
            // btnBusCliente
            // 
            this.btnBusCliente.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBusCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBusCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusCliente.Image = global::Proyecto_Final_Moanso.Properties.Resources.search_26px;
            this.btnBusCliente.Location = new System.Drawing.Point(289, 70);
            this.btnBusCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusCliente.Name = "btnBusCliente";
            this.btnBusCliente.Size = new System.Drawing.Size(67, 38);
            this.btnBusCliente.TabIndex = 20;
            this.btnBusCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusCliente.UseVisualStyleBackColor = false;
            this.btnBusCliente.Click += new System.EventHandler(this.btnBusCliente_Click);
            // 
            // Frm_MantClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(941, 610);
            this.Controls.Add(this.lbNumRegCli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMostrarDesh);
            this.Controls.Add(this.btnHabilitarCli);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnDeshabilitarCli);
            this.Controls.Add(this.btnNuevoCli);
            this.Controls.Add(this.btnModificarCli);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnBusCliente);
            this.Controls.Add(this.txtBuscarCli);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_MantClientes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Frm_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnBusCliente;
        private System.Windows.Forms.TextBox txtBuscarCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnDeshabilitarCli;
        private System.Windows.Forms.Button btnNuevoCli;
        private System.Windows.Forms.Button btnModificarCli;
        private System.Windows.Forms.Button btnHabilitarCli;
        private System.Windows.Forms.Button btnMostrarDesh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNumRegCli;
    }
}