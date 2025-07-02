namespace Proyecto_Final_Moanso
{
    partial class Frm_ReportesVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReportesVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dgvReportesVenta = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrarPDF = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnBusCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesVenta)).BeginInit();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 32);
            this.label5.TabIndex = 43;
            this.label5.Text = "Reporte de Ventas:";
            // 
            // dgvReportesVenta
            // 
            this.dgvReportesVenta.AllowUserToAddRows = false;
            this.dgvReportesVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvReportesVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportesVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReportesVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReportesVenta.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportesVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReportesVenta.ColumnHeadersHeight = 35;
            this.dgvReportesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportesVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReportesVenta.EnableHeadersVisualStyles = false;
            this.dgvReportesVenta.GridColor = System.Drawing.Color.Orange;
            this.dgvReportesVenta.Location = new System.Drawing.Point(54, 131);
            this.dgvReportesVenta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReportesVenta.Name = "dgvReportesVenta";
            this.dgvReportesVenta.ReadOnly = true;
            this.dgvReportesVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportesVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReportesVenta.RowHeadersVisible = false;
            this.dgvReportesVenta.RowHeadersWidth = 60;
            this.dgvReportesVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReportesVenta.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReportesVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportesVenta.Size = new System.Drawing.Size(837, 345);
            this.dgvReportesVenta.TabIndex = 44;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(54, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 30);
            this.textBox1.TabIndex = 45;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nombre del Cliente :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(362, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 30);
            this.dateTimePicker1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Fecha de Venta :";
            // 
            // btnMostrarPDF
            // 
            this.btnMostrarPDF.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMostrarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarPDF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMostrarPDF.FlatAppearance.BorderSize = 2;
            this.btnMostrarPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnMostrarPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnMostrarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPDF.ForeColor = System.Drawing.Color.White;
            this.btnMostrarPDF.Image = global::Proyecto_Final_Moanso.Properties.Resources.pdf_file_44;
            this.btnMostrarPDF.Location = new System.Drawing.Point(260, 489);
            this.btnMostrarPDF.Name = "btnMostrarPDF";
            this.btnMostrarPDF.Size = new System.Drawing.Size(174, 71);
            this.btnMostrarPDF.TabIndex = 50;
            this.btnMostrarPDF.Text = "Mostrar";
            this.btnMostrarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMostrarPDF.UseVisualStyleBackColor = false;
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLeer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLeer.FlatAppearance.BorderSize = 2;
            this.btnLeer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnLeer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnLeer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.ForeColor = System.Drawing.Color.White;
            this.btnLeer.Location = new System.Drawing.Point(54, 489);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(168, 71);
            this.btnLeer.TabIndex = 51;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = false;
            // 
            // btnBusCliente
            // 
            this.btnBusCliente.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBusCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBusCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnBusCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusCliente.Image = global::Proyecto_Final_Moanso.Properties.Resources.search_26px;
            this.btnBusCliente.Location = new System.Drawing.Point(260, 84);
            this.btnBusCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusCliente.Name = "btnBusCliente";
            this.btnBusCliente.Size = new System.Drawing.Size(66, 38);
            this.btnBusCliente.TabIndex = 49;
            this.btnBusCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusCliente.UseVisualStyleBackColor = false;
            // 
            // Frm_ReportesVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(942, 610);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnMostrarPDF);
            this.Controls.Add(this.btnBusCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvReportesVenta);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ReportesVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportesVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvReportesVenta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBusCliente;
        private System.Windows.Forms.Button btnMostrarPDF;
        private System.Windows.Forms.Button btnLeer;
    }
}