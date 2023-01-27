using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Creating_Classes_Final
{
    internal class Person
    {

        private int PersonID;
        private int Age;
        private string FName, LName, FavColor;
        private bool IsWorking;

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

            string List = ($"PersonID: {PersonID}\nFirst Name: {FName}\nLast Name: {LName}\nFavorite Color: {FavColor}\nAge: {Age}\nIsWorking? {IsWorking}");
            return List;

        }

        public string Name() //Optional (Reuseable), I added to Easily use Name() with FName and LName.

        {

            string Name = ($"{FName} {LName}");
            return Name; 

        }

        public string DisplayPersonInfo()

        {
            
            string Info = ($"{PersonID}: {Name()}'s FAVORITE COLOR is {FavColor}");
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

            string AgeUp = ($"{Name()}'s Age in 10 Years is: {Age + 10}");
            return AgeUp;

        }

    }
}