using System;

namespace EmployeeDelegateMng
{
    public delegate void EmployeeDelegate();
    class Employee
    {
        public string firstName, lastName, designation;
        public float netSalary, grossSalary;

        protected Employee()
        {
            this.firstName = "";
            this.lastName = "";
            this.designation = "";
            this.netSalary = 0.0F;
            this.grossSalary = 0.0F;
        }

        protected Employee(string fName, string lName, string designation, float salary)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.designation = designation;
            this.netSalary = salary;
        }

        public virtual void CalculateSalary()
        {
            // empty function for overriding
        }
    }

    class Manager : Employee
    {
        public float petrolAllowance, foodAllowance, otherAllowance;

        public Manager(string fName, string lName, string designation, float salary) : base(fName, lName, designation, salary)
        {
            this.petrolAllowance = 0.08F;
            this.foodAllowance = 0.13F;
            this.otherAllowance = 0.03F;
        }

        public override void CalculateSalary()
        {
            grossSalary = (1 + petrolAllowance + foodAllowance + otherAllowance) * netSalary;

        }
    }

    class MarketingExecutive : Employee
    {
        public float kilometerTravel, tourAllowance;
        public int telephoneAllowance;

        public MarketingExecutive(string fName, string lName, string designation, float salary, float kilometers) : base(fName, lName, designation, salary)
        {
            this.kilometerTravel = kilometers;
            tourAllowance = 5 * this.kilometerTravel;
            telephoneAllowance = 1000;
        }

        public override void CalculateSalary()
        {
            grossSalary = netSalary + kilometerTravel + tourAllowance + telephoneAllowance;
        }
    }

    class EmployeeManagementMain
    {
        static void main()
        {
            EmployeeDelegate empDlg = DisplayManagerDetails;
            Employee obj;
            obj = new Manager("Kayden", "Break", "Manager", 123456);
            obj.CalculateSalary();

            obj = new MarketingExecutive("Aether", "Twilight", "Marketing Executive", 123456, 10);
            obj.CalculateSalary();
        }

        public static void DisplayManagerDetails()
        {
            Employee obj = new Manager("Kayden", "Break", "Manager", 123456);
            Console.WriteLine("EMPLOYEE DETAILS:\n");
            Console.WriteLine("Name: {0} {1}", obj.firstName, obj.lastName);
            Console.WriteLine("Designation: {0}", obj.designation);
            Console.WriteLine("Net Salary: {0}", obj.netSalary);
            Console.WriteLine("Gross Salary: {0}\n", obj.grossSalary);
        }
    }
}
