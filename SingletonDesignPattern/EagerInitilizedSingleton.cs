////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "EagerInitilizedSingleton.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.SingletonDesignPattern
{
    /// <summary>
    /// eager initialization
    /// </summary>
    public class EagerInitilizedSingleton
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static EagerInitilizedSingleton instance = new EagerInitilizedSingleton();

        /// <summary>
        /// Prevents a default instance of the <see cref="EagerInitilizedSingleton"/> class from being created.
        /// </summary>
        private EagerInitilizedSingleton()
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns>returning instance of EagerInitializedSingleton</returns>
        public static EagerInitilizedSingleton GetInstance()
        {
            return instance;
        }
    }
}
