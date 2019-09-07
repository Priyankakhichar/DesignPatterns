////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "DemoDecorator.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.DecoratorDesignPattern
{
    using System;

    /// <summary>
    /// Decorator Pattern Demo
    /// </summary>
    public class DemoDecorator
    {
        /// <summary>
        /// Demo decorator start.
        /// </summary>
        public void DemoDecoratorStart()
        {
            HondaCity car = new HondaCity();

            ////price of car
            Console.WriteLine(" Honda City base price are : {0} ", car.Price);

            //// Special offer
            SpecialOffer offer = new SpecialOffer(car);
            offer.DiscountPercentage = 25;
            offer.Offer = "25 % discount";

            //// price of car after Special offer
            Console.WriteLine("{1} @ Diwali Special Offer and price are : {0} ", offer.NewPrice, offer.Offer);
        }
    }
}
