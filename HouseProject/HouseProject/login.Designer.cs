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
            this.txtSerial.BackColor = System.Drawing.Color.Maroon;
            this.txtSerial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSerial.Location = new System.Drawing.Point(346, 143);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(6);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(180, 29);
            this.txtSerial.TabIndex = 0;
            // 
            // txtPassw
            // 
            this.txtPassw.BackColor = System.Drawing.Color.Maroon;
            this.txtPassw.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPassw.Location = new System.Drawing.Point(346, 198);
            this.txtPassw.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.PasswordChar = '*';
            this.txtPassw.Size = new System.Drawing.Size(180, 29);
            this.txtPassw.TabIndex = 1;
            this.txtPassw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassw_KeyUp);
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.BackColor = System.Drawing.Color.Transparent;
            this.labUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labUser.Location = new System.Drawing.Point(231, 148);
            this.labUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(103, 24);
            this.labUser.TabIndex = 2;
            this.labUser.Text = "Serial Num";
            // 
            // labPassw
            // 
            this.labPassw.AutoSize = true;
            this.labPassw.BackColor = System.Drawing.Color.Transparent;
            this.labPassw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labPassw.Location = new System.Drawing.Point(242, 201);
            this.labPassw.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labPassw.Name = "labPassw";
            this.labPassw.Size = new System.Drawing.Size(92, 24);
            this.labPassw.TabIndex = 3;
            this.labPassw.Text = "Password";
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.Maroon;
            this.butLogin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butLogin.Location = new System.Drawing.Point(346, 263);
            this.butLogin.Margin = new System.Windows.Forms.Padding(6);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(183, 74);
            this.butLogin.TabIndex = 4;
            this.butLogin.Text = "Login";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // labFail
            // 
            this.labFail.BackColor = System.Drawing.Color.Transparent;
            this.labFail.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFail.ForeColor = System.Drawing.Color.Red;
            this.labFail.Location = new System.Drawing.Point(554, 283);
            this.labFail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labFail.Name = "labFail";
            this.labFail.Size = new System.Drawing.Size(248, 33);
            this.labFail.TabIndex = 5;
            this.labFail.Text = "Credentials Error";
            this.labFail.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(908, 476);
            this.Controls.Add(this.labFail);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.labPassw);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.txtSerial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
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

