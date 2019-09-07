////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "HondaCity.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.DecoratorDesignPattern
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    /// <seealso cref="DesignPattern.DecoratorDesignPattern.IVehicle" />
    public class HondaCity : IVehicle
    {
        /// <summary>
        /// Gets the make.
        /// </summary>
        /// <value>
        /// The make.
        /// </value>
        public string Make
        {
            get
            {
                return "HondaCity";
            }
        }

        /// <summary>
        /// Gets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public string Model
        {
            get
            {
                return "CNG";
            }
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price
        {
            get
            {
                return 100000;
            }
        }
    }
}
