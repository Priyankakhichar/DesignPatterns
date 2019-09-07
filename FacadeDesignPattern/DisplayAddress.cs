////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "DisplayAddress.cs" company ="Bridgelabz">
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
    using Newtonsoft.Json;

    /// <summary>
    /// Display Address having the function to display the content
    /// </summary>
    public class DisplayAddress
    {
        /// <summary>
        /// Reads the data from file.
        /// </summary>
        public void ReadDataFromFile()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\Admin\source\repos\DesignPattern\DesignPattern\facadeDesignPattern\AddressJson.json"))
            {
                string jsonContent = reader.ReadToEnd();
                reader.Close();

                ////converting json file to object form
                List<AddressDetails> list = JsonConvert.DeserializeObject<List<AddressDetails>>(jsonContent);

                ////displaying the details
                foreach (AddressDetails details in list)
                {
                    Console.WriteLine("firstName " + details.FirstName + "\tLastName : " + details.LastName + "\tMobileNo " + details.MobileNo + "\tAddress " + details.Address + "\tcity " + details.City + "\tState " + details.State + "\tZipCpde " + details.ZipCode);
                }
            }
        }
    }
}
