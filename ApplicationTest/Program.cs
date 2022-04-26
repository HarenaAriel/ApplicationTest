using System;

namespace ApplicationTest
{
  class Program
  {
    public static void Main(string[] args)
    {

      #region Test

      int[] ints = { 500, 800, 3, -1, 10, 70, 500 };

      Console.WriteLine("Largest Number");
      Console.WriteLine(largestNumber(ints) + "\n");

      Console.WriteLine("Closest Zero Number Positive");
      Console.WriteLine(closestToZero(ints) + "\n");

      int[] newList = sortList(ints);

      Console.WriteLine("Sort a List of Number");
      for (int i = 0; i < newList.Length; i++)
      {
        Console.WriteLine(newList[i]);
      }

      Console.WriteLine("");

      Console.WriteLine("Coins change");
      Change c = scanchange(6);

      Console.WriteLine(c.coin2 + " coins 2, " + c.bill5 + " bills of 5 and " + c.bill10 + " bills of 10 \n");

      string test1 = "Math";
      string test2 = "Science";

      string result = string.Format("first {0} then second {1}", test1, test2);

      Console.WriteLine(result); // first form
      Console.WriteLine($"first {test1} then second {test2}"); // '$' allow to use interpolation on variable itself

      /* Recursion Test function */

      recursionTest(5);

      #endregion

      Console.ReadLine();
    }

    #region Test

    class Change
    {
      public long coin2 = 0;
      public long bill5 = 0;
      public long bill10 = 0;
    }

    static int largestNumber(int[] ints)
    {
      int largest = ints[0];

      for (int i = 0; i < ints.Length; i++)
      {
        if (ints[i] > largest)
        {
          largest = ints[i];
        }
      }

      return largest;
    }

    static int closestToZero(int[] ints)
    {
      int closest = ints[0];

      for (int i = 0; i < ints.Length; i++)
      {
        if (ints[i] > 0 && ints[i] < closest)
        {
          closest = ints[i];
        }
      }

      return closest;
    }

    static int[] sortList(int[] ints)
    {
      int a;

      for (int i = 0; i < ints.Length; i++)
      {
        for (int j = i + 1; j < ints.Length; j++)
        {
          if (ints[i] > ints[j])
          {
            a = ints[i];
            ints[i] = ints[j];
            ints[j] = a;
          }
        }
      }

      return ints;

    }

    static Change scanchange(long s)
    {
      Change c = new Change();
      if (s == 1)
      {
        return c;
      }
      else
      {
        long montant = s;

        if(montant % 2 == 0 && montant < 10)
        {
          c.coin2 = montant / 2;
          montant = montant % 2;
        }

        if (montant >= 10)
        {
          c.bill10 = montant / 10;
          if (montant % 10 >= 2)
          {
            montant = montant % 10;
          }
        }

        if (montant >= 5 && montant < 10)
        {
          c.bill5 = montant / 5;
          if (montant % 5 >= 2)
          {
            montant = montant % 5;
          }
        }

        if (montant >= 2 && montant < 5)
        {
          c.coin2 = montant / 2;
          if (montant % 2 >= 2)
          {
            montant = montant % 2;
          }
        }

        return c;
      }
    }

    static char scanChart(string s)
    {
      for (char c = 'A'; c <= 'Z'; c++)
      {
        //if (asciiart.printchar(c) == s)
        //{
        //  return c;
        //}
      }

      return '?';
    }

    static void recursionTest(int stock)
    {
      if(stock <= 0)
      {
        Console.WriteLine("There are no stock left.");
      }
      else
      {
        Console.WriteLine($"Only {stock} left.");
        recursionTest(stock - 1);
      }
    }

    #endregion

  }


}