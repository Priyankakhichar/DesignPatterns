////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Adaptee.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;

    /// <summary>
    /// Main class 
    /// </summary>
    public class Adaptee
    {
        /// <summary>
        /// Checks the adapter.
        /// </summary>
        public void CheckAdapter()
        {
            ISocket isocket = new SocketClassAdapterImplementation();
            Volt v3 = this.GetVolt(isocket, 3);
            Volt v12 = this.GetVolt(isocket, 12);
            Volt v120 = this.GetVolt(isocket, 120);
            Console.WriteLine(" for V3 volt is : " + v3.Volts);
            Console.WriteLine(" for V12 volt is : " + v12.Volts);
            Console.WriteLine(" for v120 volt is : " + v120.Volts);
        }

        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <param name="isocket">The socket.</param>
        /// <param name="i">The i.</param>
        /// <returns>return voltage according to user input</returns>
        public Volt GetVolt(ISocket isocket, int i)
        {
            switch (i)
            {
                case 3: return isocket.Get3Volt();
                    
                case 12: return isocket.Get12Volt();
                    
                case 120: return isocket.Get120Volt();
                    
                default: return isocket.Get120Volt();                 
            }
        }
    }
}
