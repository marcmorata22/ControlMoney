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
            this.SuspendLayout();
            // 
            // butgrafico
            // 
            this.butgrafico.Location = new System.Drawing.Point(54, 24);
            this.butgrafico.Name = "butgrafico";
            this.butgrafico.Size = new System.Drawing.Size(100, 69);
            this.butgrafico.TabIndex = 0;
            this.butgrafico.Text = "Gráfico";
            this.butgrafico.UseVisualStyleBackColor = true;
            this.butgrafico.Click += new System.EventHandler(this.butgrafico_Click);
            // 
            // butMant
            // 
            this.butMant.Location = new System.Drawing.Point(173, 24);
            this.butMant.Name = "butMant";
            this.butMant.Size = new System.Drawing.Size(100, 69);
            this.butMant.TabIndex = 1;
            this.butMant.Text = "Mantenimiento";
            this.butMant.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butMant);
            this.Controls.Add(this.butgrafico);
            this.Name = "Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butgrafico;
        private System.Windows.Forms.Button butMant;
    }
}

