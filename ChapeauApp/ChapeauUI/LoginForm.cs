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
                    Show();
                    break;
                case StaffRole.Chef:
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

            StaffService staffService = new StaffService();

            if (!staffService.CheckUserNameExist(userName))
            {
                lblInvalid.Text = "Username does not exit";

            }
            string hashedPassword = staffService.HashPasword(password);
            List<Employee> employees = new List<Employee>();
            if (employees.Count > 0)
            {
                Employee employeeAccess = employees[0];
                OpenView(employeeAccess);

            }
            else
            {
                lblInvalid.Text = "Incorrect password please try again";
            }
        }
    }
}
