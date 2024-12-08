using System.Text.RegularExpressions;


namespace WordCounter
{
    public class WordCounter
    {
        static public void Main()
        {
            String filename = @".\Text.txt";

            string workingDirectory = Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            Directory.SetCurrentDirectory(projectDirectory);

            Console.WriteLine("CurrentDirectory: {0}", System.IO.Directory.GetCurrentDirectory());

            String text = "";
            try
            {
                using StreamReader reader = new(filename);
                text = reader.ReadToEnd();
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }


            // Convert to lowercase and remove punctuation characters
            // String cleanedText = new string(text.ToLower().Where(c => !char.IsPunctuation(c)).ToArray());
            String cleanedText = Regex.Replace(text.ToLower(), "[^a-zA-Z ]", "");

            var words = cleanedText.Replace("  ", " ").Trim().Split(" ");

            var counter = new Dictionary<string, int>();
            foreach (var word in words)
            {
                counter[word] = counter.GetValueOrDefault(word, 0) + 1;
            }

            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key,-20}: {item.Value} {new String('*', item.Value)}");
            }
        }
    }
}
