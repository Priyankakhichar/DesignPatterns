////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "GoldPrice.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ProxyDesignPattern
{
    using System;

    /// <summary>
    /// having function for gold Price
    /// </summary>
    public class GoldPrice : IPrice
    {
        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <returns>
        /// returning the price
        /// </returns>
        public int GetPrice()
        {
            Random random = new Random();
            return random.Next(999, 999999);
        }
    }
}
