using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Creating_Classes_Final

{

    internal class Program

    {

        static void Main()

        {

            Person P1Ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person P2Gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person P3Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person P4Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Console.WriteLine(P2Gina.DisplayPersonInfo());
            Console.WriteLine(P3Mike.ToString());
            Console.WriteLine(P1Ian.ChangeFavoriteColor());
            Console.WriteLine(P4Mary.GetAgeInTenYears());

        }

    }

}