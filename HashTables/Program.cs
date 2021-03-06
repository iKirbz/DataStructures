using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 1000000;

            List<Person> list = new List<Person>();
            Dictionary<string, Person> dict = new Dictionary<string, Person>();

            FillCollections(list, dict, length);

            string[] people = GetRandomPeople(20, length);

            TimeList(list, people);
            TimeDictionary(dict, people);

            Console.ReadLine();
        }

        class Person
        {
            public int id;
            public string name;
        }

        private static void FillCollections(List<Person> list, Dictionary<string, Person> dict, int length)
        {
            Console.WriteLine("Generating People...");

            //Fills the collection with people from the range 0 -> length
            for (int i = 0; i < length; i++)
            {
                //Names of the people is "Person" + i
                string name = $"Person{i}";
                list.Add(new Person() { id = i, name = name });
                dict.Add(name, new Person() { id = i, name = name });
            }
        }

        private static string[] GetRandomPeople(int amount, int length)
        {
            int[] numbers = new int[amount];

            Random rnd = new Random();

            //Generate 'amount' amount of random numbers within the range of 0 -> length (amount of people)
            for (int i = 0; i < amount; i++)
            {
                numbers[i] = rnd.Next(0, length);
            }

            Array.Sort(numbers);

            //Prepend numbers with 'Person' prefix
            string[] people = new string[amount];

            for (int i = 0; i < amount; i++)
            {
                people[i] = $"Person{numbers[i]}";
            }

            return people;
        }

        private static void TimeList(List<Person> list, string[] people)
        {
            Stopwatch watch = new Stopwatch();

            Console.WriteLine("\n\nNow Timing List:\n");

            foreach (string person in people)
            {
                watch.Start();
                Person result = list.Find(element => element.name == person);
                watch.Stop();

                //Calculates the microseconds the operation took
                string microseconds = (watch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L))).ToString("D4");
                Console.WriteLine($"{microseconds} microseconds - {result.name}");
                watch.Reset();
            }
        }

        private static void TimeDictionary(Dictionary<string, Person> dict, string[] people)
        {
            Stopwatch watch = new Stopwatch();

            Console.WriteLine("\n\nNow Timing Dictionary:\n");

            foreach (string person in people)
            {
                watch.Start();
                Person result = dict[person];
                watch.Stop();

                //Gets the microseconds the operation took
                string microseconds = (watch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L))).ToString("D2");
                Console.WriteLine($"{microseconds} microseconds - {result.name}");
                watch.Reset();
            }
        }
    }
}
