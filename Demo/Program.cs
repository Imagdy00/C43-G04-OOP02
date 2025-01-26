namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 1 
            //            using System;

            //// Class Example
            //class MyClass
            //        {
            //            public int X { get; set; }
            //            public int Y { get; set; }
            //        }

            //        // Struct Example
            //        struct MyStruct
            //        {
            //            public int X { get; set; }
            //            public int Y { get; set; }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                // Class is a reference type
            //                MyClass objClass = new MyClass { X = 10, Y = 20 };
            //                MyClass objClass2 = objClass;
            //                objClass2.X = 30;
            //                Console.WriteLine($"Class: objClass.X = {objClass.X}, objClass2.X = {objClass2.X}");

            //                // Struct is a value type
            //                MyStruct objStruct = new MyStruct { X = 10, Y = 20 };
            //                MyStruct objStruct2 = objStruct;
            //                objStruct2.X = 30;
            //                Console.WriteLine($"Struct: objStruct.X = {objStruct.X}, objStruct2.X = {objStruct2.X}");
            //            }
            //        }
            #endregion

            #region Video 2 
            //            using System;

            //// Base Class
            //class Animal
            //        {
            //            public void Eat()
            //            {
            //                Console.WriteLine("Eating...");
            //            }
            //        }

            //        // Derived Class
            //        class Dog : Animal
            //        {
            //            public void Bark()
            //            {
            //                Console.WriteLine("Barking...");
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                Dog dog = new Dog();
            //                dog.Eat(); // Inherited from Animal
            //                dog.Bark(); // Defined in Dog
            //            }
            //        }
            #endregion

            #region Video 3
            //            using System;

            //// Base Class
            //class Shape
            //        {
            //            public virtual void Draw()
            //            {
            //                Console.WriteLine("Drawing a shape");
            //            }
            //        }

            //        // Derived Classes
            //        class Circle : Shape
            //        {
            //            public override void Draw()
            //            {
            //                Console.WriteLine("Drawing a circle");
            //            }
            //        }

            //        class Rectangle : Shape
            //        {
            //            public override void Draw()
            //            {
            //                Console.WriteLine("Drawing a rectangle");
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                Shape shape1 = new Circle();
            //                Shape shape2 = new Rectangle();

            //                shape1.Draw(); // Output: Drawing a circle
            //                shape2.Draw(); // Output: Drawing a rectangle
            //            }
            //        }
            #endregion


            #region Video 4
            //            using System;

            //class Calculator
            //        {
            //            // Method Overloading
            //            public int Add(int a, int b)
            //            {
            //                return a + b;
            //            }

            //            public int Add(int a, int b, int c)
            //            {
            //                return a + b + c;
            //            }

            //            public double Add(double a, double b)
            //            {
            //                return a + b;
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                Calculator calc = new Calculator();
            //                Console.WriteLine(calc.Add(1, 2)); // Output: 3
            //                Console.WriteLine(calc.Add(1, 2, 3)); // Output: 6
            //                Console.WriteLine(calc.Add(1.5, 2.5)); // Output: 4.0
            //            }
            //        }
            #endregion


            #region Video 5
            //            using System;

            //// Base Class
            //class Animal
            //        {
            //            public virtual void MakeSound()
            //            {
            //                Console.WriteLine("Animal sound");
            //            }
            //        }

            //        // Derived Class
            //        class Dog : Animal
            //        {
            //            public override void MakeSound()
            //            {
            //                Console.WriteLine("Bark");
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                Animal myAnimal = new Dog();
            //                myAnimal.MakeSound(); // Output: Bark
            //            }
            //        }
            #endregion

            #region Video 6
            //            using System;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                // Early Binding (Static Binding)
            //                int sum = 1 + 2;
            //                Console.WriteLine($"Sum: {sum}"); // Output: Sum: 3
            //            }
            //        }
            #endregion

            #region Video 7
            //            using System;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                // Late Binding (Dynamic Binding)
            //                object obj = "Hello";
            //                string str = obj.ToString(); // Late binding happens here
            //                Console.WriteLine(str); // Output: Hello
            //            }
            //        }
            #endregion

            #region Video 8
            //            using System;

            //class Program
            //        {
            //            static void Main()
            //            {
            //                // Early Binding Example
            //                int a = 5;
            //                int b = 10;
            //                int result = a + b; // Early binding
            //                Console.WriteLine($"Result: {result}");

            //                // Late Binding Example
            //                object obj = "Hello";
            //                dynamic dyn = obj;
            //                Console.WriteLine(dyn.ToUpper()); // Late binding
            //            }
            //        }
            #endregion

            #region Video 9
//            using System;

//class Program
//        {
//            static void Main()
//            {
//                // Early Binding
//                string text = "Hello, World!";
//                Console.WriteLine(text.ToUpper()); // Output: HELLO, WORLD!

//                // Late Binding
//                object obj = "Hello, World!";
//                dynamic dyn = obj;
//                Console.WriteLine(dyn.ToUpper()); // Output: HELLO, WORLD!
//            }
//        }
        #endregion
    }
    }
}
