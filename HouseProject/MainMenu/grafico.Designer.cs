namespace MainMenu
{
    partial class grafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafMoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lol = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // grafMoney
            // 
            chartArea3.Name = "ChartArea1";
            this.grafMoney.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grafMoney.Legends.Add(legend3);
            this.grafMoney.Location = new System.Drawing.Point(12, 71);
            this.grafMoney.Name = "grafMoney";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.grafMoney.Series.Add(series3);
            this.grafMoney.Size = new System.Drawing.Size(664, 354);
            this.grafMoney.TabIndex = 0;
            this.grafMoney.Text = "Gráfico";
            // 
            // lol
            // 
            this.lol.Location = new System.Drawing.Point(682, 111);
            this.lol.Name = "lol";
            this.lol.Size = new System.Drawing.Size(100, 20);
            this.lol.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(682, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(682, 369);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(100, 23);
            this.butUpdate.TabIndex = 3;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lol);
            this.Controls.Add(this.grafMoney);
            this.Name = "grafico";
            this.Text = "Gráfico";
            this.Load += new System.EventHandler(this.grafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafMoney;
        private System.Windows.Forms.TextBox lol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butUpdate;
    }
}