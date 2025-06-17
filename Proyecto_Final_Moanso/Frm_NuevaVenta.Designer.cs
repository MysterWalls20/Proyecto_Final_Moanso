namespace Proyecto_Final_Moanso
{
    partial class Frm_NuevaVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIdV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadV = new System.Windows.Forms.TextBox();
            this.txtColorV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDniV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClienV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccionPed = new System.Windows.Forms.TextBox();
            this.chEnviar = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbPagoT = new System.Windows.Forms.Label();
            this.btnReporteVenta = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.dgvProductosV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaV = new System.Windows.Forms.TextBox();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.txtMarcaV = new System.Windows.Forms.TextBox();
            this.txtCategoriaV = new System.Windows.Forms.TextBox();
            this.cbmMetodoPag = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.IDv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUpv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdV
            // 
            this.txtIdV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdV.Location = new System.Drawing.Point(61, 29);
            this.txtIdV.Name = "txtIdV";
            this.txtIdV.Size = new System.Drawing.Size(95, 33);
            this.txtIdV.TabIndex = 0;
            this.txtIdV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdV_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Producto:";
            // 
            // txtProductV
            // 
            this.txtProductV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductV.Location = new System.Drawing.Point(283, 28);
            this.txtProductV.Name = "txtProductV";
            this.txtProductV.ReadOnly = true;
            this.txtProductV.Size = new System.Drawing.Size(292, 33);
            this.txtProductV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad:";
            // 
            // txtCantidadV
            // 
            this.txtCantidadV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadV.Location = new System.Drawing.Point(121, 86);
            this.txtCantidadV.MaxLength = 10000;
            this.txtCantidadV.Name = "txtCantidadV";
            this.txtCantidadV.Size = new System.Drawing.Size(91, 33);
            this.txtCantidadV.TabIndex = 7;
            this.txtCantidadV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidadV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadV_KeyPress);
            // 
            // txtColorV
            // 
            this.txtColorV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColorV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorV.Location = new System.Drawing.Point(694, 28);
            this.txtColorV.Name = "txtColorV";
            this.txtColorV.ReadOnly = true;
            this.txtColorV.Size = new System.Drawing.Size(165, 33);
            this.txtColorV.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(618, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Color:";
            // 
            // txtStockV
            // 
            this.txtStockV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockV.Location = new System.Drawing.Point(809, 86);
            this.txtStockV.Name = "txtStockV";
            this.txtStockV.ReadOnly = true;
            this.txtStockV.Size = new System.Drawing.Size(98, 33);
            this.txtStockV.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(732, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stock:";
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioV.Location = new System.Drawing.Point(630, 86);
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.ReadOnly = true;
            this.txtPrecioV.Size = new System.Drawing.Size(91, 33);
            this.txtPrecioV.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(526, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio U:";
            // 
            // txtDniV
            // 
            this.txtDniV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDniV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniV.Location = new System.Drawing.Point(101, 467);
            this.txtDniV.MaxLength = 8;
            this.txtDniV.Name = "txtDniV";
            this.txtDniV.Size = new System.Drawing.Size(179, 33);
            this.txtDniV.TabIndex = 17;
            this.txtDniV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniV_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "DNI:";
            // 
            // txtClienV
            // 
            this.txtClienV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienV.Location = new System.Drawing.Point(130, 517);
            this.txtClienV.Name = "txtClienV";
            this.txtClienV.ReadOnly = true;
            this.txtClienV.Size = new System.Drawing.Size(227, 33);
            this.txtClienV.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cliente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 571);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "Dirección:";
            // 
            // txtDireccionPed
            // 
            this.txtDireccionPed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionPed.Enabled = false;
            this.txtDireccionPed.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionPed.Location = new System.Drawing.Point(158, 568);
            this.txtDireccionPed.Name = "txtDireccionPed";
            this.txtDireccionPed.Size = new System.Drawing.Size(310, 33);
            this.txtDireccionPed.TabIndex = 20;
            // 
            // chEnviar
            // 
            this.chEnviar.AutoSize = true;
            this.chEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chEnviar.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chEnviar.Location = new System.Drawing.Point(381, 471);
            this.chEnviar.Name = "chEnviar";
            this.chEnviar.Size = new System.Drawing.Size(85, 27);
            this.chEnviar.TabIndex = 24;
            this.chEnviar.Text = "Enviar";
            this.chEnviar.UseVisualStyleBackColor = true;
            this.chEnviar.CheckedChanged += new System.EventHandler(this.chEnviar_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(645, 460);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 26);
            this.label11.TabIndex = 25;
            this.label11.Text = "Pago total:";
            // 
            // lbPagoT
            // 
            this.lbPagoT.AutoSize = true;
            this.lbPagoT.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagoT.Location = new System.Drawing.Point(805, 463);
            this.lbPagoT.Name = "lbPagoT";
            this.lbPagoT.Size = new System.Drawing.Size(53, 26);
            this.lbPagoT.TabIndex = 26;
            this.lbPagoT.Text = "0.00";
            // 
            // btnReporteVenta
            // 
            this.btnReporteVenta.BackColor = System.Drawing.Color.White;
            this.btnReporteVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteVenta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReporteVenta.FlatAppearance.BorderSize = 2;
            this.btnReporteVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnReporteVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnReporteVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteVenta.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVenta.Location = new System.Drawing.Point(650, 586);
            this.btnReporteVenta.Name = "btnReporteVenta";
            this.btnReporteVenta.Size = new System.Drawing.Size(212, 68);
            this.btnReporteVenta.TabIndex = 27;
            this.btnReporteVenta.Text = "Reporte de Ventas";
            this.btnReporteVenta.UseVisualStyleBackColor = false;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.White;
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVender.FlatAppearance.BorderSize = 2;
            this.btnVender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Image = global::Proyecto_Final_Moanso.Properties.Resources.dinero_40;
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVender.Location = new System.Drawing.Point(650, 500);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(212, 68);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = " VENDER";
            this.btnVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // dgvProductosV
            // 
            this.dgvProductosV.AllowUserToAddRows = false;
            this.dgvProductosV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProductosV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProductosV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductosV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductosV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProductosV.ColumnHeadersHeight = 35;
            this.dgvProductosV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductosV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDv,
            this.NombrePV,
            this.ColorPV,
            this.cantPV,
            this.PrecioUpv,
            this.PrecioTPV,
            this.MetPag});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosV.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProductosV.EnableHeadersVisualStyles = false;
            this.dgvProductosV.GridColor = System.Drawing.Color.Orange;
            this.dgvProductosV.Location = new System.Drawing.Point(24, 138);
            this.dgvProductosV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductosV.Name = "dgvProductosV";
            this.dgvProductosV.ReadOnly = true;
            this.dgvProductosV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosV.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProductosV.RowHeadersVisible = false;
            this.dgvProductosV.RowHeadersWidth = 60;
            this.dgvProductosV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductosV.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvProductosV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosV.Size = new System.Drawing.Size(868, 311);
            this.dgvProductosV.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 622);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 26);
            this.label10.TabIndex = 29;
            this.label10.Text = "Fecha V:";
            // 
            // txtFechaV
            // 
            this.txtFechaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaV.Location = new System.Drawing.Point(140, 620);
            this.txtFechaV.Name = "txtFechaV";
            this.txtFechaV.ReadOnly = true;
            this.txtFechaV.Size = new System.Drawing.Size(166, 33);
            this.txtFechaV.TabIndex = 30;
            this.txtFechaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteId.Location = new System.Drawing.Point(292, 471);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(17, 26);
            this.lblClienteId.TabIndex = 31;
            this.lblClienteId.Text = ".";
            this.lblClienteId.Visible = false;
            // 
            // txtMarcaV
            // 
            this.txtMarcaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarcaV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaV.Location = new System.Drawing.Point(866, 29);
            this.txtMarcaV.Name = "txtMarcaV";
            this.txtMarcaV.ReadOnly = true;
            this.txtMarcaV.Size = new System.Drawing.Size(10, 33);
            this.txtMarcaV.TabIndex = 32;
            this.txtMarcaV.Visible = false;
            // 
            // txtCategoriaV
            // 
            this.txtCategoriaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoriaV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaV.Location = new System.Drawing.Point(582, 29);
            this.txtCategoriaV.Name = "txtCategoriaV";
            this.txtCategoriaV.ReadOnly = true;
            this.txtCategoriaV.Size = new System.Drawing.Size(10, 33);
            this.txtCategoriaV.TabIndex = 33;
            this.txtCategoriaV.Visible = false;
            // 
            // cbmMetodoPag
            // 
            this.cbmMetodoPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmMetodoPag.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmMetodoPag.FormattingEnabled = true;
            this.cbmMetodoPag.Location = new System.Drawing.Point(329, 87);
            this.cbmMetodoPag.Name = "cbmMetodoPag";
            this.cbmMetodoPag.Size = new System.Drawing.Size(191, 34);
            this.cbmMetodoPag.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(228, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 26);
            this.label12.TabIndex = 35;
            this.label12.Text = "M. Pago:";
            // 
            // IDv
            // 
            this.IDv.HeaderText = "Id:";
            this.IDv.MinimumWidth = 6;
            this.IDv.Name = "IDv";
            this.IDv.ReadOnly = true;
            this.IDv.Width = 61;
            // 
            // NombrePV
            // 
            this.NombrePV.HeaderText = "Producto:";
            this.NombrePV.MinimumWidth = 6;
            this.NombrePV.Name = "NombrePV";
            this.NombrePV.ReadOnly = true;
            this.NombrePV.Width = 122;
            // 
            // ColorPV
            // 
            this.ColorPV.HeaderText = "Color:";
            this.ColorPV.MinimumWidth = 6;
            this.ColorPV.Name = "ColorPV";
            this.ColorPV.ReadOnly = true;
            this.ColorPV.Width = 89;
            // 
            // cantPV
            // 
            this.cantPV.HeaderText = "Cantidad";
            this.cantPV.MinimumWidth = 6;
            this.cantPV.Name = "cantPV";
            this.cantPV.ReadOnly = true;
            this.cantPV.Width = 115;
            // 
            // PrecioUpv
            // 
            this.PrecioUpv.HeaderText = "Precio U:";
            this.PrecioUpv.MinimumWidth = 6;
            this.PrecioUpv.Name = "PrecioUpv";
            this.PrecioUpv.ReadOnly = true;
            this.PrecioUpv.Width = 115;
            // 
            // PrecioTPV
            // 
            this.PrecioTPV.HeaderText = "Precio T:";
            this.PrecioTPV.MinimumWidth = 6;
            this.PrecioTPV.Name = "PrecioTPV";
            this.PrecioTPV.ReadOnly = true;
            this.PrecioTPV.Width = 113;
            // 
            // MetPag
            // 
            this.MetPag.HeaderText = "Metodo de Pago:";
            this.MetPag.MinimumWidth = 6;
            this.MetPag.Name = "MetPag";
            this.MetPag.ReadOnly = true;
            this.MetPag.Width = 185;
            // 
            // Frm_NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(922, 672);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbmMetodoPag);
            this.Controls.Add(this.txtCategoriaV);
            this.Controls.Add(this.txtMarcaV);
            this.Controls.Add(this.lblClienteId);
            this.Controls.Add(this.txtFechaV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvProductosV);
            this.Controls.Add(this.btnReporteVenta);
            this.Controls.Add(this.lbPagoT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chEnviar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDireccionPed);
            this.Controls.Add(this.txtClienV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDniV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecioV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStockV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColorV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtIdV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_NuevaVenta";
            this.Text = "Frm_NuevaVenta";
            this.Load += new System.EventHandler(this.Frm_NuevaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdV;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadV;
        private System.Windows.Forms.TextBox txtColorV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDniV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtClienV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccionPed;
        private System.Windows.Forms.CheckBox chEnviar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbPagoT;
        private System.Windows.Forms.Button btnReporteVenta;
        private System.Windows.Forms.DataGridView dgvProductosV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFechaV;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.TextBox txtMarcaV;
        private System.Windows.Forms.TextBox txtCategoriaV;
        private System.Windows.Forms.ComboBox cbmMetodoPag;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUpv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetPag;
    }
}