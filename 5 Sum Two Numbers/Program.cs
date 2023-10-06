
// This program askes the user for two numbers and outputs the sum of those two numbers
 
Console.WriteLine("Adding Two Numbers");

Console.WriteLine("Enter the first number.");
string number1String = Console.ReadLine();

Console.WriteLine("Enter second number.");
string number2String = Console.ReadLine();

int number1Int = int.Parse(number1String);
int number2Int = int.Parse(number2String);

Console.WriteLine(number1Int + "+" +  number2Int + " = " + (number1Int + number2Int));
