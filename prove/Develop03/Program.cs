using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        
        var task = MainAsync(args);
        task.GetAwaiter().GetResult();
    }
    static async Task MainAsync(string[] args)
{
    // Create a reference object
    var reference = new Reference("1 Nephi", 3, 16);

    // Try to get scripture text from the API
    string scriptureText = await FetchScriptureTextAsync("1 Nephi 3:16");

    // Create a Scripture object with the retrieved or fallback text
    var scripture = new Scripture(reference, scriptureText);

    // Loop to hide words
    while (true)
    {
        Console.Clear();
        Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");
        Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
        string input = Console.ReadLine();

        if (input.ToLower() == "quit")
        {
            break;
        }
        scripture.HideRandomWords(3);
    }
}

// Fetch scripture text from the API, fallback if the API fails
static async Task<string> FetchScriptureTextAsync(string query)
{
    string apiUrl = $"https://api.nephi.org/scriptures/?q={query}";

    try
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var scriptureJson = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonResponse);
               
                // Assuming the API returns scripture text as a field named 'text'
                if (scriptureJson != null && scriptureJson.ContainsKey("text"))
                {
                    return scriptureJson["text"].ToString();
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"API request failed: {ex.Message}");
    }

    // Fallback scripture if API fails
    return "And it came to pass that I, Nephi, said unto my father: I will go" + 
    "and do the things which the Lord hath commanded, for I know that the Lord giveth" + 
    "no commandments unto the children of men, save he shall prepare a way for them" +
     "that they may accomplish the thing which he commandeth them.";
    } 
}                  