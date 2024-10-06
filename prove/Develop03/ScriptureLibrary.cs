using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class ScriptureLibrary
{
    private static readonly HttpClient client = new HttpClient();
    public static async Task<string> GetScripture(string reference)
    {
        string url = $"https://api.nephi.org/scriptures/?q={Uri.EscapeDataString(reference)}";
        
        try
        {
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Raw Json Response: " + jsonResponse);

                using JsonDocument doc = JsonDocument.Parse(jsonResponse);
                JsonElement root = doc.RootElement;
                
                if (root.TryGetProperty("scriptures", out JsonElement scriptures) && scriptures.GetArrayLength() > 0)
                {
                    JsonElement firstScripture = scriptures[0];
                    if (firstScripture.TryGetProperty("scripture", out JsonElement scriptureTextElement))
                    {
                        string scriptureText = scriptureTextElement.GetString();
                        return scriptureText;
                    } 
                    
                }
                return "scripture not found";
            }
            else
            {
                return "Scripture not found";
            }
        }
        catch (HttpRequestException e)
        {
            return $"Request error: {e.Message}";
        }
        catch (JsonException e)
        {
            return $"Json parse error {e.Message}";
        }    
    
        
    }
}