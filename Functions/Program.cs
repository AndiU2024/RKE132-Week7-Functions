﻿
Console.WriteLine("Are you coming or leaving?");
string userChoice = Console.WriteLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}



static void PrintHello()
{
    Console.WriteLine("Hello, world!");
}
static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}
