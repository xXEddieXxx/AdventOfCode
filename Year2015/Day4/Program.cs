
//Part1 

using System.Text;
var body = File.ReadAllText("Input.txt");
var number = 0;
string key;

while (true)
{
    using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
    {
        byte[] hashBytes = md5.ComputeHash(Encoding.Default.GetBytes(body+number));
        key = Convert.ToHexString(hashBytes);
    }
    
    if (key.Substring(0,5) == "00000")
    {
        break;
    }
    number++;
}

Console.WriteLine(number);

//Part2

while (true)
{
    using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
    {
        byte[] hashBytes = md5.ComputeHash(Encoding.Default.GetBytes(body+number));
        key = Convert.ToHexString(hashBytes);
    }
    
    if (key.Substring(0,6) == "000000")
    {
        break;
    }
    number++;
}
Console.WriteLine(number);


    
    
