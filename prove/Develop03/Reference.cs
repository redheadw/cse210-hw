using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
//Reference class book, chapter, and verses
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;  // only one verse
    }
    //multiple verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    //Getter
    public string GetDisplayText() =>
        _endVerse == -1 ? $"{_book} {_chapter}:{_verse}" : $"{_book} {_chapter}:{_verse}-{_endVerse}";

}