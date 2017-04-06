using System;
using System.Collections.Generic;
using System.Text;

namespace TheAbstractPrototype
{ //Properties are named members of classes, structs, and interfaces.
    //They provide a flexible mechanism to read, write, or compute the values
    //of private fields through accessors.
    public abstract class Shape
    {
        private string myStringStuff;

        public Shape(string s)
        {
            StringStuff = s;
        }

        public string StringStuff
        {
            get { return myStringStuff; }
            set { myStringStuff = value; }
        }

        public abstract double Area
        {
            get;
        }

        public override string ToString()
        {
            return StringStuff + " Area = " + string.Format("{0:F2}", Area);
        }
    }
        
}
