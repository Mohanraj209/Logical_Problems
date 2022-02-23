using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Problems
{
	public class Logical_pgms
	{
		/// <summary>
		/// Code for Fibonacci series..
		/// </summary>
		public static void Fibonacci()
		{
			int n1 = 0, n2 = 1, n3, i, number;
			Console.Write("\n Enter the number of elements: ");
			number = int.Parse(Console.ReadLine());
			Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
			for (i = 2; i < number; i++) //loop starts from 2 because 0 and 1 are already printed    
			{
				n3 = n1 + n2;
				Console.Write(n3 + " ");
				n1 = n2;
				n2 = n3;
			}
		}

		/// <summary>
		/// Code for Perfect number..
		/// </summary>
		public static void Perfect_num()
		{

			int i, num, Sum = 0;
			Console.Write("\n\n Please Enter any Number: ");
			num = Convert.ToInt32(Console.ReadLine());

			for (i = 1; i < num; i++)
			{
				if (num % i == 0)
				{
					Sum = Sum + i;
				}
			}
			if (Sum == num)
			{
				Console.WriteLine(String.Format("{0} is a Perfect Number", num));
			}
			else
			{
				Console.WriteLine(String.Format("{0} is NOT a Perfect Number", num));
			}
		}

		/// <summary>
		/// Code for Prime number..
		/// </summary>
		public static void Prime_num()
		{

			int i, p = 0, flag = 0;
            int num;// it is the number to be checked
			Console.WriteLine("\n Enter the number to check it is prime ot not");
			num = Convert.ToInt32(Console.ReadLine());

			p = num / 2;
			if (num == 0 || num == 1)
			{
				Console.WriteLine(num + " is not prime number");
			}
			else
			{
				for (i = 2; i <= p; i++)
				{
					if (num % i == 0)
					{
						Console.WriteLine(num + " is not prime number");
						flag = 1;
						break;
					}
				}
				if (flag == 0)
				{
					Console.WriteLine(num + " is prime number");
				}
			}
		}

		/// <summary>
		/// Code for Reverse number..
		/// </summary>
		public static void Reverse_num()
		{

			int num, reverse = 0;
			Console.WriteLine("\n Enter the number to reverse it");
			num = Convert.ToInt32(Console.ReadLine());
			for (; num != 0; num = num / 10)
			{
				int remainder = num % 10;
				reverse = reverse * 10 + remainder;
			}
			Console.WriteLine("The reverse of the given number is: " + reverse);
		}

	}
}


