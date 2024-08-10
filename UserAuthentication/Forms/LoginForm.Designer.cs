namespace UserAuthentication.Forms
{
    partial class LoginForm
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
            EmailTextBox = new TextBox();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            LoginButton = new Button();
            GotoRegistarFormText = new Label();
            SuspendLayout();
            // 
            // EmailTextBox
            // 
            EmailTextBox.Font = new Font("Segoe UI", 12F);
            EmailTextBox.Location = new Point(304, 71);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(266, 29);
            EmailTextBox.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(234, 74);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 21;
            label2.Text = "Email:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 12F);
            PasswordTextBox.Location = new Point(304, 118);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(266, 29);
            PasswordTextBox.TabIndex = 20;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(206, 126);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 19;
            label1.Text = "Password:";
            // 
            // LoginButton
            // 
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F);
            LoginButton.Location = new Point(424, 170);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(146, 35);
            LoginButton.TabIndex = 28;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // GotoRegistarFormText
            // 
            GotoRegistarFormText.AutoSize = true;
            GotoRegistarFormText.Cursor = Cursors.Hand;
            GotoRegistarFormText.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            GotoRegistarFormText.Location = new Point(407, 218);
            GotoRegistarFormText.Name = "GotoRegistarFormText";
            GotoRegistarFormText.Size = new Size(163, 15);
            GotoRegistarFormText.TabIndex = 29;
            GotoRegistarFormText.Text = "no account yet sign up Form";
            GotoRegistarFormText.Click += GotoRegistarFormText_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GotoRegistarFormText);
            Controls.Add(LoginButton);
            Controls.Add(EmailTextBox);
            Controls.Add(label2);
            Controls.Add(PasswordTextBox);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailTextBox;
        private Label label2;
        private TextBox PasswordTextBox;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button LoginButton;
        private Label GotoRegistarFormText;
    }
}