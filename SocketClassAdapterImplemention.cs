////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "SocketClassAdapterImplementation.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    /// <summary>
    /// SocketClassAdapterImplementation
    /// </summary>
    /// <seealso cref="DesignPattern.Socket" />
    /// <seealso cref="DesignPattern.ISocket" />
    public class SocketClassAdapterImplementation : Socket, ISocket
    {
        /// <summary>
        /// Get120s the volt.
        /// </summary>
        /// <returns>
        /// returning voltage
        /// </returns>
        public Volt Get120Volt()
        {
            return this.GetVolt();
        }

        /// <summary>
        /// Get12s the volt.
        /// </summary>
        /// <returns>
        /// returning voltage
        /// </returns>
        public Volt Get12Volt()
        {
            Volt v = this.GetVolt();
            return this.ConvertVolt(v, 10);
        }

        /// <summary>
        /// Get3s the volt.
        /// </summary>
        /// <returns>
        /// returning voltage
        /// </returns>
        public Volt Get3Volt()
        {
            Volt v = this.GetVolt();
            return this.ConvertVolt(v, 40);
        }

        /// <summary>
        /// Converts the volt.
        /// </summary>
        /// <param name="v">The v.</param>
        /// <param name="i">The i.</param>
        /// <returns>returning converted volt</returns>
        private Volt ConvertVolt(Volt v, int i)
        {
            return new Volt(v.Volts / i);
        }
    }
}
