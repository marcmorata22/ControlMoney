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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grafMoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grafMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // grafMoney
            // 
            chartArea1.Name = "ChartArea1";
            this.grafMoney.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafMoney.Legends.Add(legend1);
            this.grafMoney.Location = new System.Drawing.Point(12, 71);
            this.grafMoney.Name = "grafMoney";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafMoney.Series.Add(series1);
            this.grafMoney.Size = new System.Drawing.Size(776, 367);
            this.grafMoney.TabIndex = 0;
            this.grafMoney.Text = "Gráfico";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 20);
            this.textBox1.TabIndex = 1;
            // 
            // grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
    }
}