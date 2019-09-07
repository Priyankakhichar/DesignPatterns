////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "TestFacadeAddress.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FacadeDesignPattern
{
    using System;

    /// <summary>
    /// TestFacadeAddress have function to check FacadePattern
    /// </summary>
    public class TestFacadeAddress
    {
        /// <summary>
        /// Tests the facade.
        /// </summary>
        public void TestFacade()
        {
            FacadeAddress address = new FacadeAddress();
            Console.WriteLine("1. for Add");
            Console.WriteLine("2. for Display");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: address.Add.AddDataToFile();
                    break;

                case 2: address.Display.ReadDataFromFile();
                    break;
            }
        }
    }
}
