using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

//Word class/ show text and hide words
public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide() => _isHidden = true;
    
    public string GetDisplayText() => _isHidden ? "__" : _text;
              
    public bool IsHidden() => _isHidden;
           
    
}   

