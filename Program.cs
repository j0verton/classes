using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company JoeInc = new Company("Joe Inc", DateTime.Now);

            // Create three employees
            Employee Jeff = new Employee("Jeff", "Jeff", "manager", DateTime.Today);
            Employee Steve = new Employee("Steve", "Jeff", "minion", DateTime.Today);
            Employee Sue = new Employee("Sue", "Jeff", "manager", DateTime.Today);

            // Assign the employees to the company
            JoeInc.HireEmployee(Jeff);
            JoeInc.HireEmployee(Steve);
            JoeInc.HireEmployee(Sue);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            JoeInc.ListEmployees();
        }
    }
}
