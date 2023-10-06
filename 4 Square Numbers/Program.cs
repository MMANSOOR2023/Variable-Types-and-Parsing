// This program takes an input from the user and outputs that number multiplied by itself.

Console.WriteLine("Square Numbers Program");

Console.WriteLine("Please enter the number to be squared.");
string number = Console.ReadLine();

int numberInt = int.Parse(number);

int numberSquaredInt = numberInt * numberInt;

Console.WriteLine(numberInt + " squared is " + numberSquaredInt);