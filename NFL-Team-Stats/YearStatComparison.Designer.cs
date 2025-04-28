namespace D_Schiefer_CPT244_Final_Project_NFL_Team_Stats
{
    partial class yearStatComparisonFrm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.saveTeamComparisonBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.yearlyStatTitleLbl = new System.Windows.Forms.Label();
            this.statListBoxLbl = new System.Windows.Forms.Label();
            this.statLstBx = new System.Windows.Forms.ComboBox();
            this.yearListBoxLbl = new System.Windows.Forms.Label();
            this.yearLstBx = new System.Windows.Forms.ComboBox();
            this.yearStatCompLstVw = new System.Windows.Forms.ListView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(550, 400);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(122, 45);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "E&xit Program";
            this.toolTip1.SetToolTip(this.exitBtn, "Click to exit the program");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Location = new System.Drawing.Point(400, 400);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(122, 45);
            this.mainMenuBtn.TabIndex = 4;
            this.mainMenuBtn.Text = "  Return to     &Main Menu";
            this.toolTip1.SetToolTip(this.mainMenuBtn, "Click to return to the main menu");
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // saveTeamComparisonBtn
            // 
            this.saveTeamComparisonBtn.Location = new System.Drawing.Point(250, 400);
            this.saveTeamComparisonBtn.Name = "saveTeamComparisonBtn";
            this.saveTeamComparisonBtn.Size = new System.Drawing.Size(122, 45);
            this.saveTeamComparisonBtn.TabIndex = 3;
            this.saveTeamComparisonBtn.Text = "&Save Comparison";
            this.toolTip1.SetToolTip(this.saveTeamComparisonBtn, "Click to save stat comparison to a text file");
            this.saveTeamComparisonBtn.UseVisualStyleBackColor = true;
            this.saveTeamComparisonBtn.Click += new System.EventHandler(this.saveTeamComparisonBtn_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(100, 400);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(122, 45);
            this.displayBtn.TabIndex = 2;
            this.displayBtn.Text = "&Display Comparison";
            this.toolTip1.SetToolTip(this.displayBtn, "Click to display the selected stat comparison");
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // yearlyStatTitleLbl
            // 
            this.yearlyStatTitleLbl.AutoSize = true;
            this.yearlyStatTitleLbl.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyStatTitleLbl.Location = new System.Drawing.Point(271, 40);
            this.yearlyStatTitleLbl.Name = "yearlyStatTitleLbl";
            this.yearlyStatTitleLbl.Size = new System.Drawing.Size(241, 22);
            this.yearlyStatTitleLbl.TabIndex = 19;
            this.yearlyStatTitleLbl.Text = "Yearly Stat Comparison";
            // 
            // statListBoxLbl
            // 
            this.statListBoxLbl.AutoSize = true;
            this.statListBoxLbl.Location = new System.Drawing.Point(409, 99);
            this.statListBoxLbl.Name = "statListBoxLbl";
            this.statListBoxLbl.Size = new System.Drawing.Size(39, 18);
            this.statListBoxLbl.TabIndex = 23;
            this.statListBoxLbl.Text = "Stat:";
            this.statListBoxLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statLstBx
            // 
            this.statLstBx.FormattingEnabled = true;
            this.statLstBx.Items.AddRange(new object[] {
            "Records",
            "Points",
            "Total Offense",
            "Passing",
            "Rushing",
            "Turnovers",
            "Attendance"});
            this.statLstBx.Location = new System.Drawing.Point(454, 96);
            this.statLstBx.Name = "statLstBx";
            this.statLstBx.Size = new System.Drawing.Size(121, 26);
            this.statLstBx.TabIndex = 1;
            // 
            // yearListBoxLbl
            // 
            this.yearListBoxLbl.AutoSize = true;
            this.yearListBoxLbl.Location = new System.Drawing.Point(189, 96);
            this.yearListBoxLbl.Name = "yearListBoxLbl";
            this.yearListBoxLbl.Size = new System.Drawing.Size(42, 18);
            this.yearListBoxLbl.TabIndex = 21;
            this.yearListBoxLbl.Text = "Year:";
            this.yearListBoxLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearLstBx
            // 
            this.yearLstBx.FormattingEnabled = true;
            this.yearLstBx.Location = new System.Drawing.Point(237, 93);
            this.yearLstBx.Name = "yearLstBx";
            this.yearLstBx.Size = new System.Drawing.Size(121, 26);
            this.yearLstBx.TabIndex = 0;
            // 
            // yearStatCompLstVw
            // 
            this.yearStatCompLstVw.HideSelection = false;
            this.yearStatCompLstVw.Location = new System.Drawing.Point(12, 145);
            this.yearStatCompLstVw.Name = "yearStatCompLstVw";
            this.yearStatCompLstVw.Size = new System.Drawing.Size(760, 213);
            this.yearStatCompLstVw.TabIndex = 24;
            this.yearStatCompLstVw.TabStop = false;
            this.yearStatCompLstVw.UseCompatibleStateImageBehavior = false;
            this.yearStatCompLstVw.View = System.Windows.Forms.View.Details;
            // 
            // yearStatComparisonFrm
            // 
            this.AcceptButton = this.displayBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.yearStatCompLstVw);
            this.Controls.Add(this.statListBoxLbl);
            this.Controls.Add(this.statLstBx);
            this.Controls.Add(this.yearListBoxLbl);
            this.Controls.Add(this.yearLstBx);
            this.Controls.Add(this.yearlyStatTitleLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.saveTeamComparisonBtn);
            this.Controls.Add(this.displayBtn);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "yearStatComparisonFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daniel Schiefer - CPT244 Final Project: NFL Team Stat Analyzer - Yearly Stat Comp" +
    "arison";
            this.Load += new System.EventHandler(this.yearStatComparisonFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button saveTeamComparisonBtn;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Label yearlyStatTitleLbl;
        private System.Windows.Forms.Label statListBoxLbl;
        private System.Windows.Forms.ComboBox statLstBx;
        private System.Windows.Forms.Label yearListBoxLbl;
        private System.Windows.Forms.ComboBox yearLstBx;
        private System.Windows.Forms.ListView yearStatCompLstVw;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}