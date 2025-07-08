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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtTipoCli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtClienV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccionV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbPagoT = new System.Windows.Forms.Label();
            this.dgvProductosV = new System.Windows.Forms.DataGridView();
            this.IDp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUpv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFechaV = new System.Windows.Forms.TextBox();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.txtMarcaV = new System.Windows.Forms.TextBox();
            this.txtTallaV = new System.Windows.Forms.TextBox();
            this.cbmTipoPag = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.btnAgregarProTabla = new System.Windows.Forms.Button();
            this.btnEliminarProTabla = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCancelarV = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbVuelto = new System.Windows.Forms.Label();
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
            this.txtIdV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdV_KeyDown);
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
            this.label2.Location = new System.Drawing.Point(220, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Producto:";
            // 
            // txtProductV
            // 
            this.txtProductV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductV.Location = new System.Drawing.Point(337, 17);
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
            // txtTipoCli
            // 
            this.txtTipoCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoCli.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCli.Location = new System.Drawing.Point(508, 415);
            this.txtTipoCli.MaxLength = 8;
            this.txtTipoCli.Name = "txtTipoCli";
            this.txtTipoCli.ReadOnly = true;
            this.txtTipoCli.Size = new System.Drawing.Size(155, 33);
            this.txtTipoCli.TabIndex = 17;
            this.txtTipoCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTipoCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniV_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(365, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tipo Cliente:";
            // 
            // txtClienV
            // 
            this.txtClienV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClienV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienV.Location = new System.Drawing.Point(108, 414);
            this.txtClienV.Name = "txtClienV";
            this.txtClienV.Size = new System.Drawing.Size(221, 33);
            this.txtClienV.TabIndex = 19;
            this.txtClienV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cliente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 467);
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
            this.txtDireccionV.Location = new System.Drawing.Point(133, 465);
            this.txtDireccionV.Name = "txtDireccionV";
            this.txtDireccionV.ReadOnly = true;
            this.txtDireccionV.Size = new System.Drawing.Size(275, 33);
            this.txtDireccionV.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(482, 510);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 26);
            this.label11.TabIndex = 25;
            this.label11.Text = "Pago total:";
            // 
            // lbPagoT
            // 
            this.lbPagoT.AutoSize = true;
            this.lbPagoT.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagoT.Location = new System.Drawing.Point(629, 510);
            this.lbPagoT.Name = "lbPagoT";
            this.lbPagoT.Size = new System.Drawing.Size(53, 26);
            this.lbPagoT.TabIndex = 26;
            this.lbPagoT.Text = "0.00";
            // 
            // dgvProductosV
            // 
            this.dgvProductosV.AllowUserToAddRows = false;
            this.dgvProductosV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProductosV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductosV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductosV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductosV.ColumnHeadersHeight = 35;
            this.dgvProductosV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductosV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDp,
            this.NombrePV,
            this.MarC,
            this.ColorPV,
            this.ColTall,
            this.cantPV,
            this.PrecioUpv,
            this.PrecioTPV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosV.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductosV.EnableHeadersVisualStyles = false;
            this.dgvProductosV.GridColor = System.Drawing.Color.Orange;
            this.dgvProductosV.Location = new System.Drawing.Point(11, 115);
            this.dgvProductosV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductosV.Name = "dgvProductosV";
            this.dgvProductosV.ReadOnly = true;
            this.dgvProductosV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductosV.RowHeadersVisible = false;
            this.dgvProductosV.RowHeadersWidth = 60;
            this.dgvProductosV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductosV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductosV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosV.Size = new System.Drawing.Size(800, 274);
            this.dgvProductosV.TabIndex = 28;
            // 
            // IDp
            // 
            this.IDp.HeaderText = "ID";
            this.IDp.MinimumWidth = 6;
            this.IDp.Name = "IDp";
            this.IDp.ReadOnly = true;
            this.IDp.Width = 58;
            // 
            // NombrePV
            // 
            this.NombrePV.HeaderText = "Producto";
            this.NombrePV.MinimumWidth = 6;
            this.NombrePV.Name = "NombrePV";
            this.NombrePV.ReadOnly = true;
            this.NombrePV.Width = 117;
            // 
            // MarC
            // 
            this.MarC.HeaderText = "Marca";
            this.MarC.MinimumWidth = 6;
            this.MarC.Name = "MarC";
            this.MarC.ReadOnly = true;
            this.MarC.Width = 92;
            // 
            // ColorPV
            // 
            this.ColorPV.HeaderText = "Color";
            this.ColorPV.MinimumWidth = 6;
            this.ColorPV.Name = "ColorPV";
            this.ColorPV.ReadOnly = true;
            this.ColorPV.Width = 84;
            // 
            // ColTall
            // 
            this.ColTall.HeaderText = "Talla";
            this.ColTall.MinimumWidth = 6;
            this.ColTall.Name = "ColTall";
            this.ColTall.ReadOnly = true;
            this.ColTall.Width = 80;
            // 
            // cantPV
            // 
            this.cantPV.HeaderText = "Cant.";
            this.cantPV.MinimumWidth = 6;
            this.cantPV.Name = "cantPV";
            this.cantPV.ReadOnly = true;
            this.cantPV.Width = 83;
            // 
            // PrecioUpv
            // 
            this.PrecioUpv.HeaderText = "Precio U";
            this.PrecioUpv.MinimumWidth = 6;
            this.PrecioUpv.Name = "PrecioUpv";
            this.PrecioUpv.ReadOnly = true;
            this.PrecioUpv.Width = 110;
            // 
            // PrecioTPV
            // 
            this.PrecioTPV.HeaderText = "Precio T";
            this.PrecioTPV.MinimumWidth = 6;
            this.PrecioTPV.Name = "PrecioTPV";
            this.PrecioTPV.ReadOnly = true;
            this.PrecioTPV.Width = 108;
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
            this.lblClienteId.Location = new System.Drawing.Point(340, 416);
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
            // txtTallaV
            // 
            this.txtTallaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTallaV.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTallaV.Location = new System.Drawing.Point(637, 18);
            this.txtTallaV.Name = "txtTallaV";
            this.txtTallaV.ReadOnly = true;
            this.txtTallaV.Size = new System.Drawing.Size(10, 33);
            this.txtTallaV.TabIndex = 33;
            this.txtTallaV.Visible = false;
            // 
            // cbmTipoPag
            // 
            this.cbmTipoPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmTipoPag.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmTipoPag.FormattingEnabled = true;
            this.cbmTipoPag.Location = new System.Drawing.Point(21, 543);
            this.cbmTipoPag.Name = "cbmTipoPag";
            this.cbmTipoPag.Size = new System.Drawing.Size(284, 34);
            this.cbmTipoPag.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 510);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 26);
            this.label12.TabIndex = 35;
            this.label12.Text = "Tipo de Pago:";
            // 
            // txtPago
            // 
            this.txtPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPago.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(334, 544);
            this.txtPago.MaxLength = 10000;
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(122, 33);
            this.txtPago.TabIndex = 36;
            this.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregarProTabla
            // 
            this.btnAgregarProTabla.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAgregarProTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarProTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProTabla.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarProTabla.FlatAppearance.BorderSize = 2;
            this.btnAgregarProTabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnAgregarProTabla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnAgregarProTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProTabla.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProTabla.Location = new System.Drawing.Point(824, 115);
            this.btnAgregarProTabla.Name = "btnAgregarProTabla";
            this.btnAgregarProTabla.Size = new System.Drawing.Size(100, 120);
            this.btnAgregarProTabla.TabIndex = 51;
            this.btnAgregarProTabla.Text = "Agregar+";
            this.btnAgregarProTabla.UseVisualStyleBackColor = false;
            // 
            // btnEliminarProTabla
            // 
            this.btnEliminarProTabla.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminarProTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarProTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProTabla.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarProTabla.FlatAppearance.BorderSize = 2;
            this.btnEliminarProTabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminarProTabla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnEliminarProTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProTabla.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProTabla.Location = new System.Drawing.Point(824, 269);
            this.btnEliminarProTabla.Name = "btnEliminarProTabla";
            this.btnEliminarProTabla.Size = new System.Drawing.Size(100, 120);
            this.btnEliminarProTabla.TabIndex = 52;
            this.btnEliminarProTabla.Text = "Eliminar-";
            this.btnEliminarProTabla.UseVisualStyleBackColor = false;
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
            this.btnVender.Location = new System.Drawing.Point(712, 513);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(212, 64);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = " VENDER";
            this.btnVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnCancelarV
            // 
            this.btnCancelarV.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancelarV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelarV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarV.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarV.FlatAppearance.BorderSize = 2;
            this.btnCancelarV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnCancelarV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnCancelarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarV.ForeColor = System.Drawing.Color.White;
            this.btnCancelarV.Location = new System.Drawing.Point(712, 414);
            this.btnCancelarV.Name = "btnCancelarV";
            this.btnCancelarV.Size = new System.Drawing.Size(212, 64);
            this.btnCancelarV.TabIndex = 53;
            this.btnCancelarV.Text = "Cancelar";
            this.btnCancelarV.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(329, 510);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 26);
            this.label13.TabIndex = 54;
            this.label13.Text = "Pago: S/";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(482, 548);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 26);
            this.label14.TabIndex = 55;
            this.label14.Text = "Vuelto:";
            // 
            // lbVuelto
            // 
            this.lbVuelto.AutoSize = true;
            this.lbVuelto.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVuelto.Location = new System.Drawing.Point(629, 548);
            this.lbVuelto.Name = "lbVuelto";
            this.lbVuelto.Size = new System.Drawing.Size(53, 26);
            this.lbVuelto.TabIndex = 56;
            this.lbVuelto.Text = "0.00";
            // 
            // Frm_NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(946, 610);
            this.Controls.Add(this.lbVuelto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCancelarV);
            this.Controls.Add(this.btnEliminarProTabla);
            this.Controls.Add(this.btnAgregarProTabla);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbmTipoPag);
            this.Controls.Add(this.txtTallaV);
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
            this.Controls.Add(this.txtTipoCli);
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
        private System.Windows.Forms.TextBox txtTipoCli;
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
        private System.Windows.Forms.TextBox txtTallaV;
        private System.Windows.Forms.ComboBox cbmTipoPag;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Button btnAgregarProTabla;
        private System.Windows.Forms.Button btnEliminarProTabla;
        private System.Windows.Forms.Button btnCancelarV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbVuelto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTall;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUpv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTPV;
    }
}