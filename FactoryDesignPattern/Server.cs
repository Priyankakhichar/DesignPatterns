////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "Server.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// Server class inheriting Computer class
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryDesignPattern.Computer" />
    public class Server : Computer
    {
        /// <summary>
        /// The ram
        /// </summary>
        private string ram;

        /// <summary>
        /// The HDD
        /// </summary>
        private string hdd;

        /// <summary>
        /// The CPU
        /// </summary>
        private string cpu;

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The CPU.</param>
        public Server(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        /// <summary>
        /// Gets the ram.
        /// </summary>
        /// <returns>
        /// returning the value of RAM
        /// </returns>
        public override string GetRAM()
        {
            return this.ram;
        }

        /// <summary>
        /// Gets the HDD.
        /// </summary>
        /// <returns>
        /// returning the value of HDD
        /// </returns>
        public override string GetHDD()
        {
            return this.hdd;
        }

        /// <summary>
        /// Gets the CPU.
        /// </summary>
        /// <returns>
        /// returning the value of CPU
        /// </returns>
        public override string GetCPU()
        {
            return this.cpu;
        }
    }
}
