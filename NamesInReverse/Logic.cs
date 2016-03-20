using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesInReverse
{
    public class Logic
    {
        private Random _random;

        // by instantiating a new class & invoking the constructor every time, this
        // helps to ensure that we get a different randomly shuffled name every time
        // we iterate through the for loop (total of 4 times).
        public Logic()
        {
            var random = new Random();
            this._random = random;
        }

        public Person RandomizeName(Person person)
        {
            Person newperson = new Person();

            // Shuffle string in random order. Please note that although this way
            // of shuffling the characters is OK, the best way to shuffle is to
            // instead use the well-known Fisher-Yates shuffle algorithm.
            newperson.FirstName = new string(person.FirstName.OrderBy(r => _random.Next()).ToArray());
            newperson.LastName = new string(person.LastName.OrderBy(r => _random.Next()).ToArray());

            return newperson;
        }

        public Person ReverseName(Person person)
        {
            char[] first = person.FirstName.ToCharArray();
            Array.Reverse(first);
            char[] last = person.LastName.ToCharArray();
            Array.Reverse(last);

            Person correctperson = new Person
            {
                FirstName = new string(first),
                LastName = new string(last)
            };

            return correctperson;
        }
    }
}