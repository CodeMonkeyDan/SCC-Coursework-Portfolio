namespace D_Schiefer_CPT244_Final_Project_NFL_Team_Stats
{
    partial class playoffStatComparisonFrm
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
            this.playoffStatTitleLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.saveTeamComparisonBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.yearListBoxLbl = new System.Windows.Forms.Label();
            this.yearLstBx = new System.Windows.Forms.ComboBox();
            this.playoffStatCompLstVw = new System.Windows.Forms.ListView();
            this.sbwLbl = new System.Windows.Forms.Label();
            this.sbwPicBx = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sbwPicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // playoffStatTitleLbl
            // 
            this.playoffStatTitleLbl.AutoSize = true;
            this.playoffStatTitleLbl.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playoffStatTitleLbl.Location = new System.Drawing.Point(272, 40);
            this.playoffStatTitleLbl.Name = "playoffStatTitleLbl";
            this.playoffStatTitleLbl.Size = new System.Drawing.Size(247, 22);
            this.playoffStatTitleLbl.TabIndex = 20;
            this.playoffStatTitleLbl.Text = "Playoff Stat Comparison";
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(550, 400);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(122, 45);
            this.exitBtn.TabIndex = 4;
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
            this.mainMenuBtn.TabIndex = 3;
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
            this.saveTeamComparisonBtn.TabIndex = 2;
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
            this.displayBtn.TabIndex = 1;
            this.displayBtn.Text = "&Display Comparison";
            this.toolTip1.SetToolTip(this.displayBtn, "Click to display the selected stat comparison");
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // yearListBoxLbl
            // 
            this.yearListBoxLbl.AutoSize = true;
            this.yearListBoxLbl.Location = new System.Drawing.Point(203, 96);
            this.yearListBoxLbl.Name = "yearListBoxLbl";
            this.yearListBoxLbl.Size = new System.Drawing.Size(42, 18);
            this.yearListBoxLbl.TabIndex = 26;
            this.yearListBoxLbl.Text = "Year:";
            this.yearListBoxLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearLstBx
            // 
            this.yearLstBx.FormattingEnabled = true;
            this.yearLstBx.Location = new System.Drawing.Point(251, 93);
            this.yearLstBx.Name = "yearLstBx";
            this.yearLstBx.Size = new System.Drawing.Size(121, 26);
            this.yearLstBx.TabIndex = 0;
            // 
            // playoffStatCompLstVw
            // 
            this.playoffStatCompLstVw.HideSelection = false;
            this.playoffStatCompLstVw.Location = new System.Drawing.Point(12, 145);
            this.playoffStatCompLstVw.Name = "playoffStatCompLstVw";
            this.playoffStatCompLstVw.Size = new System.Drawing.Size(760, 213);
            this.playoffStatCompLstVw.TabIndex = 27;
            this.playoffStatCompLstVw.TabStop = false;
            this.playoffStatCompLstVw.UseCompatibleStateImageBehavior = false;
            this.playoffStatCompLstVw.View = System.Windows.Forms.View.Details;
            // 
            // sbwLbl
            // 
            this.sbwLbl.AutoSize = true;
            this.sbwLbl.Location = new System.Drawing.Point(431, 96);
            this.sbwLbl.Name = "sbwLbl";
            this.sbwLbl.Size = new System.Drawing.Size(158, 18);
            this.sbwLbl.TabIndex = 28;
            this.sbwLbl.Text = "Superbowl Champions:";
            this.sbwLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sbwLbl.Visible = false;
            // 
            // sbwPicBx
            // 
            this.sbwPicBx.Location = new System.Drawing.Point(595, 64);
            this.sbwPicBx.Name = "sbwPicBx";
            this.sbwPicBx.Size = new System.Drawing.Size(81, 55);
            this.sbwPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sbwPicBx.TabIndex = 29;
            this.sbwPicBx.TabStop = false;
            // 
            // playoffStatComparisonFrm
            // 
            this.AcceptButton = this.displayBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.sbwPicBx);
            this.Controls.Add(this.sbwLbl);
            this.Controls.Add(this.playoffStatCompLstVw);
            this.Controls.Add(this.yearListBoxLbl);
            this.Controls.Add(this.yearLstBx);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.saveTeamComparisonBtn);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.playoffStatTitleLbl);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "playoffStatComparisonFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daniel Schiefer - CPT244 Final Project: NFL Team Stat Analyzer - Playoff Stat Com" +
    "parison";
            this.Load += new System.EventHandler(this.playoffStatComparisonFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sbwPicBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playoffStatTitleLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button saveTeamComparisonBtn;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Label yearListBoxLbl;
        private System.Windows.Forms.ComboBox yearLstBx;
        private System.Windows.Forms.ListView playoffStatCompLstVw;
        private System.Windows.Forms.Label sbwLbl;
        private System.Windows.Forms.PictureBox sbwPicBx;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}