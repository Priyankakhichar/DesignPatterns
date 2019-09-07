////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Book.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// Book class have function for name and price
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.ItemElement" />
    public class Book : ItemElement
    {
        /// <summary>
        /// The price
        /// </summary>
        private int price;

        /// <summary>
        /// The ISBN number
        /// </summary>
        private string isbnNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="cost">The cost.</param>
        /// <param name="isbn">The ISBN.</param>
        public Book(int cost, string isbn)
        {
            this.price = cost;
            this.isbnNumber = isbn;
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <returns>returning price</returns>
        public int GetPrice()
        {
            return this.price;
        }

        /// <summary>
        /// Gets the ISBN number.
        /// </summary>
        /// <returns>returning the string value</returns>
        public string GetIsbnNumber()
        {
            return this.isbnNumber;
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns>returning the price</returns>
        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
