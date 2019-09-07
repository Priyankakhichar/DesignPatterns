////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "AddAddress.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FacadeDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;

    /// <summary>
    /// AddAddress class having function to add details to file
    /// </summary>
    public class AddAddress 
    {
        /// <summary>
        /// Adds the data to file.
        /// </summary>
        public void AddDataToFile()
        {
            Console.WriteLine("please enter the firstName");
            string firstName = Console.ReadLine();
            if (!Regex.IsMatch(firstName, "^[a-zA-z]+$"))
            {
                Console.WriteLine("firstName is not valid");
                return;
            }

            Console.WriteLine("please enter the lastName");
            string lastName = Console.ReadLine();
            if (!Regex.IsMatch(lastName, "^[a-zA-z]+$"))
            {
                Console.WriteLine("LastName is not valid");
                return;
            }

            Console.WriteLine("please enter the mobile no");
            string mobileNo = Console.ReadLine();
            if (!Regex.IsMatch(mobileNo, "^[0-9]+$"))
            {
                Console.WriteLine("MobileNo is not valid");
                return;
            }

            Console.WriteLine("pease enter the Address");
            string address = Console.ReadLine();
            if (string.IsNullOrEmpty(address))
            {
                Console.WriteLine("address is not valid");
                return;
            }

            Console.WriteLine("please enter the city");
            string city = Console.ReadLine();
            Console.WriteLine("please enter the state");
            string state = Console.ReadLine();
            Console.WriteLine("please enter the zipcode");
            string zipcode = Console.ReadLine();
            if (!Regex.IsMatch(zipcode, "^[0-9]+$"))
            {
                return;
            }

            AddressDetails addressDetails = new AddressDetails();
            addressDetails.FirstName = "Test";

            AddressDetails details = new AddressDetails(firstName, lastName, mobileNo, address, city, state, zipcode);
            using (StreamReader reader = new StreamReader(@"C:\Users\Admin\source\repos\DesignPattern\DesignPattern\facadeDesignPattern\AddressJson.json"))
            {
                string jsonContent = reader.ReadToEnd();
                reader.Close();

                ////converting json file to object
                List<AddressDetails> addressList = JsonConvert.DeserializeObject<List<AddressDetails>>(jsonContent);

                ////adding address details to the list
                addressList.Add(details);

                ////converting object to string
                string jsonfile = JsonConvert.SerializeObject(addressList);

                ////writing data to the file
                File.WriteAllText(@"C:\Users\Admin\source\repos\DesignPattern\DesignPattern\facadeDesignPattern\AddressJson.json", jsonfile);
            }           
        }
    }
}
