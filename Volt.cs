////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Volt.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    /// <summary>
    /// Volt class to convert voltage into integer number
    /// </summary>
    public class Volt
    {
        /// <summary>
        /// The volts
        /// </summary>
        private int volts;

        /// <summary>
        /// Initializes a new instance of the <see cref="Volt"/> class.
        /// </summary>
        /// <param name="v">The v.</param>
        public Volt(int v)
        {
            this.volts = v;
        }

        /// <summary>
        /// Gets or sets the volts.
        /// </summary>
        /// <value>
        /// The volts.
        /// </value>
        public int Volts
        {
            get
            {
                return this.volts;
            }

            set
            {
                this.volts = this.volts;
            }
        }
    }
}
