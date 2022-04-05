using System;

namespace EmployeeManagement
{
    interface IPrintable
    {
        void DisplayEmployeeDetails();
    }
    class Employee : IPrintable
    {
        protected string firstName, lastName, designation;
        protected float grossSalary;

        protected Employee()
        {
            this.firstName = "";
            this.lastName = "";
            this.designation = "";
            this.grossSalary = 0.0F;
        }

        protected Employee(string fName, string lName, string designation, float salary)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.designation = designation;
            this.grossSalary = salary;
        }

        public virtual void CalculateSalary()
        {
            // empty function for overriding
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("EMPLOYEE DETAILS:\n");
            Console.WriteLine("Name: {0} {1}", this.firstName, this.lastName);
            Console.WriteLine("Designation: {0}", this.designation);
            Console.WriteLine("Gross Salary: {0}\n", this.grossSalary);
        }
    }

    class Manager : Employee
    {
        private float petrolAllowance, foodAllowance, otherAllowance;

        public Manager(string fName, string lName, string designation, float salary) : base(fName, lName, designation, salary)
        {
            this.petrolAllowance = 0.08F;
            this.foodAllowance = 0.13F;
            this.otherAllowance = 0.03F;
        }

        public override void CalculateSalary()
        {
            grossSalary += (petrolAllowance + foodAllowance + otherAllowance) * grossSalary;
        }
    }

    class MarketingExecutive : Employee
    {
        private float kilometerTravel, tourAllowance;
        private int telephoneAllowance;

        public MarketingExecutive(string fName, string lName, string designation, float salary, float kilometers) : base(fName, lName, designation, salary)
        {
            this.kilometerTravel = kilometers;
            tourAllowance = 5 * this.kilometerTravel;
            telephoneAllowance = 1000;
        }

        public override void CalculateSalary()
        {
            grossSalary += kilometerTravel + tourAllowance + telephoneAllowance;
        }
    }

    class EmployeeManagementMain
    {
        static void Main()
        {
            Employee obj;
            obj = new Manager("Kayden", "Break", "Manager", 123456);
            obj.CalculateSalary();
            obj.DisplayEmployeeDetails();

            obj = new MarketingExecutive("Aether", "Twilight", "Marketing Executive", 123456, 10);
            obj.CalculateSalary();
            obj.DisplayEmployeeDetails();
        }
    }
}