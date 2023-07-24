namespace cSharp_LambaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOperation = Add;
            int result = mathOperation(5, 3);
            mathOperation = Multiply;
            int result1 = mathOperation(6, 6);
            Console.WriteLine(result);
            Console.WriteLine(result1);
        }
        public delegate int MathOperation(int a, int b);
        static int Add(int a, int b) => a + b;
        static int Multiply(int a, int b) => a * b;

    }

    
}