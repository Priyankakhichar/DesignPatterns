////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Service.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DepedencyInjection
{
    using System;

    /// <summary>
    /// Iset interface
    /// </summary>
    public interface ISet
    {
        /// <summary>
        /// Prints this instance.
        /// </summary>
        void Print();
    }

    /// <summary>
    /// Service class
    /// </summary>
    /// <seealso cref="DesignPattern.DepedencyInjection.ISet" />
    public class Service : ISet
    {
        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("print somthing");
        }
    }
}
