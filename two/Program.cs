// Заменить буквы маленькие на большие, и вставить вместо пробелов другой знак

string text = "это будет текст для выполнения задания. в нем мы будем менять маленькие буквы на большие и вставлять восклицательный знак, вместо пробела.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string NewText = Replace(text, ' ', '!');
Console.WriteLine(NewText);

Console.WriteLine( );
NewText = Replace(NewText, 'а', 'А');
Console.WriteLine(NewText);

