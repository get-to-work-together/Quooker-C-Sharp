List<int> GetRandomNumbers(int count, int min, int max)
{
    Random random = new Random();
    List<int> numbers = new List<int>();

    for (int i = 0; i < count; i++)
    {
        numbers.Add(random.Next(min, max));
    }
    return numbers;
}


int count = 20; // Number of random numbers
int min = 1;    // Minimum value (inclusive)
int max = 100;  // Maximum value (exclusive)

List<int> numbers = GetRandomNumbers(count, min, max);

var numberQuery = from number in numbers
                  where number > 80
                  orderby number
                  select number;

foreach (var number in numberQuery)
{
    Console.Write(number + " ");
}

