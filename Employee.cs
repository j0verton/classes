using System;
using System.Collections.Generic;

namespace classes
{
    // Define class here
    public class Employee
    {
        public Employee(string firstName, string lastName, string title, DateTime started)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartDate = started;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; set; }
        public DateTime StartDate { get; }

    }
}