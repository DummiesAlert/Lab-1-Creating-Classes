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

            Person Ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person Gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Console.WriteLine(Gina.DisplayPersonInfo());
            Console.WriteLine(Mike.ToString());
            Console.WriteLine(Ian.ChangeFavoriteColor());
            Console.WriteLine(Mary.GetAgeInTenYears());

        }

    }

}