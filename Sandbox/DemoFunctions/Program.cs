using System.Runtime.CompilerServices;

namespace DemoFunctions
{
    internal class Program
    {
        enum Gender
        {
            Male, 
            Female,
        }

        struct Person {
            string name;
            String address;
            Gender gender;
        }

        class RealPerson: IDisposable
        {
            public string name;
            public string? address;

            public RealPerson(string name)
            {
                this.name = name;
            }

            override public string ToString()
            {
                return $"RealPerson: {name}";
            }

            public void Move(string newAddress)
            {
                address = newAddress ;
            }

            public void Dispose()
            {
            }
        }

        public static void Main(string[] args)
        {
            using (RealPerson p1 = new RealPerson("Peter"))
            {
                Console.WriteLine(p1.ToString());
            }

            Console.WriteLine("Hello, World!");
            int resultaat = Vermenigvuldig(3, 6);
            Console.WriteLine("Het resultaat is {0:F2}", resultaat * 3);
            Console.WriteLine($"Het resultaat is {resultaat * 3:F2}");

            int result = 0;
            if (TryDivide(4, 0, ref result) && result > 10)
            {
                Console.WriteLine(result);
            }
        }

        private static int Vermenigvuldig(int a, int b)
        {
            int result = a * b;
            return result;

        }

        private static bool TryDivide(int a, int b, ref int result)
        {
            if (b != 0)
            {
                result = a / b;
                return true;
            }
            else
            {
                result = 0;
                return false;
            }
        }

    }
}
