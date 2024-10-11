using System;
public class Comment
{
    public string _name;
    public string _entryText;

    public Comment(string name, string text)
    {
        _name = name;
        _entryText = text;
    }
    public override string ToString()
    {
        return $"{_name}: {_entryText}";
    }
}