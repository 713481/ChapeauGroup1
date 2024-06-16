using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
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
        // Method to open the form based on the employee's role
        private void OpenView(Employee employee)
        {
            Form newForm = null;

            switch (employee.Role)
            {
                //method to open the form base on the employee role
                case StaffRole.Waiter:
               
                    newForm = new TableViewForm(employee);
                    break;
                case StaffRole.Chef:
                    newForm = new KitchenAndBarView( employee);
                    break;
                case StaffRole.Bartender:
                   newForm = new KitchenAndBarView( employee);
                    
                    break;
                case StaffRole.Manger:
                    newForm = new PaymentForm();
                    break;

            }
            //Show the new form and hide and close the login form
            if (newForm != null)
            {
                this.Hide();
                newForm.ShowDialog();
                this.Close();
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // Get the username and password from the text boxes
            string userName = textBoxUsernameInput.Text;
            string password = textBoxPassowrdInput.Text;


            // Validate the input fields
            if (VerifyCheck(userName, password))
            {
                StaffService staffService = new StaffService();
                Employee employee = staffService.GetUserNameAndPassword(userName, password);
                 if(employee != null)
                {
                    // Open the form if authentication is successful
                    OpenView(employee);
                } 
                else
                {
                    // Show error message for incorrect password
                    lblInvalid.Text = "Incorrect password, please try again";
                }
            }
            else
            {
                // Show error message for validation failure
                lblInvalid.Text = "Incorrect username or password";
            }


        }
        // Method to check that both username and password fields are not empty
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
