
//Part1

var body = File.ReadLines("Input.txt");
var nice = 0;

foreach (string word in body)
{
    var vowels = 0; 
    var doubleLetter = false;
    var lastchar = ' ';
    
    for (int i = 0; i < word.Length; i++)
    {
        if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
        {
            vowels++;
        }
        if (word[i] == lastchar)
        {
            doubleLetter = true;
        }
        lastchar = word[i];
    }

    if (vowels >= 3 && doubleLetter && !word.Contains("ab") && !word.Contains("cd") && !word.Contains("pq") && !word.Contains("xy"))
    {
        nice++;
    }
}

Console.WriteLine(nice);

//Part2 

nice = 0;

foreach (string word in body)
{
    var appearsTwice = Enumerable.Range(0, word.Length - 1).Any(i => word.IndexOf(word.Substring(i, 2), i+2, StringComparison.Ordinal) >= 0); 
    var repeats = Enumerable.Range(0, word.Length - 2).Any(i => word[i] == word[i + 2]);

    if (appearsTwice && repeats)
    {
        nice++;
    }
}
Console.WriteLine(nice);

