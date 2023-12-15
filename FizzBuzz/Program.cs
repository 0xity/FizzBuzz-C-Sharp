using System.Data;
using System.Collections.Generic;

string output;
Dictionary<int, string> values = new Dictionary<int, string>();
values.Add(3, "Fizz");
values.Add(5, "Buzz");
output = "";

for (int i = 1; i <= 100; i++)
{
    foreach(KeyValuePair<int, string> fbp in values)
    {
        if (i % fbp.Key == 0)
        {
            output += fbp.Value;
        }
    }
    Console.WriteLine($"{i} {output}");
    output = "";
}