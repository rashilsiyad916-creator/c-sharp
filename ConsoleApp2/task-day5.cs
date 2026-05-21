using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//// interface
////interface Shape {

////    double GetArea();
////}

//////circle class
////class Circle :Shape {

////    public double radius;

////    public double GetArea() {


////        return 3.14 * radius * radius;
////    }
////}

//////rectangle class
////class Rectangle : Shape {

////    public double length;
////    public double width;

////    public double GetArea() {

////        return length * width;
////    }

////}

//////Square class
////class Square : Shape
////{
////    public double side;

////    public double GetArea()
////    {
////        return side * side;
////    }
////}

////class program {

////    static void Main() {

////        //circle object
////        Circle c = new Circle();

////        c.radius = 5;

////        Console.WriteLine("Circle Area : " + c.GetArea());


////        //rectangle object 
////        Rectangle r = new Rectangle();

////        r.length = 10;
////        r.width = 4;

////        Console.WriteLine("Rectangle Area :"+ r.GetArea());


////        //square object 

////        Square s = new Square();

////        s.side = 6;

////        Console.WriteLine("Square Area :" + s.GetArea());
////    }


////}


////task ; 

////person class
//class person { 

//public string Name { get; set ; }

//public int Age { get; set; }

//public string City { get; set; }


//}

//class program
//{

//    static void Main()
//    {
//        //list of persons 

//        List<person> people = new List<person>() { 
        
//        new person{ Name = "rashil " , Age=28 , City ="malappuram" },

//        new person{ Name ="hisham ", Age = 23 , City = "thirurangady"},

//        new person{ Name = "fayis" , Age =22 , City ="calicut"},

//        new person{ Name ="ashif" , Age =23 , City="puthanathaani"},

//        new person{ Name ="kenza" , Age = 27 , City ="malappuram"}
        
        
//     };


//        //LINQ query

//        var result = people.Where(p => p.Age > 25 &&
//        p.City == "malappuram")
//            .Select(p => new { 
//            p.Name,p.Age
            
//            });

//        //dispaly result 
//        foreach (var person in result) {
        
//        Console.WriteLine(
//            "Name :"+ person.Name +", Age :"+person.Age);
//        }
//    }
//}



