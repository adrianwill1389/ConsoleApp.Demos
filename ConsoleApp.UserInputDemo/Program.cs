// See https://aka.ms/new-console-template for more information

// Declare variables

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 42;

// Prompt the user for input

Console.WriteLine("Please enter your first name: ");
firstName = Console.ReadLine();

Console.WriteLine("Please enter last name: ");
lastName = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

// Ourput results to user
Console.WriteLine($"Full Name: {firstName} {lastName} ");
Console.WriteLine("Age: " + age);
Console.WriteLine($"Working years left:  {workingYearsRemaining}");



