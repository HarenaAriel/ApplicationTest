using System;
using System.Collections.Generic;

namespace ApplicationTest
{
	class Program
	{
		public static void Main(string[] args)
		{

			#region Test Delegates

			MyClass cl = new MyClass();
			cl.LongRunning(SomeMethod);
			cl.StringValues(SomeMethod);

			#endregion

			Console.ReadLine();
		}

		static void SomeMethod(int i)
		{
			Console.WriteLine(i);
		}

		static void SomeMethod(String i)
		{
			Console.WriteLine(i);
		}

	}

	public class MyClass
	{

		List<string> str = new List<String>() { "mamy", "Tojo", "Emma", "Tsiry", "Boss" };

		public delegate void CallBack(int i); // Create a delegate function that send the result value whenever the programs needs it.
		public delegate void CallBackString(String a);

		public void LongRunning(CallBack obj) // Call the delegate function to send a value of an integer types
		{
			for (int i = 0; i < 5; i++)
			{
				obj(i); // Invoke the value of i (integer) and pass it throught the delegate
			}
		}

		public void StringValues(CallBackString obj)
		{
			for (int i = 0; i < str.Count; i++)
			{
				obj(str[i]); // Invoke the value of str[i] (String) and pass it throught the delegate
			}
		}

	}

}