namespace OlympicAnalyzer
{
    partial class olympicsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(olympicsFrm));
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.olympicDataTitleLbl = new System.Windows.Forms.Label();
            this.selectYearGrpBx = new System.Windows.Forms.GroupBox();
            this.selectYearBtn = new System.Windows.Forms.Button();
            this.yearSelectorCmbBx = new System.Windows.Forms.ComboBox();
            this.olympicDataLstVw = new System.Windows.Forms.ListView();
            this.yearSeasonLbl = new System.Windows.Forms.Label();
            this.hostLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.selectYearGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainMenuBtn.Location = new System.Drawing.Point(437, 536);
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
            this.exitBtn.Location = new System.Drawing.Point(437, 580);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(129, 38);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitBtn, "click to exit the program");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // olympicDataTitleLbl
            // 
            this.olympicDataTitleLbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olympicDataTitleLbl.Location = new System.Drawing.Point(12, 33);
            this.olympicDataTitleLbl.Name = "olympicDataTitleLbl";
            this.olympicDataTitleLbl.Size = new System.Drawing.Size(565, 35);
            this.olympicDataTitleLbl.TabIndex = 16;
            this.olympicDataTitleLbl.Text = "Olympic Data";
            this.olympicDataTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.olympicDataTitleLbl.Visible = false;
            // 
            // selectYearGrpBx
            // 
            this.selectYearGrpBx.Controls.Add(this.selectYearBtn);
            this.selectYearGrpBx.Controls.Add(this.yearSelectorCmbBx);
            this.selectYearGrpBx.Location = new System.Drawing.Point(45, 498);
            this.selectYearGrpBx.Name = "selectYearGrpBx";
            this.selectYearGrpBx.Size = new System.Drawing.Size(264, 120);
            this.selectYearGrpBx.TabIndex = 0;
            this.selectYearGrpBx.TabStop = false;
            this.selectYearGrpBx.Text = "Select Year To View Olympic Data:";
            // 
            // selectYearBtn
            // 
            this.selectYearBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.selectYearBtn.Location = new System.Drawing.Point(71, 65);
            this.selectYearBtn.Name = "selectYearBtn";
            this.selectYearBtn.Size = new System.Drawing.Size(129, 38);
            this.selectYearBtn.TabIndex = 1;
            this.selectYearBtn.Text = "Select &Year";
            this.toolTip1.SetToolTip(this.selectYearBtn, "select a year from the above drop down box and click here to view specific olympi" +
        "c data");
            this.selectYearBtn.UseVisualStyleBackColor = true;
            this.selectYearBtn.Click += new System.EventHandler(this.selectYearBtn_Click);
            // 
            // yearSelectorCmbBx
            // 
            this.yearSelectorCmbBx.FormattingEnabled = true;
            this.yearSelectorCmbBx.Location = new System.Drawing.Point(25, 33);
            this.yearSelectorCmbBx.Name = "yearSelectorCmbBx";
            this.yearSelectorCmbBx.Size = new System.Drawing.Size(207, 26);
            this.yearSelectorCmbBx.TabIndex = 0;
            // 
            // olympicDataLstVw
            // 
            this.olympicDataLstVw.GridLines = true;
            this.olympicDataLstVw.HideSelection = false;
            this.olympicDataLstVw.Location = new System.Drawing.Point(16, 171);
            this.olympicDataLstVw.Name = "olympicDataLstVw";
            this.olympicDataLstVw.Size = new System.Drawing.Size(561, 299);
            this.olympicDataLstVw.TabIndex = 18;
            this.olympicDataLstVw.TabStop = false;
            this.olympicDataLstVw.UseCompatibleStateImageBehavior = false;
            this.olympicDataLstVw.View = System.Windows.Forms.View.Details;
            // 
            // yearSeasonLbl
            // 
            this.yearSeasonLbl.Location = new System.Drawing.Point(16, 85);
            this.yearSeasonLbl.Name = "yearSeasonLbl";
            this.yearSeasonLbl.Size = new System.Drawing.Size(561, 32);
            this.yearSeasonLbl.TabIndex = 19;
            this.yearSeasonLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hostLbl
            // 
            this.hostLbl.Location = new System.Drawing.Point(16, 117);
            this.hostLbl.Name = "hostLbl";
            this.hostLbl.Size = new System.Drawing.Size(561, 32);
            this.hostLbl.TabIndex = 20;
            this.hostLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetBtn
            // 
            this.resetBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetBtn.Location = new System.Drawing.Point(437, 492);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(129, 38);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "&Reset Form";
            this.toolTip1.SetToolTip(this.resetBtn, "click to reset the form");
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // olympicsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 641);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.hostLbl);
            this.Controls.Add(this.yearSeasonLbl);
            this.Controls.Add(this.olympicDataLstVw);
            this.Controls.Add(this.selectYearGrpBx);
            this.Controls.Add(this.olympicDataTitleLbl);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.exitBtn);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "olympicsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPT206 Group Project I - Group III: Olympic Analyzer - Olympics";
            this.Load += new System.EventHandler(this.olympicsFrm_Load);
            this.selectYearGrpBx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label olympicDataTitleLbl;
        private System.Windows.Forms.GroupBox selectYearGrpBx;
        private System.Windows.Forms.Button selectYearBtn;
        private System.Windows.Forms.ComboBox yearSelectorCmbBx;
        private System.Windows.Forms.ListView olympicDataLstVw;
        private System.Windows.Forms.Label yearSeasonLbl;
        private System.Windows.Forms.Label hostLbl;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}