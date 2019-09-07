////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Computer.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// abstract super class
    /// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// Gets the ram.
        /// </summary>
        /// <returns>returning the value of RAM</returns>
        public abstract string GetRAM();

        /// <summary>
        /// Gets the HDD.
        /// </summary>
        /// <returns>returning the value of HDD</returns>
        public abstract string GetHDD();

        /// <summary>
        /// Gets the CPU.
        /// </summary>
        /// <returns>returning the value of CPU</returns>
        public abstract string GetCPU();

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "RAM :" + this.GetRAM() + "  HDD :" + this.GetHDD() + "  CPU :" + this.GetCPU(); 
        }
    }
}
