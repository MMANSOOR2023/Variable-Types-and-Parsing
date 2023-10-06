/* This code will ask the user their name, their age at the start of their course and the length of their course
* then display it will add the starting age to the course duration and display the user's age when they finish their course.
*/

Console.WriteLine("Graduation Age Program");

Console.WriteLine("Hello, What is your name?");

string name = Console.ReadLine();

Console.WriteLine("How old were you at the start of your course?");

string startingAge = Console.ReadLine();

int startingAgeInt = int.Parse(startingAge);

Console.WriteLine("How long is your course in years?");

string courseDuration = Console.ReadLine();

int courseDurationInt = int.Parse(courseDuration);

Console.WriteLine("At the end of your course you will be " + (startingAgeInt + courseDurationInt) +" years old.");