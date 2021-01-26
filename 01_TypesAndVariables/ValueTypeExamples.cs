using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void Booleans()
        {
            //declare
            bool isDeclared;
            //initialize
            isDeclared = true;

            bool isDeclaredAndInitialized = true;
            isDeclaredAndInitialized = false;

        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char anotherChar = ';';
            char specialChar = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            // sbyte
            int intMin = -2147483648;
            int intMax = 2147483647;

            long longExample = 9223372036854775807;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.0452315464d;
            decimal decimalExample = 1.0452313425686546468m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum PastryType { Cake = 20, Cupcake, Eclaire, Croissant, Danish, Donut}

        [TestMethod]
        public void Enums()
        {
            PastryType pastryType = PastryType.Donut;
            PastryType anotherOne = PastryType.Cake;

            //Casting = converting one type to another
            Console.WriteLine(pastryType);
            Console.WriteLine(anotherOne);
        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 21;

            DateTime today = DateTime.Now;

            DateTime birthdate = new DateTime(1999, 03, 22);

            Console.WriteLine(birthdate);

            TimeSpan myAge = today - birthdate;

            Console.WriteLine(today - birthdate);
        }
    }
}
