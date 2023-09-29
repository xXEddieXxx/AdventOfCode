var body = File.ReadAllLines("Input.txt");

//part1

var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

var compartment1 = "";
var compartment2 = "";
var points = 0;

foreach (var line in body)
{
    compartment1 = line.Substring(0, line.Length/2);
    compartment2 = line.Substring(line.Length/2,  line.Length/2);

    foreach (var cha in compartment1)
    {
        if (compartment2.Contains(cha))
        {
            points += alphabet.IndexOf(cha) + 1;
            break;
        }
    }
}

Console.WriteLine(points);

//part 2 

points = 0;
var group = new List<string>();
var counter = 0;
foreach (var line in body)
{
    counter++;
    group.Add(line);

    if (counter == 3)
    {
        counter = 0;
        foreach (var cha in group[0])
        {
            if (group[1].Contains(cha) && group[2].Contains(cha))
            {
                points += alphabet.IndexOf(cha) + 1;
                break;
            }
        }
        group.Clear();
    }
}

Console.WriteLine(points);
