////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "ProxyTest.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ProxyDesignPattern
{
    using System;

    /// <summary>
    /// ProxyTest class has function to checkProxy class
    /// </summary>
    public class ProxyTest
    {
        /// <summary>
        /// Checks the proxy.
        /// </summary>
        public void CheckProxy()
        {
            ProxyAPI proxyAPI = new ProxyAPI();
            int price = proxyAPI.GetCurrentGoldPrice(true);
            if (price > 0)
            {
                Console.WriteLine("current gold price is : " + price);
            }
            else
            {
                Console.WriteLine("no api is called");
            }

            int price1 = proxyAPI.GetCurrentGoldPrice(false);
            if (price1 > 0)
            {
                Console.WriteLine("current gold price is: " + price1);
            }
            else
            {
                Console.WriteLine("No API is called");
            }
        }
    }
}
