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
using OlympicAnalyzer;
using System.Security.Cryptography;
using System.Text.RegularExpressions; // i hate it here.

namespace Group_Project_Gui
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            ShadowLabel lblSignUp = new ShadowLabel // same as welcome text on login page
            {
                Text = "Sign Up",
                Font = new Font("Arial", 34, FontStyle.Bold),
                ForeColor = Color.Black, // text color
                ShadowColor = Color.FromArgb(80, 0, 0, 0), // transparency,,,
                ShadowOffset = 5, // distance from text
                AutoSize = true,
                Location = new Point(95, 50) // where it is positioned
            };
            this.Controls.Add(lblSignUp); // add to form
            lblSignUp.BackColor = Color.Transparent; // transparent bg

            pnlSignUp.SetRoundedRegion(20); // make it round
        }
        // and the shadow
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawPanelShadow(e.Graphics, pnlSignUp);
        }

        private void DrawPanelShadow(Graphics g, Panel panel)
        {
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(50, 0, 0, 0))) // Semi-transparent black
            {
                g.FillRectangle(shadowBrush, panel.Left + 0, panel.Top + 15, panel.Width, panel.Height);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // add tothe txt file that has all the users and psswoards
            string username = txtbUsername.Text;
            string pass = txtbPass.Text;
            string email = txtbEmail.Text;
            string filePath = "data.txt";

            // check if file exists
            if (File.Exists(filePath))
            {
                // now check to make sure everything was filled out
                if (username == "" || pass == "" || email == "")
                {
                    MessageBox.Show("Please fill out all fields.");
                    return;
                }
                if (!isEmail(email)) // validate email
                {
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }
                string[] lines = File.ReadAllLines("data.txt");
                foreach (string line in lines) //go through each line
                {
                    string[] parts = line.Split(':');
                    if (parts[0] == username)
                    {
                        MessageBox.Show("Username already exists. If you forgot your password, go back to the log in and select the 'forgot password' option.");
                        return;
                    }
                }
                // now we can add the user
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(username + ":" + pass + ":" + email);
                }
                MessageBox.Show("User added successfully.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn(); // create a new instance of the log in form
            logIn.Show(); // show the log in form
            this.Close(); // close this form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            EndProgram.Exit();
        }

        private void btnGenRandom_Click(object sender, EventArgs e)
        {
            string password = GenPass(8); // generate a random password
            txtbPass.Text = password; // set the text box to the password so it can be submitted
        }
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

        // use the stupid regex to figure out if the email is valid
        private bool isEmail(string email)
        {
            string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
