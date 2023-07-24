using Microsoft.VisualBasic;
using System.Buffers.Text;
using System.Threading;

namespace cSharp_LambaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MathOperation mathOperation = Add;
            //int result = mathOperation(5, 3);
            //mathOperation = Multiply;
            //int result1 = mathOperation(6, 6);
            //Console.WriteLine(result);
            //Console.WriteLine(result1);

            List<Person> list = new List<Person>() {
            new Person("salim", 22, "Male", "sohar"),
            new Person("salim", 23, "Male", "sohar"),
            new Person("salim", 25, "Male", "sohar"),
            new Person("ali", 20, "Male", "muscat"),
            new Person("shagufta", 25, "Female", "muscat"),
            new Person("Aliya", 19, "Female", "sohar"),
            new Person("Fariha", 30, "Female", "muscat"),
            new Person("Farzana", 35, "Female", "salalah"),
            new Person("Muqeet", 20, "Male", "sohar"),
            new Person("Sehar", 18, "Female", "muscat")};

            //List<String> Name = list
            //    .Where(x => x.Age >= 25)
            //    .OrderBy(x => x.Name)
            //    .Select(x => x.Name)
            //    .ToList();

            //foreach (String Names in Name) 
            //{
            //    Console.WriteLine(Names);
            //}
            //Person person = list.FirstOrDefault(x => x.Address == "Karachi");
            //Console.WriteLine(person?.Name ?? "\r\nNull");

            //List<String> Age = list
            //    .Where(x => x.Age < 25)
            //    .OrderBy(x => x.Address)
            //    .Select(x => x.Name)
            //    .ToList();

            //foreach (String age in Age)
            //{
            //    Console.WriteLine(Age);
            //}


            // Task 1: Create a program that stores records of students in a list.
            // Each student record should contain the following information: Name, Age, Gender, and GPA.
            // Implement the following tasks using LINQ:
            List<Student> students = new List<Student>()
        {
            new Student("Aliya", "ST-0032", 20, "Female", 3.8),
            new Student("Ahmed", "ST-0034", 21, "Male", 3.2),
            new Student("Said", "ST-0036", 19, "Male", 3.5),
            new Student("Saif", "ST-0023", 22, "Male", 3.9),
            new Student("Marwa", "ST-0012", 20, "Female", 4.0)
        };

            // Task 1 A: Display the list of all students.
            Console.WriteLine("List of all Students");

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            // Task 1 B: Filter and display male students with a GPA greater than 3.5.
            List<Student> maleGPA = students
                .Where(x => x.Gender == "Male")
                .Where(x => x.GPA < 3.5)
                .OrderBy(x => x.GPA)
                .ToList();
            foreach (Student student in maleGPA)
            {
                Console.WriteLine("Student Name: {0}\nStudent GPA: {1}", student.Name, student.GPA);
            }
            // Task 1 C: Find the average GPA of all female students.
            double femaleGPAave = students
                .Where(x => x.Gender == "Female")
                .Average(x => x.GPA);


            Console.WriteLine("\nStudent female average GPA: {0}", femaleGPAave);
            // Task 1 D: Display the names of the top three students with the highest GPA.
            List<string> Top3Student = students
                .OrderByDescending(x => x.GPA)
                .Take(3)
                .Select(x => x.Name)
                .ToList();
            Console.WriteLine("\nNames of the top three students with the highest GPA:");
            foreach (var name in Top3Student)
            {
                Console.WriteLine(name);
            }
            // Task 1 E: Update the GPA of a specific student.
            string targetName = "Marwa";
            double newGPA = 3.7; // Change the GPA to new GPA. 
            Student targetStudent = students.Find(s => s.Name == targetName);
            if (targetStudent != null)
            {
                targetStudent.GPA = newGPA;
                Console.WriteLine("\nUpdated the GPA of {0} to {1}", targetName, newGPA);
                Console.WriteLine(targetStudent);
            }
            else
            {
                Console.WriteLine("\nNo student with the name {0} found", targetName);
            }
            // Task 1 F: Remove a student from the list based on their name.
            string removeName = "Ahmed"; // To remove this name
            bool removed = students.Remove(students.Find(s => s.Name == removeName));
            if (removed)
            {
                Console.WriteLine("\nRemoved {0} from the list", removeName);
                Console.WriteLine("Updated list of students:");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine($"\nNo student with the name {0} found", removeName);
            }
        }
            // Lambda expressions
            public delegate int MathOperation(int a, int b);
            static int Add(int a, int b) => a + b;
            static int Multiply(int a, int b) => a * b;
    
    }
}