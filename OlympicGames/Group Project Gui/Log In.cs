using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OlympicAnalyzer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group_Project_Gui
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //AddShadowToButton(btnLogIn);
            //AddShadowToButton(btnSignUp);
            ShadowLabel lblWelcome = new ShadowLabel // create the text box dynamically bc it CAN'T READ
            {
                Text = "Welcome back.",
                Font = new Font("Arial", 34, FontStyle.Bold),
                ForeColor = Color.Black, // text color
                ShadowColor = Color.FromArgb(80, 0, 0, 0), // transparency,,,
                ShadowOffset = 5, // distance from text
                AutoSize = true,
                Location = new Point(300, 50) // where it is positioned
            };
            this.Controls.Add(lblWelcome); // add to form
            lblWelcome.BackColor = Color.Transparent; // make it transparent

            pnlLogIn.SetRoundedRegion(20);  // call on the SetRoundedEdges class to execute this method
            pnlSignUp.SetRoundedRegion(20); // graphic design is my passion. we are not hooligans with sharp cornesr.

            txtbPass.UseSystemPasswordChar = true; // hide the password by default
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawPanelShadow(e.Graphics, pnlLogIn);
            DrawPanelShadow(e.Graphics, pnlSignUp);
        }

        private void DrawPanelShadow(Graphics g, Panel panel)
        {
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(50, 0, 0, 0))) // Semi-transparent black
            {
                g.FillRectangle(shadowBrush, panel.Left + 15, panel.Top + 15, panel.Width, panel.Height);
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // turn them tostrings so they can be passed to the method that will check a database for the user and pass
            string username = txtbUsername.Text;
            string pass = txtbPass.Text;
            // call the method that will check the database for the user and pass
            UserValidation userValidation = new UserValidation(); // another new instance. yey

            bool isValid = userValidation.CheckUserData(username, pass); // true or false
            if (isValid)
            {
                mainMenuFrm mainMenu = new mainMenuFrm(); // declare new instance of the main menu
                mainMenu.Show(); // and then shows it
                this.Hide(); // close this form
            }
            else
            {
                // if its wrong
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            ForgotPass forgotPass = new ForgotPass(); // declare new instance of the forgot password form
            forgotPass.Show(); // and then shows it
            this.Hide(); // hide this form
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(); // declare new instance of the sign up form
            signUp.Show(); // and then shows it
            this.Hide(); // close this form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            EndProgram.Exit(); // call the method to close the program
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtbPass.UseSystemPasswordChar)
            {
                txtbPass.UseSystemPasswordChar = false;
                btnShowPass.Text = "Hide Password";
            }
            else
            {
                txtbPass.UseSystemPasswordChar = true;
                btnShowPass.Text = "Show Password";
            }
        }
    }
}
