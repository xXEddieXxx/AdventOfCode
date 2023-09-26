var body = File.ReadLines("Input.txt");

//part 1
var points = 0;

var point = new Dictionary<string, int>
{
    { "A X", 4 },
    { "A Y", 8},
    { "A Z", 3},
    { "B X", 1},
    { "B Y", 5},
    { "B Z", 9},
    { "C X", 7},
    { "C Y", 2},
    { "C Z", 6},
};

foreach (var line in body)
{
    points += point[line];
}
Console.WriteLine(points);

//part2

points = 0;
point = new Dictionary<string, int>
{
    { "A X", 3 },
    { "A Y", 4},
    { "A Z", 8},
    { "B X", 1},
    { "B Y", 5},
    { "B Z", 9},
    { "C X", 2},
    { "C Y", 6},
    { "C Z", 7},
};
foreach (var line in body)
{
    points += point[line];
}

Console.WriteLine(points);