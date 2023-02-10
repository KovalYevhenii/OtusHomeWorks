using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleAppSheet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int maxValue = 1000000;
			Stopwatch stopwatch = new Stopwatch();
			

			// all operations for List
			List<int> listNumbers = new();
			stopwatch.Start();
			for (int i = 1; i <= maxValue; i++)
			{
				listNumbers.Add(i);
			}
			stopwatch.Stop();
			Console.WriteLine("Time taken to add elements to List: " + stopwatch.ElapsedMilliseconds + "ms");
	
			stopwatch.Start();
			int element = listNumbers[496753];
			stopwatch.Stop();
			Console.WriteLine("Time to find the 496,753rd element in List: " + stopwatch.ElapsedMilliseconds + "ms\n");
			stopwatch.Start();


			Console.WriteLine("All numbers dividable by 777 without riminder\n");
			List<int> divisibleBy777 = listNumbers.Where(maxValue => maxValue % 777 == 0).ToList();
			foreach(int number in divisibleBy777)
			{
				Console.Write($"{number}, ");
			}
			stopwatch.Stop();
			Console.WriteLine("\nTime to retrive all elements in a collection" +
				" that are devisible by 777 element in List: " + stopwatch.ElapsedMilliseconds + "ms\n");

			//all operations for array List
			ArrayList arrayListNumbers = new();
			stopwatch.Start();
			for (int i = 1; i <= maxValue; i++)
			{
				arrayListNumbers.Add(i);
			}
			stopwatch.Stop();
			Console.WriteLine("Time taken to add elements to Array List: " + stopwatch.ElapsedMilliseconds + "ms");
			stopwatch.Start();
			 element = (int)arrayListNumbers[496753];
			stopwatch.Stop();
			Console.WriteLine("Time to find the 496,753rd element in arrayList: " + stopwatch.ElapsedMilliseconds + "ms");

			stopwatch.Start();
			List<int> divisibleBy777ArrayList = listNumbers.OfType<int>().Where(maxValue => maxValue % 777 == 0).ToList();
			foreach(int number in divisibleBy777ArrayList)

			stopwatch.Stop();
			Console.WriteLine("Time to retrive all elements in a collection" +
				" that are devisible by 777 element in Array List: " + stopwatch.ElapsedMilliseconds + "ms\n");
			
			//all operations for Linked List
			LinkedList<int> linkedListNumbers = new();
			stopwatch.Start();
			for (int i = 1; i <= maxValue; i++)
			{
				linkedListNumbers.AddLast(i);
			}
			stopwatch.Stop();
			Console.WriteLine("Time taken to add elements to Linked List: " + stopwatch.ElapsedMilliseconds + "ms");
			
			stopwatch.Start();
			var value = linkedListNumbers.ElementAt(496753);
			stopwatch.Stop();
			Console.WriteLine("Time to find the 496,753rd element in arrayList: " + stopwatch.ElapsedMilliseconds + "ms");

			stopwatch.Start();
			List<int> divisibleBy777LinkedList = linkedListNumbers.OfType<int>().Where(maxValue => maxValue % 777 == 0).ToList();
			foreach (int number in divisibleBy777ArrayList)
				stopwatch.Stop();
			Console.WriteLine("Time to retrive all elements in a collection" +
				"that are devisible by 777 element in Array List: " + stopwatch.ElapsedMilliseconds + "ms\n");


		}
	
	}
}