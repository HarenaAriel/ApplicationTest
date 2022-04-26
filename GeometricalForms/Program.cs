using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GeometricalForms
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Square(15, 30);
      Triangle(15, 15);

      Console.WriteLine($"the value of pi is : {LetsFindPi(200)}");

      int n = 5;
      List<int> arr = new List<int>() { 1, 2, 3, 1, 2 , 1, 3};

      Console.WriteLine($"the result : {sockMerchant(n , arr)}");

      Console.Read();
    }

    public static void Square(int c1, int c2)
    {

      int ax = 0, ay = 0; // First Row & Column
      int aX = c1 - 1, aY = c2 - 1; // Last Row & Column

      Console.WriteLine((c1 == c2) ? "Square" : "Not Square");
      Console.WriteLine("");

      /* Empty Square */

      for (int i = 0; i < c1; i++) // Rows
      {
        if(i == ax || i == aX) // set the first and last row to be drawn
        {
          for (int j = 0; j < c2; j++) // columns
          {
            Console.Write("$");
          }
        }
        else
        {
          for (int j = 0; j < c2; j++) // columns
          {
            if (j == ay || j == aY)
            {
              Console.Write("$");
            }
            else
            {
              Console.Write(" ");
            }
          }

        }
          
        Console.WriteLine("");
      }

      Console.WriteLine(""); 

      /* Full Square */

      for (int i = 0; i < c1; i++) // Rows
      {
        for (int j = 0; j < c2; j++) // columns
        {
          Console.Write("$");
        }

        Console.WriteLine("");
      }

    }

    public static void Triangle(int h, int l)
    {
      int space = l - 1;

      for(int i = 0; i < h; i++)
      {
        for(int j = 0; j < l; j++)
        {
          /*
           * With else statement you get the opposite form of the triangle
           * Without you get the other portion
           */
          if(j >= space)
          {
            Console.Write("#");
          }
          else
          {
            Console.Write(" ");
          }
        }
        space--;
        Console.WriteLine("");
      }
    }

    public static double LetsFindPi(int n)
    {

      var rnd = new Random(); //Cryptographically weak so that it allows attackers to predict value be generated
      
      double num_point_circle = 0;
      double num_point_total = 0;

      for(int i = 0; i < n; i++)
      {
        double x = rnd.NextDouble();
        double y = rnd.NextDouble();

        //double x = RandomNumberGenerator.Create();
        //double y = RandomNumberGenerator;

        if (Math.Sqrt(Math.Pow(Math.Round(x, 1), 2) + Math.Pow(Math.Round(y, 1), 2)) < 1)
        {
          num_point_circle += 1;
        }

        num_point_total += 1;
      }

      return 4 * (num_point_circle/ num_point_total);
    }

    public static int sockMerchant(int n, List<int> ar)
    {
      int nbPair = 0;
      List<int> arrDist = ar.Distinct().ToList();

      int treat = 0;
      int rep = 0;
      
      for(int i = 0; i < arrDist.Count; i++)
      {
        for(int j = 0; j < ar.Count; j++)
        {
          treat = arrDist[i];
          if (treat == ar[j])
          {
            rep++;
          }

        }

        if (rep > 1)
        {
          nbPair += rep / 2;
        }

        rep = 0;
      }

      return nbPair;
    }
  }
}
