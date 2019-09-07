////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Client.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DepedencyInjection
{
    using System;

    /// <summary>
    /// Client class
    /// </summary>
    public class Client
    {
        /// <summary>
        /// The set
        /// </summary>
        private ISet set;

        /// <summary>
        /// Runs the specified serv.
        /// </summary>
        /// <param name="ser">The ser.</param>
        public void Run(ISet ser)
        {
            this.set = ser;
            Console.WriteLine("start");
            this.set.Print();
        }
    }
}
