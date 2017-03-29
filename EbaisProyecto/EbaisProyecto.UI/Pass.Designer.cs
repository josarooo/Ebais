namespace EbaisProyecto.UI
{
    partial class Pass
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
            this.btIngresar = new System.Windows.Forms.Button();
            this.mtbPass = new System.Windows.Forms.MaskedTextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btIngresar
            // 
            this.btIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIngresar.Location = new System.Drawing.Point(323, 373);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(116, 52);
            this.btIngresar.TabIndex = 31;
            this.btIngresar.Text = "Continuar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // mtbPass
            // 
            this.mtbPass.Location = new System.Drawing.Point(302, 274);
            this.mtbPass.Name = "mtbPass";
            this.mtbPass.PasswordChar = '*';
            this.mtbPass.Size = new System.Drawing.Size(247, 26);
            this.mtbPass.TabIndex = 30;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(145, 277);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(117, 20);
            this.lbPass.TabIndex = 32;
            this.lbPass.Text = "Contraseña : ";
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenido.Location = new System.Drawing.Point(245, 162);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(475, 31);
            this.lbBienvenido.TabIndex = 33;
            this.lbBienvenido.Text = ", escriba su contraseña para continuar";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(101, 162);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(103, 31);
            this.lbNombre.TabIndex = 34;
            this.lbNombre.Text = "usuario";
            // 
            // Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbBienvenido);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.mtbPass);
            this.Controls.Add(this.lbPass);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Introduzca su contraseña";
            this.Load += new System.EventHandler(this.Pass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIngresar;
        public System.Windows.Forms.MaskedTextBox mtbPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbBienvenido;
        private System.Windows.Forms.Label lbNombre;
    }
}