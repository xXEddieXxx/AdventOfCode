
//Part1

var body = File.ReadAllText("Input.txt");

var counter = 0;

foreach (char c in body)
{
    if ( c == '(')
    {
        counter++;
    }
    else
    {
        counter--;
    }
}

Console.WriteLine(counter);

//Part2

counter = 0;
var basementcounter = 0;

foreach (char c in body)
{
    if ( c == '(')
    {
        counter++;
    }
    else
    {
        counter--;
    }
    
    basementcounter++;
    
    if (counter < 0)
    {
        Console.WriteLine(basementcounter);
        break;
    }
}
