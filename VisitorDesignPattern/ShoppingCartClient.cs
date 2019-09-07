////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "ShoppingCartClient.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    using System;

    /// <summary>
    /// ShoppingCartClient 
    /// </summary>
   public class ShoppingCartClient
    {
        /// <summary>
        /// Shopping the cart.
        /// </summary>
        public void ShoppingCart()
        {
            ItemElement[] items = new ItemElement[] { new Book(20, "1234"), new Book(100, "5678"), new Fruit(10, 2, "Banana"), new Fruit(5, 5, "Apple") };
            ////calculate the total price
            int total = CalculatePrice(items);
            Console.WriteLine("Total Cost = " + total);
        }

        /// <summary>
        /// Calculates the price.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns>returning the total price</returns>
        private static int CalculatePrice(ItemElement[] items)
        {
            ShoppingCartVisitor visitor = new ShoppingCartVisitorImp();
            int sum = 0;
            foreach (ItemElement item in items)
            {
                sum = sum + item.Accept(visitor);
            }

            return sum;
        }
    }
}
