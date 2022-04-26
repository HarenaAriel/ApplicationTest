using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reshape
{
  public class Program
  {
    public static void Main(string[] args)
    {

      int i = 0;
      Console.Out.WriteLine(i++);

      Console.Out.WriteLine("");

      var res = new String[] { "Pomme", "Boruto", "Red", "Mouche", "Test" }.Max(c => c.Length);
      Console.WriteLine(res);
      var ano = new { Fruit = "Pomme", Perso = "Boruto" }; // Declare an anonymous variable
      Console.WriteLine(ano.Fruit);

      Console.Out.WriteLine("");

      Console.Out.WriteLine(Reshape(5, "abc de fghij k"));
      Console.Out.WriteLine(Reshape(2, "1 23 4567 89"));

      Console.Out.WriteLine("");

      List<string> strs = new List<string>();
      strs.Add("Guys");
      strs.Add("Liths");
      strs.Add("Luke");
      strs.Add("Asthem");
      strs.Add("Labs");

      foreach (string str in NewEnum(strs))
      {
        Console.Out.WriteLine(str);
      }

      Console.Out.WriteLine("");

      string resultat = solve(100, 150, 50, 10); // width, height, length, mass
      Console.Out.WriteLine(resultat);

      Console.Read();
    }

    public static string Reshape(int n, string str)
    {
      string strToReturn = "";

      char[] c = str.Replace(" ", "").ToCharArray();
      string concat = "";

      for (int i = 0; i < c.Count(); i++)
      {
        concat += c[i];

        if(concat.Length == n)
        {
          strToReturn += concat + " ";
          concat = "";
        }

        if (i + 1 == c.Count())
        {
          strToReturn += concat + " ";
          concat = "";
        }
      }

      return strToReturn;
    }

    public static IEnumerable<string> NewEnum(List<string> strings)
    {
      IEnumerable<string> strEnum = strings.Where(x => x.Substring(0, 1).ToUpper() == "L").OrderBy(x => x);

      return strEnum;
    }

    /*
     * solve the following problems
     * encombrant si W * H * L >= 1000000 || W ou H ou L >= 150
     * lourd si M >= 20
     * STD si non encombrant et non lourd
     * SPL si encombrant ou lourd
     * RJT si encombrant et lourd
     */

    public static string solve(int width, int height, int length, int mass)
    {

      int VolLimit = 1000000;
      int DimLimit = 150;
      int MassLimit = 20;
      int siEncombrant = width * height * length;


      if (((siEncombrant >= VolLimit) || (width == DimLimit || height == DimLimit || length == DimLimit)) && (mass >= MassLimit))
      {
        return "RJT";
      }
      else if (((siEncombrant >= VolLimit) || (width == DimLimit || height == DimLimit || length == DimLimit)) || (mass >= MassLimit))
      {
        return "SPL";
      }
      else
      {
        return "STD";
      }

      return "";
    }

  }
}
