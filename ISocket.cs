////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "ISocket.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    /// <summary>
    /// Interface having three methods
    /// </summary>
    public interface ISocket
    {
        /// <summary>
        /// Get120s the volt.
        /// </summary>
        /// <returns>returning voltage</returns>
        Volt Get120Volt();

        /// <summary>
        /// Get12s the volt.
        /// </summary>
        /// <returns>returning voltage</returns>
        Volt Get12Volt();

        /// <summary>
        /// Get3s the volt.
        /// </summary>
        /// <returns>returning voltage</returns>
        Volt Get3Volt();
    }
}
