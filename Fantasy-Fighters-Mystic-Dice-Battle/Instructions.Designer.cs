namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    partial class instructionsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instructionsFrm));
            this.exitBtn = new System.Windows.Forms.Button();
            this.highScoresBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.instructionsLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.instrctionsTxtBx = new System.Windows.Forms.TextBox();
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
            // highScoresBtn
            // 
            this.highScoresBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.highScoresBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.highScoresBtn.Location = new System.Drawing.Point(525, 525);
            this.highScoresBtn.Name = "highScoresBtn";
            this.highScoresBtn.Size = new System.Drawing.Size(160, 55);
            this.highScoresBtn.TabIndex = 2;
            this.highScoresBtn.Text = "&High Scores";
            this.toolTip1.SetToolTip(this.highScoresBtn, "Click to view high scores");
            this.highScoresBtn.UseVisualStyleBackColor = false;
            this.highScoresBtn.Click += new System.EventHandler(this.highScoresBtn_Click);
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
            // instructionsLbl
            // 
            this.instructionsLbl.AutoSize = true;
            this.instructionsLbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructionsLbl.Location = new System.Drawing.Point(283, 50);
            this.instructionsLbl.Name = "instructionsLbl";
            this.instructionsLbl.Size = new System.Drawing.Size(425, 19);
            this.instructionsLbl.TabIndex = 9;
            this.instructionsLbl.Text = "Fantasy Fighters: Mystic Dice Battle - How to Play";
            // 
            // instrctionsTxtBx
            // 
            this.instrctionsTxtBx.Location = new System.Drawing.Point(180, 99);
            this.instrctionsTxtBx.Multiline = true;
            this.instrctionsTxtBx.Name = "instrctionsTxtBx";
            this.instrctionsTxtBx.ReadOnly = true;
            this.instrctionsTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.instrctionsTxtBx.Size = new System.Drawing.Size(633, 372);
            this.instrctionsTxtBx.TabIndex = 10;
            // 
            // instructionsFrm
            // 
            this.AcceptButton = this.newGameBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.instrctionsTxtBx);
            this.Controls.Add(this.instructionsLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.highScoresBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.newGameBtn);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "instructionsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daniel Schiefer - Final Project: Fantasy Fighter: Mystic Dice Battle - Instructio" +
    "ns";
            this.Load += new System.EventHandler(this.instructionsFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button highScoresBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Label instructionsLbl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox instrctionsTxtBx;
    }
}