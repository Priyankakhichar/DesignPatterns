////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "TestFactory.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FactoryDesignPattern
{
    using System;

    /// <summary>
    /// TestFactory class for testing the factory class
    /// </summary>
    public class TestFactory
    {
        /// <summary>
        /// Tests the computer factory.
        /// </summary>
        public void TestComputerFactory()
        {
            Computer pc = ComputerFactory.GetComputer("Pc", "4 GB", "250 GB", "2.4 GHz");
            Computer laptop = ComputerFactory.GetComputer("Laptop", "6 GB", "400 GB", "2.8 GHz");
            Computer server = ComputerFactory.GetComputer("Server", "8 GB", "500 GB", "2.10GHZ");
            Console.WriteLine("Details for Pc is : " + pc);
            Console.WriteLine("Details for laptop is : " + laptop);
            Console.WriteLine("Details for server is : " + server);
        }
    }
}
