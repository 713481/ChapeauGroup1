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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblInvalid = new Label();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            textBoxPassowrdInput = new TextBox();
            textBoxUsernameInput = new TextBox();
            label1 = new Label();
            lblLogin = new Label();
            pnlLoginnigLogo = new Panel();
            SuspendLayout();
            // 
            // lblInvalid
            // 
            lblInvalid.AutoSize = true;
            lblInvalid.Location = new Point(32, 301);
            lblInvalid.Name = "lblInvalid";
            lblInvalid.Size = new Size(12, 20);
            lblInvalid.TabIndex = 15;
            lblInvalid.Text = ".";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(32, 334);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(202, 29);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 248);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 13;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 195);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 12;
            label2.Text = "Username:";
            // 
            // textBoxPassowrdInput
            // 
            textBoxPassowrdInput.Location = new Point(32, 271);
            textBoxPassowrdInput.Name = "textBoxPassowrdInput";
            textBoxPassowrdInput.Size = new Size(202, 27);
            textBoxPassowrdInput.TabIndex = 11;
            // 
            // textBoxUsernameInput
            // 
            textBoxUsernameInput.Location = new Point(32, 218);
            textBoxUsernameInput.Name = "textBoxUsernameInput";
            textBoxUsernameInput.Size = new Size(202, 27);
            textBoxUsernameInput.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 142);
            label1.Name = "label1";
            label1.Size = new Size(179, 20);
            label1.TabIndex = 9;
            label1.Text = "Welcome back to the app";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(32, 113);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(46, 20);
            lblLogin.TabIndex = 8;
            lblLogin.Text = "Login";
            // 
            // pnlLoginnigLogo
            // 
            pnlLoginnigLogo.BackColor = Color.White;
            pnlLoginnigLogo.BackgroundImage = (Image)resources.GetObject("pnlLoginnigLogo.BackgroundImage");
            pnlLoginnigLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlLoginnigLogo.Location = new Point(87, 24);
            pnlLoginnigLogo.Margin = new Padding(3, 4, 3, 4);
            pnlLoginnigLogo.Name = "pnlLoginnigLogo";
            pnlLoginnigLogo.Size = new Size(98, 85);
            pnlLoginnigLogo.TabIndex = 16;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(291, 450);
            Controls.Add(pnlLoginnigLogo);
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

        private Label lblInvalid;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private TextBox textBoxPassowrdInput;
        private TextBox textBoxUsernameInput;
        private Label label1;
        private Label lblLogin;
        private Panel pnlLoginnigLogo;
    }
}