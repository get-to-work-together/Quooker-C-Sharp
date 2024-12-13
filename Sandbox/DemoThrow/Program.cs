namespace DemoThrow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                Console.WriteLine(CalculateArea(4, -5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static int CalculateArea(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                throw new ArgumentException("Negative argument!!");
            }
            return x * y;
        }
    }
}
