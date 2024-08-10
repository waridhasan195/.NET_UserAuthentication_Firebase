namespace UserAuthentication.Forms
{
    partial class RegistrationForm
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
            RegistarButton = new Button();
            Gender_GroupBox = new GroupBox();
            Female_radioButton = new RadioButton();
            Male_radioButton = new RadioButton();
            Password_textBox2 = new TextBox();
            label6 = new Label();
            Password_textBox1 = new TextBox();
            label5 = new Label();
            AddresstextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            EmailTextBox = new TextBox();
            label2 = new Label();
            NameTextBox = new TextBox();
            label1 = new Label();
            GotoLoginFormText = new Label();
            label7 = new Label();
            BirthDatePicker = new DateTimePicker();
            Gender_GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RegistarButton
            // 
            RegistarButton.FlatStyle = FlatStyle.Flat;
            RegistarButton.Font = new Font("Segoe UI", 12F);
            RegistarButton.Location = new Point(408, 374);
            RegistarButton.Name = "RegistarButton";
            RegistarButton.Size = new Size(146, 35);
            RegistarButton.TabIndex = 27;
            RegistarButton.Text = "Registar";
            RegistarButton.UseVisualStyleBackColor = true;
            RegistarButton.Click += RegistarButton_Click;
            // 
            // Gender_GroupBox
            // 
            Gender_GroupBox.Controls.Add(Female_radioButton);
            Gender_GroupBox.Controls.Add(Male_radioButton);
            Gender_GroupBox.Location = new Point(300, 128);
            Gender_GroupBox.Name = "Gender_GroupBox";
            Gender_GroupBox.Size = new Size(236, 32);
            Gender_GroupBox.TabIndex = 26;
            Gender_GroupBox.TabStop = false;
            // 
            // Female_radioButton
            // 
            Female_radioButton.AutoSize = true;
            Female_radioButton.Font = new Font("Segoe UI", 12F);
            Female_radioButton.Location = new Point(105, 3);
            Female_radioButton.Name = "Female_radioButton";
            Female_radioButton.Size = new Size(78, 25);
            Female_radioButton.TabIndex = 6;
            Female_radioButton.TabStop = true;
            Female_radioButton.Text = "Female";
            Female_radioButton.UseVisualStyleBackColor = true;
            // 
            // Male_radioButton
            // 
            Male_radioButton.AutoSize = true;
            Male_radioButton.Font = new Font("Segoe UI", 12F);
            Male_radioButton.Location = new Point(17, 3);
            Male_radioButton.Name = "Male_radioButton";
            Male_radioButton.Size = new Size(62, 25);
            Male_radioButton.TabIndex = 5;
            Male_radioButton.TabStop = true;
            Male_radioButton.Text = "Male";
            Male_radioButton.UseVisualStyleBackColor = true;
            // 
            // Password_textBox2
            // 
            Password_textBox2.Font = new Font("Segoe UI", 12F);
            Password_textBox2.Location = new Point(288, 327);
            Password_textBox2.Name = "Password_textBox2";
            Password_textBox2.Size = new Size(266, 29);
            Password_textBox2.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(146, 330);
            label6.Name = "label6";
            label6.Size = new Size(123, 21);
            label6.TabIndex = 24;
            label6.Text = "Password Again:";
            // 
            // Password_textBox1
            // 
            Password_textBox1.Font = new Font("Segoe UI", 12F);
            Password_textBox1.Location = new Point(288, 286);
            Password_textBox1.Name = "Password_textBox1";
            Password_textBox1.PasswordChar = '*';
            Password_textBox1.Size = new Size(266, 29);
            Password_textBox1.TabIndex = 23;
            Password_textBox1.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(190, 286);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 22;
            label5.Text = "Password:";
            // 
            // AddresstextBox
            // 
            AddresstextBox.Font = new Font("Segoe UI", 12F);
            AddresstextBox.Location = new Point(288, 227);
            AddresstextBox.Name = "AddresstextBox";
            AddresstextBox.Size = new Size(266, 29);
            AddresstextBox.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(200, 230);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 20;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(205, 133);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 19;
            label3.Text = "Gender:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Segoe UI", 12F);
            EmailTextBox.Location = new Point(288, 87);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(266, 29);
            EmailTextBox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(218, 90);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 17;
            label2.Text = "Email:";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 12F);
            NameTextBox.Location = new Point(288, 42);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(266, 29);
            NameTextBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(214, 45);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 15;
            label1.Text = "Name:";
            // 
            // GotoLoginFormText
            // 
            GotoLoginFormText.AutoSize = true;
            GotoLoginFormText.Cursor = Cursors.Hand;
            GotoLoginFormText.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            GotoLoginFormText.Location = new Point(243, 421);
            GotoLoginFormText.Name = "GotoLoginFormText";
            GotoLoginFormText.Size = new Size(311, 15);
            GotoLoginFormText.TabIndex = 28;
            GotoLoginFormText.Text = "Already have an account click here to log in got it close";
            GotoLoginFormText.Click += GotoLoginFormText_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(169, 174);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 29;
            label7.Text = "Date of Birth:";
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.CalendarFont = new Font("Segoe UI", 12F);
            BirthDatePicker.Location = new Point(300, 174);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new Size(218, 23);
            BirthDatePicker.TabIndex = 30;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BirthDatePicker);
            Controls.Add(label7);
            Controls.Add(GotoLoginFormText);
            Controls.Add(RegistarButton);
            Controls.Add(Gender_GroupBox);
            Controls.Add(Password_textBox2);
            Controls.Add(label6);
            Controls.Add(Password_textBox1);
            Controls.Add(label5);
            Controls.Add(AddresstextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EmailTextBox);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Gender_GroupBox.ResumeLayout(false);
            Gender_GroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegistarButton;
        private GroupBox Gender_GroupBox;
        private RadioButton Female_radioButton;
        private RadioButton Male_radioButton;
        private TextBox Password_textBox2;
        private Label label6;
        private TextBox Password_textBox1;
        private Label label5;
        private TextBox AddresstextBox;
        private Label label4;
        private Label label3;
        private TextBox EmailTextBox;
        private Label label2;
        private TextBox NameTextBox;
        private Label label1;
        private Label GotoLoginFormText;
        private Label label7;
        private DateTimePicker BirthDatePicker;
    }
}