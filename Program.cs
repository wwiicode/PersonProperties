using TheAbstractPrototype;
using System;

namespace PersonProperties
{
    class Person
    {
        private string myName = "lala";
        private int myAge = 0;

        public string Name
        {
            get
            {
                return myName;
            }
            set
            {
                myName = value;
            }
        }

        public int Age
        {
            get { return myAge; }
            set { myAge = value; }
        }
    

        public override string ToString()
        {
            return "Name = " + Name + ", Age = " + Age;
        }

        public static void Main()
        {
            Console.WriteLine("Simple Properties");

            //Create a new Person object: 
            Person person = new Person();

            Console.WriteLine("Person Details - {0}", person);

            person.Name = "Joe";
            person.Age = 99;
            Console.WriteLine("Person Details - {0}", person);

            person.Age += 1;
            Console.WriteLine("Person Details - {0}", person);

            Console.Write("\n\n Below is the Shape area calculation stuff:\n ");
            Console.WriteLine("==================================================");
            //Shape stuff
            Cuboid stuff = new Cuboid(5,4,3, "Show me how to capture this Square shape #1");

            Trepezoid stuff2 = new Trepezoid(5, 4, 3, "The Area of Trepezoid is : ");

            Ellipse stuff3 = new Ellipse(5, 4, System.Math.PI, "The Ellipse's area is: ");


            foreach(string s in Shape)
            {
                WriteLine("{0} ", s);
            }

            //Console.WriteLine("{0}\n{1}", stuff, stuff2);
            
            Console.ReadLine();
        }
         
    }
}