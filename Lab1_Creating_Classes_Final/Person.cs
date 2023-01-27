using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Creating_Classes_Final
{
    internal class Person
    {

        public int PersonID;
        public int Age;
        public string FName, LName, FavColor;
        public bool IsWorking;
        public Person(int PersonID, string FName, string LName, string FavColor, int Age, bool IsWorking)

        {

            this.PersonID = PersonID;
            this.Age = Age;
            this.FName = FName;
            this.LName = LName;
            this.FavColor = FavColor;
            this.IsWorking = IsWorking;

        }

        public override string ToString()

        {

            string List = ($"PersonID: {PersonID}\nFirst Name: {FName}\nLast Name: {LName}\nFavorite Color: {FavColor}\nAge: {Age}\nIs Working? {IsWorking}");
            return List;

        }

        public string DisplayPersonInfo()

        {

            string Info = ($"{PersonID}: {FName} {LName}'s FAVORITE COLOR is {FavColor}");
            return Info;

        }

        public string ChangeFavoriteColor()

        {
            FavColor = "White";
            string Change = DisplayPersonInfo();
            return Change;
        }

        public string GetAgeInTenYears()

        {

            string AgeUp = ($"{FName} {LName}'s Age in 10 Years is: {Age + 10}");
            return AgeUp;

        }
    }
}