namespace HouseProject
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.labUser = new System.Windows.Forms.Label();
            this.labPassw = new System.Windows.Forms.Label();
            this.butLogin = new System.Windows.Forms.Button();
            this.labFail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(361, 83);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(100, 20);
            this.txtSerial.TabIndex = 0;
            // 
            // txtPassw
            // 
            this.txtPassw.Location = new System.Drawing.Point(361, 122);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.PasswordChar = '*';
            this.txtPassw.Size = new System.Drawing.Size(100, 20);
            this.txtPassw.TabIndex = 1;
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(282, 86);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(73, 13);
            this.labUser.TabIndex = 2;
            this.labUser.Text = "Serial Number";
            // 
            // labPassw
            // 
            this.labPassw.AutoSize = true;
            this.labPassw.Location = new System.Drawing.Point(302, 125);
            this.labPassw.Name = "labPassw";
            this.labPassw.Size = new System.Drawing.Size(53, 13);
            this.labPassw.TabIndex = 3;
            this.labPassw.Text = "Password";
            // 
            // butLogin
            // 
            this.butLogin.Location = new System.Drawing.Point(386, 148);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(75, 23);
            this.butLogin.TabIndex = 4;
            this.butLogin.Text = "Login";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // labFail
            // 
            this.labFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFail.Location = new System.Drawing.Point(357, 191);
            this.labFail.Name = "labFail";
            this.labFail.Size = new System.Drawing.Size(49, 20);
            this.labFail.TabIndex = 5;
            this.labFail.Text = "FAIL";
            this.labFail.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labFail);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.labPassw);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.txtSerial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.TextBox txtPassw;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labPassw;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Label labFail;
    }
}

