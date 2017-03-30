namespace EbaisProyecto.UI
{
    partial class Farmacia
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
            this.tabPageAgregarMedicamento = new System.Windows.Forms.TabPage();
            this.dgvMedicamentosUno = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.rchtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMedicamento = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtNombreMedicamento = new System.Windows.Forms.TextBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label32 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.tabControlMedicamentos = new System.Windows.Forms.TabControl();
            this.tabPageConsultaMedicamentos = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvListaMedicamentosDos = new System.Windows.Forms.DataGridView();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.txtCodigoB = new System.Windows.Forms.TextBox();
            this.txtNombreB = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.tabPageAgregarMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.tabControlMedicamentos.SuspendLayout();
            this.tabPageConsultaMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMedicamentosDos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageAgregarMedicamento
            // 
            this.tabPageAgregarMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.tabPageAgregarMedicamento.Controls.Add(this.dgvMedicamentosUno);
            this.tabPageAgregarMedicamento.Controls.Add(this.label7);
            this.tabPageAgregarMedicamento.Controls.Add(this.rchtDescripcion);
            this.tabPageAgregarMedicamento.Controls.Add(this.label5);
            this.tabPageAgregarMedicamento.Controls.Add(this.label4);
            this.tabPageAgregarMedicamento.Controls.Add(this.label3);
            this.tabPageAgregarMedicamento.Controls.Add(this.label1);
            this.tabPageAgregarMedicamento.Controls.Add(this.cbMedicamento);
            this.tabPageAgregarMedicamento.Controls.Add(this.label37);
            this.tabPageAgregarMedicamento.Controls.Add(this.txtNombreMedicamento);
            this.tabPageAgregarMedicamento.Controls.Add(this.numCantidad);
            this.tabPageAgregarMedicamento.Controls.Add(this.label32);
            this.tabPageAgregarMedicamento.Controls.Add(this.btnLimpiar);
            this.tabPageAgregarMedicamento.Controls.Add(this.btnGuardar);
            this.tabPageAgregarMedicamento.Controls.Add(this.label25);
            this.tabPageAgregarMedicamento.Location = new System.Drawing.Point(4, 22);
            this.tabPageAgregarMedicamento.Name = "tabPageAgregarMedicamento";
            this.tabPageAgregarMedicamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgregarMedicamento.Size = new System.Drawing.Size(776, 503);
            this.tabPageAgregarMedicamento.TabIndex = 0;
            this.tabPageAgregarMedicamento.Text = "Agregar Medicamentos";
            this.tabPageAgregarMedicamento.Click += new System.EventHandler(this.tabPageAgregarMedicamento_Click);
            // 
            // dgvMedicamentosUno
            // 
            this.dgvMedicamentosUno.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMedicamentosUno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentosUno.Location = new System.Drawing.Point(387, 48);
            this.dgvMedicamentosUno.Name = "dgvMedicamentosUno";
            this.dgvMedicamentosUno.Size = new System.Drawing.Size(290, 359);
            this.dgvMedicamentosUno.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Descripción:";
            // 
            // rchtDescripcion
            // 
            this.rchtDescripcion.Location = new System.Drawing.Point(39, 220);
            this.rchtDescripcion.Name = "rchtDescripcion";
            this.rchtDescripcion.Size = new System.Drawing.Size(312, 125);
            this.rchtDescripcion.TabIndex = 65;
            this.rchtDescripcion.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 60;
            // 
            // cbMedicamento
            // 
            this.cbMedicamento.FormattingEnabled = true;
            this.cbMedicamento.Items.AddRange(new object[] {
            "Pastillas",
            "Jarabe"});
            this.cbMedicamento.Location = new System.Drawing.Point(116, 93);
            this.cbMedicamento.Margin = new System.Windows.Forms.Padding(2);
            this.cbMedicamento.Name = "cbMedicamento";
            this.cbMedicamento.Size = new System.Drawing.Size(62, 21);
            this.cbMedicamento.TabIndex = 59;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(37, 132);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(0, 13);
            this.label37.TabIndex = 49;
            // 
            // txtNombreMedicamento
            // 
            this.txtNombreMedicamento.Location = new System.Drawing.Point(116, 48);
            this.txtNombreMedicamento.Name = "txtNombreMedicamento";
            this.txtNombreMedicamento.Size = new System.Drawing.Size(212, 20);
            this.txtNombreMedicamento.TabIndex = 31;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(269, 94);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(59, 20);
            this.numCantidad.TabIndex = 43;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(205, 94);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 13);
            this.label32.TabIndex = 40;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Location = new System.Drawing.Point(254, 377);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 30);
            this.btnLimpiar.TabIndex = 37;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(40, 377);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 30);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(37, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(0, 13);
            this.label25.TabIndex = 2;
            // 
            // tabControlMedicamentos
            // 
            this.tabControlMedicamentos.Controls.Add(this.tabPageAgregarMedicamento);
            this.tabControlMedicamentos.Controls.Add(this.tabPageConsultaMedicamentos);
            this.tabControlMedicamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMedicamentos.Location = new System.Drawing.Point(0, 0);
            this.tabControlMedicamentos.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMedicamentos.Name = "tabControlMedicamentos";
            this.tabControlMedicamentos.SelectedIndex = 0;
            this.tabControlMedicamentos.Size = new System.Drawing.Size(784, 529);
            this.tabControlMedicamentos.TabIndex = 33;
            // 
            // tabPageConsultaMedicamentos
            // 
            this.tabPageConsultaMedicamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.tabPageConsultaMedicamentos.Controls.Add(this.btnEditar);
            this.tabPageConsultaMedicamentos.Controls.Add(this.btnEliminar);
            this.tabPageConsultaMedicamentos.Controls.Add(this.dgvListaMedicamentosDos);
            this.tabPageConsultaMedicamentos.Controls.Add(this.btnBuscarNombre);
            this.tabPageConsultaMedicamentos.Controls.Add(this.btnBuscarId);
            this.tabPageConsultaMedicamentos.Controls.Add(this.txtCodigoB);
            this.tabPageConsultaMedicamentos.Controls.Add(this.txtNombreB);
            this.tabPageConsultaMedicamentos.Controls.Add(this.label36);
            this.tabPageConsultaMedicamentos.Controls.Add(this.label35);
            this.tabPageConsultaMedicamentos.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultaMedicamentos.Name = "tabPageConsultaMedicamentos";
            this.tabPageConsultaMedicamentos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultaMedicamentos.Size = new System.Drawing.Size(776, 503);
            this.tabPageConsultaMedicamentos.TabIndex = 2;
            this.tabPageConsultaMedicamentos.Text = "Consulta y edición";
            this.tabPageConsultaMedicamentos.Click += new System.EventHandler(this.tabPageConsultaMedicamentos_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(460, 432);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 30);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(578, 432);
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
            this.dgvListaMedicamentosDos.Location = new System.Drawing.Point(97, 170);
            this.dgvListaMedicamentosDos.Name = "dgvListaMedicamentosDos";
            this.dgvListaMedicamentosDos.Size = new System.Drawing.Size(578, 228);
            this.dgvListaMedicamentosDos.TabIndex = 6;
            this.dgvListaMedicamentosDos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaMedicamentosDos_CellDoubleClick_1);
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarNombre.Location = new System.Drawing.Point(494, 113);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(97, 30);
            this.btnBuscarNombre.TabIndex = 5;
            this.btnBuscarNombre.Text = "Buscar";
            this.btnBuscarNombre.UseVisualStyleBackColor = false;
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarId.Location = new System.Drawing.Point(494, 57);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(97, 30);
            this.btnBuscarId.TabIndex = 4;
            this.btnBuscarId.Text = "Buscar";
            this.btnBuscarId.UseVisualStyleBackColor = false;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // txtCodigoB
            // 
            this.txtCodigoB.Location = new System.Drawing.Point(249, 119);
            this.txtCodigoB.Name = "txtCodigoB";
            this.txtCodigoB.Size = new System.Drawing.Size(213, 20);
            this.txtCodigoB.TabIndex = 3;
            // 
            // txtNombreB
            // 
            this.txtNombreB.Location = new System.Drawing.Point(249, 63);
            this.txtNombreB.Name = "txtNombreB";
            this.txtNombreB.Size = new System.Drawing.Size(213, 20);
            this.txtNombreB.TabIndex = 2;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(116, 120);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(107, 13);
            this.label36.TabIndex = 1;
            this.label36.Text = "Código Medicamento";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(116, 64);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(131, 13);
            this.label35.TabIndex = 0;
            this.label35.Text = "Nombre del Medicamento:";
            // 
            // Farmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabControlMedicamentos);
            this.Name = "Farmacia";
            this.Size = new System.Drawing.Size(784, 529);
            this.Load += new System.EventHandler(this.Farmacia_Load);
            this.tabPageAgregarMedicamento.ResumeLayout(false);
            this.tabPageAgregarMedicamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentosUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.tabControlMedicamentos.ResumeLayout(false);
            this.tabPageConsultaMedicamentos.ResumeLayout(false);
            this.tabPageConsultaMedicamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMedicamentosDos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageAgregarMedicamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMedicamento;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TabControl tabControlMedicamentos;
        private System.Windows.Forms.TabPage tabPageConsultaMedicamentos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvListaMedicamentosDos;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.TextBox txtCodigoB;
        private System.Windows.Forms.TextBox txtNombreB;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.RichTextBox rchtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvMedicamentosUno;
    }
}
