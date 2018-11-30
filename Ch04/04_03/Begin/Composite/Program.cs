using System;
using System.Collections.Generic;

/// <summary>
/// This code demonstrates the composite pattern for an application where 
/// any employee can see their own performance record. The supervisor can 
/// see their own and their subordinate’s performance record
/// </summary>
namespace Composite.Demonstration
{
    //'IComponent' interface
    public interface IEmployee
    {
        int EmployeeID { get; set; }
        string Name { get; set; }
        int Rating { get; set; }
        void PerformanceSummary();
    }
    //'Leaf' class - will be leaf node in tree structure
    public class Employee : IEmployee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public void PerformanceSummary()
        {
            Console.WriteLine("\nPerformance summary of employee: " +
                              $"{Name} is {Rating} out of 5");
        }
    }
    //'Composite' class - will be branch node in tree structure
    public class Supervisor : IEmployee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

        public List<IEmployee> ListSubordinates = new List<IEmployee>();

        public void PerformanceSummary()
        {
            Console.WriteLine("\nPerformance summary of supervisor: " +
                              $"{Name} is {Rating} out of 5");
        }

        public void AddSubordinate(IEmployee employee)
        {
            ListSubordinates.Add(employee);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // TODO
        }
    }
}