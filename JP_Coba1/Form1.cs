using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JP_Coba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.LoginName = tbUsername.Text;
            employee.Password = tbPassword.Text;
            if (employee.Login(employee.LoginName, employee.Password))
            {
                MessageBox.Show("Login Berhasil, ID anda : " + employee.EmployeeID.ToString());
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
        }
    }
}
