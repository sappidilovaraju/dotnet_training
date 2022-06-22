using System;

namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Compile time
            BaseCaluculation a = new Caluculation();

            // Runtime poly morp
            BaseClass b = new DerivedClass();
            b.Add(1, 2);
            
            //Caluculation calc = new Caluculation();
            ////Console.WriteLine(calc.Add(1, 2)); // 3 + 1
            ////Console.WriteLine(calc.Sub(2, 2)); // 0
            ////Console.WriteLine(calc.Mul(2, 2)); // 4
            ////Console.WriteLine(calc.Div(4, 2)); // 2
            //Console.WriteLine(calc.Coutner);

            ////Encapsulation obj = new Encapsulation();
            ////obj.IncreaseCountBy(); // +1, counter = 1
            ////obj.IncreaseCountBy(); // +1, counter = 2
            ////Console.WriteLine(obj.Counter);
            Console.ReadKey();
        }
    }

    // Method Overriding
    public class DerivedClass : BaseClass
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    public class BaseClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class MethodOverloading
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    public class AbstractDerivedClass: AbstractTestClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract method implementation");
        }
    }

    public abstract class AbstractTestClass
    {
        public abstract void AbstractMethod();
        public void NonAbstractMethod()
        {
            Console.WriteLine("This is non abstract method");
        }
    }


    public class BaseInterfaceClass : IBaseInterface
    {
        public void Add()
        {
            Console.WriteLine("This is implementation of Add.");
        }
    }

    public interface IBaseInterface
    {
        void Add();
    }

    public class Caluculation : BaseCaluculation
    {
        public Caluculation()
        {
            base.Coutner = 1;
        }

        public override int Add(int a, int b)
        {
            return a + b + 1;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }
    }

    public class BaseCaluculation
    {
        public int Coutner { get; set; }
        public BaseCaluculation()
        {
            Coutner = 0;
        }

        public virtual int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }

    public class Encapsulation
    {
        private int _counter = 0;
        public int Counter
        { 
            get { return _counter; }
        }

        public void IncreaseCountBy()
        {
            _counter++;
        }
    }


}
