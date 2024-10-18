
using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace EmployeeApplication1
{
    public partial class Form1 : Form
    {
        private IEmployee employee;

        public Form1()
        {
            InitializeComponent();
            employee = new PartTimeEmployee("", "", "", "");
        }

        private void btnComputeSalary_Click(object sender, EventArgs e)
        {
            try
            {
                employee.FirstName = txtFirstName.Text;
                employee.LastName = txtLastName.Text;
                employee.Department = txtDepartment.Text;
                employee.JobTitle = txtJobTitle.Text;

                int hoursWorked = int.Parse(txtHoursWorked.Text);
                double ratePerHour = double.Parse(txtRatePerHour.Text);

                employee.computeSalary(hoursWorked, ratePerHour);

                lblFirstName.Text = "First Name: " + employee.FirstName;
                lblLastName.Text = "Last Name: " + employee.LastName;
                lblBasicSalary.Text = "Basic Salary: " + "₱ " + employee.BasicSalary; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}