namespace D_Schiefer_Final_Project_Fantasy_Fighters_Mystic_Dice_Battle
{
    partial class userNameFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userNameFrm));
            this.userNameTxtBx = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // userNameTxtBx
            // 
            this.userNameTxtBx.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxtBx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userNameTxtBx.Location = new System.Drawing.Point(98, 76);
            this.userNameTxtBx.Name = "userNameTxtBx";
            this.userNameTxtBx.Size = new System.Drawing.Size(240, 30);
            this.userNameTxtBx.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.okBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.okBtn.Location = new System.Drawing.Point(54, 132);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(111, 39);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "&Ok";
            this.toolTip1.SetToolTip(this.okBtn, "Click to proceed to the game");
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelBtn.Location = new System.Drawing.Point(261, 132);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(111, 39);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "&Cancel";
            this.toolTip1.SetToolTip(this.cancelBtn, "Click to return to the main menu");
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userNameLbl.Location = new System.Drawing.Point(155, 41);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(181, 23);
            this.userNameLbl.TabIndex = 3;
            this.userNameLbl.Text = "Enter your name:";
            // 
            // userNameFrm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(430, 203);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.userNameTxtBx);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "userNameFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daniel Schiefer - Final Project: Fantasy Fighter: Mystic Dice Battle - Enter User" +
    " Name";
            this.Load += new System.EventHandler(this.userNameFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTxtBx;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}