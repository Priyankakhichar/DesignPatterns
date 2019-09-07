////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "AddressDetails.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FacadeDesignPattern
{
    /// <summary>
    /// Address Book Details
    /// </summary>
    public class AddressDetails
    {
        /// <summary>
        /// The first name
        /// </summary>
        private string firstName;

        /// <summary>
        /// The last name
        /// </summary>
        private string lastName;

        /// <summary>
        /// The mobile no
        /// </summary>
        private string mobileNo;

        /// <summary>
        /// The address
        /// </summary>
        private string address;

        /// <summary>
        /// The city
        /// </summary>
        private string city;

        /// <summary>
        /// The state
        /// </summary>
        private string state;

        /// <summary>
        /// The zip code
        /// </summary>
        private string zipCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressDetails"/> class.
        /// </summary>
        public AddressDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressDetails"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="mobileNo">The mobile no.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipcode">The ZipCode.</param>
        public AddressDetails(string firstName, string lastName, string mobileNo, string address, string city, string state, string zipcode)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MobileNo = mobileNo;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipcode;
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

        /// <summary>
        /// Gets or sets the mobile no.
        /// </summary>
        /// <value>
        /// The mobile no.
        /// </value>
        public string MobileNo
        {
            get
            {
                return this.mobileNo;
            }

            set
            {
                this.mobileNo = value;
            }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.address = value;
            }
        }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City
        {
            get
            {
                return this.city;
            }

            set
            {
                this.city = value;
            }
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.state = value;
            }
        }

        /// <summary>
        /// Gets or sets the zip Code.
        /// </summary>
        /// <value>
        /// The zipCode.
        /// </value>
        public string ZipCode
        {
            get
            {
                return this.zipCode;
            }

            set
            {
                this.zipCode = value;
            }
        }
    }
}
