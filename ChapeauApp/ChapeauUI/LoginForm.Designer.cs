namespace ChapeauUI
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
            lblLogin = new Label();
            label1 = new Label();
            textBoxUsernameInput = new TextBox();
            textBoxPassowrdInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            lblInvalid = new Label();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(46, 80);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(46, 20);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 113);
            label1.Name = "label1";
            label1.Size = new Size(179, 20);
            label1.TabIndex = 1;
            label1.Text = "Welcome back to the app";
            // 
            // textBoxUsernameInput
            // 
            textBoxUsernameInput.Location = new Point(46, 185);
            textBoxUsernameInput.Name = "textBoxUsernameInput";
            textBoxUsernameInput.Size = new Size(202, 27);
            textBoxUsernameInput.TabIndex = 2;
            // 
            // textBoxPassowrdInput
            // 
            textBoxPassowrdInput.Location = new Point(46, 250);
            textBoxPassowrdInput.Name = "textBoxPassowrdInput";
            textBoxPassowrdInput.Size = new Size(202, 27);
            textBoxPassowrdInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 162);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 227);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(46, 303);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(202, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblInvalid
            // 
            lblInvalid.AutoSize = true;
            lblInvalid.Location = new Point(46, 280);
            lblInvalid.Name = "lblInvalid";
            lblInvalid.Size = new Size(12, 20);
            lblInvalid.TabIndex = 7;
            lblInvalid.Text = ".";
            lblInvalid.Click += this.label4_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 450);
            Controls.Add(lblInvalid);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPassowrdInput);
            Controls.Add(textBoxUsernameInput);
            Controls.Add(label1);
            Controls.Add(lblLogin);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label label1;
        private TextBox textBoxUsernameInput;
        private TextBox textBoxPassowrdInput;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Label lblInvalid;
    }
}