////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Format.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DepedencyInjection
{
    using System;

    /// <summary>
    /// Format
    /// </summary>
    /// <seealso cref="DesignPattern.DepedencyInjection.IText" />
    public class Format : IText
    {
        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("here is text format");
        }
    }
}
