namespace EbaisProyecto.UI
{
    partial class Principal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrOpciones = new System.Windows.Forms.MenuStrip();
            this.menuItemInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPantallaPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExpedientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNuevoExp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCita = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPreConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDiagnostico = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFarmacia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMedicamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPadecimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemControlPadecimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemManualUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.inicio1 = new EbaisProyecto.UI.Inicio();
            this.pnlFarmacia = new System.Windows.Forms.Panel();
            this.farmacia1 = new EbaisProyecto.UI.Farmacia();
            this.pnlPaciente = new System.Windows.Forms.Panel();
            this.paciente1 = new EbaisProyecto.UI.Paciente();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.usuario1 = new EbaisProyecto.UI.Usuario();
            this.pnlPreconsulta = new System.Windows.Forms.Panel();
            this.preconsulta1 = new EbaisProyecto.UI.Preconsulta();
            this.pnlPadecimiento = new System.Windows.Forms.Panel();
            this.padecimiento1 = new EbaisProyecto.UI.Padecimiento();
            this.pnlDiagnostico = new System.Windows.Forms.Panel();
            this.diagnostico1 = new EbaisProyecto.UI.Diagnostico();
            this.pnlExpediente = new System.Windows.Forms.Panel();
            this.expediente1 = new EbaisProyecto.UI.Expediente();
            this.pnlCita = new System.Windows.Forms.Panel();
            this.cita1 = new EbaisProyecto.UI.Cita();
            this.menuStrOpciones.SuspendLayout();
            this.pnlInicio.SuspendLayout();
            this.pnlFarmacia.SuspendLayout();
            this.pnlPaciente.SuspendLayout();
            this.pnlUsuarios.SuspendLayout();
            this.pnlPreconsulta.SuspendLayout();
            this.pnlPadecimiento.SuspendLayout();
            this.pnlDiagnostico.SuspendLayout();
            this.pnlExpediente.SuspendLayout();
            this.pnlCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrOpciones
            // 
            this.menuStrOpciones.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrOpciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrOpciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemInicio,
            this.menuItemExpedientes,
            this.menuItemFarmacia,
            this.menuItemPadecimientos,
            this.menuItemUsuarios,
            this.menuItemAyuda});
            this.menuStrOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuStrOpciones.Name = "menuStrOpciones";
            this.menuStrOpciones.Padding = new System.Windows.Forms.Padding(6, 5, 0, 5);
            this.menuStrOpciones.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrOpciones.Size = new System.Drawing.Size(784, 35);
            this.menuStrOpciones.TabIndex = 16;
            this.menuStrOpciones.Text = "menuPrincipal";
            // 
            // menuItemInicio
            // 
            this.menuItemInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPantallaPrincipal,
            this.menuItemSalir});
            this.menuItemInicio.Name = "menuItemInicio";
            this.menuItemInicio.Size = new System.Drawing.Size(59, 25);
            this.menuItemInicio.Text = "Inicio";
            // 
            // menuItemPantallaPrincipal
            // 
            this.menuItemPantallaPrincipal.Name = "menuItemPantallaPrincipal";
            this.menuItemPantallaPrincipal.Size = new System.Drawing.Size(198, 26);
            this.menuItemPantallaPrincipal.Text = "Pantalla Principal";
            this.menuItemPantallaPrincipal.Click += new System.EventHandler(this.menuItemPantallaPrincipal_Click);
            // 
            // menuItemSalir
            // 
            this.menuItemSalir.Name = "menuItemSalir";
            this.menuItemSalir.Size = new System.Drawing.Size(198, 26);
            this.menuItemSalir.Text = "Salir";
            // 
            // menuItemExpedientes
            // 
            this.menuItemExpedientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNuevoExp,
            this.menuItemCita,
            this.menuItemPaciente,
            this.menuItemPreConsulta,
            this.menuItemDiagnostico});
            this.menuItemExpedientes.Name = "menuItemExpedientes";
            this.menuItemExpedientes.Size = new System.Drawing.Size(104, 25);
            this.menuItemExpedientes.Text = "Expedientes";
            // 
            // menuItemNuevoExp
            // 
            this.menuItemNuevoExp.Name = "menuItemNuevoExp";
            this.menuItemNuevoExp.Size = new System.Drawing.Size(205, 26);
            this.menuItemNuevoExp.Text = "Nuevo Expediente";
            this.menuItemNuevoExp.Click += new System.EventHandler(this.menuItemNuevoExp_Click);
            // 
            // menuItemCita
            // 
            this.menuItemCita.Name = "menuItemCita";
            this.menuItemCita.Size = new System.Drawing.Size(205, 26);
            this.menuItemCita.Text = "Citas";
            this.menuItemCita.Click += new System.EventHandler(this.menuItemCita_Click);
            // 
            // menuItemPaciente
            // 
            this.menuItemPaciente.Name = "menuItemPaciente";
            this.menuItemPaciente.Size = new System.Drawing.Size(205, 26);
            this.menuItemPaciente.Text = "Pacientes";
            this.menuItemPaciente.Click += new System.EventHandler(this.menuItemPaciente_Click);
            // 
            // menuItemPreConsulta
            // 
            this.menuItemPreConsulta.Name = "menuItemPreConsulta";
            this.menuItemPreConsulta.Size = new System.Drawing.Size(205, 26);
            this.menuItemPreConsulta.Text = "Preconsulta";
            this.menuItemPreConsulta.Click += new System.EventHandler(this.menuItemPreConsulta_Click);
            // 
            // menuItemDiagnostico
            // 
            this.menuItemDiagnostico.Name = "menuItemDiagnostico";
            this.menuItemDiagnostico.Size = new System.Drawing.Size(205, 26);
            this.menuItemDiagnostico.Text = "Diagnóstico";
            this.menuItemDiagnostico.Click += new System.EventHandler(this.menuItemDiagnostico_Click);
            // 
            // menuItemFarmacia
            // 
            this.menuItemFarmacia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemMedicamentos});
            this.menuItemFarmacia.Name = "menuItemFarmacia";
            this.menuItemFarmacia.Size = new System.Drawing.Size(84, 25);
            this.menuItemFarmacia.Text = "Farmacia";
            // 
            // menuItemMedicamentos
            // 
            this.menuItemMedicamentos.Name = "menuItemMedicamentos";
            this.menuItemMedicamentos.Size = new System.Drawing.Size(182, 26);
            this.menuItemMedicamentos.Text = "Medicamentos";
            this.menuItemMedicamentos.Click += new System.EventHandler(this.menuItemMedicamentos_Click);
            // 
            // menuItemPadecimientos
            // 
            this.menuItemPadecimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemControlPadecimientos});
            this.menuItemPadecimientos.Name = "menuItemPadecimientos";
            this.menuItemPadecimientos.Size = new System.Drawing.Size(122, 25);
            this.menuItemPadecimientos.Text = "Padecimientos";
            // 
            // menuItemControlPadecimientos
            // 
            this.menuItemControlPadecimientos.Name = "menuItemControlPadecimientos";
            this.menuItemControlPadecimientos.Size = new System.Drawing.Size(258, 26);
            this.menuItemControlPadecimientos.Text = "Control de padecimientos";
            this.menuItemControlPadecimientos.Click += new System.EventHandler(this.menuItemControlPadecimientos_Click);
            // 
            // menuItemUsuarios
            // 
            this.menuItemUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlDeUsuariosToolStripMenuItem});
            this.menuItemUsuarios.Name = "menuItemUsuarios";
            this.menuItemUsuarios.Size = new System.Drawing.Size(83, 25);
            this.menuItemUsuarios.Text = "Usuarios";
            // 
            // controlDeUsuariosToolStripMenuItem
            // 
            this.controlDeUsuariosToolStripMenuItem.Name = "controlDeUsuariosToolStripMenuItem";
            this.controlDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.controlDeUsuariosToolStripMenuItem.Text = "Control de usuarios";
            this.controlDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.controlDeUsuariosToolStripMenuItem_Click);
            // 
            // menuItemAyuda
            // 
            this.menuItemAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuItemAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemManualUsuario,
            this.menuItemAcercaDe});
            this.menuItemAyuda.Name = "menuItemAyuda";
            this.menuItemAyuda.Size = new System.Drawing.Size(66, 25);
            this.menuItemAyuda.Text = "Ayuda";
            // 
            // menuItemManualUsuario
            // 
            this.menuItemManualUsuario.Name = "menuItemManualUsuario";
            this.menuItemManualUsuario.Size = new System.Drawing.Size(209, 26);
            this.menuItemManualUsuario.Text = "Manual de usuario";
            // 
            // menuItemAcercaDe
            // 
            this.menuItemAcercaDe.Name = "menuItemAcercaDe";
            this.menuItemAcercaDe.Size = new System.Drawing.Size(209, 26);
            this.menuItemAcercaDe.Text = "Acerca de Ebais";
            // 
            // pnlInicio
            // 
            this.pnlInicio.Controls.Add(this.inicio1);
            this.pnlInicio.Location = new System.Drawing.Point(0, 32);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(784, 529);
            this.pnlInicio.TabIndex = 17;
            // 
            // inicio1
            // 
            this.inicio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.inicio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.inicio1.Location = new System.Drawing.Point(0, -3);
            this.inicio1.Margin = new System.Windows.Forms.Padding(4);
            this.inicio1.Name = "inicio1";
            this.inicio1.Size = new System.Drawing.Size(784, 529);
            this.inicio1.TabIndex = 0;
            // 
            // pnlFarmacia
            // 
            this.pnlFarmacia.Controls.Add(this.farmacia1);
            this.pnlFarmacia.Location = new System.Drawing.Point(0, 29);
            this.pnlFarmacia.Name = "pnlFarmacia";
            this.pnlFarmacia.Size = new System.Drawing.Size(784, 532);
            this.pnlFarmacia.TabIndex = 18;
            // 
            // farmacia1
            // 
            this.farmacia1.BackColor = System.Drawing.Color.Transparent;
            this.farmacia1.Location = new System.Drawing.Point(0, 3);
            this.farmacia1.Margin = new System.Windows.Forms.Padding(4);
            this.farmacia1.Name = "farmacia1";
            this.farmacia1.Size = new System.Drawing.Size(784, 529);
            this.farmacia1.TabIndex = 0;
            // 
            // pnlPaciente
            // 
            this.pnlPaciente.Controls.Add(this.paciente1);
            this.pnlPaciente.Location = new System.Drawing.Point(3, 26);
            this.pnlPaciente.Name = "pnlPaciente";
            this.pnlPaciente.Size = new System.Drawing.Size(784, 535);
            this.pnlPaciente.TabIndex = 22;
            // 
            // paciente1
            // 
            this.paciente1.BackColor = System.Drawing.Color.Transparent;
            this.paciente1.Location = new System.Drawing.Point(-3, 6);
            this.paciente1.Margin = new System.Windows.Forms.Padding(4);
            this.paciente1.Name = "paciente1";
            this.paciente1.Size = new System.Drawing.Size(784, 529);
            this.paciente1.TabIndex = 1;
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.Controls.Add(this.usuario1);
            this.pnlUsuarios.Location = new System.Drawing.Point(0, 26);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(784, 535);
            this.pnlUsuarios.TabIndex = 24;
            // 
            // usuario1
            // 
            this.usuario1.Location = new System.Drawing.Point(3, 3);
            this.usuario1.Margin = new System.Windows.Forms.Padding(4);
            this.usuario1.Name = "usuario1";
            this.usuario1.Size = new System.Drawing.Size(784, 529);
            this.usuario1.TabIndex = 0;
            // 
            // pnlPreconsulta
            // 
            this.pnlPreconsulta.Controls.Add(this.preconsulta1);
            this.pnlPreconsulta.Location = new System.Drawing.Point(0, 26);
            this.pnlPreconsulta.Name = "pnlPreconsulta";
            this.pnlPreconsulta.Size = new System.Drawing.Size(784, 532);
            this.pnlPreconsulta.TabIndex = 25;
            // 
            // preconsulta1
            // 
            this.preconsulta1.Location = new System.Drawing.Point(3, 3);
            this.preconsulta1.Margin = new System.Windows.Forms.Padding(4);
            this.preconsulta1.Name = "preconsulta1";
            this.preconsulta1.Size = new System.Drawing.Size(784, 529);
            this.preconsulta1.TabIndex = 0;
            // 
            // pnlPadecimiento
            // 
            this.pnlPadecimiento.Controls.Add(this.padecimiento1);
            this.pnlPadecimiento.Location = new System.Drawing.Point(0, 26);
            this.pnlPadecimiento.Name = "pnlPadecimiento";
            this.pnlPadecimiento.Size = new System.Drawing.Size(784, 535);
            this.pnlPadecimiento.TabIndex = 27;
            // 
            // padecimiento1
            // 
            this.padecimiento1.BackColor = System.Drawing.Color.Transparent;
            this.padecimiento1.Location = new System.Drawing.Point(3, 6);
            this.padecimiento1.Margin = new System.Windows.Forms.Padding(4);
            this.padecimiento1.Name = "padecimiento1";
            this.padecimiento1.Size = new System.Drawing.Size(784, 529);
            this.padecimiento1.TabIndex = 0;
            this.padecimiento1.Load += new System.EventHandler(this.padecimiento1_Load);
            // 
            // pnlDiagnostico
            // 
            this.pnlDiagnostico.Controls.Add(this.diagnostico1);
            this.pnlDiagnostico.Location = new System.Drawing.Point(0, 26);
            this.pnlDiagnostico.Name = "pnlDiagnostico";
            this.pnlDiagnostico.Size = new System.Drawing.Size(784, 535);
            this.pnlDiagnostico.TabIndex = 28;
            // 
            // diagnostico1
            // 
            this.diagnostico1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.diagnostico1.Location = new System.Drawing.Point(0, 3);
            this.diagnostico1.Margin = new System.Windows.Forms.Padding(4);
            this.diagnostico1.Name = "diagnostico1";
            this.diagnostico1.Size = new System.Drawing.Size(784, 529);
            this.diagnostico1.TabIndex = 0;
            // 
            // pnlExpediente
            // 
            this.pnlExpediente.Controls.Add(this.expediente1);
            this.pnlExpediente.Location = new System.Drawing.Point(0, 26);
            this.pnlExpediente.Name = "pnlExpediente";
            this.pnlExpediente.Size = new System.Drawing.Size(784, 535);
            this.pnlExpediente.TabIndex = 30;
            // 
            // expediente1
            // 
            this.expediente1.BackColor = System.Drawing.Color.Transparent;
            this.expediente1.Location = new System.Drawing.Point(3, 3);
            this.expediente1.Margin = new System.Windows.Forms.Padding(4);
            this.expediente1.Name = "expediente1";
            this.expediente1.Size = new System.Drawing.Size(784, 529);
            this.expediente1.TabIndex = 0;
            // 
            // pnlCita
            // 
            this.pnlCita.Controls.Add(this.cita1);
            this.pnlCita.Location = new System.Drawing.Point(3, 26);
            this.pnlCita.Name = "pnlCita";
            this.pnlCita.Size = new System.Drawing.Size(781, 535);
            this.pnlCita.TabIndex = 31;
            // 
            // cita1
            // 
            this.cita1.Location = new System.Drawing.Point(0, 6);
            this.cita1.Margin = new System.Windows.Forms.Padding(4);
            this.cita1.Name = "cita1";
            this.cita1.Size = new System.Drawing.Size(784, 529);
            this.cita1.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlInicio);
            this.Controls.Add(this.pnlPadecimiento);
            this.Controls.Add(this.pnlCita);
            this.Controls.Add(this.pnlExpediente);
            this.Controls.Add(this.pnlDiagnostico);
            this.Controls.Add(this.pnlPreconsulta);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.pnlPaciente);
            this.Controls.Add(this.pnlFarmacia);
            this.Controls.Add(this.menuStrOpciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ebais Sabanilla";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrOpciones.ResumeLayout(false);
            this.menuStrOpciones.PerformLayout();
            this.pnlInicio.ResumeLayout(false);
            this.pnlFarmacia.ResumeLayout(false);
            this.pnlPaciente.ResumeLayout(false);
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlPreconsulta.ResumeLayout(false);
            this.pnlPadecimiento.ResumeLayout(false);
            this.pnlDiagnostico.ResumeLayout(false);
            this.pnlExpediente.ResumeLayout(false);
            this.pnlCita.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrOpciones;
        private System.Windows.Forms.ToolStripMenuItem menuItemInicio;
        private System.Windows.Forms.ToolStripMenuItem menuItemPantallaPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuItemSalir;
        private System.Windows.Forms.ToolStripMenuItem menuItemExpedientes;
        private System.Windows.Forms.ToolStripMenuItem menuItemNuevoExp;
        private System.Windows.Forms.ToolStripMenuItem menuItemCita;
        private System.Windows.Forms.ToolStripMenuItem menuItemFarmacia;
        private System.Windows.Forms.ToolStripMenuItem menuItemMedicamentos;
        private System.Windows.Forms.Panel pnlInicio;
        private Inicio inicio1;
        private System.Windows.Forms.Panel pnlFarmacia;
        private Farmacia farmacia1;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaciente;
        private System.Windows.Forms.Panel pnlPaciente;
        private Paciente paciente1;
        private System.Windows.Forms.Panel pnlUsuarios;
        private Usuario usuario1;
        private System.Windows.Forms.Panel pnlPreconsulta;
        private Preconsulta preconsulta1;
        private System.Windows.Forms.Panel pnlPadecimiento;
        private Padecimiento padecimiento1;
        private System.Windows.Forms.Panel pnlDiagnostico;
        private Diagnostico diagnostico1;
        private System.Windows.Forms.Panel pnlExpediente;
        private Expediente expediente1;
        private System.Windows.Forms.Panel pnlCita;
        private Cita cita1;
        private System.Windows.Forms.ToolStripMenuItem menuItemPreConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuItemDiagnostico;
        private System.Windows.Forms.ToolStripMenuItem menuItemAyuda;
        private System.Windows.Forms.ToolStripMenuItem menuItemManualUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuItemAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem menuItemPadecimientos;
        private System.Windows.Forms.ToolStripMenuItem menuItemUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuItemControlPadecimientos;
        private System.Windows.Forms.ToolStripMenuItem controlDeUsuariosToolStripMenuItem;
    }
}

