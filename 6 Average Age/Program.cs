// This program asks the users for three ages and outputs the average age

Console.WriteLine("Average Age Program");

Console.WriteLine("Please enter the first age");
string age1String = Console.ReadLine();
int age1 = int.Parse(age1String);

Console.WriteLine("Please enter the second age");
string age2String = Console.ReadLine();
int age2 = int.Parse(age2String);

Console.WriteLine("Please enter the third age");
string age3String = Console.ReadLine();
int age3 = int.Parse(age3String);

float averageAge = (float)(age1 + age2 + age3) / 3f;

Console.WriteLine("Average age is " + averageAge);