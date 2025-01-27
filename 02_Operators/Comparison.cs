﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 21;
            bool equals = age == 21;
            Console.WriteLine("Am I 21? " + equals);

            string name = "Zuri";

            Console.WriteLine(name == "Michelle");

            bool notEqual = age != 200;

            Console.WriteLine("I'm not two centuries old am I?" + notEqual);

            List<string> firstList = new List<string>();
            firstList.Add(name);
            List<string> secondList = new List<string>();
            secondList.Add(name);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine("Are the lists exactly the same>" + listsAreEqual);

            // These are references to values, not the values themselves
            // This is the difference between value and references types


            bool amIAnAdult = age >= 18;
            // <  > <=  >=

            bool amEighteen = age == 18;
            bool amOverEighteen = age > 18;

            // OR
            amIAnAdult = amEighteen || amOverEighteen;

            // AND
            bool hasGreen = true;
            bool hasNavy = true;
            bool myFaveColors = hasGreen && hasNavy;

            // XOR, NAND, NOR, XNOR <-- not included, but intersting
        }
    }
}
