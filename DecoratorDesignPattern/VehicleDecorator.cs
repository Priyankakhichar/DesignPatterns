////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "VehicleDecorator.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DecoratorDesignPattern
{
    /// <summary>
    /// Decorator abstract class
    /// </summary>
    /// <seealso cref="DesignPattern.DecoratorDesignPattern.IVehicle" />
    public abstract class VehicleDecorator : IVehicle
    {
        /// <summary>
        /// The vehicle
        /// </summary>
        private IVehicle vehicle;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleDecorator"/> class.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        public VehicleDecorator(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

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
                return this.vehicle.Make;
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
                return this.vehicle.Model;
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
                return this.vehicle.Price;
            }
        }
    }
}
