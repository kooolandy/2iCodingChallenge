// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Nodes;
using System.Xml;

Console.Write("Enter X value :");
var X = int.Parse(Console.ReadLine());

Console.Write("Enter Array :");
var arr = Console.ReadLine();
var split = arr.Split(',');

List<int> ints = new List<int>();
foreach (var a in split)
{
    var usable = int.Parse(a);
    if (usable <= X)
    {
        Console.WriteLine($"Usable: {usable}");
        ints.Add(usable);
    }
}

var outVal = 0;
var l = ints.Count();
for (var i = 0; i < l; i++)
{
    for (var j = i +1; j < l; j++)
    {
        if (X.Equals(ints[i] + ints[j]))
        {
            Console.WriteLine($"i: {ints[i]}, j: {ints[j]}");
            outVal++;
        }
    }    
}

Console.WriteLine($"Output: {outVal}");

