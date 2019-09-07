////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "ProtoTypePatternTest.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ProtoTypeDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// ProtoTypeDesignPattern test
    /// </summary>
    public class ProtoTypePatternTest
    {
        /// <summary>
        /// Proto the type pattern test start.
        /// </summary>
        public void ProtoTypePatternTestStart()
        {
            Employee employee = new Employee();
            employee.LoadData();

            ////getting the employee object using Clone method.
            Employee empNew = (Employee)employee.Clone();

            ////getting the employee object using Clone method.
            Employee newEmp1 = (Employee)employee.Clone();

            ////getting the list of employee using empNew object
            List<string> list = empNew.GetEmpList();

            ////addign a member to list
            list.Add("punendra");

            ////getting the list of employees using newEmp1 object
            List<string> list1 = newEmp1.GetEmpList();

            ////removing one content from list
            list1.Remove("Deep");
            Console.Write("employee original list is :-> ");

            ////printing the list through PrintList method
            this.PrintList(employee.GetEmpList());
            Console.WriteLine();
            Console.Write("employee list1 :-> ");

            //// printing the list through PrintList method
            this.PrintList(list);
            Console.WriteLine();
            Console.Write("employee list2 :-> ");

            ////printing the list through PrintList method
            this.PrintList(list1);
        }

        /// <summary>
        /// Prints the list of Employees
        /// </summary>
        /// <param name="list">The list.</param>
        public void PrintList(List<string> list)
        {
            foreach (string s in list)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();
        }
    }
}
