using System;
using System.Threading.Tasks;

Console.WriteLine("C# Parallel For Loop");


Parallel.For(1, 11, number =>
{
    Console.WriteLine(number);
});

Console.ReadLine();
