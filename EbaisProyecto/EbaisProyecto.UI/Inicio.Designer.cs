namespace EbaisProyecto.UI
{
    partial class Inicio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancelarCita = new System.Windows.Forms.Button();
            this.btnPosponerCita = new System.Windows.Forms.Button();
            this.btnTiempo = new System.Windows.Forms.Button();
            this.btnRetrasado = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 317);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCita.Location = new System.Drawing.Point(412, 5);
            this.btnCancelarCita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Size = new System.Drawing.Size(97, 28);
            this.btnCancelarCita.TabIndex = 15;
            this.btnCancelarCita.Text = "Cancelar Cita";
            this.btnCancelarCita.UseVisualStyleBackColor = false;
            // 
            // btnPosponerCita
            // 
            this.btnPosponerCita.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPosponerCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosponerCita.Location = new System.Drawing.Point(276, 5);
            this.btnPosponerCita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPosponerCita.Name = "btnPosponerCita";
            this.btnPosponerCita.Size = new System.Drawing.Size(97, 28);
            this.btnPosponerCita.TabIndex = 17;
            this.btnPosponerCita.Text = "Posponer Cita";
            this.btnPosponerCita.UseVisualStyleBackColor = false;
            // 
            // btnTiempo
            // 
            this.btnTiempo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiempo.Location = new System.Drawing.Point(4, 5);
            this.btnTiempo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTiempo.Name = "btnTiempo";
            this.btnTiempo.Size = new System.Drawing.Size(97, 28);
            this.btnTiempo.TabIndex = 16;
            this.btnTiempo.Text = "A Tiempo";
            this.btnTiempo.UseVisualStyleBackColor = false;
            // 
            // btnRetrasado
            // 
            this.btnRetrasado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRetrasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrasado.Location = new System.Drawing.Point(140, 5);
            this.btnRetrasado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetrasado.Name = "btnRetrasado";
            this.btnRetrasado.Size = new System.Drawing.Size(97, 28);
            this.btnRetrasado.TabIndex = 14;
            this.btnRetrasado.Text = "Retrasado";
            this.btnRetrasado.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnTiempo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelarCita, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRetrasado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPosponerCita, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(156, 419);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 38);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(784, 529);
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancelarCita;
        private System.Windows.Forms.Button btnPosponerCita;
        private System.Windows.Forms.Button btnTiempo;
        private System.Windows.Forms.Button btnRetrasado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
