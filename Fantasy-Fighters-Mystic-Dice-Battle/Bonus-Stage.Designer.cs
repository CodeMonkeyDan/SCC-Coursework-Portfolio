namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    partial class bonusStageFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bonusStageFrm));
            this.continueBtn = new System.Windows.Forms.Button();
            this.bonusStageTitleLbl = new System.Windows.Forms.Label();
            this.findingsLbl = new System.Windows.Forms.Label();
            this.treasureBoxPicBx = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treasureBoxPicBx)).BeginInit();
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
            this.continueBtn.TabIndex = 1;
            this.continueBtn.Text = "&Continue";
            this.toolTip1.SetToolTip(this.continueBtn, "Click to continue");
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // bonusStageTitleLbl
            // 
            this.bonusStageTitleLbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusStageTitleLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bonusStageTitleLbl.Location = new System.Drawing.Point(1, 50);
            this.bonusStageTitleLbl.Name = "bonusStageTitleLbl";
            this.bonusStageTitleLbl.Size = new System.Drawing.Size(981, 38);
            this.bonusStageTitleLbl.TabIndex = 2;
            this.bonusStageTitleLbl.Text = "Title";
            this.bonusStageTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findingsLbl
            // 
            this.findingsLbl.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findingsLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.findingsLbl.Location = new System.Drawing.Point(1, 415);
            this.findingsLbl.Name = "findingsLbl";
            this.findingsLbl.Size = new System.Drawing.Size(981, 38);
            this.findingsLbl.TabIndex = 4;
            this.findingsLbl.Text = "words...";
            this.findingsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // treasureBoxPicBx
            // 
            this.treasureBoxPicBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.treasureBoxPicBx.Location = new System.Drawing.Point(300, 139);
            this.treasureBoxPicBx.Name = "treasureBoxPicBx";
            this.treasureBoxPicBx.Size = new System.Drawing.Size(394, 237);
            this.treasureBoxPicBx.TabIndex = 3;
            this.treasureBoxPicBx.TabStop = false;
            // 
            // bonusStageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.findingsLbl);
            this.Controls.Add(this.treasureBoxPicBx);
            this.Controls.Add(this.bonusStageTitleLbl);
            this.Controls.Add(this.continueBtn);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bonusStageFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daniel Schiefer - Final Project: Fantasy Fighter: Mystic Dice Battle - Bonus Stag" +
    "e";
            this.Load += new System.EventHandler(this.bonusStageFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treasureBoxPicBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Label bonusStageTitleLbl;
        private System.Windows.Forms.PictureBox treasureBoxPicBx;
        private System.Windows.Forms.Label findingsLbl;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}