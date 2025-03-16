// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp
{
  internal class Program
  {
    static void Main(string[] args)
    {

			//PrintHelloWorld();

			//PrintFullName();

			SumOfTwoNumber();

			//detail of variable

			//string firstName = "";
			//firstName = "Cherry";

			//int age = 0;
			//age = 5;

			//double price = 0;
			//price = 10.5;
		}

		public static void PrintHelloWorld()
		{
			Console.WriteLine("Hello World!");
		}

		public static void PrintFullName()
		{
			string firstName = "";
			string lastName = "";
			string fullName = "";

			Console.WriteLine("Please Enter your FirstName");
			firstName = Console.ReadLine();

			Console.WriteLine("Please Enter your LastName");
			lastName = Console.ReadLine();

			fullName = firstName + " " +lastName;
			Console.WriteLine("Your full name is: " + fullName);

		}

		public static void SumOfTwoNumber() {
			int number1 = 0;
			int number2 = 0;
			int sum = 0;

			Console.WriteLine("Please Enter First Number");
			number1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please Enter Second Number");
			number2 = Convert.ToInt32(Console.ReadLine());

			sum = number1 + number2;

			Console.WriteLine("Sum is: " + sum);

		}
  }
}
