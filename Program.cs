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

            List<String> Name = list
                .Where(x => x.Age >= 25)
                .OrderBy(x => x.Name)
                .Select(x => x.Name)
                .ToList();

            foreach (String Names in Name) 
            {
                Console.WriteLine(Names);
            }
            Person person = list.FirstOrDefault(x => x.Address == "Karachi");
            Console.WriteLine(person?.Name ?? "\r\nNull");


        }

        // Lambda expressions
        public delegate int MathOperation(int a, int b);
        static int Add(int a, int b) => a + b;
        static int Multiply(int a, int b) => a * b;


        
    }

    
}