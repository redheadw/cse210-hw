using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;
    

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = new List<Word>();
        foreach (var word in _text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }
    public string GetDisplayText()
    {
        var displayWords = new List<string> ();
        foreach (var word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        } 
        return string.Join(" ", displayWords);
        
    }    
    public void HideRandomWords(int Count)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < Count && hiddenCount < _words.Count)
        {
            int index = random.Next(_words.Count);
            
        }
        
        
    } 
    public Reference GetReference() => _reference;
    
}