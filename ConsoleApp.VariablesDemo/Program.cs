// See https://aka.ms/new-console-template for more information

// Different variable types
/* 
    text - string
    integers - int
    decimal - double, float, decimal
    logical - bool 
 */

string name = "Adrian Williams";

Console.WriteLine(name);
Console.WriteLine("My name is" + name); // string concatenation
Console.WriteLine($"They call me {name}"); // string interpolation
Console.WriteLine("The name I was given {0}", name); // formatted string

int age = 32;
int retirementageleft = 11;
int retirementage = age + retirementageleft;
Console.WriteLine("My age is: " + age);
Console.WriteLine("My retirement age is: " + retirementage);

bool isretired = false;
Console.WriteLine("Am I retired? " + isretired);




