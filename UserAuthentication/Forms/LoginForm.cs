using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAuthentication.Classes;

namespace UserAuthentication.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void GotoRegistarFormText_Click(object sender, EventArgs e)
        {
            Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text.Trim();
            string password = PasswordTextBox.Text;

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(email);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();
            
            if (data != null)
            {
                if(password == Security.Decrypt(data.Password))
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
