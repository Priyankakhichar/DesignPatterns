////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "ProxyAPI.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.ProxyDesignPattern
{
    /// <summary>
    /// Proxy class
    /// </summary>
    public class ProxyAPI
    {
        /// <summary>
        /// The price
        /// </summary>
        private IPrice price;

        /// <summary>
        /// Gets the current gold price.
        /// </summary>
        /// <param name="getPrice">if set to <c>true</c> [get price].</param>
        /// <returns>return the price of gold</returns>
        public int GetCurrentGoldPrice(bool getPrice)
        {
            if (getPrice)
            {
                this.price = new GoldPrice();

                ////getting the actual resources
                return this.price.GetPrice();
            }
            else
            {
                return 0;
            }
        }
    }
}
