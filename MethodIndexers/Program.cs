using System;

namespace MethodIndexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "1. Hello, World.";
            stringCollection[99] = "100. Hello, World.";
            Console.WriteLine(stringCollection[99]);
        }
    }

    class SampleCollection<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];

        // Define the indexer to allow client code to use [] notation.
        public T this[int i]
        {
            get => arr[i];
            set => arr[i] = value;
        }
    }
}
