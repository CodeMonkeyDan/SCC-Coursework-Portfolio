using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Group_Project_Gui
{
    public class UserValidation
    {
        private string filePath = "data.txt"; // path to txt

        // if it already exists, it wont try to make a new file. if it doesn't, then it makes a new one because icould NOT find it when i made it manually
        public UserValidation()
        {
            if (!File.Exists(filePath))
            {
                CreateDataFile();
            }
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

        // the method TM
        public bool CheckUserData(string username, string password)
        {
            try
            {
                // read all the lines in the file
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    // colon is delimiter. we use that for the split
                    string[] userCredentials = line.Split(':');
                    if (userCredentials.Length == 3 && userCredentials[0] == username && userCredentials[1] == password)
                    {
                        return true; // if the username and passwords match, return true
                    }
                }
                return false; // if it doesn't match, return false
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false; // error checking
            }
        }
    }
}