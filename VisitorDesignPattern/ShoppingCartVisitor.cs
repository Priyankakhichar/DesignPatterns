////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "ShoppingCartVisitor.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// interface ShoppingCartVisitor
    /// </summary>
    public interface ShoppingCartVisitor
    {
        /// <summary>
        /// Visits the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns>returning the price of book</returns>
        int Visit(Book book);

        /// <summary>
        /// Visits the specified fruit.
        /// </summary>
        /// <param name="fruit">The fruit.</param>
        /// <returns>returning the price of fruit</returns>
        int Visit(Fruit fruit);
    }
}
