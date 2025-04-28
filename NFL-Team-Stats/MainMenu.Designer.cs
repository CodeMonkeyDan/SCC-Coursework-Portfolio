namespace D_Schiefer_CPT244_Final_Project_NFL_Team_Stats
{
    partial class mainMenuFrm
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
            this.mainMenuTitleLbl = new System.Windows.Forms.Label();
            this.mainMenuAuthorLbl = new System.Windows.Forms.Label();
            this.teamStatsBtn = new System.Windows.Forms.Button();
            this.nflStatsBtn = new System.Windows.Forms.Button();
            this.playoffStatsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.nflLogoPicBx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nflLogoPicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuTitleLbl
            // 
            this.mainMenuTitleLbl.AutoSize = true;
            this.mainMenuTitleLbl.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuTitleLbl.Location = new System.Drawing.Point(283, 70);
            this.mainMenuTitleLbl.Name = "mainMenuTitleLbl";
            this.mainMenuTitleLbl.Size = new System.Drawing.Size(250, 22);
            this.mainMenuTitleLbl.TabIndex = 1;
            this.mainMenuTitleLbl.Text = "NFL Team Stat Analyzer";
            // 
            // mainMenuAuthorLbl
            // 
            this.mainMenuAuthorLbl.AutoSize = true;
            this.mainMenuAuthorLbl.Location = new System.Drawing.Point(284, 92);
            this.mainMenuAuthorLbl.Name = "mainMenuAuthorLbl";
            this.mainMenuAuthorLbl.Size = new System.Drawing.Size(134, 18);
            this.mainMenuAuthorLbl.TabIndex = 2;
            this.mainMenuAuthorLbl.Text = "by: Daniel Schiefer";
            // 
            // teamStatsBtn
            // 
            this.teamStatsBtn.Location = new System.Drawing.Point(100, 400);
            this.teamStatsBtn.Name = "teamStatsBtn";
            this.teamStatsBtn.Size = new System.Drawing.Size(122, 45);
            this.teamStatsBtn.TabIndex = 0;
            this.teamStatsBtn.Text = "   &Team Stats    by Year";
            this.toolTip1.SetToolTip(this.teamStatsBtn, "Compare stats between any two teams from 2003-2019");
            this.teamStatsBtn.UseVisualStyleBackColor = true;
            this.teamStatsBtn.Click += new System.EventHandler(this.teamStatsBtn_Click);
            // 
            // nflStatsBtn
            // 
            this.nflStatsBtn.Location = new System.Drawing.Point(250, 400);
            this.nflStatsBtn.Name = "nflStatsBtn";
            this.nflStatsBtn.Size = new System.Drawing.Size(122, 45);
            this.nflStatsBtn.TabIndex = 1;
            this.nflStatsBtn.Text = "    &NFL Stats      by Year";
            this.toolTip1.SetToolTip(this.nflStatsBtn, "Compare a list of stats between all 32 teams for a given year");
            this.nflStatsBtn.UseVisualStyleBackColor = true;
            this.nflStatsBtn.Click += new System.EventHandler(this.nflStatsBtn_Click);
            // 
            // playoffStatsBtn
            // 
            this.playoffStatsBtn.Location = new System.Drawing.Point(400, 400);
            this.playoffStatsBtn.Name = "playoffStatsBtn";
            this.playoffStatsBtn.Size = new System.Drawing.Size(122, 45);
            this.playoffStatsBtn.TabIndex = 2;
            this.playoffStatsBtn.Text = "  &Playoff Stats     by Year";
            this.toolTip1.SetToolTip(this.playoffStatsBtn, "Compare teams stats for all playoff teams for a given year");
            this.playoffStatsBtn.UseVisualStyleBackColor = true;
            this.playoffStatsBtn.Click += new System.EventHandler(this.playoffStatsBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(550, 400);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(122, 45);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "E&xit Program";
            this.toolTip1.SetToolTip(this.exitBtn, "Click to exit the program");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // nflLogoPicBx
            // 
            this.nflLogoPicBx.Image = global::D_Schiefer_CPT244_Final_Project_NFL_Team_Stats.Properties.Resources.NFL_Shield_NoBackground;
            this.nflLogoPicBx.Location = new System.Drawing.Point(231, 65);
            this.nflLogoPicBx.Name = "nflLogoPicBx";
            this.nflLogoPicBx.Size = new System.Drawing.Size(50, 50);
            this.nflLogoPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nflLogoPicBx.TabIndex = 0;
            this.nflLogoPicBx.TabStop = false;
            // 
            // mainMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.playoffStatsBtn);
            this.Controls.Add(this.nflStatsBtn);
            this.Controls.Add(this.teamStatsBtn);
            this.Controls.Add(this.mainMenuAuthorLbl);
            this.Controls.Add(this.mainMenuTitleLbl);
            this.Controls.Add(this.nflLogoPicBx);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainMenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daniel Schiefer - CPT244 Final Project: NFL Team Stat Analyzer - Main Menu";
            this.Load += new System.EventHandler(this.mainMenuFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nflLogoPicBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox nflLogoPicBx;
        private System.Windows.Forms.Label mainMenuTitleLbl;
        private System.Windows.Forms.Label mainMenuAuthorLbl;
        private System.Windows.Forms.Button teamStatsBtn;
        private System.Windows.Forms.Button nflStatsBtn;
        private System.Windows.Forms.Button playoffStatsBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

