﻿namespace EbaisProyecto.UI
{
    partial class Usuario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMedicamentos = new System.Windows.Forms.TabControl();
            this.tabPagePadecimientos = new System.Windows.Forms.TabPage();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rchDireccion = new System.Windows.Forms.RichTextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numTelefono = new System.Windows.Forms.NumericUpDown();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tabPageConsultaMedicamentos = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvListaMedicamentosDos = new System.Windows.Forms.DataGridView();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.txtNombreB = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tabControlMedicamentos.SuspendLayout();
            this.tabPagePadecimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTelefono)).BeginInit();
            this.tabPageConsultaMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMedicamentosDos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMedicamentos
            // 
            this.tabControlMedicamentos.Controls.Add(this.tabPagePadecimientos);
            this.tabControlMedicamentos.Controls.Add(this.tabPageConsultaMedicamentos);
            this.tabControlMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMedicamentos.Location = new System.Drawing.Point(0, 0);
            this.tabControlMedicamentos.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMedicamentos.Name = "tabControlMedicamentos";
            this.tabControlMedicamentos.SelectedIndex = 0;
            this.tabControlMedicamentos.Size = new System.Drawing.Size(784, 529);
            this.tabControlMedicamentos.TabIndex = 35;
            // 
            // tabPagePadecimientos
            // 
            this.tabPagePadecimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.tabPagePadecimientos.Controls.Add(this.maskedTextBox2);
            this.tabPagePadecimientos.Controls.Add(this.label10);
            this.tabPagePadecimientos.Controls.Add(this.maskedTextBox1);
            this.tabPagePadecimientos.Controls.Add(this.label9);
            this.tabPagePadecimientos.Controls.Add(this.textBox1);
            this.tabPagePadecimientos.Controls.Add(this.label8);
            this.tabPagePadecimientos.Controls.Add(this.btnGuardar);
            this.tabPagePadecimientos.Controls.Add(this.rchDireccion);
            this.tabPagePadecimientos.Controls.Add(this.btnLimpiar);
            this.tabPagePadecimientos.Controls.Add(this.label1);
            this.tabPagePadecimientos.Controls.Add(this.label4);
            this.tabPagePadecimientos.Controls.Add(this.numTelefono);
            this.tabPagePadecimientos.Controls.Add(this.lbTelefono);
            this.tabPagePadecimientos.Controls.Add(this.label12);
            this.tabPagePadecimientos.Controls.Add(this.txtCedula);
            this.tabPagePadecimientos.Controls.Add(this.txtApellidos);
            this.tabPagePadecimientos.Controls.Add(this.cbSexo);
            this.tabPagePadecimientos.Controls.Add(this.txtNombre);
            this.tabPagePadecimientos.Controls.Add(this.lbNombre);
            this.tabPagePadecimientos.Controls.Add(this.label3);
            this.tabPagePadecimientos.Controls.Add(this.label7);
            this.tabPagePadecimientos.Controls.Add(this.dtpFechaNacimiento);
            this.tabPagePadecimientos.Location = new System.Drawing.Point(4, 22);
            this.tabPagePadecimientos.Name = "tabPagePadecimientos";
            this.tabPagePadecimientos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePadecimientos.Size = new System.Drawing.Size(776, 503);
            this.tabPagePadecimientos.TabIndex = 0;
            this.tabPagePadecimientos.Text = "Agregar Usuario";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(497, 369);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "Confirmar password:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(248, 369);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 86;
            this.label8.Text = "Usuario:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(465, 429);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 29);
            this.btnGuardar.TabIndex = 85;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // rchDireccion
            // 
            this.rchDireccion.Location = new System.Drawing.Point(248, 264);
            this.rchDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.rchDireccion.Name = "rchDireccion";
            this.rchDireccion.Size = new System.Drawing.Size(343, 28);
            this.rchDireccion.TabIndex = 84;
            this.rchDireccion.Text = "";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(589, 429);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 29);
            this.btnLimpiar.TabIndex = 83;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Dirección :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Sexo :";
            // 
            // numTelefono
            // 
            this.numTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.numTelefono.Location = new System.Drawing.Point(248, 190);
            this.numTelefono.Name = "numTelefono";
            this.numTelefono.Size = new System.Drawing.Size(159, 20);
            this.numTelefono.TabIndex = 77;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(78, 192);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(110, 13);
            this.lbTelefono.TabIndex = 76;
            this.lbTelefono.Text = "Número de Teléfono :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 69;
            this.label12.Text = "Número de Cédula :";
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.SystemColors.Window;
            this.txtCedula.Location = new System.Drawing.Point(248, 41);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(217, 20);
            this.txtCedula.TabIndex = 70;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellidos.Location = new System.Drawing.Point(248, 139);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(343, 20);
            this.txtApellidos.TabIndex = 75;
            // 
            // cbSexo
            // 
            this.cbSexo.BackColor = System.Drawing.SystemColors.Window;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(470, 190);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 80;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(248, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(308, 20);
            this.txtNombre.TabIndex = 74;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(78, 94);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 72;
            this.lbNombre.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Apellidos :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "Fecha Nacimiento :";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(248, 227);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(160, 20);
            this.dtpFechaNacimiento.TabIndex = 82;
            // 
            // tabPageConsultaMedicamentos
            // 
            this.tabPageConsultaMedicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.tabPageConsultaMedicamentos.Controls.Add(this.button2);
            this.tabPageConsultaMedicamentos.Controls.Add(this.btnEditar);
            this.tabPageConsultaMedicamentos.Controls.Add(this.btnEliminar);
            this.tabPageConsultaMedicamentos.Controls.Add(this.dgvListaMedicamentosDos);
            this.tabPageConsultaMedicamentos.Controls.Add(this.btnBuscarId);
            this.tabPageConsultaMedicamentos.Controls.Add(this.txtNombreB);
            this.tabPageConsultaMedicamentos.Controls.Add(this.label35);
            this.tabPageConsultaMedicamentos.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultaMedicamentos.Name = "tabPageConsultaMedicamentos";
            this.tabPageConsultaMedicamentos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultaMedicamentos.Size = new System.Drawing.Size(776, 503);
            this.tabPageConsultaMedicamentos.TabIndex = 2;
            this.tabPageConsultaMedicamentos.Text = "Consulta y edición";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(372, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 30);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ver";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(475, 442);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 30);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(578, 442);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 30);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvListaMedicamentosDos
            // 
            this.dgvListaMedicamentosDos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListaMedicamentosDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMedicamentosDos.Location = new System.Drawing.Point(97, 136);
            this.dgvListaMedicamentosDos.Name = "dgvListaMedicamentosDos";
            this.dgvListaMedicamentosDos.Size = new System.Drawing.Size(578, 228);
            this.dgvListaMedicamentosDos.TabIndex = 6;
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarId.Location = new System.Drawing.Point(501, 60);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(97, 30);
            this.btnBuscarId.TabIndex = 4;
            this.btnBuscarId.Text = "Buscar";
            this.btnBuscarId.UseVisualStyleBackColor = false;
            // 
            // txtNombreB
            // 
            this.txtNombreB.Location = new System.Drawing.Point(256, 66);
            this.txtNombreB.Name = "txtNombreB";
            this.txtNombreB.Size = new System.Drawing.Size(213, 20);
            this.txtNombreB.TabIndex = 2;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(117, 69);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(95, 13);
            this.label35.TabIndex = 0;
            this.label35.Text = "Cédula de usuario:";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMedicamentos);
            this.Name = "Usuario";
            this.Size = new System.Drawing.Size(784, 529);
            this.tabControlMedicamentos.ResumeLayout(false);
            this.tabPagePadecimientos.ResumeLayout(false);
            this.tabPagePadecimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTelefono)).EndInit();
            this.tabPageConsultaMedicamentos.ResumeLayout(false);
            this.tabPageConsultaMedicamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMedicamentosDos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMedicamentos;
        private System.Windows.Forms.TabPage tabPagePadecimientos;
        private System.Windows.Forms.TabPage tabPageConsultaMedicamentos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvListaMedicamentosDos;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.TextBox txtNombreB;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RichTextBox rchDireccion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTelefono;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}