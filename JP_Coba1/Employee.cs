using System;
using System.Collections.Generic;
using System.Text;

namespace JP_Coba1
{
    class Employee
    {
        public int EmployeeID = 1;
        public string LoginName;
        public string Password;

        public Employee() { }
        public Employee(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
        }
        public bool Login(string LoginName_, string Password_)
        {
            bool login = false;
            if(LoginName == ""/*<-- Insert Username Here*/ && Password == "" /*<-- Insert Password Here*/)
            {
                login = true;
            }
            return login;
        }

    }
}
