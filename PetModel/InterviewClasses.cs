using System;
using System.Collections.Generic;
using System.Linq;

namespace PetModel.Models
{
    public enum Gender
    {
        Male = 'M',
        Female = 'F'
    }

    public interface IPet
    {
        int ID { get; set; }
        string Name { get; set; }
        DateTime DateOfBirth { get; set; }
        Gender Gender { get; set; }

        string Speak();
    }

    public abstract class PetBase : IPet
    {
        public abstract int ID { get; set; }
        public abstract string Name { get; set; }
        public abstract DateTime DateOfBirth { get; set; }
        public abstract Gender Gender { get; set; }
        public abstract string Speak();

        public static bool IsStringAPalindrome(string str) 
        {
                // Check whether a string is palindrome by compareing the string with reversed string.                 
                string reversedStr = new string(str.Reverse().ToArray());
                return string.Compare(str, reversedStr) == 0 ? true : false;
        }

        public virtual bool IsNameAPalindrome
        {
            get
            {
                return IsStringAPalindrome(Name);
            }
        }

        public virtual int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year + 1;
            }
        }
    }

    public class Bird : PetBase
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override DateTime DateOfBirth { get; set; }
        public override Gender Gender { get; set; }

        public float Wingspan { get; set; }

        public override string Speak()
        {
            return "Chirp!";
        }
    }

    public class Cat : PetBase
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override DateTime DateOfBirth { get; set; }
        public override Gender Gender { get; set; }

        public override string Speak()
        {
            return "Meow!";
        }
    }

    public class Dog : PetBase
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override DateTime DateOfBirth { get; set; }
        public override Gender Gender { get; set; }

        public override string Speak()
        {
            return "Whoof!";
        }
    }

    public class House : List<PetBase>
    {
        public House GetPalindromePets()
        {
            House panlindromePet = new House();
            foreach (PetBase pet in this)
            {
                if (pet.IsNameAPalindrome)
                    panlindromePet.Add(pet);

            }
            return panlindromePet;
        }

        public void AddTestData()
        {
            this.Add(new Cat()
            {
                ID = this.Count + 1,
                Name = "Gracie",
                DateOfBirth = new DateTime(2016, 09, 28),
                Gender = Gender.Female
            });

            this.Add(new Cat()
            {
                ID = this.Count + 1,
                Name = "Patches",
                DateOfBirth = new DateTime(2015, 01, 09),
                Gender = Gender.Male
            });

            this.Add(new Bird()
            {
                ID = this.Count + 1,
                Name = "Izzi",
                DateOfBirth = new DateTime(2018, 06, 03),
                Gender = Gender.Female,
                Wingspan = 10.0f,
            });

            this.Add(new Dog()
            {
                ID = this.Count + 1,
                Name = "Missy",
                DateOfBirth = new DateTime(2016, 03, 05),
                Gender = Gender.Female
            });
        }
    }
}