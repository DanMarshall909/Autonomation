// See https://aka.ms/new-console-template for more information

using Autonomation.Core;

var input = "";
while (true)
{
    if (args.Length == 0)
    {
        while (input == "")
        {
            Console.WriteLine("Enter a string to partition into palindromes (q quits):");
            input = Console.ReadLine();
        }
    }
    else
    {
        input = args[0];
    }

    if (input == "q")
    {
        Console.WriteLine("Quitting...");
        break;
    }

    var partitions = PalindromeService.CommaSeparatedPartitions(input);
    Console.WriteLine($"The palindromic partitions of {input} are:");
    foreach (var partition in partitions)
    {
        Console.WriteLine(partition);
    }

    input = "";
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Ariva derci!");