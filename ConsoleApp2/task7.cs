using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//student class 
class Student { 
    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public string Course { get; set; }

}

//corse class 
class Course { 


    public int CourseId { get; set; }

    public string CourseName { get; set; }
}

//student manager class

class StudentManager {

    private List<Student> students =
        new List<Student>();

    //add student 

    public void Addstudent( Student student) {

        students.Add(student);
    }
    //view stuent
    public void ViewStudents() {

        foreach (var student in students) {

            Console.WriteLine(
                
                $"Id :{ student.Id}, "+
                $"Name:{student.Name}, "+
                $"Age:{student.Age},"+
                $"Course{student.Course}"


                );
        
        }
    
    
    }

    //update student 
    public void UpdateStudents(int id ,string newName ) {

        var student =
            students.FirstOrDefault(s => s.Id ==id);

        if (student != null) {

            student.Name = newName;
            Console.WriteLine("student updated");

        }
    
    }

    //Delete student
    public void Deletestudent(int id) {

        var student =
            students.FirstOrDefault(s => s.Id == id);

        if (student != null) {

            students.Remove(student);

            Console.WriteLine("Student Delated");
        
        }
    
    }

    //LINQ - student Above Certain Age
    public void FindStudentsAboveAge(int age) {

        var result =
                students.Where( s=>s.Age >age);

        Console.WriteLine("\nStudents Above Age"+age);

        foreach (var stundent in result) {

            Console.WriteLine(stundent.Name);
        }
    }

    //LINQ - students in specific course

    public void FindStudentsByCourse(string course) {

        var result =
                students.Where(s =>s.Course==course);

        Console.WriteLine("\nStudents in Course :" + course);

        foreach (var student in result) {

            Console.WriteLine(student.Name);
        }
    }
}

//course manger class
class CourseManager {

    private List<Course> courses =
        new List<Course>();

    //Add coursse
    public void AddCourses(Course course) {

        courses.Add(course);
    }

    //view course
    public void ViewCourses() {

        foreach (var course in courses) {

            Console.WriteLine(
                 $"Course Id: {course.CourseId}, " +
                $"Course Name :{course.CourseName}"
                
                );
        
        }
    }
}
class program {

    static void Main() {

        //student manager object
        StudentManager studentManager =
            new StudentManager();

        //Course manger object
        CourseManager courseManager =
            new CourseManager();

        //add course
        courseManager.AddCourses(

            new Course { 
            
                CourseId =1 ,
                CourseName="C# program"
            }
            );

        courseManager.AddCourses(
            new Course { 
            
                CourseId = 2 ,
                CourseName ="java program"

            }
            );

        //view courses

        Console.WriteLine("courses :");
        courseManager.ViewCourses();

        //add students 
        studentManager.Addstudent(
            new Student { 
            
                Id =1 ,
                Name="rashil",
                Age=25 ,
                Course="C# program"
            
            }
            );

        studentManager.Addstudent(
            new Student { 
            Id=2 ,
            Name="hisham",
            Age=23,
            Course="java programing"

            }
            
            );
        studentManager.Addstudent(
            
            new Student { 
             Id = 3 ,
             Name="fayis",
             Age = 22 , 
             Course="C# program"
            }
            );

        //view students 
        Console.WriteLine("\nStudent :");
        studentManager.ViewStudents();

        //update student 
        studentManager.UpdateStudents( 2 , "arjun");

        //delete student 
        studentManager.Deletestudent(1);

        //view updated students 
        Console.WriteLine("\nUpdated student List :");
        studentManager.ViewStudents();

        //LINQ quaries
        studentManager.FindStudentsAboveAge(22);
        studentManager.FindStudentsByCourse("C# program");
    }

}