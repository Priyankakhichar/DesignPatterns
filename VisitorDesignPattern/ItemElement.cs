////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "ItemElement.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// ItemElement interface
    /// </summary>
    public interface ItemElement
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns>returning price</returns>
        int Accept(ShoppingCartVisitor visitor);
    }
}
