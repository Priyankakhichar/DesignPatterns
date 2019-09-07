////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "MethodInjection.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.DepedencyInjection
{
    using System;

    /// <summary>
    /// MethodInjection
    /// </summary>
    public class MethodInjection
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public static void Test()
        {
            Client cn = new Client();
            cn.Run(new Service());
            Console.ReadKey();
        }
    }
}
