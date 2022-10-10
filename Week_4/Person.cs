using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4
{
    class Person
    {
        private string name;
        public Person(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(name, "You have to enter a name");
            else
            {
                this.name = name;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                this.name = value;
            }
        }

        public string ToString()
        {
            string name = ("Name : " + this.name);
            return name;
        }

        ~Person() // Destructor
        {
            name = String.Empty;
            Console.WriteLine("Name was deleted");
        }
    }
}
