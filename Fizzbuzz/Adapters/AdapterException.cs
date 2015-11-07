using System;

namespace Fizzbuzz.Adapters
{
    sealed class AdapterException : Exception
    {
        public AdapterException(Type adapterType, Exception inner) : base("An adapter error occurred in adapter class: " + adapterType.Name, inner)
        { }
    }
}
