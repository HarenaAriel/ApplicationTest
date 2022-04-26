using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutRefApps
{
  class Program
  {
    static void Main(string[] args)
    {
      int OutSideValue = 20;
      SomeMethod(ref OutSideValue);
      Console.WriteLine(OutSideValue);

      SomeMethod2(out OutSideValue);
      Console.WriteLine(OutSideValue);

      Console.Read();
    }

    /*
     * 2 way (pass Data and reference to the method and send it back)
     * Apply modified by the method logic
     * Keep the value the callee send to the caller
     */
    static void SomeMethod(ref int InsiderValue)
    {
      InsiderValue = InsiderValue + 10;
    }

    /*
     * 1 way (pass the Data and reference and only return the reference back)
     * Apply modification by the method logic
     * Re-new the value pass by reference and send the new value back
     */
    static void SomeMethod2(out int InsiderValue)
    {
      InsiderValue = 0;
      InsiderValue = InsiderValue + 10;
    }
  }
}
