namespace OlympicAnalyzer
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
            this.worldRecordsBtn = new System.Windows.Forms.Button();
            this.olympicsBtn = new System.Windows.Forms.Button();
            this.totalMedalsBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.compareBtn = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // worldRecordsBtn
            // 
            this.worldRecordsBtn.Location = new System.Drawing.Point(424, 18);
            this.worldRecordsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.worldRecordsBtn.Name = "worldRecordsBtn";
            this.worldRecordsBtn.Size = new System.Drawing.Size(161, 61);
            this.worldRecordsBtn.TabIndex = 2;
            this.worldRecordsBtn.Text = "World &Records";
            this.toolTip1.SetToolTip(this.worldRecordsBtn, "click to view a list of world records");
            this.worldRecordsBtn.UseVisualStyleBackColor = true;
            this.worldRecordsBtn.Click += new System.EventHandler(this.worldRecordBtn_Click);
            // 
            // olympicsBtn
            // 
            this.olympicsBtn.Location = new System.Drawing.Point(20, 18);
            this.olympicsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.olympicsBtn.Name = "olympicsBtn";
            this.olympicsBtn.Size = new System.Drawing.Size(161, 61);
            this.olympicsBtn.TabIndex = 0;
            this.olympicsBtn.Text = "&Olympics";
            this.toolTip1.SetToolTip(this.olympicsBtn, "click to view olympic data by year");
            this.olympicsBtn.UseVisualStyleBackColor = true;
            this.olympicsBtn.Click += new System.EventHandler(this.olympicsBtn_Click);
            // 
            // totalMedalsBtn
            // 
            this.totalMedalsBtn.Location = new System.Drawing.Point(220, 18);
            this.totalMedalsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalMedalsBtn.Name = "totalMedalsBtn";
            this.totalMedalsBtn.Size = new System.Drawing.Size(161, 61);
            this.totalMedalsBtn.TabIndex = 1;
            this.totalMedalsBtn.Text = "Total &Medals";
            this.toolTip1.SetToolTip(this.totalMedalsBtn, "click to view total medals for each country");
            this.totalMedalsBtn.UseVisualStyleBackColor = true;
            this.totalMedalsBtn.Click += new System.EventHandler(this.medalsBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(846, 18);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(161, 61);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitBtn, "click to exit the program");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // compareBtn
            // 
            this.compareBtn.Location = new System.Drawing.Point(640, 18);
            this.compareBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(161, 61);
            this.compareBtn.TabIndex = 3;
            this.compareBtn.Text = "&Compare";
            this.toolTip1.SetToolTip(this.compareBtn, "click to compare two countries medals and records");
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlMain.Controls.Add(this.olympicsBtn);
            this.pnlMain.Controls.Add(this.compareBtn);
            this.pnlMain.Controls.Add(this.worldRecordsBtn);
            this.pnlMain.Controls.Add(this.exitBtn);
            this.pnlMain.Controls.Add(this.totalMedalsBtn);
            this.pnlMain.Location = new System.Drawing.Point(28, 288);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1024, 97);
            this.pnlMain.TabIndex = 6;
            // 
            // mainMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(1091, 394);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "mainMenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPT206 Group Project I - Group III: Olympic Analyzer - Main Menu";
            this.Load += new System.EventHandler(this.mainMenuFrm_Load);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button worldRecordsBtn;
        private System.Windows.Forms.Button olympicsBtn;
        private System.Windows.Forms.Button totalMedalsBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

