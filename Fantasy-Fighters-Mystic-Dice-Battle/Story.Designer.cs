namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    partial class storyFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(storyFrm));
            this.continueBtn = new System.Windows.Forms.Button();
            this.chapterTitleLbl = new System.Windows.Forms.Label();
            this.storyLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.highScoreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.continueBtn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.continueBtn.Location = new System.Drawing.Point(750, 525);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(160, 55);
            this.continueBtn.TabIndex = 0;
            this.continueBtn.Text = "&Continue";
            this.toolTip1.SetToolTip(this.continueBtn, "Click to continue");
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // chapterTitleLbl
            // 
            this.chapterTitleLbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterTitleLbl.Location = new System.Drawing.Point(1, 50);
            this.chapterTitleLbl.Name = "chapterTitleLbl";
            this.chapterTitleLbl.Size = new System.Drawing.Size(981, 38);
            this.chapterTitleLbl.TabIndex = 1;
            this.chapterTitleLbl.Text = "Title";
            this.chapterTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storyLbl
            // 
            this.storyLbl.Location = new System.Drawing.Point(180, 152);
            this.storyLbl.Name = "storyLbl";
            this.storyLbl.Size = new System.Drawing.Size(618, 294);
            this.storyLbl.TabIndex = 2;
            this.storyLbl.Text = "story...";
            // 
            // highScoreLbl
            // 
            this.highScoreLbl.Location = new System.Drawing.Point(416, 476);
            this.highScoreLbl.Name = "highScoreLbl";
            this.highScoreLbl.Size = new System.Drawing.Size(175, 27);
            this.highScoreLbl.TabIndex = 3;
            this.highScoreLbl.Text = "Score = ";
            this.highScoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.highScoreLbl.Visible = false;
            // 
            // storyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.highScoreLbl);
            this.Controls.Add(this.storyLbl);
            this.Controls.Add(this.chapterTitleLbl);
            this.Controls.Add(this.continueBtn);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "storyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daniel Schiefer - Final Project: Fantasy Fighter: Mystic Dice Battle - Story Boar" +
    "d";
            this.Load += new System.EventHandler(this.storyFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Label chapterTitleLbl;
        private System.Windows.Forms.Label storyLbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label highScoreLbl;
    }
}