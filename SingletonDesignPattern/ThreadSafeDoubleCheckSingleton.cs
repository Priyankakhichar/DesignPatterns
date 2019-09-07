////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "ThreadSafeDoubleCheckSingleton.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.SingletonDesignPattern
{
    /// <summary>
    /// ThreadSafeDoubleCheckSingleton
    /// </summary>
    public sealed class ThreadSafeDoubleCheckSingleton
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static ThreadSafeDoubleCheckSingleton instance = null;

        /// <summary>
        /// The object lock
        /// </summary>
        private static object objectLock = new object();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadSafeDoubleCheckSingleton"/> class.
        /// </summary>
        public ThreadSafeDoubleCheckSingleton()
        {
        }

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static ThreadSafeDoubleCheckSingleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (objectLock)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafeDoubleCheckSingleton();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
