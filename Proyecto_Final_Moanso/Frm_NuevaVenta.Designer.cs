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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtDireccionV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbPagoT = new System.Windows.Forms.Label();
            this.dgvProductosV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaV = new System.Windows.Forms.TextBox();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.txtMarcaV = new System.Windows.Forms.TextBox();
            this.txtCategoriaV = new System.Windows.Forms.TextBox();
            this.cbmMetodoPag = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IDp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUpv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdV
            // 
            this.txtIdV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdV.Location = new System.Drawing.Point(63, 17);
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
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Producto:";
            // 
            // txtProductV
            // 
            this.txtProductV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductV.Location = new System.Drawing.Point(320, 17);
            this.txtProductV.Name = "txtProductV";
            this.txtProductV.ReadOnly = true;
            this.txtProductV.Size = new System.Drawing.Size(292, 33);
            this.txtProductV.TabIndex = 3;
            this.txtProductV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad:";
            // 
            // txtCantidadV
            // 
            this.txtCantidadV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadV.Location = new System.Drawing.Point(129, 64);
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
            this.txtColorV.Location = new System.Drawing.Point(739, 17);
            this.txtColorV.Name = "txtColorV";
            this.txtColorV.ReadOnly = true;
            this.txtColorV.Size = new System.Drawing.Size(165, 33);
            this.txtColorV.TabIndex = 10;
            this.txtColorV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(660, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Color:";
            // 
            // txtStockV
            // 
            this.txtStockV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockV.Location = new System.Drawing.Point(557, 66);
            this.txtStockV.Name = "txtStockV";
            this.txtStockV.ReadOnly = true;
            this.txtStockV.Size = new System.Drawing.Size(98, 33);
            this.txtStockV.TabIndex = 12;
            this.txtStockV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(477, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stock:";
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioV.Location = new System.Drawing.Point(356, 66);
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.ReadOnly = true;
            this.txtPrecioV.Size = new System.Drawing.Size(91, 33);
            this.txtPrecioV.TabIndex = 15;
            this.txtPrecioV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Precio U:";
            // 
            // txtDniV
            // 
            this.txtDniV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDniV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniV.Location = new System.Drawing.Point(81, 400);
            this.txtDniV.MaxLength = 8;
            this.txtDniV.Name = "txtDniV";
            this.txtDniV.Size = new System.Drawing.Size(179, 33);
            this.txtDniV.TabIndex = 17;
            this.txtDniV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDniV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniV_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "DNI:";
            // 
            // txtClienV
            // 
            this.txtClienV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienV.Location = new System.Drawing.Point(394, 401);
            this.txtClienV.Name = "txtClienV";
            this.txtClienV.ReadOnly = true;
            this.txtClienV.Size = new System.Drawing.Size(221, 33);
            this.txtClienV.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cliente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 26);
            this.label9.TabIndex = 21;
            this.label9.Text = "Dirección:";
            // 
            // txtDireccionV
            // 
            this.txtDireccionV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccionV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionV.Location = new System.Drawing.Point(139, 451);
            this.txtDireccionV.Name = "txtDireccionV";
            this.txtDireccionV.ReadOnly = true;
            this.txtDireccionV.Size = new System.Drawing.Size(275, 33);
            this.txtDireccionV.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(707, 487);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 26);
            this.label11.TabIndex = 25;
            this.label11.Text = "Pago total:";
            // 
            // lbPagoT
            // 
            this.lbPagoT.AutoSize = true;
            this.lbPagoT.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagoT.Location = new System.Drawing.Point(869, 488);
            this.lbPagoT.Name = "lbPagoT";
            this.lbPagoT.Size = new System.Drawing.Size(53, 26);
            this.lbPagoT.TabIndex = 26;
            this.lbPagoT.Text = "0.00";
            // 
            // dgvProductosV
            // 
            this.dgvProductosV.AllowUserToAddRows = false;
            this.dgvProductosV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProductosV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvProductosV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductosV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductosV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProductosV.ColumnHeadersHeight = 35;
            this.dgvProductosV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductosV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDp,
            this.NombrePV,
            this.ColorPV,
            this.cantPV,
            this.PrecioUpv,
            this.PrecioTPV});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosV.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProductosV.EnableHeadersVisualStyles = false;
            this.dgvProductosV.GridColor = System.Drawing.Color.Orange;
            this.dgvProductosV.Location = new System.Drawing.Point(24, 115);
            this.dgvProductosV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductosV.Name = "dgvProductosV";
            this.dgvProductosV.ReadOnly = true;
            this.dgvProductosV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosV.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvProductosV.RowHeadersVisible = false;
            this.dgvProductosV.RowHeadersWidth = 60;
            this.dgvProductosV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductosV.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvProductosV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosV.Size = new System.Drawing.Size(784, 270);
            this.dgvProductosV.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(675, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 26);
            this.label10.TabIndex = 29;
            this.label10.Text = "Fecha V:";
            // 
            // txtFechaV
            // 
            this.txtFechaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaV.Location = new System.Drawing.Point(776, 67);
            this.txtFechaV.Name = "txtFechaV";
            this.txtFechaV.ReadOnly = true;
            this.txtFechaV.Size = new System.Drawing.Size(148, 33);
            this.txtFechaV.TabIndex = 30;
            this.txtFechaV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteId.Location = new System.Drawing.Point(278, 407);
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
            this.txtMarcaV.Location = new System.Drawing.Point(912, 18);
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
            this.txtCategoriaV.Location = new System.Drawing.Point(620, 18);
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
            this.cbmMetodoPag.Location = new System.Drawing.Point(24, 536);
            this.cbmMetodoPag.Name = "cbmMetodoPag";
            this.cbmMetodoPag.Size = new System.Drawing.Size(284, 34);
            this.cbmMetodoPag.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 501);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 26);
            this.label12.TabIndex = 35;
            this.label12.Text = "Tipo de Pago:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(482, 536);
            this.textBox1.MaxLength = 10000;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 33);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 2;
            this.btnAgregarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(820, 115);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(104, 120);
            this.btnAgregarProducto.TabIndex = 51;
            this.btnAgregarProducto.Text = "Agregar+";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarProducto.FlatAppearance.BorderSize = 2;
            this.btnEliminarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Location = new System.Drawing.Point(820, 265);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(104, 120);
            this.btnEliminarProducto.TabIndex = 52;
            this.btnEliminarProducto.Text = "Eliminar-";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVender.FlatAppearance.BorderSize = 2;
            this.btnVender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.Black;
            this.btnVender.Image = global::Proyecto_Final_Moanso.Properties.Resources.dinero_40;
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVender.Location = new System.Drawing.Point(712, 526);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(212, 64);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = " GRABAR";
            this.btnVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(712, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 64);
            this.button1.TabIndex = 53;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // IDp
            // 
            this.IDp.HeaderText = "Id:";
            this.IDp.MinimumWidth = 6;
            this.IDp.Name = "IDp";
            this.IDp.ReadOnly = true;
            this.IDp.Width = 61;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(477, 501);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 26);
            this.label13.TabIndex = 54;
            this.label13.Text = "Pago:";
            // 
            // Frm_NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(942, 610);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbmMetodoPag);
            this.Controls.Add(this.txtCategoriaV);
            this.Controls.Add(this.txtMarcaV);
            this.Controls.Add(this.lblClienteId);
            this.Controls.Add(this.txtFechaV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvProductosV);
            this.Controls.Add(this.lbPagoT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDireccionV);
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
        private System.Windows.Forms.TextBox txtDireccionV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbPagoT;
        private System.Windows.Forms.DataGridView dgvProductosV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFechaV;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.TextBox txtMarcaV;
        private System.Windows.Forms.TextBox txtCategoriaV;
        private System.Windows.Forms.ComboBox cbmMetodoPag;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUpv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTPV;
        private System.Windows.Forms.Label label13;
    }
}