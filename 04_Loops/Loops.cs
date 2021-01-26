﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _04_Loops
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 0;

            while (total < 100)
            {
                // total = total + 1;
                // total += 1;
                total++;
                Console.WriteLine("Total: " + total);
            }

            int number = 5;
            Console.WriteLine(++number);

            Random randy = new Random();
            int someNumber = randy.Next(0, 21);

            while (true)
            {
                someNumber = randy.Next(0, 21);
                if (someNumber == 7)
                {
                    break;
                }
            }
            Console.WriteLine("out of the loop!");
        }

        [TestMethod]
        public void forLoops()
        {
            string greeting = "hello world!";

            foreach (char letter in greeting)
            {
                Console.WriteLine(letter);
            }

            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("World");
            stringList.Add("banana");

            foreach(string word in stringList)
            {
                Console.WriteLine(word);
            }

            Random randy = new Random();

            for (int i = 0; i != 5; i = randy.Next(0, 21))
            {
                Console.WriteLine(i);
            }
        }
    }
}
