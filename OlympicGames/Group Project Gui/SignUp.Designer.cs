namespace Group_Project_Gui
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.btnGenRandom = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtbPass = new System.Windows.Forms.TextBox();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.Controls.Add(this.btnGenRandom);
            this.pnlSignUp.Controls.Add(this.btnExit);
            this.pnlSignUp.Controls.Add(this.txtbEmail);
            this.pnlSignUp.Controls.Add(this.lblEmail);
            this.pnlSignUp.Controls.Add(this.btnSignUp);
            this.pnlSignUp.Controls.Add(this.btnBack);
            this.pnlSignUp.Controls.Add(this.txtbPass);
            this.pnlSignUp.Controls.Add(this.txtbUsername);
            this.pnlSignUp.Controls.Add(this.lblPassword);
            this.pnlSignUp.Controls.Add(this.lblUserName);
            this.pnlSignUp.Location = new System.Drawing.Point(49, 191);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(287, 316);
            this.pnlSignUp.TabIndex = 0;
            // 
            // btnGenRandom
            // 
            this.btnGenRandom.Location = new System.Drawing.Point(164, 244);
            this.btnGenRandom.Name = "btnGenRandom";
            this.btnGenRandom.Size = new System.Drawing.Size(97, 66);
            this.btnGenRandom.TabIndex = 4;
            this.btnGenRandom.Text = "Generate Random";
            this.toolTip1.SetToolTip(this.btnGenRandom, "click to generate password");
            this.btnGenRandom.UseVisualStyleBackColor = true;
            this.btnGenRandom.Click += new System.EventHandler(this.btnGenRandom_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(28, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 29);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "click to exit the program");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtbEmail
            // 
            this.txtbEmail.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.txtbEmail.Location = new System.Drawing.Point(123, 158);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(138, 33);
            this.txtbEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 162);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 29);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(164, 209);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(97, 29);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign Up";
            this.toolTip1.SetToolTip(this.btnSignUp, "click to signup");
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 209);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(97, 66);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to Log In";
            this.toolTip1.SetToolTip(this.btnBack, "click to return to login screen");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtbPass
            // 
            this.txtbPass.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.txtbPass.Location = new System.Drawing.Point(123, 89);
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.Size = new System.Drawing.Size(138, 33);
            this.txtbPass.TabIndex = 1;
            // 
            // txtbUsername
            // 
            this.txtbUsername.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.txtbUsername.Location = new System.Drawing.Point(123, 21);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(138, 33);
            this.txtbUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(23, 93);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 29);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(23, 25);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(94, 29);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "Username:";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(385, 519);
            this.Controls.Add(this.pnlSignUp);
            this.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGenRandom;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}