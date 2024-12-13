namespace DemoTask
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started......");

            // 1 SomeMethod();
            // 2 SomeAsyncMethod();
            // 3 SomeMethodWithTask();

            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }

        public static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");

            Thread.Sleep(TimeSpan.FromSeconds(5));

            Console.WriteLine("\nSome Method End");
        }

        public async static void SomeAsyncMethod()
        {
            Console.WriteLine("Some Method Started......");

            await Task.Delay(TimeSpan.FromSeconds(5));

            Console.WriteLine("\nSome Method End");
        }

        public async static void SomeMethodWithTask()
        {
            Console.WriteLine("Some Method Started......");

            await Wait();

            Console.WriteLine("Some Method End");
        }

        private static async Task Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("\n10 Seconds wait Completed\n");
        }

    }
}
