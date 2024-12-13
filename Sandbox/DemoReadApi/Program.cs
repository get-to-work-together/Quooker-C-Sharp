using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        // API URL
        string url = "https://api.openweathermap.org/data/2.5/weather?appid=d1526a9039658a6f76950cff21823aff&units=metric&mode=json&q=groningen";

        try
        {
            using (HttpClient client = new HttpClient())
            {
                // Fetch the JSON response
                HttpResponseMessage response = await client.GetAsync(url);

                // Ensure the request was successful
                response.EnsureSuccessStatusCode();

                // Read the JSON content as a string
                string jsonResponse = await response.Content.ReadAsStringAsync();

                // Deserialize the JSON into a dynamic object
                dynamic weatherData = JsonConvert.DeserializeObject(jsonResponse);

                // Access data dynamically
                double temperature = weatherData.main.temp;

                // Output the data
                Console.WriteLine($"Temperature: {temperature}°C");
            }
        }
        catch (Exception ex)
        {
            // Handle errors
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}