
//Part1

int SmallestValue(int value1 , int value2 , int value3 = 999999999)
{
    var smallest = value1;

    if (value1 > value2)
    {
        smallest = value2;
        if (value2 > value3)
        {
            smallest = value3;
        }
    }
    else if (value1 > value3)
    {
        smallest = value3;
    }
    return smallest;
} 

var presents = File.ReadLines("Input.txt");

var neededmaterial = 0;

foreach (string presentdimension in presents)
{
    var splitvalues = presentdimension.Split("x");
    var length = Int32.Parse(splitvalues[0]);
    var width = Int32.Parse(splitvalues[1]);
    var height = Int32.Parse(splitvalues[2]);
    
    neededmaterial += 2 * (length * width) + 2 * (width * height) + 2 * (height * length) + SmallestValue(length * width, width * height, height * length);
}

Console.WriteLine(neededmaterial);

//Part2

neededmaterial = 0;

foreach (string presentdimension in presents)
{
    var splitvalues = presentdimension.Split("x");
    var length = Int32.Parse(splitvalues[0]);
    var width = Int32.Parse(splitvalues[1]);
    var height = Int32.Parse(splitvalues[2]);
    var small1 = SmallestValue(length, width, height);
    int small2;

    if (small1 == length)
    {
        small2 = SmallestValue(width, height);
    }
    else if (small1 == width)
    {
        small2 = SmallestValue(length, height);
    }
    else
    {
        small2 = SmallestValue(length, width);
    }

    neededmaterial += 2 * small1 + 2 * small2 + (length * width * height);
}

Console.WriteLine(neededmaterial);