﻿namespace MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.grafMoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.butUpdate = new System.Windows.Forms.Button();
            this.labdescrip = new System.Windows.Forms.Label();
            this.labdate = new System.Windows.Forms.Label();
            this.dgvGraph = new System.Windows.Forms.DataGridView();
            this.txtmovement = new System.Windows.Forms.TextBox();
            this.labmovement = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.labmonth = new System.Windows.Forms.Label();
            this.dailygraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.labLast = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailygraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            this.SuspendLayout();
            // 
            // grafMoney
            // 
            chartArea3.Name = "ChartArea1";
            this.grafMoney.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grafMoney.Legends.Add(legend3);
            this.grafMoney.Location = new System.Drawing.Point(567, 149);
            this.grafMoney.Name = "grafMoney";
            this.grafMoney.Size = new System.Drawing.Size(634, 279);
            this.grafMoney.TabIndex = 0;
            this.grafMoney.Text = "Mensual";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(1282, 253);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 20);
            this.txtdate.TabIndex = 1;
            // 
            // txtdescrip
            // 
            this.txtdescrip.Location = new System.Drawing.Point(1282, 218);
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(100, 20);
            this.txtdescrip.TabIndex = 2;
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(1218, 405);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(164, 23);
            this.butUpdate.TabIndex = 3;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // labdescrip
            // 
            this.labdescrip.AutoSize = true;
            this.labdescrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labdescrip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labdescrip.Location = new System.Drawing.Point(1215, 221);
            this.labdescrip.Name = "labdescrip";
            this.labdescrip.Size = new System.Drawing.Size(60, 13);
            this.labdescrip.TabIndex = 4;
            this.labdescrip.Text = "Description";
            // 
            // labdate
            // 
            this.labdate.AutoSize = true;
            this.labdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labdate.Location = new System.Drawing.Point(1218, 256);
            this.labdate.Name = "labdate";
            this.labdate.Size = new System.Drawing.Size(30, 13);
            this.labdate.TabIndex = 5;
            this.labdate.Text = "Date";
            // 
            // dgvGraph
            // 
            this.dgvGraph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGraph.Location = new System.Drawing.Point(10, 149);
            this.dgvGraph.Name = "dgvGraph";
            this.dgvGraph.Size = new System.Drawing.Size(551, 279);
            this.dgvGraph.TabIndex = 6;
            // 
            // txtmovement
            // 
            this.txtmovement.Location = new System.Drawing.Point(1282, 290);
            this.txtmovement.Name = "txtmovement";
            this.txtmovement.Size = new System.Drawing.Size(100, 20);
            this.txtmovement.TabIndex = 0;
            this.txtmovement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmovement_KeyPress);
            // 
            // labmovement
            // 
            this.labmovement.AutoSize = true;
            this.labmovement.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labmovement.Location = new System.Drawing.Point(1218, 293);
            this.labmovement.Name = "labmovement";
            this.labmovement.Size = new System.Drawing.Size(57, 13);
            this.labmovement.TabIndex = 7;
            this.labmovement.Text = "Movement";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(1282, 327);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(100, 20);
            this.txtmonth.TabIndex = 8;
            // 
            // labmonth
            // 
            this.labmonth.AutoSize = true;
            this.labmonth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labmonth.Location = new System.Drawing.Point(1219, 330);
            this.labmonth.Name = "labmonth";
            this.labmonth.Size = new System.Drawing.Size(37, 13);
            this.labmonth.TabIndex = 9;
            this.labmonth.Text = "Month";
            // 
            // dailygraph
            // 
            chartArea4.Name = "ChartArea1";
            this.dailygraph.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.dailygraph.Legends.Add(legend4);
            this.dailygraph.Location = new System.Drawing.Point(10, 434);
            this.dailygraph.Name = "dailygraph";
            this.dailygraph.Size = new System.Drawing.Size(1372, 363);
            this.dailygraph.TabIndex = 10;
            this.dailygraph.Text = "Diario";
            // 
            // pictureBack
            // 
            this.pictureBack.BackgroundImage = global::MainMenu.Properties.Resources.atras;
            this.pictureBack.Location = new System.Drawing.Point(10, 12);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(129, 131);
            this.pictureBack.TabIndex = 11;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.pictureBack_Click);
            // 
            // labLast
            // 
            this.labLast.AutoSize = true;
            this.labLast.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLast.ForeColor = System.Drawing.Color.Lime;
            this.labLast.Location = new System.Drawing.Point(769, 59);
            this.labLast.Name = "labLast";
            this.labLast.Size = new System.Drawing.Size(0, 42);
            this.labLast.TabIndex = 13;
            // 
            // grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1394, 804);
            this.Controls.Add(this.labLast);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(this.dailygraph);
            this.Controls.Add(this.labmonth);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.labmovement);
            this.Controls.Add(this.txtmovement);
            this.Controls.Add(this.dgvGraph);
            this.Controls.Add(this.labdate);
            this.Controls.Add(this.labdescrip);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.txtdescrip);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.grafMoney);
            this.Name = "grafico";
            this.Text = "Gráfico";
            this.Load += new System.EventHandler(this.grafico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailygraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafMoney;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Label labdescrip;
        private System.Windows.Forms.Label labdate;
        private System.Windows.Forms.DataGridView dgvGraph;
        private System.Windows.Forms.TextBox txtmovement;
        private System.Windows.Forms.Label labmovement;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.Label labmonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart dailygraph;
        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.Label labLast;
    }
}