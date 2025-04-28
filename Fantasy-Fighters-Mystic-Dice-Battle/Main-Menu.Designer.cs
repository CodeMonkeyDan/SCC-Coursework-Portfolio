namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenuFrm));
            this.newGameBtn = new System.Windows.Forms.Button();
            this.instructionsBtn = new System.Windows.Forms.Button();
            this.highScoresBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.titleScreenPicBx = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.titleScreenPicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameBtn
            // 
            this.newGameBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.newGameBtn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // instructionsBtn
            // 
            this.instructionsBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.instructionsBtn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instructionsBtn.Location = new System.Drawing.Point(300, 525);
            this.instructionsBtn.Name = "instructionsBtn";
            this.instructionsBtn.Size = new System.Drawing.Size(160, 55);
            this.instructionsBtn.TabIndex = 1;
            this.instructionsBtn.Text = "&Instructions";
            this.toolTip1.SetToolTip(this.instructionsBtn, "Click to view game instructions");
            this.instructionsBtn.UseVisualStyleBackColor = false;
            this.instructionsBtn.Click += new System.EventHandler(this.instructionsBtn_Click);
            // 
            // highScoresBtn
            // 
            this.highScoresBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.highScoresBtn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // titleScreenPicBx
            // 
            this.titleScreenPicBx.BackgroundImage = global::D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle.Properties.Resources.TitleScreen;
            this.titleScreenPicBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleScreenPicBx.Location = new System.Drawing.Point(-10, -2);
            this.titleScreenPicBx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.titleScreenPicBx.Name = "titleScreenPicBx";
            this.titleScreenPicBx.Size = new System.Drawing.Size(1037, 508);
            this.titleScreenPicBx.TabIndex = 0;
            this.titleScreenPicBx.TabStop = false;
            // 
            // mainMenuFrm
            // 
            this.AcceptButton = this.newGameBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.highScoresBtn);
            this.Controls.Add(this.instructionsBtn);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.titleScreenPicBx);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mainMenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daniel Schiefer - Final Project: Fantasy Fighter: Mystic Dice Battle - Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.titleScreenPicBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox titleScreenPicBx;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button instructionsBtn;
        private System.Windows.Forms.Button highScoresBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

