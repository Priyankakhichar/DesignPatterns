////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Employee.cs" company ="Bridgelabz">
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
    /// Employee class implementing List interface
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    public class Employee : ICloneable
    {
        /// <summary>
        /// The Employee list
        /// </summary>
        private List<string> empList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee()
        {
            this.empList = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="list">The list.</param>
        public Employee(List<string> list)
        {
            this.empList = list;
        }

        /// <summary>
        /// Loads the data.
        /// </summary>
        public void LoadData()
        {
            this.empList.Add("priyanka");
            this.empList.Add("kapil");
            this.empList.Add("harshil");
            this.empList.Add("minesh");
            this.empList.Add("Deep");
        }

        /// <summary>
        /// Gets the Employee list.
        /// </summary>
        /// <returns>returning the list of employees</returns>
        public List<string> GetEmpList()
        {
            return this.empList;
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        public object Clone()
        {
            List<string> temp = new List<string>();
            foreach (string s in this.GetEmpList())
            {
                temp.Add(s);
            }

            return new Employee(temp);
        }
    }
}
