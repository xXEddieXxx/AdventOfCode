
//Part1

var body = File.ReadAllText("Input.txt");

var path = new List<string>();

var y=0;
var x=0;

path.Add(x+"x"+y);

foreach (char move in body)
{
    if (move == '^')
    {
        y++;
    }
    else if (move == 'v')
    {
        y--;
    }
    else if (move == '>')
    {
        x++;
    }    
    else if (move == '<')
    {
        x--;
    }
    path.Add(x+"x"+y);
}

Console.WriteLine(path.Distinct().Count());

//Part2

var path2 = new List<string>();

var santax=0;
var santay=0;
var robotx=0;
var roboty=0;

path2.Add(santax + "x" + santay);
path2.Add(robotx + "x" + roboty);

for (int i = 0; i < body.Length; i++)
{
    var move = body[i];
    if (i % 2 == 0)
    {
        if (move == '^')
        {
            santay++;
        }
        else if (move == 'v')
        {
            santay--;
        }
        else if (move == '>')
        {
            santax++;
        }    
        else if (move == '<')
        {
            santax--;
        } 
        path2.Add(santax + "x" + santay);
    }
    else
    {
        if (move == '^')
        {
            roboty++;
        }
        else if (move == 'v')
        {
            roboty--;
        }
        else if (move == '>')
        {
            robotx++;
        }    
        else if (move == '<')
        {
            robotx--;
        } 
        path2.Add(robotx + "x" + roboty);
    }
}

Console.WriteLine(path2.Distinct().Count());