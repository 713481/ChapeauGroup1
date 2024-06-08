using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChapeauUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        
        }

        private void OpenView(Employee employee)
        {
           
            switch (employee.Role)
            {
                case StaffRole.Waiter:
                  orderingForm orderingForm = new orderingForm();
                    orderingForm.ShowDialog();
                    break;
                case StaffRole.Chef:
                    // ...
                    Show();
                    break;
                case StaffRole.Bartender:
                    Show();
                    break;
                case StaffRole.Manger:
                    Show();
                    break;

            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string userName = textBoxUsernameInput.Text;
            string password = textBoxPassowrdInput.Text;


            
            if (VerifyCheck(userName, password))
            {
                StaffService staffService = new StaffService();
                Employee employee = staffService.GetUserNameAndPassword(userName, password);
                 if(employee != null)
                {
                    OpenView(employee);
                } 
                else
                {
                    lblInvalid.Text = "Incorrect password, please try again";
                }
            }
            else
            {
                lblInvalid.Text = "Incorrect username or password";
            }


        }
        private bool VerifyCheck(string username, string password)
        {

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblInvalid.Text = "Please Enter your Username and Password";
                return false;
            }
            else
            {
                return true;
            }

        }

        
    }
}
