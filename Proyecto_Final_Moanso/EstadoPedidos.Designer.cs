namespace Proyecto_Final_Moanso
{
    partial class EstadoPedidos
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
            this.dgvPedidosEstado = new System.Windows.Forms.DataGridView();
            this.IDped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clienteped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direcped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlmPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReparPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbPorcentajeEnv = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarEnvio = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbCerrarEstado = new System.Windows.Forms.PictureBox();
            this.dtpHoraEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraEnvio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEstado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidosEstado
            // 
            this.dgvPedidosEstado.AllowUserToAddRows = false;
            this.dgvPedidosEstado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPedidosEstado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidosEstado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPedidosEstado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPedidosEstado.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidosEstado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidosEstado.ColumnHeadersHeight = 35;
            this.dgvPedidosEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidosEstado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDped,
            this.Clienteped,
            this.Direcped,
            this.AlmPed,
            this.ReparPed,
            this.EstPed});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidosEstado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidosEstado.EnableHeadersVisualStyles = false;
            this.dgvPedidosEstado.GridColor = System.Drawing.Color.Orange;
            this.dgvPedidosEstado.Location = new System.Drawing.Point(16, 74);
            this.dgvPedidosEstado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedidosEstado.Name = "dgvPedidosEstado";
            this.dgvPedidosEstado.ReadOnly = true;
            this.dgvPedidosEstado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidosEstado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPedidosEstado.RowHeadersVisible = false;
            this.dgvPedidosEstado.RowHeadersWidth = 60;
            this.dgvPedidosEstado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPedidosEstado.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPedidosEstado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidosEstado.Size = new System.Drawing.Size(860, 299);
            this.dgvPedidosEstado.TabIndex = 12;
            // 
            // IDped
            // 
            this.IDped.HeaderText = "Id:";
            this.IDped.MinimumWidth = 6;
            this.IDped.Name = "IDped";
            this.IDped.ReadOnly = true;
            this.IDped.Width = 61;
            // 
            // Clienteped
            // 
            this.Clienteped.HeaderText = "Cliente:";
            this.Clienteped.MinimumWidth = 6;
            this.Clienteped.Name = "Clienteped";
            this.Clienteped.ReadOnly = true;
            this.Clienteped.Width = 103;
            // 
            // Direcped
            // 
            this.Direcped.HeaderText = "Direccion de entrega:";
            this.Direcped.MinimumWidth = 6;
            this.Direcped.Name = "Direcped";
            this.Direcped.ReadOnly = true;
            this.Direcped.Width = 221;
            // 
            // AlmPed
            // 
            this.AlmPed.HeaderText = "Per. Almacen:";
            this.AlmPed.MinimumWidth = 6;
            this.AlmPed.Name = "AlmPed";
            this.AlmPed.ReadOnly = true;
            this.AlmPed.Width = 156;
            // 
            // ReparPed
            // 
            this.ReparPed.HeaderText = "Per. Repartidor:";
            this.ReparPed.MinimumWidth = 6;
            this.ReparPed.Name = "ReparPed";
            this.ReparPed.ReadOnly = true;
            this.ReparPed.Width = 173;
            // 
            // EstPed
            // 
            this.EstPed.HeaderText = "Estado:";
            this.EstPed.MinimumWidth = 6;
            this.EstPed.Name = "EstPed";
            this.EstPed.ReadOnly = true;
            this.EstPed.Width = 101;
            // 
            // lbPorcentajeEnv
            // 
            this.lbPorcentajeEnv.AutoSize = true;
            this.lbPorcentajeEnv.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPorcentajeEnv.Location = new System.Drawing.Point(835, 468);
            this.lbPorcentajeEnv.Name = "lbPorcentajeEnv";
            this.lbPorcentajeEnv.Size = new System.Drawing.Size(38, 22);
            this.lbPorcentajeEnv.TabIndex = 24;
            this.lbPorcentajeEnv.Text = "----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(741, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Progreso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(762, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "ENTREGADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "MITAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "INICIO";
            // 
            // progressBarEnvio
            // 
            this.progressBarEnvio.ForeColor = System.Drawing.Color.DarkOrange;
            this.progressBarEnvio.Location = new System.Drawing.Point(382, 428);
            this.progressBarEnvio.Name = "progressBarEnvio";
            this.progressBarEnvio.Size = new System.Drawing.Size(492, 31);
            this.progressBarEnvio.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.pbCerrarEstado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 45);
            this.panel1.TabIndex = 25;
            // 
            // pbCerrarEstado
            // 
            this.pbCerrarEstado.BackgroundImage = global::Proyecto_Final_Moanso.Properties.Resources.cerrar;
            this.pbCerrarEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCerrarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCerrarEstado.Location = new System.Drawing.Point(825, 3);
            this.pbCerrarEstado.Name = "pbCerrarEstado";
            this.pbCerrarEstado.Size = new System.Drawing.Size(61, 39);
            this.pbCerrarEstado.TabIndex = 26;
            this.pbCerrarEstado.TabStop = false;
            this.pbCerrarEstado.Click += new System.EventHandler(this.pbCerrarEstado_Click);
            this.pbCerrarEstado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCerrarEstado_MouseDown);
            // 
            // dtpHoraEntrega
            // 
            this.dtpHoraEntrega.CalendarFont = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrega.Enabled = false;
            this.dtpHoraEntrega.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEntrega.Location = new System.Drawing.Point(198, 454);
            this.dtpHoraEntrega.Name = "dtpHoraEntrega";
            this.dtpHoraEntrega.ShowUpDown = true;
            this.dtpHoraEntrega.Size = new System.Drawing.Size(132, 29);
            this.dtpHoraEntrega.TabIndex = 31;
            // 
            // dtpHoraEnvio
            // 
            this.dtpHoraEnvio.CalendarFont = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEnvio.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEnvio.Location = new System.Drawing.Point(173, 405);
            this.dtpHoraEnvio.Name = "dtpHoraEnvio";
            this.dtpHoraEnvio.ShowUpDown = true;
            this.dtpHoraEnvio.Size = new System.Drawing.Size(132, 29);
            this.dtpHoraEnvio.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Hora de Entrega:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Hora de Envio:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Orange;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnviar.FlatAppearance.BorderSize = 2;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(31, 519);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(147, 62);
            this.btnEnviar.TabIndex = 38;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Orange;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(198, 519);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(146, 62);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EstadoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 655);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.dtpHoraEntrega);
            this.Controls.Add(this.dtpHoraEnvio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPorcentajeEnv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarEnvio);
            this.Controls.Add(this.dgvPedidosEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadoPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstadoPedidos";
            this.Load += new System.EventHandler(this.EstadoPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEstado)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidosEstado;
        private System.Windows.Forms.Label lbPorcentajeEnv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarEnvio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCerrarEstado;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrega;
        private System.Windows.Forms.DateTimePicker dtpHoraEnvio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDped;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clienteped;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direcped;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlmPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReparPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstPed;
        private System.Windows.Forms.Timer timer1;
    }
}