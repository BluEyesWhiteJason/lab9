using System;
namespace Lab9
{
    class Student
    {
        // instance vars/properties
        public string Name;
        public string Hometown;
        public string FavoriteFood;
        public string HumanDancer;

        //constructor - put data for properties
        public Student(string name, string homeTown, string favoriteFood, string humanDancer)//parameters mean those data are necessary
        {
            Name = name;
            Hometown = homeTown;
            FavoriteFood = favoriteFood;
            HumanDancer = humanDancer;

        }

        //methods
        public string GetName()
        {
            return Name;
        }

        public string GetHometown()
        {
            return Hometown;
        }

        public string GetFavoriteFood()
        {
            return FavoriteFood;
        }

        public string GetHumanDancer()
        {
            return HumanDancer;
        }
    }
}
