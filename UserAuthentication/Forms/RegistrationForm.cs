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
    public partial class RegistrationForm : Form
    {
        string gender;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void GotoLoginFormText_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            Close();

        }

        private void RegistarButton_Click(object sender, EventArgs e)
        {
            var db = FirestoreHelper.Database;

            if (CheckIfUserAlreadyExist())
            {
                MessageBox.Show("user Already Exist");
                return;
            }
            
            var data = GetWriteData();
            DocumentReference docRef = db.Collection("UserData").Document(data.UserNameorEmail);
            docRef.SetAsync(data);
            MessageBox.Show("Success");
        }
        private UserData GetWriteData()
        {

            string name = NameTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            var checkRadioButton = Gender_GroupBox.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            if (checkRadioButton != null)
            {
                gender = checkRadioButton.Text;
            }
            string birthdate = BirthDatePicker.Value.ToString();
            string address = AddresstextBox.Text.Trim();
            string password = Security.Encrypt(Password_textBox1.Text);

            return new UserData()
            {
                Name = name,
                UserNameorEmail = email,
                Gender = gender,
                DateofBirth = birthdate,
                Address = address,
                Password = password

            };
        }

        private bool CheckIfUserAlreadyExist()
        {
            string email = EmailTextBox.Text.Trim();
            string password = Password_textBox1.Text;

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(email);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if (data != null)
            {
                return true;
            }
            return false;

        }
    }
}
