namespace MainMenu
{
    partial class Mant
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
            this.GridMant = new System.Windows.Forms.DataGridView();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butInsert = new System.Windows.Forms.Button();
            this.labDescrip = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.laBankingmovement = new System.Windows.Forms.Label();
            this.labMonth = new System.Windows.Forms.Label();
            this.sdstxtbox5 = new controlTxt.sdstxtbox();
            this.sdstxtbox4 = new controlTxt.sdstxtbox();
            this.sdstxtbox3 = new controlTxt.sdstxtbox();
            this.sdstxtbox2 = new controlTxt.sdstxtbox();
            this.sdstxtbox1 = new controlTxt.sdstxtbox();
            ((System.ComponentModel.ISupportInitialize)(this.GridMant)).BeginInit();
            this.SuspendLayout();
            // 
            // GridMant
            // 
            this.GridMant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMant.Location = new System.Drawing.Point(12, 12);
            this.GridMant.Name = "GridMant";
            this.GridMant.Size = new System.Drawing.Size(747, 613);
            this.GridMant.TabIndex = 0;
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(799, 508);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(179, 23);
            this.butUpdate.TabIndex = 1;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(799, 537);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(179, 23);
            this.butInsert.TabIndex = 2;
            this.butInsert.Text = "Insert";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // labDescrip
            // 
            this.labDescrip.AutoSize = true;
            this.labDescrip.ForeColor = System.Drawing.SystemColors.Control;
            this.labDescrip.Location = new System.Drawing.Point(798, 74);
            this.labDescrip.Name = "labDescrip";
            this.labDescrip.Size = new System.Drawing.Size(60, 13);
            this.labDescrip.TabIndex = 8;
            this.labDescrip.Text = "Description";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labDate.Location = new System.Drawing.Point(806, 100);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(30, 13);
            this.labDate.TabIndex = 9;
            this.labDate.Text = "Date";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.labTotal.Location = new System.Drawing.Point(806, 126);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(31, 13);
            this.labTotal.TabIndex = 10;
            this.labTotal.Text = "Total";
            // 
            // laBankingmovement
            // 
            this.laBankingmovement.AutoSize = true;
            this.laBankingmovement.ForeColor = System.Drawing.SystemColors.Control;
            this.laBankingmovement.Location = new System.Drawing.Point(763, 152);
            this.laBankingmovement.Name = "laBankingmovement";
            this.laBankingmovement.Size = new System.Drawing.Size(95, 13);
            this.laBankingmovement.TabIndex = 11;
            this.laBankingmovement.Text = "Bankingmovement";
            // 
            // labMonth
            // 
            this.labMonth.AutoSize = true;
            this.labMonth.ForeColor = System.Drawing.SystemColors.Control;
            this.labMonth.Location = new System.Drawing.Point(806, 178);
            this.labMonth.Name = "labMonth";
            this.labMonth.Size = new System.Drawing.Size(37, 13);
            this.labMonth.TabIndex = 12;
            this.labMonth.Text = "Month";
            // 
            // sdstxtbox5
            // 
            this.sdstxtbox5.ColumnName = "date";
            this.sdstxtbox5.Location = new System.Drawing.Point(864, 97);
            this.sdstxtbox5.Name = "sdstxtbox5";
            this.sdstxtbox5.Nom = null;
            this.sdstxtbox5.NomTaula = "graficoMoney";
            this.sdstxtbox5.Requerit = false;
            this.sdstxtbox5.Size = new System.Drawing.Size(143, 20);
            this.sdstxtbox5.TabIndex = 7;
            this.sdstxtbox5.Text = "sdstxtbox";
            // 
            // sdstxtbox4
            // 
            this.sdstxtbox4.ColumnName = "total";
            this.sdstxtbox4.Location = new System.Drawing.Point(864, 123);
            this.sdstxtbox4.Name = "sdstxtbox4";
            this.sdstxtbox4.Nom = null;
            this.sdstxtbox4.NomTaula = "graficoMoney";
            this.sdstxtbox4.Requerit = false;
            this.sdstxtbox4.Size = new System.Drawing.Size(143, 20);
            this.sdstxtbox4.TabIndex = 6;
            this.sdstxtbox4.Text = "sdstxtbox";
            // 
            // sdstxtbox3
            // 
            this.sdstxtbox3.ColumnName = "bankingmovement";
            this.sdstxtbox3.Location = new System.Drawing.Point(864, 149);
            this.sdstxtbox3.Name = "sdstxtbox3";
            this.sdstxtbox3.Nom = null;
            this.sdstxtbox3.NomTaula = "graficoMoney";
            this.sdstxtbox3.Requerit = false;
            this.sdstxtbox3.Size = new System.Drawing.Size(143, 20);
            this.sdstxtbox3.TabIndex = 5;
            this.sdstxtbox3.Text = "sdstxtbox";
            // 
            // sdstxtbox2
            // 
            this.sdstxtbox2.ColumnName = "month";
            this.sdstxtbox2.Location = new System.Drawing.Point(864, 175);
            this.sdstxtbox2.Name = "sdstxtbox2";
            this.sdstxtbox2.Nom = null;
            this.sdstxtbox2.NomTaula = "graficoMoney";
            this.sdstxtbox2.Requerit = false;
            this.sdstxtbox2.Size = new System.Drawing.Size(143, 20);
            this.sdstxtbox2.TabIndex = 4;
            this.sdstxtbox2.Text = "sdstxtbox";
            // 
            // sdstxtbox1
            // 
            this.sdstxtbox1.ColumnName = "description";
            this.sdstxtbox1.Location = new System.Drawing.Point(864, 71);
            this.sdstxtbox1.Name = "sdstxtbox1";
            this.sdstxtbox1.Nom = null;
            this.sdstxtbox1.NomTaula = "graficoMoney";
            this.sdstxtbox1.Requerit = false;
            this.sdstxtbox1.Size = new System.Drawing.Size(143, 20);
            this.sdstxtbox1.TabIndex = 3;
            this.sdstxtbox1.Text = "sdstxtbox";
            // 
            // Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1019, 637);
            this.Controls.Add(this.labMonth);
            this.Controls.Add(this.laBankingmovement);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labDescrip);
            this.Controls.Add(this.sdstxtbox5);
            this.Controls.Add(this.sdstxtbox4);
            this.Controls.Add(this.sdstxtbox3);
            this.Controls.Add(this.sdstxtbox2);
            this.Controls.Add(this.sdstxtbox1);
            this.Controls.Add(this.butInsert);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.GridMant);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Mant";
            this.Text = "Mant";
            this.Load += new System.EventHandler(this.Mant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridMant;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butInsert;
        private controlTxt.sdstxtbox sdstxtbox1;
        private controlTxt.sdstxtbox sdstxtbox2;
        private controlTxt.sdstxtbox sdstxtbox3;
        private controlTxt.sdstxtbox sdstxtbox4;
        private controlTxt.sdstxtbox sdstxtbox5;
        private System.Windows.Forms.Label labDescrip;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label laBankingmovement;
        private System.Windows.Forms.Label labMonth;
    }
}