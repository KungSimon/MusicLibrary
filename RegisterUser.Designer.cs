namespace MusicLibrary
{
    partial class RegisterUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUser));
            registerButton = new Button();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.Location = new Point(308, 231);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(129, 29);
            registerButton.TabIndex = 9;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = SystemColors.Window;
            passwordLabel.Location = new Point(182, 182);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(97, 25);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(290, 183);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(219, 27);
            passwordTextBox.TabIndex = 7;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = SystemColors.Window;
            usernameLabel.Location = new Point(182, 139);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(102, 25);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(290, 140);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(219, 27);
            usernameTextBox.TabIndex = 5;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(registerButton);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(usernameTextBox);
            Name = "RegisterUser";
            Text = "RegisterUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label usernameLabel;
        private TextBox usernameTextBox;
    }
}