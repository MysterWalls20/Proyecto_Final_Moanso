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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEliminarCli = new System.Windows.Forms.Button();
            this.btnNuevoCli = new System.Windows.Forms.Button();
            this.btnActualizarCli = new System.Windows.Forms.Button();
            this.btnBusCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumRegCli = new System.Windows.Forms.Label();
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
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(13, 70);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgvClientes.Location = new System.Drawing.Point(13, 117);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgvClientes.Size = new System.Drawing.Size(916, 297);
            this.dgvClientes.TabIndex = 21;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(629, 422);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 39);
            this.button1.TabIndex = 48;
            this.button1.Text = "Mostrar Deshabilitados";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageKey = "Habilitar-30.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(742, 500);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 98);
            this.button2.TabIndex = 44;
            this.button2.Text = "\r\n\r\n\rHabilitar";
            this.button2.UseVisualStyleBackColor = false;
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
            this.btnLeer.Location = new System.Drawing.Point(240, 500);
            this.btnLeer.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(124, 98);
            this.btnLeer.TabIndex = 25;
            this.btnLeer.Text = "\r\n\r\n\r\nLeer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnEliminarCli
            // 
            this.btnEliminarCli.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCli.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarCli.FlatAppearance.BorderSize = 2;
            this.btnEliminarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnEliminarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCli.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCli.ImageKey = "Deshabilitar-30.png";
            this.btnEliminarCli.ImageList = this.imageList1;
            this.btnEliminarCli.Location = new System.Drawing.Point(571, 500);
            this.btnEliminarCli.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarCli.Name = "btnEliminarCli";
            this.btnEliminarCli.Size = new System.Drawing.Size(128, 98);
            this.btnEliminarCli.TabIndex = 24;
            this.btnEliminarCli.Text = "\r\n\r\n\r\nDeshabilitar";
            this.btnEliminarCli.UseVisualStyleBackColor = false;
            this.btnEliminarCli.Click += new System.EventHandler(this.btnEliminarCli_Click);
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
            this.btnNuevoCli.Location = new System.Drawing.Point(75, 500);
            this.btnNuevoCli.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoCli.Name = "btnNuevoCli";
            this.btnNuevoCli.Size = new System.Drawing.Size(124, 98);
            this.btnNuevoCli.TabIndex = 22;
            this.btnNuevoCli.Text = "\r\n\r\n\r\nNuevo";
            this.btnNuevoCli.UseVisualStyleBackColor = false;
            this.btnNuevoCli.Click += new System.EventHandler(this.btnNuevoCli_Click);
            // 
            // btnActualizarCli
            // 
            this.btnActualizarCli.BackColor = System.Drawing.Color.DarkOrange;
            this.btnActualizarCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarCli.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizarCli.FlatAppearance.BorderSize = 2;
            this.btnActualizarCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnActualizarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCli.ForeColor = System.Drawing.Color.White;
            this.btnActualizarCli.ImageKey = "save_file_disk_open_searsh_loading_clipboard_1513(1).png";
            this.btnActualizarCli.ImageList = this.imageList1;
            this.btnActualizarCli.Location = new System.Drawing.Point(406, 500);
            this.btnActualizarCli.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarCli.Name = "btnActualizarCli";
            this.btnActualizarCli.Size = new System.Drawing.Size(124, 98);
            this.btnActualizarCli.TabIndex = 23;
            this.btnActualizarCli.Text = "\r\n\r\n\r\nModificar";
            this.btnActualizarCli.UseVisualStyleBackColor = false;
            this.btnActualizarCli.Click += new System.EventHandler(this.btnActualizarCli_Click);
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
            this.label1.Location = new System.Drawing.Point(8, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Total de Registros:";
            // 
            // lbNumRegCli
            // 
            this.lbNumRegCli.AutoSize = true;
            this.lbNumRegCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumRegCli.Location = new System.Drawing.Point(218, 428);
            this.lbNumRegCli.Name = "lbNumRegCli";
            this.lbNumRegCli.Size = new System.Drawing.Size(24, 25);
            this.lbNumRegCli.TabIndex = 51;
            this.lbNumRegCli.Text = "0";
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnEliminarCli);
            this.Controls.Add(this.btnNuevoCli);
            this.Controls.Add(this.btnActualizarCli);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnBusCliente);
            this.Controls.Add(this.txtBuscar);
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
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEliminarCli;
        private System.Windows.Forms.Button btnNuevoCli;
        private System.Windows.Forms.Button btnActualizarCli;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNumRegCli;
    }
}