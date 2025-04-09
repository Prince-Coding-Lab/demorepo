// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp
{
  internal class Program
  {
    static void Main(string[] args)
    {

			StaffDomain staffDomain = new StaffDomain();
			Console.WriteLine("Please Enter the Brand Name");
		  string brand = Console.ReadLine();

			staffDomain.AddBrand(brand);
			//staffDomain.GetStaffData();

			//staffDomain.GetCustomerData();
			//staffDomain.GetStaffDataSet();
			//string message = string.Empty;

			//Message objMessage = new Message();
			//message = objMessage.SendMessage1();

			//Whatsaap objWhatsapp = new Whatsaap();
			//message= objWhatsapp.SendMessage1();

			//Bike objBike = new Bike();


			//Employee.GetEmployeeName();

			//Student objStudent = new Student();
			//	objStudent.GetStudentNameV1();

			//string NameValue = "";

			//NameValue = objStudent.GetStudentNameV2();

			//Console.WriteLine(NameValue);


			//string NameValue1 = "My Name is Prince";
			//objStudent.GetStudentNameV3(NameValue1);

			//string firstName = "Prince";
			//string lastName = "Sharma";

			//string fullName = "";

			//fullName = objStudent.PrintYourFullName(firstName, lastName);

			//Console.WriteLine(fullName);

			//int number1 = 0;
			//int number2 = 0;
			//Console.WriteLine("Please Enter First Number");
			//number1 = Convert.ToInt32(Console.ReadLine());

			//Console.WriteLine("Please Enter Second Number");
			//number2 = Convert.ToInt32(Console.ReadLine());
			//SumOfTwoNumberV2(number1, number2);

			//SumOfTwoNumber();



			//PrintHelloWorld();

			//PrintFullName();

			//SumOfTwoNumber();
			//CalculateAgeLabel();
			//IdentifyEvenOddNumber();

			//WorkingWithForLoop();
			//FindPrimeNumber();

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


		public static void SumOfTwoNumberV2(int number1, int number2)
		{
			int sum = 0;
			sum = number1 + number2;

			Console.WriteLine("Sum is: " + sum);

		}

		public static void CalculateAgeLabel()
		{ 
			int age = 0;

			Console.WriteLine("Please Enter the Age");
			age = Convert.ToInt32(Console.ReadLine());

			if (age < 15)
			{
				Console.WriteLine("You are a child");
			}
			else if (age > 15 && age < 35)
			{
				Console.WriteLine("you are very young");
			}
			else {
				Console.WriteLine("You are very old");
			}
		
		}

		public static void IdentifyEvenOddNumber()
		{
			int number = 0;
			Console.WriteLine("Please enter the number");
			number = Convert.ToInt32(Console.ReadLine());

			if (number % 2 == 0)
			{
				Console.WriteLine("This is a even number");
			}
			else {
				Console.WriteLine("This is a odd number");
			}
		
		}

		public static void WorkingWithForLoop()
		{

			for (int i = 1; i <= 5; i++)
			{
				Console.WriteLine(i);

			}
		
		}

		public static void FindPrimeNumber()
		{
			int number = 0;
			bool NotPrime = false;
			Console.WriteLine("Please enter the number");
			number = Convert.ToInt32(Console.ReadLine());
			for (int i = 2; i <= number; i++)
			{
				if (number % 1 == 0 && number % number == 0 && number % i != 0)
				{

				}
				else
				{
					Console.WriteLine("It is not a prime number");
					NotPrime = true;
					break;
				}
				

			}
			if (!NotPrime)
			{
				Console.WriteLine("This is a prime number");
			}


		}
  }

	public class Student {

		//fields
		private int id;
		public string name;

		//method
		public void GetStudentNameV1()
		{
			Console.WriteLine("My Name is Prince");
		}

		public string GetStudentNameV2()
		{
			return "My Name is Prince";
		}


		public void GetStudentNameV3(string nameValue)
		{
			Console.WriteLine(nameValue);
		}


		public string PrintYourFullName(string firstName, string lastName)
		{

			string fullName = string.Empty;

			fullName = firstName +" "+ lastName;

			return fullName;
		}

	}
}
