using System;
using static System.Console;

namespace ConsoleApp1
{
    enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

    public struct Coffee
    {
        private string[] beverages;

        public Coffee(string bev1)
        {
            beverages = new string[] { "Latte", "Cappucino" };
        }

        public string this[int index]
        {
            get { return this.beverages[index]; }
            set { this.beverages[index] = value; }
        }

        public int Length
        {
            get { return this.beverages.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World");

            Day favoriteDay = (Day)5;
        }
    }
}
