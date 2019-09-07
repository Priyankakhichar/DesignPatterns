////-------------------------------------------------------------------------------------------------------------------------------
////<copyright file = "LazyInitialization.cs" company ="Bridgelabz">
////Copyright © 2019 company ="Bridgelabz"
////</copyright>
////<creator name ="Priyanka khichar"/>
////
////-------------------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.SingletonDesignPattern
{
    /// <summary>
    /// Lazy Initialization
    /// </summary>
    public sealed class LazyInitialization
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="LazyInitialization"/> class from being created.
        /// </summary>
        private LazyInitialization()
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static LazyInitialization GetInstance
        {
            get
            {
                return Nested.Instance;
            }
        }

        /// <summary>
        /// Nested class
        /// </summary>
        private class Nested
        {
            /// <summary>
            /// The instance
            /// </summary>
            internal static readonly LazyInitialization Instance = new LazyInitialization();

            /// <summary>
            /// Initializes static members of the <see cref="Nested"/> class.
            /// </summary>
            static Nested()
            {
            }
        }
    }
}
