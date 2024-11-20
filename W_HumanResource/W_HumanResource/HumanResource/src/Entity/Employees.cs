﻿namespace HumanResource.src.Entity
{

    internal class Employees
    {
        private int employId;
        private string email;
        private string employeeName;
        private string avatar;
        private string addressEmployee;
        private string phone;
        private string gender;
     

        public int EmployId
        {
            get { return employId; }
            set { employId = value; }
        }

        public Employees()
        { }

        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }


        public string AddressEmployee
        {
            get { return addressEmployee; }
            set { addressEmployee = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }
    }
}
