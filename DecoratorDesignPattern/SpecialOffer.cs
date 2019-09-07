////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "SpecialOffer.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DecoratorDesignPattern
{
    using System;

    /// <summary>
    /// ConcreteDecorator class
    /// </summary>
    /// <seealso cref="DesignPattern.DecoratorDesignPattern.VehicleDecorator" />
    public class SpecialOffer : VehicleDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialOffer"/> class.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        public SpecialOffer(IVehicle vehicle) : base(vehicle)
        {
        }

        /// <summary>
        /// Gets or sets the discount percentage.
        /// </summary>
        /// <value>
        /// The discount percentage.
        /// </value>
        public int DiscountPercentage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the offer.
        /// </summary>
        /// <value>
        /// The offer.
        /// </value>
        public string Offer
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the NewPrice.
        /// </summary>
        /// <value>
        /// The old Price
        /// </value>
        public double NewPrice
        {
            get
            {
                double oldPrice = Price;
                int percentage = 100 - this.DiscountPercentage;
                return Math.Round(oldPrice * percentage / 100, 2);
            }
        }
    }
}
