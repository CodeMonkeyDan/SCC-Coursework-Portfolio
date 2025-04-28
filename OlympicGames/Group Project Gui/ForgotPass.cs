using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using OlympicAnalyzer;

namespace Group_Project_Gui
{
    public partial class ForgotPass : Form
    {
        private string filePath = "data.txt"; // path to txt
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {
            lblForgor.BackColor = Color.Transparent; // transparent bg

            pnlForgor.SetRoundedRegion(20); // make it round

            // check if file exists, make it if it doesnt exists
            if (!File.Exists(filePath))
            {
                MessageBox.Show("User data file does not exist. Creating file and dummy data...", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CreateDataFile();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawPanelShadow(e.Graphics, pnlForgor);
        }

        private void DrawPanelShadow(Graphics g, Panel panel)
        {
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(50, 0, 0, 0))) // Semi-transparent black
            {
                g.FillRectangle(shadowBrush, panel.Left + 0, panel.Top + 15, panel.Width, panel.Height);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtbEmail.Text;
            string newPass = txtbPass.Text;
            string[] linesArray = File.ReadAllLines(filePath); // make array of lines
            List<string> lines = new List<string>(linesArray); // put them in list

            for (int i = 0; i < lines.Count; i++)
            {
                string[] parts = lines[i].Split(':');
                if (parts.Length == 3 && parts[2] == email) // parts = user:pass:email. its an array so 0:1:2
                {
                    string username = parts[0];
                    // update the line
                    lines[i] = parts[0] + ":" + newPass + ":" + email;
                    break; // exit after update
                }
            }
            File.WriteAllLines(filePath, lines); // write the lines back to the file
            MessageBox.Show("Password updated successfully.", "Password Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // now clear everything out
            txtbEmail.Text = string.Empty;
            txtbPass.Text = string.Empty;
        }

        // and the method to make the file
        private void CreateDataFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    string dummyData = "admin:admin123"; // dummy data

                    // write the line
                    sw.WriteLine(dummyData);
                    MessageBox.Show("The user file was created successfully and dummy data was added.", "File Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User file and dummy data not entered:" + ex.Message); // get the error
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn(); // create a new instance of the log in form
            logIn.Show(); // show the form
            this.Close(); // close this form
        }

        private void btnGenRan_Click(object sender, EventArgs e)
        {
            string password = GenPass(8); // generate a random password
            txtbPass.Text = password; // set the text box to the password so it can be submitted
        }
        
        // the function to generate the password
        static string GenPass(int length)
        {
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+";
            StringBuilder result = new StringBuilder(length);
            byte[] randomBytes = new byte[length];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }

            foreach (byte b in randomBytes)
            {
                result.Append(validChars[b % validChars.Length]);
            }
            return result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndProgram.Exit(); // exit the program
        }
    }
}