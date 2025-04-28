namespace Group_Project_Gui
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.pnlForgor = new System.Windows.Forms.Panel();
            this.btnGenRan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbPass = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblForgor = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlForgor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForgor
            // 
            this.pnlForgor.Controls.Add(this.btnGenRan);
            this.pnlForgor.Controls.Add(this.button1);
            this.pnlForgor.Controls.Add(this.txtbPass);
            this.pnlForgor.Controls.Add(this.btnSubmit);
            this.pnlForgor.Controls.Add(this.btnReturn);
            this.pnlForgor.Controls.Add(this.txtbEmail);
            this.pnlForgor.Controls.Add(this.lblEmail);
            this.pnlForgor.Controls.Add(this.lblPassword);
            this.pnlForgor.Location = new System.Drawing.Point(14, 139);
            this.pnlForgor.Name = "pnlForgor";
            this.pnlForgor.Size = new System.Drawing.Size(310, 272);
            this.pnlForgor.TabIndex = 0;
            // 
            // btnGenRan
            // 
            this.btnGenRan.Location = new System.Drawing.Point(8, 162);
            this.btnGenRan.Name = "btnGenRan";
            this.btnGenRan.Size = new System.Drawing.Size(103, 76);
            this.btnGenRan.TabIndex = 3;
            this.btnGenRan.Text = "Generate Random";
            this.toolTip1.SetToolTip(this.btnGenRan, "click to generate password");
            this.btnGenRan.UseVisualStyleBackColor = true;
            this.btnGenRan.Click += new System.EventHandler(this.btnGenRan_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(117, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.toolTip1.SetToolTip(this.button1, "click to exit the program");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbPass
            // 
            this.txtbPass.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.txtbPass.Location = new System.Drawing.Point(153, 96);
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.Size = new System.Drawing.Size(138, 33);
            this.txtbPass.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Location = new System.Drawing.Point(213, 213);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(78, 39);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.toolTip1.SetToolTip(this.btnSubmit, "click to submit new password");
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.Location = new System.Drawing.Point(131, 152);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(145, 39);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return to Log In";
            this.toolTip1.SetToolTip(this.btnReturn, "click to return to login screen");
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtbEmail
            // 
            this.txtbEmail.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.txtbEmail.Location = new System.Drawing.Point(153, 18);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(138, 33);
            this.txtbEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(82, 22);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 29);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(14, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(128, 29);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "New Password:";
            // 
            // lblForgor
            // 
            this.lblForgor.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgor.Location = new System.Drawing.Point(79, 9);
            this.lblForgor.Name = "lblForgor";
            this.lblForgor.Size = new System.Drawing.Size(172, 101);
            this.lblForgor.TabIndex = 1;
            this.lblForgor.Text = "Forgot Password?";
            this.lblForgor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 465);
            this.Controls.Add(this.lblForgor);
            this.Controls.Add(this.pnlForgor);
            this.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "ForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPass";
            this.Load += new System.EventHandler(this.ForgotPass_Load);
            this.pnlForgor.ResumeLayout(false);
            this.pnlForgor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForgor;
        private System.Windows.Forms.Label lblForgor;
        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenRan;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}