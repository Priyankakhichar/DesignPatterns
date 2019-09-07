////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "ShoppingCartVisitorImp.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    using System;

    /// <summary>
    /// ShoppingCartVisitorImp have function to visit fruit and book class
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.ShoppingCartVisitor" />
    public class ShoppingCartVisitorImp : ShoppingCartVisitor
    {
        /// <summary>
        /// Visits the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns>returning the price of book</returns>
        public int Visit(Book book)
        {
            int cost = 0;
            if (book.GetPrice() > 50)
            {
                cost = book.GetPrice() - 5;
            }
            else
            {
                cost = book.GetPrice();
            }

            Console.WriteLine("Book Isbn " + book.GetIsbnNumber() + "cost = " + cost);
            return cost;
        }

        /// <summary>
        /// Visits the specified fruit.
        /// </summary>
        /// <param name="fruit">The fruit.</param>
        /// <returns>returning the cost of item</returns>
        public int Visit(Fruit fruit)
        {
            int cost = fruit.GetPricePerKg() * fruit.GetWeight();
            Console.WriteLine(fruit.GetName() + " cost = " + cost);
            return cost;
        }
    }
}
