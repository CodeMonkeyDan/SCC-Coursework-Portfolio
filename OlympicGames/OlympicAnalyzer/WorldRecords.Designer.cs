namespace OlympicAnalyzer
{
    partial class worldRecordsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(worldRecordsFrm));
            this.exitBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.worldRecordLstVw = new System.Windows.Forms.ListView();
            this.worldRecordTitleLbl = new System.Windows.Forms.Label();
            this.eventSelectorCmbBx = new System.Windows.Forms.ComboBox();
            this.selectEventBtn = new System.Windows.Forms.Button();
            this.selectEventGrpBx = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortRecordCmbBx = new System.Windows.Forms.ComboBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.selectEventGrpBx.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(891, 488);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(129, 38);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitBtn, "click to exit the program");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainMenuBtn.Location = new System.Drawing.Point(891, 444);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(129, 38);
            this.mainMenuBtn.TabIndex = 3;
            this.mainMenuBtn.Text = "Main &Menu";
            this.toolTip1.SetToolTip(this.mainMenuBtn, "click to return to the main menu");
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // worldRecordLstVw
            // 
            this.worldRecordLstVw.GridLines = true;
            this.worldRecordLstVw.HideSelection = false;
            this.worldRecordLstVw.Location = new System.Drawing.Point(12, 76);
            this.worldRecordLstVw.Name = "worldRecordLstVw";
            this.worldRecordLstVw.Size = new System.Drawing.Size(1008, 299);
            this.worldRecordLstVw.TabIndex = 14;
            this.worldRecordLstVw.TabStop = false;
            this.worldRecordLstVw.UseCompatibleStateImageBehavior = false;
            this.worldRecordLstVw.View = System.Windows.Forms.View.Details;
            // 
            // worldRecordTitleLbl
            // 
            this.worldRecordTitleLbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldRecordTitleLbl.Location = new System.Drawing.Point(12, 33);
            this.worldRecordTitleLbl.Name = "worldRecordTitleLbl";
            this.worldRecordTitleLbl.Size = new System.Drawing.Size(1008, 35);
            this.worldRecordTitleLbl.TabIndex = 15;
            this.worldRecordTitleLbl.Text = "World Records";
            this.worldRecordTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.worldRecordTitleLbl.Visible = false;
            // 
            // eventSelectorCmbBx
            // 
            this.eventSelectorCmbBx.FormattingEnabled = true;
            this.eventSelectorCmbBx.Location = new System.Drawing.Point(25, 33);
            this.eventSelectorCmbBx.Name = "eventSelectorCmbBx";
            this.eventSelectorCmbBx.Size = new System.Drawing.Size(435, 26);
            this.eventSelectorCmbBx.TabIndex = 0;
            // 
            // selectEventBtn
            // 
            this.selectEventBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.selectEventBtn.Location = new System.Drawing.Point(178, 65);
            this.selectEventBtn.Name = "selectEventBtn";
            this.selectEventBtn.Size = new System.Drawing.Size(129, 38);
            this.selectEventBtn.TabIndex = 1;
            this.selectEventBtn.Text = "Select &Event";
            this.toolTip1.SetToolTip(this.selectEventBtn, "select an event from the above drop down box and click here to view the top three" +
        " records");
            this.selectEventBtn.UseVisualStyleBackColor = true;
            this.selectEventBtn.Click += new System.EventHandler(this.selectEventBtn_Click);
            // 
            // selectEventGrpBx
            // 
            this.selectEventGrpBx.Controls.Add(this.selectEventBtn);
            this.selectEventGrpBx.Controls.Add(this.eventSelectorCmbBx);
            this.selectEventGrpBx.Location = new System.Drawing.Point(290, 411);
            this.selectEventGrpBx.Name = "selectEventGrpBx";
            this.selectEventGrpBx.Size = new System.Drawing.Size(488, 120);
            this.selectEventGrpBx.TabIndex = 1;
            this.selectEventGrpBx.TabStop = false;
            this.selectEventGrpBx.Text = "Select Event To View The Top 3 Records:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortBtn);
            this.groupBox1.Controls.Add(this.sortRecordCmbBx);
            this.groupBox1.Location = new System.Drawing.Point(16, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort World Records by:";
            // 
            // sortBtn
            // 
            this.sortBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sortBtn.Location = new System.Drawing.Point(55, 65);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(129, 38);
            this.sortBtn.TabIndex = 1;
            this.sortBtn.Text = "&Sort Records";
            this.toolTip1.SetToolTip(this.sortBtn, "select a record from the above drop down box and click here to sort data");
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // sortRecordCmbBx
            // 
            this.sortRecordCmbBx.FormattingEnabled = true;
            this.sortRecordCmbBx.Items.AddRange(new object[] {
            "Event",
            "Category",
            "Record",
            "Athlete",
            "Country",
            "Date"});
            this.sortRecordCmbBx.Location = new System.Drawing.Point(24, 33);
            this.sortRecordCmbBx.Name = "sortRecordCmbBx";
            this.sortRecordCmbBx.Size = new System.Drawing.Size(186, 26);
            this.sortRecordCmbBx.TabIndex = 0;
            // 
            // resetBtn
            // 
            this.resetBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetBtn.Location = new System.Drawing.Point(891, 400);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(129, 38);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "&Reset Form";
            this.toolTip1.SetToolTip(this.resetBtn, "click to reset the form");
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // worldRecordsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 541);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.worldRecordTitleLbl);
            this.Controls.Add(this.worldRecordLstVw);
            this.Controls.Add(this.selectEventGrpBx);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.exitBtn);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "worldRecordsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPT206 Group Project I - Group III: Olympic Analyzer - World Records";
            this.Load += new System.EventHandler(this.worldRecordsFrm_Load);
            this.selectEventGrpBx.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.ListView worldRecordLstVw;
        private System.Windows.Forms.Label worldRecordTitleLbl;
        private System.Windows.Forms.ComboBox eventSelectorCmbBx;
        private System.Windows.Forms.Button selectEventBtn;
        private System.Windows.Forms.GroupBox selectEventGrpBx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.ComboBox sortRecordCmbBx;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}