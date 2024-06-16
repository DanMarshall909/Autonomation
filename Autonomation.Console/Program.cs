// See https://aka.ms/new-console-template for more information

using Autonomation.Core;

var input = "";
if (args.Length == 1)
    input = args[0];

while (input != "q")
{
    while (input == "")
    {
        Console.WriteLine("Enter a string to partition into palindromes (q quits):");
        input = Console.ReadLine();
    }

    if (input != "q")
    {
        var partitions = PalindromeService.CommaSeparatedPartitions(input);
        Console.WriteLine($"The palindromic partitions of {input} are:");
        foreach (var partition in partitions)
        {
            Console.WriteLine(partition);
        }

        input = "";
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Ariva derci!");