using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrain
{
    public class Person
    {
        public string Name { get; set; }
        public int Money { get; set; }

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
        }

        public string PersonNote()
        {
            string note = $"{Name} {Money}";
            return note;
        }

    }


    class Program
    {

       public static List<Person> people = new List<Person>()
            {
                new Person("John", 550),
                 new Person("Kon", 440),
                  new Person("Varv", 220),
                   new Person("Kop", 888)

            };

        public static string[] ShowMe(List<Person> people)
        {
            string[] notes = new string[people.Count];

            for (int i = 0; i < notes.Length; i++)
            {
                notes[i] = people[i].PersonNote();
            }
            
            return notes;
        }


        static void Main(string[] args)
        {
            string[] notes = ShowMe(people);

            foreach (var person in notes)
            {
                Console.WriteLine(person);
            }



            Console.ReadLine();

        }
    }
}
