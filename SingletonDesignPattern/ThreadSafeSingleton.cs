////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "ThreadSafeSingleton.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.SingletonDesignPattern
{
    /// <summary>
    /// simple thread safe
    /// </summary>
    public sealed class ThreadSafeSingleton
    {
        /// <summary>
        /// The lock1.
        /// </summary>
        public static readonly object Lock1 = new object();

        /// <summary>
        /// The instance
        /// </summary>
        private static ThreadSafeSingleton instance = null;

        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSafeSingleton"/> class from being created.
        /// </summary>
        public ThreadSafeSingleton()
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (Lock1)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }

                    return instance;
                }
            }
        }
    }
}
