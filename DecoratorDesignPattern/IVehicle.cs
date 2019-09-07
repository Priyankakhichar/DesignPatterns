////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "IVehicle.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.DecoratorDesignPattern
{
    /// <summary>
    /// The 'Component' interface
    /// </summary>
    public interface IVehicle
    {
        /// <summary>
        /// Gets the make.
        /// </summary>
        /// <value>
        /// The make.
        /// </value>
        string Make { get; }

        /// <summary>
        /// Gets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        string Model { get; }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        double Price { get; }
    }
}
