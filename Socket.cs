////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Socket.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    /// <summary>
    /// Socket class
    /// </summary>
    public class Socket
    {
        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <returns>returning voltage</returns>
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }
}
