namespace Proyecto_Final_Moanso
{
    partial class Frm_OrdenesCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OrdenesCompra));
            this.dgvOrdenesCompra = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBusProveedor = new System.Windows.Forms.Button();
            this.btnVerLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrdenesCompra
            // 
            this.dgvOrdenesCompra.AllowUserToAddRows = false;
            this.dgvOrdenesCompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOrdenesCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdenesCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdenesCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenesCompra.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenesCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrdenesCompra.ColumnHeadersHeight = 35;
            this.dgvOrdenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdenesCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrdenesCompra.EnableHeadersVisualStyles = false;
            this.dgvOrdenesCompra.GridColor = System.Drawing.Color.Orange;
            this.dgvOrdenesCompra.Location = new System.Drawing.Point(15, 85);
            this.dgvOrdenesCompra.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrdenesCompra.Name = "dgvOrdenesCompra";
            this.dgvOrdenesCompra.ReadOnly = true;
            this.dgvOrdenesCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenesCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrdenesCompra.RowHeadersVisible = false;
            this.dgvOrdenesCompra.RowHeadersWidth = 60;
            this.dgvOrdenesCompra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOrdenesCompra.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrdenesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenesCompra.Size = new System.Drawing.Size(797, 294);
            this.dgvOrdenesCompra.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(15, 40);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.MaxLength = 30;
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(160, 38);
            this.txtBuscar.TabIndex = 55;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Num. de Orden:";
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
            // btnBusProveedor
            // 
            this.btnBusProveedor.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBusProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBusProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusProveedor.Image = global::Proyecto_Final_Moanso.Properties.Resources.search_26px;
            this.btnBusProveedor.Location = new System.Drawing.Point(185, 39);
            this.btnBusProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusProveedor.Name = "btnBusProveedor";
            this.btnBusProveedor.Size = new System.Drawing.Size(67, 38);
            this.btnBusProveedor.TabIndex = 56;
            this.btnBusProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBusProveedor.UseVisualStyleBackColor = false;
            // 
            // btnVerLista
            // 
            this.btnVerLista.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVerLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerLista.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerLista.FlatAppearance.BorderSize = 2;
            this.btnVerLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnVerLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnVerLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerLista.ForeColor = System.Drawing.Color.White;
            this.btnVerLista.ImageKey = "Product-sale-report_25407.png";
            this.btnVerLista.ImageList = this.imageList1;
            this.btnVerLista.Location = new System.Drawing.Point(821, 85);
            this.btnVerLista.Name = "btnVerLista";
            this.btnVerLista.Size = new System.Drawing.Size(114, 94);
            this.btnVerLista.TabIndex = 53;
            this.btnVerLista.Text = "\r\n\r\nListar";
            this.btnVerLista.UseVisualStyleBackColor = false;
            this.btnVerLista.Click += new System.EventHandler(this.btnVerLista_Click);
            // 
            // Frm_OrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(950, 610);
            this.Controls.Add(this.btnBusProveedor);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVerLista);
            this.Controls.Add(this.dgvOrdenesCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_OrdenesCompra";
            this.Text = "Frm_OrdenesCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrdenesCompra;
        private System.Windows.Forms.Button btnVerLista;
        private System.Windows.Forms.Button btnBusProveedor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
    }
}