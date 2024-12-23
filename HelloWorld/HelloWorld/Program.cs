using System;
using System.Linq;
using System.IO;

namespace HelloWorld
{
    //Methods
    //static bool evenorodd(int num)
    //{
    //    if (num % 2 == 0) {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}


    //static string country(string country = "Norway") {
    //    return $"Country is {country}";
    //}

    //static string plus(string name, int age)
    //{
    //    return $"my name is {name} and age is {age}";
    //}

    ////example of overloading
    //static int plus(int num1, int num2) {
    //    return num1 + num2;
    //}
    //static double plus(double num1, double num2) {
    //    return (num1 + num2);
    //}
    class Program : Car
    {
        static void Main(string[] args)
        {
            //int a = 2, f = 3;
            //double b = 2.3;
            //char c = 'a';
            //string d = "hello";
            //bool e = true;
            //const int i = 1;
            //Console.WriteLine("this is int " + a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine("this is declaration in one line " + f);
            //a = f = 4;
            //Console.WriteLine("this is assigment in one line " + f);






            /*
             * Type Casting
            */

            //double a= 1.22222222222222222222222222222;
            //float c = (float) a;
            //Console.WriteLine("this is down casting from double to float"+a);

            //long l = 1000000000000000000L;
            //Console.WriteLine("this is down casting from long to int " + Convert.ToInt64(l));

            /*
             * User Inputs
            */

            //Console.WriteLine("What is capital of pak");
            //string a = Console.ReadLine();
            //Console.WriteLine("capital is " + a);







            /*
               Math
            */

            //int a = 1;
            //int b = 2;

            //int c = Math.Max(a, b);
            //Console.WriteLine(c);
            //c = Math.Min(a, b);
            //Console.WriteLine(c);






            /*
               Strings
            */

            //string a = "Hello world";
            //string b = "Hello 2nd world";
            //int age = 25;
            //string c = a.ToLower();
            //Console.WriteLine("ToLower: " + c);
            //c = a.ToUpper();
            //Console.WriteLine("ToUpper: " + c);
            //c = string.Concat(a,b.ToLower());
            //Console.WriteLine("Concat " + c);
            //Console.WriteLine("this Concat with + Sign: " + a + b);
            //Console.WriteLine($"My age is: {age}");


            //int pos = a.IndexOf('w');
            //string sub = a.Substring(pos);
            //Console.WriteLine("this is sub string: " + sub);
            //string escape = "we are \"Viking\" and we support this symbol \\";
            //Console.WriteLine("exampel of escape: " + escape);








            /*
               Strings
            */

            //int a = 3,b = 3;

            //if(a < b)
            //{
            //    Console.WriteLine("a is lower than b");
            //}else if(a == b){
            //    Console.WriteLine("a is equal to b");
            //}
            //else
            //{
            //    Console.WriteLine("a is greaten than b");
            //}

            ////ternary operator

            //string result = (a >= b) ? "a is greater or equal": "b is greater";
            //Console.WriteLine(result);








            /*
               foreach loop
            */

            //string[] a = { "car", "bike", "model"};

            //foreach(string s in a)
            //{
            //    Console.WriteLine(s);
            //}








            /*
               Arrays
            */

            //int[] arr1 = { 1, 2, 3, };
            //string[] arr2 = { "1", "2", "3" };
            ////decalre array with specfic size
            //int[] arr3 = new int[4];
            ////decalere and assign
            //int[] arr4 = new int[4] {6,3,4,5};
            //Console.WriteLine(arr4[1]);
            //Console.WriteLine(arr4.Max());

            //// sorting of array
            //Array.Sort(arr4);
            //foreach(int i in arr4)
            //{
            //    Console.WriteLine("i is " + i);
            //}

            ////2D array
            //int[,] twoD = { { 1, 2, 3 }, { 4, 5, 6 } };

            //foreach(int i in twoD)
            //{
            //    Console.WriteLine("2D array: " + i);
            //}

            ////2D using for loop this is rectangular array with same element in every child array
            //int[,] forarr = { { 1, 2, }, { 3, 4 } };

            //for(int i = 0; i < forarr.GetLength(0); i++)
            //{
            //    for(int j = 0; j < forarr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"in 2D value at [{i},{j}] is: {forarr[i, j]}");
            //    }
            //}

            ////jagged array with diffrent number of elements in child array
            //int[][] jagg = new int[][]
            //{
            //    new int[] {1,2},
            //    new int[] {3,4,5},
            //};

            //for(int i = 0; i < jagg.Length; i++)
            //{
            //    for(int j = 0; j < jagg[i].Length; j++)
            //    {
            //        Console.WriteLine($"jagged array value at [{i},{j}] is: {jagg[i][j]}");
            //    }
            //}






            /*
               Methods
            */
            //bool isEven = evenorodd(345);
            //if (isEven) {
            //    Console.WriteLine("number is even");
            //}
            //else
            //{
            //    Console.WriteLine("number is odd");
            //}
            ////exampel of parameter
            //Console.WriteLine(country("pakistan"));
            //Console.WriteLine(country("india"));
            //Console.WriteLine(country());

            ////example of ky value argument
            //Console.WriteLine(plus(age: 24, name: "Hamza Burhan"));

            ////example of overloading
            //Console.WriteLine("this is int plus: " + plus(1,2));
            //Console.WriteLine("this is double plus: " + plus(1.30, 2.5));








            /*
               Classes
               other file is named Car.cs
            */



            //example of two objects of one class
            //Car ford = new Car();
            //ford.model = 1;
            //ford.color = "red";

            //Car mustang = new Car();
            //mustang.model = 2;
            //mustang.color = "YELLOW";


            //example of encapsulation

            //Car mycar = new Car();
            //mycar.SecretKey = 12345;
            //Console.WriteLine(mycar.SecretKey);


            //example of inheritance
            //Car myobj = new Car();
            //myobj.vehicleMetod();
            //myobj.carmethod();


            //example of polymorphism

            //Vehicle myV = new Vehicle();
            //myV.honk();
            //Vehicle myV2 = new Car();
            //myV2.honk();



            //Example of Abstraction

            //Car Paypal = new Car();
            //Paypal.PaymentId = 1;
            //Paypal.setPayment();


            //Exampel of interfaces

            //Car car = new Car();
            //Action<string> vehicleDelegate = car.returnVehcleMethod();

            //vehicleDelegate("Hamza");



            //Enums example in interface.cs
            //Console.WriteLine(EMonth.fab);
            //Console.WriteLine((int) EMonth.fab);



            //example of files

            //File.WriteAllText("custom.txt", "Hello");
            //string name = File.ReadAllText("custom.txt");
            //Console.WriteLine(name);



            //Example of error Exeption
            //try
            //{
            //    int[] arr = { 1, 2, };
            //    Console.WriteLine(arr[10]);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //finally
            //{
            //    Console.WriteLine("I run every time");
            //}







        }
    }
}
