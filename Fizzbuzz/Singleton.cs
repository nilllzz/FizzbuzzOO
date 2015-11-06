using System;
using System.Reflection;

namespace Fizzbuzz
{
    /// <summary>
    /// A base class for a thread-safe singleton pattern implementation.
    /// The type that uses this class must not have a public constructor.
    /// </summary>
    public abstract class Singleton<T> where T : class
    {
        private static volatile T _instance;
        private static readonly object _lockObject = new object();

        /// <summary>
        /// The instance of this singleton class.
        /// </summary>
        public static T Instance
        {
            get
            {
                EnsureInstanceExists();
                return _instance;
            }
        }

        private static void EnsureInstanceExists()
        {
            lock (_lockObject)
            {
                if (_instance == null)
                {
                    var singletonType = typeof(T);

                    //Ensure there are no public constructors...
                    if (singletonType.GetConstructors(BindingFlags.Public).Length > 0)
                    {
                        throw new InvalidOperationException(string.Format("'{0}' can be instanciated multiple time because of public constructor.", singletonType.Name));
                    }

                    _instance = (T)Activator.CreateInstance(singletonType, true);
                }
            }
        }
    }
}
