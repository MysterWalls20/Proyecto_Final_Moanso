namespace Proyecto_Final_Moanso
{
    partial class Empleados
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
            this.txtNomEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseñaEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumEmp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCarUsuario = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNuevoEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomEmp.Location = new System.Drawing.Point(104, 351);
            this.txtNomEmp.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomEmp.MaxLength = 30;
            this.txtNomEmp.Multiline = true;
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.Size = new System.Drawing.Size(288, 38);
            this.txtNomEmp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 321);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 410);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cargo de Usuario:";
            // 
            // txtContraseñaEmp
            // 
            this.txtContraseñaEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseñaEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaEmp.Location = new System.Drawing.Point(472, 440);
            this.txtContraseñaEmp.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseñaEmp.MaxLength = 30;
            this.txtContraseñaEmp.Multiline = true;
            this.txtContraseñaEmp.Name = "txtContraseñaEmp";
            this.txtContraseñaEmp.Size = new System.Drawing.Size(233, 38);
            this.txtContraseñaEmp.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 410);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            // 
            // txtNumEmp
            // 
            this.txtNumEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumEmp.Location = new System.Drawing.Point(472, 351);
            this.txtNumEmp.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumEmp.MaxLength = 30;
            this.txtNumEmp.Multiline = true;
            this.txtNumEmp.Name = "txtNumEmp";
            this.txtNumEmp.Size = new System.Drawing.Size(233, 38);
            this.txtNumEmp.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número:";
            // 
            // cbCarUsuario
            // 
            this.cbCarUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarUsuario.Font = new System.Drawing.Font("Microsoft PhagsPa", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarUsuario.FormattingEnabled = true;
            this.cbCarUsuario.Items.AddRange(new object[] {
            "Vendedor",
            "Jefe de Ventas",
            "Pers. Almacen",
            "Pers. Repartidor",
            "Jefe de Almacen"});
            this.cbCarUsuario.Location = new System.Drawing.Point(104, 440);
            this.cbCarUsuario.Name = "cbCarUsuario";
            this.cbCarUsuario.Size = new System.Drawing.Size(203, 39);
            this.cbCarUsuario.TabIndex = 10;
            // 
            // txtSalario
            // 
            this.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(104, 526);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalario.MaxLength = 30;
            this.txtSalario.Multiline = true;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(116, 38);
            this.txtSalario.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 496);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Salario:";
            // 
            // btnNuevoEmp
            // 
            this.btnNuevoEmp.BackColor = System.Drawing.Color.Orange;
            this.btnNuevoEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEmp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoEmp.FlatAppearance.BorderSize = 2;
            this.btnNuevoEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnNuevoEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.btnNuevoEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoEmp.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEmp.Location = new System.Drawing.Point(472, 509);
            this.btnNuevoEmp.Name = "btnNuevoEmp";
            this.btnNuevoEmp.Size = new System.Drawing.Size(233, 60);
            this.btnNuevoEmp.TabIndex = 13;
            this.btnNuevoEmp.Text = "Nuevo+";
            this.btnNuevoEmp.UseVisualStyleBackColor = false;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(889, 649);
            this.Controls.Add(this.btnNuevoEmp);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCarUsuario);
            this.Controls.Add(this.txtNumEmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContraseñaEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomEmp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseñaEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCarUsuario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevoEmp;
    }
}