using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            View view = new View();
            view.TitleAndInfo();
            person.FirstName = view.GetFirstName();
            person.LastName = view.GetLastName();
            view.DisplayNameInReverse(person);
            view.DisplayNameInRandomOrder(person);
            view.PauseForUser();
        }
    }
}