namespace EbaisProyecto.UI
{
    partial class Login
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
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btIngresar
            // 
            this.btIngresar.Location = new System.Drawing.Point(357, 415);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(75, 23);
            this.btIngresar.TabIndex = 26;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // mtbPass
            // 
            this.mtbPass.Location = new System.Drawing.Point(279, 330);
            this.mtbPass.Name = "mtbPass";
            this.mtbPass.PasswordChar = '*';
            this.mtbPass.Size = new System.Drawing.Size(247, 20);
            this.mtbPass.TabIndex = 25;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(279, 248);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(250, 20);
            this.tbUser.TabIndex = 24;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(190, 333);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(83, 13);
            this.lbPass.TabIndex = 29;
            this.lbPass.Text = "Contraseña : ";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(190, 255);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(58, 13);
            this.lbUsuario.TabIndex = 28;
            this.lbUsuario.Text = "Cédula : ";
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenido.Location = new System.Drawing.Point(34, 123);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(717, 31);
            this.lbBienvenido.TabIndex = 27;
            this.lbBienvenido.Text = "Bienvenido, escriba sus credenciales para poder continuar";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.mtbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbBienvenido);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ebais Sabanilla";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbBienvenido;
        public System.Windows.Forms.MaskedTextBox mtbPass;
        public System.Windows.Forms.TextBox tbUser;
    }
}