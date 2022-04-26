using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeAndTemp
{
  public class Program
  {
    /*
     * Ariel
     * 19-04-2022
     * Encode a text by its number per character
     * aaabbcccc => 3a2b4c
     */
    public static string EncodeString(string plainText)
    {
      string res = "";
      int counter = 0;

      char[] plainTextToArray = plainText.ToCharArray();
      char currentChar = plainTextToArray[0];

      for (int i = 0; i < plainTextToArray.Length; i++)
      {
        for(int j = 0; j < plainTextToArray.Length; j++)
        {
          if(plainTextToArray[i] == plainTextToArray[j])
          {
            counter += 1;
          }
          else
          {
            if (counter != 0)
            {
              if (!res.Contains(counter.ToString() + plainTextToArray[i].ToString()))
              {
                res += counter.ToString() + plainTextToArray[i].ToString();
              }
            }
            counter = 0;
          }
        }

      }

      return res;
    }

    /*
     * Ariel
     * 19-04-2022
     * Another way to get the encoding string
     */
    public static string EncodingStringAlternative(string plainText)
    {
      string res = "";

      char[] plainToArray = plainText.ToCharArray();

      List<char> simplified = new List<char>();

      foreach (char c in plainToArray)
      {
        if (!simplified.Contains(c))
        {
          simplified.Add(c);
        }
      }

      for (int i = 0; i < simplified.Count; i++)
      {
        res += plainText.Count(x => x == simplified[i]).ToString() + simplified[i].ToString();
      }

      return res;
    }

    /*
     * Ariel
     * 19-04-2022
     * Another way to get the encoding string
     */
    public static string EncodingStringAlternative2(string plainText)
    {
      string res = "";

      char[] plainToArray = plainText.ToCharArray();
      char[] plainToArrayDistinct = plainToArray.Distinct().ToArray();

      for (int i = 0; i < plainToArrayDistinct.Length; i++)
      {
        res += plainText.Count(x => x == plainToArrayDistinct[i]).ToString() + plainToArrayDistinct[i].ToString();
      }

      return res;
    }

    /*
     * Ariel
     * 19-04-2022
     * Find the Smallest interval in list of integer
     * [0, 1] => 1
     */
    public static int SmallestIntervals(int[] ints)
    {
      int smallest = ints[ints.Length - 1];

      for(int i = 0; i < ints.Length; i++)
      {
        for(int j = 0; j < ints.Length; j++)
        {
          if(ints[i] - ints[j] > 0 && ints[i] - ints[j] < smallest)
          {
            smallest = ints[i] - ints[j];
          }
        }
      }

      return smallest;
    }

    public static void Main(string[] args)
    {
      string testText = "aaabbccccddddeeefffffgggghiiijkkkllmmmnnoooppppqqrrrrssssstttttuuuuuuvvvvwwwwwxxxxyyyz";
      //string testText = "abc";
      //string testText = "abcdefghijklmnopqrstuvwxyz";
      string resultTest = Program.EncodeString(testText);
      string resultTestAlternative = Program.EncodingStringAlternative(testText);
      string resultTestAlternative2 = Program.EncodingStringAlternative2(testText);

      Console.WriteLine(resultTest);
      Console.WriteLine(resultTestAlternative);
      Console.WriteLine(resultTestAlternative2);

      Console.WriteLine("");

      int[] ints = { 0, 2, 5, 7, 9, 6 };
      int resultInts = Program.SmallestIntervals(ints);

      Console.WriteLine(resultInts);

      Console.WriteLine("");

      Console.Read();
    }
  }
}
