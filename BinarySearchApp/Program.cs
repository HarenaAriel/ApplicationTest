using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchApp
{
  class Program
  {
    static void Main(string[] args)
    {

      // Test the sorted arrays

      int[] arrays = { 15, 21, 30, 78, 56, 42, 34, 13, 97, 89 }; // { 5, 1, 0, 8, 6, 2, 4, 3, 7, 9};

      // Sort array

      SortArray(arrays);

      // Linear Search

      Console.WriteLine("Linear Search");
      int linearPosition = LinearSearch(arrays, 42); // 5
      Console.WriteLine("at the location : " + linearPosition);

      Console.WriteLine("");

      // Binary Search

      Console.WriteLine("Binary Search");
      int binaryPosition = BinarySearch(arrays, 42); // 2
      Console.WriteLine("at the location : " + binaryPosition);

      Console.WriteLine("");

      // Interpolation Search

      Console.WriteLine("Interpolation Search");
      int interpolationSearch = InterpolationSearch(arrays, 42); // 2
      Console.WriteLine("at the location : " + interpolationSearch);

      // Test

      int a = 5;
      int b = 5;

      int result = a-- * ++b;
      Console.WriteLine(result);

      Console.Read();

    }

    static void SortArray(int[] arrays)
    {
      int a;
      for(int i = 0; i < arrays.Length; i++)
      {
        for(int j = i + 1; j < arrays.Length; j++)
        {
          if(arrays[i] > arrays[j])
          {
            a = arrays[i];
            arrays[i] = arrays[j];
            arrays[j] = a;
          }
        }
      }
    }

    static int LinearSearch(int[] arrays, int k)
    {
      int position = 0;
      for(int i = 0; i < arrays.Length; i++)
      {
        if(arrays[i] == k)
        {
          position = i;
        }
      }
      return position;
    }

    static int BinarySearch(int[] arrays, int k) 
    {
      int position = 0;
      int upperValue = arrays.Length - 1; // Equals to the higher value - 1 of the array
      int lowerValue = 0;
      int midpoint = 0;
      int repLoop = 0;

      while(lowerValue <= upperValue)
      {
        repLoop++;

        midpoint = lowerValue + (upperValue - lowerValue) / 2;

        // Show value

        Console.WriteLine("");
        Console.WriteLine(repLoop  + " of the loop");
        Console.WriteLine("midpoint : " + midpoint + ", intArray[" + midpoint + "] = " + arrays[midpoint]);
        Console.WriteLine("lowerValue : " + lowerValue + ", intArray[" + lowerValue + "] = " + arrays[lowerValue]);
        Console.WriteLine("upperValue : " + upperValue + ", intArray[" + upperValue + "] = " + arrays[upperValue]);


        // Tasks 

        if(arrays[midpoint] == k)
        {
          position = midpoint; // Life's good no treatment
          break;
        }
        else
        {
          if(arrays[midpoint] < k) // if the value is lower that the k (item to find) lower is midpoint + 1
          {
            lowerValue = midpoint + 1;
          }
          else // if the value is upper that the k (item to find) upper is midpoint - 1
          {
            upperValue = midpoint - 1;
          }
        }

      }

      return position;
    }

    static int InterpolationSearch(int[] arrays, int k)
    {
      int position = 0;
      int upperValue = arrays.Length - 1; // Equals to the higher value - 1 of the array
      int lowerValue = 0;
      int midpoint = 0;
      int repLoop = 0;

      while (lowerValue <= upperValue)
      {
        repLoop++;

        midpoint = lowerValue + ((upperValue - lowerValue) / (arrays[upperValue] - arrays[lowerValue])) * (k - arrays[lowerValue]);

        // Show value

        Console.WriteLine("");
        Console.WriteLine(repLoop + " of the loop");
        Console.WriteLine("midpoint : " + midpoint + ", intArray[" + midpoint + "] = " + arrays[midpoint]);
        Console.WriteLine("lowerValue : " + lowerValue + ", intArray[" + lowerValue + "] = " + arrays[lowerValue]);
        Console.WriteLine("upperValue : " + upperValue + ", intArray[" + upperValue + "] = " + arrays[upperValue]);


        // Tasks 

        if (arrays[midpoint] == k)
        {
          position = midpoint; // Life's good no treatment
          break;
        }
        else
        {
          if (arrays[midpoint] < k) // if the value is lower that the k (item to find) lower is midpoint + 1
          {
            lowerValue = midpoint + 1;
          }
          else // if the value is upper that the k (item to find) upper is midpoint - 1
          {
            upperValue = midpoint - 1;
          }
        }

      }

      return position;
    }
  }
}
