namespace MainMenu
{
    partial class Menu
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
            this.butgrafico = new System.Windows.Forms.Button();
            this.butMant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butgrafico
            // 
            this.butgrafico.Location = new System.Drawing.Point(113, 67);
            this.butgrafico.Margin = new System.Windows.Forms.Padding(6);
            this.butgrafico.Name = "butgrafico";
            this.butgrafico.Size = new System.Drawing.Size(200, 122);
            this.butgrafico.TabIndex = 0;
            this.butgrafico.Text = "Gráfico";
            this.butgrafico.UseVisualStyleBackColor = true;
            this.butgrafico.Click += new System.EventHandler(this.butgrafico_Click);
            // 
            // butMant
            // 
            this.butMant.Location = new System.Drawing.Point(113, 221);
            this.butMant.Margin = new System.Windows.Forms.Padding(6);
            this.butMant.Name = "butMant";
            this.butMant.Size = new System.Drawing.Size(200, 122);
            this.butMant.TabIndex = 1;
            this.butMant.Text = "Mantenimiento";
            this.butMant.UseVisualStyleBackColor = true;
            this.butMant.Click += new System.EventHandler(this.butMant_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1004, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome Administrator";
            // 
            // labExit
            // 
            this.labExit.AutoSize = true;
            this.labExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labExit.ForeColor = System.Drawing.Color.Red;
            this.labExit.Location = new System.Drawing.Point(12, 9);
            this.labExit.Name = "labExit";
            this.labExit.Size = new System.Drawing.Size(79, 33);
            this.labExit.TabIndex = 3;
            this.labExit.Text = "EXIT";
            this.labExit.Click += new System.EventHandler(this.labExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1307, 537);
            this.Controls.Add(this.labExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butMant);
            this.Controls.Add(this.butgrafico);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butgrafico;
        private System.Windows.Forms.Button butMant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labExit;
    }
}

