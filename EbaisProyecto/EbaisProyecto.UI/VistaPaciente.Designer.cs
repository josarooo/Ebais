namespace EbaisProyecto.UI
{
    partial class VistaPaciente
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
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.btYaLlegue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenido.Location = new System.Drawing.Point(57, 86);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(148, 31);
            this.lbBienvenido.TabIndex = 28;
            this.lbBienvenido.Text = "Bienvenido";
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsuario.Location = new System.Drawing.Point(270, 86);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(103, 31);
            this.lbNombreUsuario.TabIndex = 29;
            this.lbNombreUsuario.Text = "usuario";
            // 
            // btYaLlegue
            // 
            this.btYaLlegue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btYaLlegue.Location = new System.Drawing.Point(260, 407);
            this.btYaLlegue.Name = "btYaLlegue";
            this.btYaLlegue.Size = new System.Drawing.Size(211, 73);
            this.btYaLlegue.TabIndex = 30;
            this.btYaLlegue.Text = "Ya llegué";
            this.btYaLlegue.UseVisualStyleBackColor = true;
            // 
            // VistaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btYaLlegue);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.lbBienvenido);
            this.Name = "VistaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ebais Sabanilla";
            this.Load += new System.EventHandler(this.VistaPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBienvenido;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.Button btYaLlegue;
    }
}