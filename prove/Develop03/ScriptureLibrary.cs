using System;
using System.Net.Http;
using System.Threading.Tasks;

class ScriptureLibrary
{
    private static readonly HttpClient client = new HttpClient();
    public static async Task<string> GetScripture(string book, int chapter, int verse)
    {
        string url = $"https://api.scriptures.nephi.org/{book}/{chapter}/{verse}";

        HttpResponseMessage response = await client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }
        else
        {
            return "Scripture not found";
        }
    
        
    }
}