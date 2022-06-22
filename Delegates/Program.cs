using System;

namespace Delegates
{
    internal class Program
    {
        public delegate void DisplayValue<T>(T a);

        static void Main(string[] args)
        {
            var displayStringDelegate = new DisplayValue<string>(DisplayString);
            var displayIntDelegate = new DisplayValue<int>(DisplayInteger);
            var displayDecimalDelegate = new DisplayValue<decimal>(DisplayDecimal);
            Display(displayStringDelegate, "This is string delegate");
            Display(displayIntDelegate, 100);
            Display(displayDecimalDelegate, 10000);
            Console.WriteLine("Hello World!");
        }

        static void Display<T>(DisplayValue<T> displayValue, T value)
        {
            displayValue.Invoke(value);
        }

        static void DisplayString(string value)
        {
            Console.WriteLine(value);
        }

        static void DisplayInteger(int value)
        {
            Console.WriteLine(value.ToString());
        }

        static void DisplayDecimal(decimal value)
        {
            Console.WriteLine(value.ToString());
        }
    }
}
