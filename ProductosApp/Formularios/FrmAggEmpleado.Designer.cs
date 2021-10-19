namespace ProductosApp.Formularios
{
    partial class FrmAggEmpleado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.nudSalario = new System.Windows.Forms.NumericUpDown();
            this.dtpContratacion = new System.Windows.Forms.DateTimePicker();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCalcelar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudHoras);
            this.groupBox1.Controls.Add(this.dtpContratacion);
            this.groupBox1.Controls.Add(this.nudSalario);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblHoras);
            this.groupBox1.Controls.Add(this.lblSalario);
            this.groupBox1.Controls.Add(this.lblFecha);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblCedula);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Empleado";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 44);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombres:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(20, 185);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(43, 13);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cédula:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(20, 139);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellidos:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(20, 271);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha de Contratación:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(20, 227);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salario:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(20, 314);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(70, 13);
            this.lblHoras.TabIndex = 6;
            this.lblHoras.Text = "Horas Extras:";
            this.lblHoras.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(181, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(146, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(181, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(181, 136);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(146, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(181, 182);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(146, 20);
            this.txtCedula.TabIndex = 10;
            // 
            // nudSalario
            // 
            this.nudSalario.Location = new System.Drawing.Point(181, 225);
            this.nudSalario.Name = "nudSalario";
            this.nudSalario.Size = new System.Drawing.Size(146, 20);
            this.nudSalario.TabIndex = 11;
            // 
            // dtpContratacion
            // 
            this.dtpContratacion.Location = new System.Drawing.Point(181, 271);
            this.dtpContratacion.Name = "dtpContratacion";
            this.dtpContratacion.Size = new System.Drawing.Size(200, 20);
            this.dtpContratacion.TabIndex = 12;
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(181, 312);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(146, 20);
            this.nudHoras.TabIndex = 13;
            this.nudHoras.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalcelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Location = new System.Drawing.Point(191, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 44);
            this.panel1.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAceptar.Location = new System.Drawing.Point(0, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 40);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCalcelar
            // 
            this.btnCalcelar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcelar.ForeColor = System.Drawing.Color.Red;
            this.btnCalcelar.Location = new System.Drawing.Point(104, 3);
            this.btnCalcelar.Name = "btnCalcelar";
            this.btnCalcelar.Size = new System.Drawing.Size(103, 40);
            this.btnCalcelar.TabIndex = 1;
            this.btnCalcelar.Text = "Cancelar";
            this.btnCalcelar.UseVisualStyleBackColor = true;
            this.btnCalcelar.Click += new System.EventHandler(this.BtnCalcelar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(404, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(473, 353);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // FrmAggEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 416);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAggEmpleado";
            this.Text = "FrmAggEmpleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.DateTimePicker dtpContratacion;
        private System.Windows.Forms.NumericUpDown nudSalario;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalcelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}