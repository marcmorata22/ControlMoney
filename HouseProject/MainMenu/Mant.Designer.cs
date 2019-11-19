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
            this.sdstxtDate = new controlTxt.sdstxtbox();
            this.sdstxTotal = new controlTxt.sdstxtbox();
            this.sdstxtBanking = new controlTxt.sdstxtbox();
            this.sdstxtMonth = new controlTxt.sdstxtbox();
            this.sdstxtDescrip = new controlTxt.sdstxtbox();
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
            // sdstxtDate
            // 
            this.sdstxtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sdstxtDate.ColumnName = "date";
            this.sdstxtDate.Location = new System.Drawing.Point(864, 97);
            this.sdstxtDate.Name = "sdstxtDate";
            this.sdstxtDate.Nom = null;
            this.sdstxtDate.NomTaula = "graficoMoney";
            this.sdstxtDate.Requerit = false;
            this.sdstxtDate.Size = new System.Drawing.Size(143, 20);
            this.sdstxtDate.TabIndex = 7;
            this.sdstxtDate.Text = "sdstxtbox";
            // 
            // sdstxTotal
            // 
            this.sdstxTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sdstxTotal.ColumnName = "total";
            this.sdstxTotal.Location = new System.Drawing.Point(864, 123);
            this.sdstxTotal.Name = "sdstxTotal";
            this.sdstxTotal.Nom = null;
            this.sdstxTotal.NomTaula = "graficoMoney";
            this.sdstxTotal.Requerit = false;
            this.sdstxTotal.Size = new System.Drawing.Size(143, 20);
            this.sdstxTotal.TabIndex = 6;
            this.sdstxTotal.Text = "sdstxtbox";
            // 
            // sdstxtBanking
            // 
            this.sdstxtBanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sdstxtBanking.ColumnName = "bankingmovement";
            this.sdstxtBanking.Location = new System.Drawing.Point(864, 149);
            this.sdstxtBanking.Name = "sdstxtBanking";
            this.sdstxtBanking.Nom = null;
            this.sdstxtBanking.NomTaula = "graficoMoney";
            this.sdstxtBanking.Requerit = false;
            this.sdstxtBanking.Size = new System.Drawing.Size(143, 20);
            this.sdstxtBanking.TabIndex = 5;
            this.sdstxtBanking.Text = "sdstxtbox";
            // 
            // sdstxtMonth
            // 
            this.sdstxtMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sdstxtMonth.ColumnName = "month";
            this.sdstxtMonth.Location = new System.Drawing.Point(864, 175);
            this.sdstxtMonth.Name = "sdstxtMonth";
            this.sdstxtMonth.Nom = null;
            this.sdstxtMonth.NomTaula = "graficoMoney";
            this.sdstxtMonth.Requerit = false;
            this.sdstxtMonth.Size = new System.Drawing.Size(143, 20);
            this.sdstxtMonth.TabIndex = 4;
            this.sdstxtMonth.Text = "sdstxtbox";
            // 
            // sdstxtDescrip
            // 
            this.sdstxtDescrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sdstxtDescrip.ColumnName = "description";
            this.sdstxtDescrip.Location = new System.Drawing.Point(864, 71);
            this.sdstxtDescrip.Name = "sdstxtDescrip";
            this.sdstxtDescrip.Nom = null;
            this.sdstxtDescrip.NomTaula = "graficoMoney";
            this.sdstxtDescrip.Requerit = false;
            this.sdstxtDescrip.Size = new System.Drawing.Size(143, 20);
            this.sdstxtDescrip.TabIndex = 3;
            this.sdstxtDescrip.Text = "sdstxtbox";
            // 
            // Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1019, 637);
            this.Controls.Add(this.labMonth);
            this.Controls.Add(this.laBankingmovement);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labDescrip);
            this.Controls.Add(this.sdstxtDate);
            this.Controls.Add(this.sdstxTotal);
            this.Controls.Add(this.sdstxtBanking);
            this.Controls.Add(this.sdstxtMonth);
            this.Controls.Add(this.sdstxtDescrip);
            this.Controls.Add(this.butInsert);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.GridMant);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
        private controlTxt.sdstxtbox sdstxtDescrip;
        private controlTxt.sdstxtbox sdstxtMonth;
        private controlTxt.sdstxtbox sdstxtBanking;
        private controlTxt.sdstxtbox sdstxTotal;
        private controlTxt.sdstxtbox sdstxtDate;
        private System.Windows.Forms.Label labDescrip;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label laBankingmovement;
        private System.Windows.Forms.Label labMonth;
    }
}