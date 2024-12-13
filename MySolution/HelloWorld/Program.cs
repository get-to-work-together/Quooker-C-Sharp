using System;
using System.Xml.Linq;

namespace HelloWorld 
{
    internal class Program
    {
        enum Gender
        {
            Male,
            Female,
            Other
        }

        static void Main(string[] args)
        {
            Gender gender = Gender.Male;

            var namen = new List<string>();
            namen.Add("Chun");
            namen.Add("Marijn");
            namen.Add("Robin");
            namen.Add("Robin");
            namen.Add("Marijn");

            string[] names = { "Chun", "Marijn", "Robin" };

            try
            {
                foreach (string name in namen)
                {
                    Console.WriteLine(name[100]);
                    Console.WriteLine($"{name} says: \"Hello, World!\"");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("That name is to long!!");
                Console.WriteLine(ex.ToString());
                throw new Exception("That really went wrong");
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
    }
}
