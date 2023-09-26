var body = File.ReadLines("Input.txt");

//Part 1
var max = 0;
var current = 0;

foreach (var line in body)
{
    if (line == string.Empty)
    {
        if (max < current)
        {
            max = current;
        }

        current = 0;
    }
    else
    {
        current += int.Parse(line);
    }
}

Console.WriteLine(max);

//Part2 
current = 0;
var max1 = 0;
var max2 = 0;
var max3 = 0;

foreach (var line in body)
{
    if (line == string.Empty)
    {
        if (max1 < current)
        {
            max3 = max2;
            max2 = max1;
            max1 = current;
        }
        else if (max2 < current)
        {
            max3 = max2;
            max2 = current;
        }
        else if (max3 < current)
        {
            max3 = current;
        }

        current = 0;
    }
    else
    {
        current += int.Parse(line);
    }
}

Console.WriteLine(max1 + max2 + max3);

