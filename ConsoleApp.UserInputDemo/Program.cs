// See https://aka.ms/new-console-template for more information

// Declare variables

string name = string.Empty;
int age = 0;
int retirementAge = 42;

// Prompt the user for input

Console.WriteLine("Please enter your name: ");
name = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

// Ourput results to user
Console.WriteLine($"Full Name: {name}");
Console.WriteLine("Age: " + age);
Console.WriteLine($"Working years left:  {workingYearsRemaining}");



