namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    partial class highScoresFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(highScoresFrm));
            this.exitBtn = new System.Windows.Forms.Button();
            this.instructionsBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.highScoresLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.highScoresLstVw = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBtn.Location = new System.Drawing.Point(750, 525);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(160, 55);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitBtn, "Click to exit the game");
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // instructionsBtn
            // 
            this.instructionsBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.instructionsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructionsBtn.Location = new System.Drawing.Point(525, 525);
            this.instructionsBtn.Name = "instructionsBtn";
            this.instructionsBtn.Size = new System.Drawing.Size(160, 55);
            this.instructionsBtn.TabIndex = 2;
            this.instructionsBtn.Text = "&Instructions";
            this.toolTip1.SetToolTip(this.instructionsBtn, "Click to view game instructions");
            this.instructionsBtn.UseVisualStyleBackColor = false;
            this.instructionsBtn.Click += new System.EventHandler(this.instructionsBtn_Click);
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mainMenuBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainMenuBtn.Location = new System.Drawing.Point(300, 525);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(160, 55);
            this.mainMenuBtn.TabIndex = 1;
            this.mainMenuBtn.Text = "&Main Menu";
            this.toolTip1.SetToolTip(this.mainMenuBtn, "Click to return to the main menu");
            this.mainMenuBtn.UseVisualStyleBackColor = false;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // newGameBtn
            // 
            this.newGameBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.newGameBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newGameBtn.Location = new System.Drawing.Point(75, 525);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(160, 55);
            this.newGameBtn.TabIndex = 0;
            this.newGameBtn.Text = "&New Game";
            this.toolTip1.SetToolTip(this.newGameBtn, "Click to start new game");
            this.newGameBtn.UseVisualStyleBackColor = false;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // highScoresLbl
            // 
            this.highScoresLbl.AutoSize = true;
            this.highScoresLbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoresLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.highScoresLbl.Location = new System.Drawing.Point(438, 50);
            this.highScoresLbl.Name = "highScoresLbl";
            this.highScoresLbl.Size = new System.Drawing.Size(161, 28);
            this.highScoresLbl.TabIndex = 13;
            this.highScoresLbl.Text = "High Scores";
            // 
            // highScoresLstVw
            // 
            this.highScoresLstVw.HideSelection = false;
            this.highScoresLstVw.Location = new System.Drawing.Point(347, 137);
            this.highScoresLstVw.Name = "highScoresLstVw";
            this.highScoresLstVw.Size = new System.Drawing.Size(295, 254);
            this.highScoresLstVw.TabIndex = 14;
            this.highScoresLstVw.UseCompatibleStateImageBehavior = false;
            this.highScoresLstVw.View = System.Windows.Forms.View.Details;
            // 
            // highScoresFrm
            // 
            this.AcceptButton = this.newGameBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.highScoresLstVw);
            this.Controls.Add(this.highScoresLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.instructionsBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.newGameBtn);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "highScoresFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daniel Schiefer - Final Project: Fantasy Fighter: Mystic Dice Battle - High Score" +
    "s";
            this.Load += new System.EventHandler(this.highScoresFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button instructionsBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Label highScoresLbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView highScoresLstVw;
    }
}