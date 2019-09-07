////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "ComputerFactory.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// computerFactory having instance of computer class
    /// </summary>
    public class ComputerFactory
    {
        /// <summary>
        /// Gets the computer
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="ram">The ram.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The CPU.</param>
        /// <returns>object of sub-class of computer</returns>
        public static Computer GetComputer(string type, string ram, string hdd, string cpu)
        {
            if ("Pc".Equals(type))
            {
                return new Pc(ram, hdd, cpu);
            }

            if ("Laptop".Equals(type))
            {
                return new Server(ram, hdd, cpu);
            }

            if ("Server".Equals(type))
            {
                return new Laptop(ram, hdd, cpu);
            }

            return null;
        }
    }
}
