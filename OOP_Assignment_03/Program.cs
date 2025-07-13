namespace OOP_Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("The Sum is " + Add(10, 90));          // Add(int , int) => 100
            Console.WriteLine("The Sum is " + Add(10, 20, 50));       // Add(int , int , int) => 80
            Console.WriteLine("The Sum is " + Add(1.1, 0.1) + "\n"); // Add(double , double) => 1.2
            #endregion
            Console.ReadLine();
        }
        #region With part(1)
        #region Q1
        public static int Add(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        public static int Add(int Num1, int Num2, int Num3)
        {
            return Num1 + Num2 + Num3;
        }
        public static double Add(double Num1, double Num2)
        {
            return Num1 + Num2;
        }
        #endregion
        #endregion
    }
}
