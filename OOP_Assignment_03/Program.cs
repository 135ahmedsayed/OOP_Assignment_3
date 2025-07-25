﻿using System.Drawing;

namespace OOP_Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part(1)
            #region Q1
            Console.WriteLine("The Sum is " + Add(10, 90));          // Add(int , int) => 100
            Console.WriteLine("The Sum is " + Add(10, 20, 50));       // Add(int , int , int) => 80
            Console.WriteLine("The Sum is " + Add(1.1, 0.1) + "\n"); // Add(double , double) => 1.2
            #endregion

            #region Q2
            Rectangle rectangle = new Rectangle();      // Parameterless constructor 0
            Console.WriteLine(rectangle.Rectangle1nfo); // Width: 0, Height: 0
            rectangle = new Rectangle(10, 20);          // Constructor with two parameters
            Console.WriteLine(rectangle.Rectangle1nfo); // Width: 10, Height: 20
            rectangle = new Rectangle(15);              // Constructor with one parameter
            Console.WriteLine(rectangle.Rectangle1nfo); // Width: 15, Height: 15
            #endregion

            #region Q3
            Console.Write("\n");
            Complex complex = new Complex(1, 6);
            Console.WriteLine(complex); // complex number = 1 + 6i
            Complex complex1 = new Complex(2, 3);
            Console.WriteLine(complex + complex1); // complex number = 3 + 9i
            Console.WriteLine(complex - complex1); // complex number = -1 + 3i
            Console.Write("\n");
            #endregion

            #region Q4
            Manager manager = new Manager();
            manager.work(); // Employee is  working and Manager is working
            #endregion

            #region Q5
            Console.Write("\n");
            BaseClass baseRef1 = new DerivedClass1();
            baseRef1.Display();  // Will call DerivedClass1's method (override) And (Dynamic Binding)

            BaseClass baseRef2 = new DerivedClass2();
            baseRef2.Display();  // Will call BaseClass's method (hiding) And (Static Binding)

            DerivedClass2 d2 = new DerivedClass2();
            d2.Display();        // Will call DerivedClass2's method And (Static Binding)
            #endregion
            #endregion

            #region Part(2)
            Console.WriteLine("\n");
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());
            Console.WriteLine($"{D1.GetHashCode()} Hashing Code");
            // Calculates Hours , Minutes and Seconds by Seconds
            D1 = new Duration(3600);
            Console.WriteLine(D1.ToString());           //Hours: 1 , Minutes : 0 , Seconds : 0
            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString());           //Hours: 2 , Minutes : 10 , Seconds : 0
            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString());           //Hours: 0 , Minutes : 11 , Seconds : 6
            // Adding two durations           
            D3 = D1 + D2;
            Console.WriteLine("D3 = D1 + D2 : " + D3);           //Hours: 3 , Minutes : 10 , Seconds : 0
            // Adding one durations and Seconds
            D3 = D1 + 7800;
            Console.WriteLine("D3 = D1 + 7800 : " + D3);           //Hours: 3 , Minutes : 10 , Seconds : 0
            D3 = 666 + D3;
            Console.WriteLine("D3 = 666 + D3 : " + D3);           //Hours: 3 , Minutes : 21 , Seconds : 6
            // (Increase One Minute)
            D3 = ++D1;
            Console.WriteLine("D3 = ++D1 : " + D3);           //Hours: 1 , Minutes : 1 , Seconds : 0
            //(Decrease One Minute)
            D3 = --D2;
            Console.WriteLine("D3 = --D2 : " + D3);           //Hours: 2 , Minutes : 9 , Seconds : 0
            // Sub two Duration
            D1 = D1 - D2;
            if (D1.hours < 0 || D1.minutes < 0 || D1.seconds < 0)
                Console.WriteLine("D1 = D1 - D2 : the Duration is Negative ");
            else
                Console.WriteLine(" D1 = D1 - D2 : " + D1);
            // >
            Console.WriteLine($" D1 > D2 :  {D1 > D2} ");
            // <=
            Console.WriteLine($" D1 <= D2 :  {D1 < D2} ");
            // bool
            if (D1)
                Console.WriteLine("if(D1) is not Zero or less ");
            // DateTime
            D1 = new Duration(1, 10, 15);
            DateTime Obj = (DateTime)D1;
            Console.WriteLine($"As DateTime: {Obj}");
            #endregion

            Console.ReadLine();
        }
        #region With part(1)
        #region Q1
        public static int Add(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        public static int Add(int Num1, int Num2, int Num3)
        {
            return Num1 + Num2 + Num3;
        }
        public static double Add(double Num1, double Num2)
        {
            return Num1 + Num2;
        }
        #endregion
        #endregion
    }
}
