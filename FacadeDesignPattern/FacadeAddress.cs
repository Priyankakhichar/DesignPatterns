////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "FacadeAddress.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FacadeDesignPattern
{
    /// <summary>
    /// FacadeAddress have function to access another classes 
    /// </summary>
    public class FacadeAddress
    {
        /// <summary>
        /// The address
        /// </summary>
        private AddressDetails address;

        /// <summary>
        /// The add
        /// </summary>
        private AddAddress add;

        /// <summary>
        /// The display
        /// </summary>
        private DisplayAddress display;

        /// <summary>
        /// Initializes a new instance of the <see cref="FacadeAddress"/> class.
        /// </summary>
        public FacadeAddress()
        {
            this.address = new AddressDetails();
            this.add = new AddAddress();
            this.display = new DisplayAddress();
        }

        /// <summary>
        /// Gets or sets the add.
        /// </summary>
        /// <value>
        /// The add.
        /// </value>
        public AddAddress Add
        {
            get
            {
                return this.add;
            }

            set
            {
                this.add = value;
            }
        }

        /// <summary>
        /// Gets or sets the display.
        /// </summary>
        /// <value>
        /// The display.
        /// </value>
        public DisplayAddress Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        /// <summary>
        /// Calls the specific method.
        /// </summary>
        /// <param name="address">The address.</param>
        public void CallSpecificeMethod(AddAddress address)
        {
            address.AddDataToFile();
        }

        /// <summary>
        /// Calls the specific method.
        /// </summary>
        /// <param name="display">The display.</param>
        public void CallSpecificeMethod(DisplayAddress display)
        {
            display.ReadDataFromFile();
        }
    }
}
