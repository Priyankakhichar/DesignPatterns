////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Fruit.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// fruit class
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.ItemElement" />
    public class Fruit : ItemElement
    {
        /// <summary>
        /// The price per kg
        /// </summary>
        private int pricePerKg;

        /// <summary>
        /// The weight
        /// </summary>
        private int weight;

        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fruit"/> class.
        /// </summary>
        /// <param name="pricePerKg">The price per kg.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="name">The name.</param>
        public Fruit(int pricePerKg, int weight, string name)
        {
            this.pricePerKg = pricePerKg;
            this.weight = weight;
            this.name = name;
        }

        /// <summary>
        /// Gets the price per kg.
        /// </summary>
        /// <returns>returning the price</returns>
        public int GetPricePerKg()
        {
            return this.pricePerKg;
        }

        /// <summary>
        /// Gets the weight.
        /// </summary>
        /// <returns>returning the weight</returns>
        public int GetWeight()
        {
            return this.weight;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>returning the name</returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns>
        /// returning price
        /// </returns>
        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
