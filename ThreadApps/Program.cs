using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadApps
{
  class Program
  {
    static void Main(string[] args)
    {

      #region ForeGround Thread

      // This is actually a foreground thread

      Thread obj1 = new Thread(Function1); // Affect the method Function1 to the Thread 1
      Thread obj2 = new Thread(Function2); // Affect the method Function2 to the Thread 2

      obj1.Start(); // Invoke the method affected to the Thread 1
      obj2.Start(); // Invoke the method affected to the Thread 2

      #endregion

      #region BackGround Thread

      Thread obj3 = new Thread(Function3); // Affect the method Function2 to the Thread 2
      obj3.IsBackground = true;
      obj3.Start();

      Console.WriteLine("The app main has terminated execution ...");

      #endregion

      Console.Read();
    }

    static void Function1() 
    {
      for(int i = 0; i < 5; i++)
      {
        Console.WriteLine("Function 1 is running at " + i + " point");
        //wait for 2 Seconds 
        Thread.Sleep(2000);
      }
    }

    static void Function2()
    {
      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine("Function 2 is running at " + i + " point");
        //wait for 2 Seconds 
        Thread.Sleep(2000);
      }
    }

    static void Function3()
    {
      Console.WriteLine("Function 3 is enterred ...");
      Console.ReadLine();
      Console.WriteLine("Function 3 is exited ...");
    }
  }
}
