using System;
using System.Collections.Generic;
using System.Text;

public class Cuboid : TheAbstractPrototype.Shape
{
    int itsLength;
    int itsWidth;
    int itsHeight;

    public Cuboid(int length, int width, int height, string getStringStuff) : base(getStringStuff)
    {
        itsLength = length;
        itsWidth = width;
        itsHeight = height;
    }

    public override double Area
    {
        get { return itsHeight * itsWidth * itsLength; }
    }

}

public class Trepezoid : TheAbstractPrototype.Shape
{
    int itsBase_a;
    int itsBase_b;
    int itsHeight;

    public Trepezoid(int baseA, int baseB, int height, string getStringStuff) : base(getStringStuff)
    {
        itsBase_a = baseA;
        itsBase_b = baseB;
        itsHeight = height;
    }

    public override double Area
    {
        get { return (itsBase_a + itsBase_b) * itsHeight / 2; }
    }
}


public class Ellipse : TheAbstractPrototype.Shape
{
    int longerRadii;
    int shorterRadii;
    int PI;


    public Ellipse(int r1, int r2, int pi, string getStringStuff) : base(getStringStuff)
    {
        longerRadii = r1;
        shorterRadii = r2;
        PI = pi;
    }

    public override double Area
    {
        get { return longerRadii * shorterRadii * PI; }
    }


}