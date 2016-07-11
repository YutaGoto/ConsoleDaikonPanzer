using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person
    {
        public string name;

        public Person()
        {
            name = "hoge";
        }

        public void SetName(string newName)
        {
            name = newName;
        }
    }

    class Tutorial
    {
        static void Main(string[] args)
        {
            Tutorial t = new Tutorial();
            Person person1 = new Person();
            person1.SetName("Daikon");
            Console.WriteLine(person1.name + t.Panzer());

            Person person2 = new Person();
            person2.SetName("Goche");
            Console.WriteLine(person2.name + t.Panzer());

            Console.WriteLine("press any key");
            Console.ReadKey();
        }

        public string Panzer()
        {
            return " 'Girls and Panzer is Good!!'";
        }
    }
}
