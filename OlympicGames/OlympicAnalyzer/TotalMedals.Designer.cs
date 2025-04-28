namespace OlympicAnalyzer
{
    partial class medalsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medalsFrm));
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.totalMedalsTitleLbl = new System.Windows.Forms.Label();
            this.olympicDataLstVw = new System.Windows.Forms.ListView();
            this.sortTotalMedalsGrpBx = new System.Windows.Forms.GroupBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortMedalsCmbBx = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sortTotalMedalsGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mainMenuBtn.Location = new System.Drawing.Point(437, 440);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(129, 38);
            this.mainMenuBtn.TabIndex = 1;
            this.mainMenuBtn.Text = "Main &Menu";
            this.toolTip1.SetToolTip(this.mainMenuBtn, "click to return to the main menu");
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(437, 484);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(129, 38);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitBtn, "click to exit the program");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // totalMedalsTitleLbl
            // 
            this.totalMedalsTitleLbl.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMedalsTitleLbl.Location = new System.Drawing.Point(12, 33);
            this.totalMedalsTitleLbl.Name = "totalMedalsTitleLbl";
            this.totalMedalsTitleLbl.Size = new System.Drawing.Size(565, 35);
            this.totalMedalsTitleLbl.TabIndex = 17;
            this.totalMedalsTitleLbl.Text = "Total Medals";
            this.totalMedalsTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalMedalsTitleLbl.Visible = false;
            // 
            // olympicDataLstVw
            // 
            this.olympicDataLstVw.GridLines = true;
            this.olympicDataLstVw.HideSelection = false;
            this.olympicDataLstVw.Location = new System.Drawing.Point(12, 85);
            this.olympicDataLstVw.Name = "olympicDataLstVw";
            this.olympicDataLstVw.Size = new System.Drawing.Size(565, 299);
            this.olympicDataLstVw.TabIndex = 19;
            this.olympicDataLstVw.TabStop = false;
            this.olympicDataLstVw.UseCompatibleStateImageBehavior = false;
            this.olympicDataLstVw.View = System.Windows.Forms.View.Details;
            // 
            // sortTotalMedalsGrpBx
            // 
            this.sortTotalMedalsGrpBx.Controls.Add(this.sortBtn);
            this.sortTotalMedalsGrpBx.Controls.Add(this.sortMedalsCmbBx);
            this.sortTotalMedalsGrpBx.Location = new System.Drawing.Point(27, 412);
            this.sortTotalMedalsGrpBx.Name = "sortTotalMedalsGrpBx";
            this.sortTotalMedalsGrpBx.Size = new System.Drawing.Size(236, 120);
            this.sortTotalMedalsGrpBx.TabIndex = 0;
            this.sortTotalMedalsGrpBx.TabStop = false;
            this.sortTotalMedalsGrpBx.Text = "Sort Total Medals by:";
            // 
            // sortBtn
            // 
            this.sortBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sortBtn.Location = new System.Drawing.Point(55, 65);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(129, 38);
            this.sortBtn.TabIndex = 1;
            this.sortBtn.Text = "&Sort Records";
            this.toolTip1.SetToolTip(this.sortBtn, "select a medal from the above drop down box and click here to sort data");
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // sortMedalsCmbBx
            // 
            this.sortMedalsCmbBx.FormattingEnabled = true;
            this.sortMedalsCmbBx.Items.AddRange(new object[] {
            "Country",
            "Gold",
            "Silver",
            "Bronze",
            "Total"});
            this.sortMedalsCmbBx.Location = new System.Drawing.Point(24, 33);
            this.sortMedalsCmbBx.Name = "sortMedalsCmbBx";
            this.sortMedalsCmbBx.Size = new System.Drawing.Size(186, 26);
            this.sortMedalsCmbBx.TabIndex = 0;
            // 
            // medalsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 544);
            this.Controls.Add(this.sortTotalMedalsGrpBx);
            this.Controls.Add(this.olympicDataLstVw);
            this.Controls.Add(this.totalMedalsTitleLbl);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.exitBtn);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "medalsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPT206 Group Project I - Group III: Olympic Analyzer - Medals";
            this.Load += new System.EventHandler(this.medalsFrm_Load);
            this.sortTotalMedalsGrpBx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label totalMedalsTitleLbl;
        private System.Windows.Forms.ListView olympicDataLstVw;
        private System.Windows.Forms.GroupBox sortTotalMedalsGrpBx;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.ComboBox sortMedalsCmbBx;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}