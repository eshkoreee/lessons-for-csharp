namespace lesson88_2
{
    internal class Program
    {
        delegate int Operation(int a, int b);
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {


            PerformMathOperation(Multiply, 5, 10);


        }
        static void PerformMathOperation(Operation mathOperation, int a, int b)
        {
            Console.WriteLine("very important code");

            var operationResult = mathOperation(a, b);

            Console.WriteLine(operationResult);

            Console.WriteLine("super important code");
        }
    }
}
