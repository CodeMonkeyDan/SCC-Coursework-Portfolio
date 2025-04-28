namespace OlympicAnalyzer
{
    partial class compareFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compareFrm));
            this.resetBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.selectCountriesGrpBx = new System.Windows.Forms.GroupBox();
            this.selectCountry2CmbBx = new System.Windows.Forms.ComboBox();
            this.compareBtn = new System.Windows.Forms.Button();
            this.selectCountry1CmbBx = new System.Windows.Forms.ComboBox();
            this.compareCountriesLstVw = new System.Windows.Forms.ListView();
            this.compareTitleLbl = new System.Windows.Forms.Label();
            this.country1Lbl = new System.Windows.Forms.Label();
            this.c1GoldLbl = new System.Windows.Forms.Label();
            this.c1BronzeLbl = new System.Windows.Forms.Label();
            this.c1SilverLbl = new System.Windows.Forms.Label();
            this.c1RecordsLbl = new System.Windows.Forms.Label();
            this.c1TotalLbl = new System.Windows.Forms.Label();
            this.c2TotalLbl = new System.Windows.Forms.Label();
            this.c2RecordsLbl = new System.Windows.Forms.Label();
            this.c2SilverLbl = new System.Windows.Forms.Label();
            this.c2BronzeLbl = new System.Windows.Forms.Label();
            this.c2GoldLbl = new System.Windows.Forms.Label();
            this.country2Lbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.selectCountriesGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetBtn
            // 
            this.resetBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetBtn.Location = new System.Drawing.Point(887, 501);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(129, 38);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "&Reset Form";
            this.toolTip1.SetToolTip(this.resetBtn, "click to reset the form");
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainMenuBtn.Location = new System.Drawing.Point(887, 545);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(129, 38);
            this.mainMenuBtn.TabIndex = 2;
            this.mainMenuBtn.Text = "Main &Menu";
            this.toolTip1.SetToolTip(this.mainMenuBtn, "click to return to the main menu");
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(887, 589);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(129, 38);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitBtn, "click to exit the program");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // selectCountriesGrpBx
            // 
            this.selectCountriesGrpBx.Controls.Add(this.selectCountry2CmbBx);
            this.selectCountriesGrpBx.Controls.Add(this.compareBtn);
            this.selectCountriesGrpBx.Controls.Add(this.selectCountry1CmbBx);
            this.selectCountriesGrpBx.Location = new System.Drawing.Point(130, 507);
            this.selectCountriesGrpBx.Name = "selectCountriesGrpBx";
            this.selectCountriesGrpBx.Size = new System.Drawing.Size(611, 120);
            this.selectCountriesGrpBx.TabIndex = 0;
            this.selectCountriesGrpBx.TabStop = false;
            this.selectCountriesGrpBx.Text = "Select Countries to Compare:";
            // 
            // selectCountry2CmbBx
            // 
            this.selectCountry2CmbBx.FormattingEnabled = true;
            this.selectCountry2CmbBx.Location = new System.Drawing.Point(316, 33);
            this.selectCountry2CmbBx.Name = "selectCountry2CmbBx";
            this.selectCountry2CmbBx.Size = new System.Drawing.Size(279, 26);
            this.selectCountry2CmbBx.TabIndex = 1;
            // 
            // compareBtn
            // 
            this.compareBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.compareBtn.Location = new System.Drawing.Point(234, 65);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(129, 38);
            this.compareBtn.TabIndex = 2;
            this.compareBtn.Text = "&Compare";
            this.toolTip1.SetToolTip(this.compareBtn, "select a country from each of the above drop down box and click here to compare d" +
        "ata");
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // selectCountry1CmbBx
            // 
            this.selectCountry1CmbBx.FormattingEnabled = true;
            this.selectCountry1CmbBx.Location = new System.Drawing.Point(15, 33);
            this.selectCountry1CmbBx.Name = "selectCountry1CmbBx";
            this.selectCountry1CmbBx.Size = new System.Drawing.Size(279, 26);
            this.selectCountry1CmbBx.TabIndex = 0;
            // 
            // compareCountriesLstVw
            // 
            this.compareCountriesLstVw.GridLines = true;
            this.compareCountriesLstVw.HideSelection = false;
            this.compareCountriesLstVw.Location = new System.Drawing.Point(12, 213);
            this.compareCountriesLstVw.Name = "compareCountriesLstVw";
            this.compareCountriesLstVw.Size = new System.Drawing.Size(1008, 269);
            this.compareCountriesLstVw.TabIndex = 26;
            this.compareCountriesLstVw.TabStop = false;
            this.compareCountriesLstVw.UseCompatibleStateImageBehavior = false;
            this.compareCountriesLstVw.View = System.Windows.Forms.View.Details;
            // 
            // compareTitleLbl
            // 
            this.compareTitleLbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareTitleLbl.Location = new System.Drawing.Point(8, 30);
            this.compareTitleLbl.Name = "compareTitleLbl";
            this.compareTitleLbl.Size = new System.Drawing.Size(1008, 35);
            this.compareTitleLbl.TabIndex = 27;
            this.compareTitleLbl.Text = "Compare Countries";
            this.compareTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.compareTitleLbl.Visible = false;
            // 
            // country1Lbl
            // 
            this.country1Lbl.Location = new System.Drawing.Point(74, 83);
            this.country1Lbl.Name = "country1Lbl";
            this.country1Lbl.Size = new System.Drawing.Size(377, 28);
            this.country1Lbl.TabIndex = 28;
            this.country1Lbl.Text = "country1";
            this.country1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c1GoldLbl
            // 
            this.c1GoldLbl.Location = new System.Drawing.Point(74, 111);
            this.c1GoldLbl.Name = "c1GoldLbl";
            this.c1GoldLbl.Size = new System.Drawing.Size(147, 23);
            this.c1GoldLbl.TabIndex = 30;
            this.c1GoldLbl.Text = "c1 Gold Medals:";
            this.c1GoldLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c1BronzeLbl
            // 
            this.c1BronzeLbl.Location = new System.Drawing.Point(74, 157);
            this.c1BronzeLbl.Name = "c1BronzeLbl";
            this.c1BronzeLbl.Size = new System.Drawing.Size(147, 23);
            this.c1BronzeLbl.TabIndex = 31;
            this.c1BronzeLbl.Text = "c1 Bronze Medals: ";
            this.c1BronzeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c1SilverLbl
            // 
            this.c1SilverLbl.Location = new System.Drawing.Point(74, 134);
            this.c1SilverLbl.Name = "c1SilverLbl";
            this.c1SilverLbl.Size = new System.Drawing.Size(147, 23);
            this.c1SilverLbl.TabIndex = 32;
            this.c1SilverLbl.Text = "c1 Silver Medals:";
            this.c1SilverLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c1RecordsLbl
            // 
            this.c1RecordsLbl.Location = new System.Drawing.Point(304, 157);
            this.c1RecordsLbl.Name = "c1RecordsLbl";
            this.c1RecordsLbl.Size = new System.Drawing.Size(147, 23);
            this.c1RecordsLbl.TabIndex = 33;
            this.c1RecordsLbl.Text = "c1 World Records: ";
            this.c1RecordsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c1TotalLbl
            // 
            this.c1TotalLbl.Location = new System.Drawing.Point(304, 111);
            this.c1TotalLbl.Name = "c1TotalLbl";
            this.c1TotalLbl.Size = new System.Drawing.Size(147, 23);
            this.c1TotalLbl.TabIndex = 34;
            this.c1TotalLbl.Text = "c1 Total Medals: ";
            this.c1TotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c2TotalLbl
            // 
            this.c2TotalLbl.Location = new System.Drawing.Point(804, 111);
            this.c2TotalLbl.Name = "c2TotalLbl";
            this.c2TotalLbl.Size = new System.Drawing.Size(147, 23);
            this.c2TotalLbl.TabIndex = 40;
            this.c2TotalLbl.Text = "c2 Total Medals: ";
            this.c2TotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c2RecordsLbl
            // 
            this.c2RecordsLbl.Location = new System.Drawing.Point(804, 157);
            this.c2RecordsLbl.Name = "c2RecordsLbl";
            this.c2RecordsLbl.Size = new System.Drawing.Size(147, 23);
            this.c2RecordsLbl.TabIndex = 39;
            this.c2RecordsLbl.Text = "c2 World Records: ";
            this.c2RecordsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c2SilverLbl
            // 
            this.c2SilverLbl.Location = new System.Drawing.Point(574, 134);
            this.c2SilverLbl.Name = "c2SilverLbl";
            this.c2SilverLbl.Size = new System.Drawing.Size(147, 23);
            this.c2SilverLbl.TabIndex = 38;
            this.c2SilverLbl.Text = "c2 Silver Medals: ";
            this.c2SilverLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c2BronzeLbl
            // 
            this.c2BronzeLbl.Location = new System.Drawing.Point(574, 157);
            this.c2BronzeLbl.Name = "c2BronzeLbl";
            this.c2BronzeLbl.Size = new System.Drawing.Size(147, 23);
            this.c2BronzeLbl.TabIndex = 37;
            this.c2BronzeLbl.Text = "c2 Bronze Medals: ";
            this.c2BronzeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c2GoldLbl
            // 
            this.c2GoldLbl.Location = new System.Drawing.Point(574, 111);
            this.c2GoldLbl.Name = "c2GoldLbl";
            this.c2GoldLbl.Size = new System.Drawing.Size(147, 23);
            this.c2GoldLbl.TabIndex = 36;
            this.c2GoldLbl.Text = "c2 Gold Medals: ";
            this.c2GoldLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // country2Lbl
            // 
            this.country2Lbl.Location = new System.Drawing.Point(574, 83);
            this.country2Lbl.Name = "country2Lbl";
            this.country2Lbl.Size = new System.Drawing.Size(377, 28);
            this.country2Lbl.TabIndex = 35;
            this.country2Lbl.Text = "country2";
            this.country2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compareFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 649);
            this.Controls.Add(this.c2TotalLbl);
            this.Controls.Add(this.c2RecordsLbl);
            this.Controls.Add(this.c2SilverLbl);
            this.Controls.Add(this.c2BronzeLbl);
            this.Controls.Add(this.c2GoldLbl);
            this.Controls.Add(this.country2Lbl);
            this.Controls.Add(this.c1TotalLbl);
            this.Controls.Add(this.c1RecordsLbl);
            this.Controls.Add(this.c1SilverLbl);
            this.Controls.Add(this.c1BronzeLbl);
            this.Controls.Add(this.c1GoldLbl);
            this.Controls.Add(this.country1Lbl);
            this.Controls.Add(this.compareTitleLbl);
            this.Controls.Add(this.compareCountriesLstVw);
            this.Controls.Add(this.selectCountriesGrpBx);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.exitBtn);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "compareFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPT206 Group Project I - Group III: Olympic Analyzer - Compare";
            this.Load += new System.EventHandler(this.compareFrm_Load);
            this.selectCountriesGrpBx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox selectCountriesGrpBx;
        private System.Windows.Forms.ComboBox selectCountry2CmbBx;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.ComboBox selectCountry1CmbBx;
        private System.Windows.Forms.ListView compareCountriesLstVw;
        private System.Windows.Forms.Label compareTitleLbl;
        private System.Windows.Forms.Label country1Lbl;
        private System.Windows.Forms.Label c1GoldLbl;
        private System.Windows.Forms.Label c1BronzeLbl;
        private System.Windows.Forms.Label c1SilverLbl;
        private System.Windows.Forms.Label c1RecordsLbl;
        private System.Windows.Forms.Label c1TotalLbl;
        private System.Windows.Forms.Label c2TotalLbl;
        private System.Windows.Forms.Label c2RecordsLbl;
        private System.Windows.Forms.Label c2SilverLbl;
        private System.Windows.Forms.Label c2BronzeLbl;
        private System.Windows.Forms.Label c2GoldLbl;
        private System.Windows.Forms.Label country2Lbl;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}