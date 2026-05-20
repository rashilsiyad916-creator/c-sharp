using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// interface
interface Shape {

    double GetArea();
}

//circle class
class Circle :Shape {

    public double radius;

    public double GetArea() {


        return 3.14 * radius * radius;
    }
}

//rectangle class
class Rectangle : Shape {

    public double length;
    public double width;

    public double GetArea() {

        return length * width;
    }

}

//Square class
class Square : Shape
{
    public double side;

    public double GetArea()
    {
        return side * side;
    }
}

class program {

    static void Main() {

        //circle object
        Circle c = new Circle();

        c.radius = 5;

        Console.WriteLine("Circle Area : " + c.GetArea());


        //rectangle object 
        Rectangle r = new Rectangle();

        r.length = 10;
        r.width = 4;

        Console.WriteLine("Rectangle Area :"+ r.GetArea());


        //square object 

        Square s = new Square();

        s.side = 6;

        Console.WriteLine("Square Area :" + s.GetArea());
    }


}