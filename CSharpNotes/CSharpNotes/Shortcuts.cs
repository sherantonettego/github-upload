using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp1
{
    class Shortcuts
    {

        #region GetInput methods

        #region GetString overloads
        public static string GetString(string message)
        {
            string input;

            WriteLine(message);
            input = ReadLine();

            return input;
        }

        public static string GetString()
        {
            string input;

            input = ReadLine();

            return input;
        }

        #endregion

        #region GetInt overloads

        public static int GetInt(string message)
        {
            string input;
            int value;

            WriteLine(message);
            input = ReadLine();
            while (int.TryParse(input, out value) == false)
            {
                Write("Please input a valid integer: ");
                input = ReadLine();
            }

            return value;
        }


        public static int GetInt()
        {
            string input;
            int value;

            input = ReadLine();
            while (int.TryParse(input, out value) == false)
            {
                Write("Please input a valid integer: ");
                input = ReadLine();
            }

            return value;
        }

        #endregion

        #region GetDouble overloads

        public static double GetDouble(string message)
        {
            string input;
            double value;

            WriteLine(message);
            input = ReadLine();
            while (double.TryParse(input, out value) == false)
            {
                Write("Please input a valid number: ");
                input = ReadLine();
            }

            return value;
        }

        public static double GetDouble()
        {
            string input;
            double value;

            input = ReadLine();
            while (double.TryParse(input, out value) == false)
            {
                Write("Please input a valid number: ");
                input = ReadLine();
            }

            return value;
        }

        #endregion

        #endregion

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }

}
