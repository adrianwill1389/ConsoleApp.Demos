// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());


//Math operations and operators

//Add numbers
int sum = num1 + num2;
//Multipy
int product = num1 * num2;
//Division
int quotient = num1 / num2;
//Substraction
int substract = num1 - num2;
//Modulous
int mod = num1 % num2;

Console.WriteLine("************Maths Result******************");
Console.WriteLine($"Sum {sum}");
Console.WriteLine($"Product {product}");
Console.WriteLine($"Quotient {quotient}");
Console.WriteLine($"Difference {substract}");
Console.WriteLine($"Modulous {mod}");
Console.WriteLine("**************End of result*******************");
Console.WriteLine();


/*
 Logical operators
 */

bool isGreaterThan = num1 > num2;   
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;  
bool isGreaterThanEqualTo = num1 >= num2;
bool isLessThanEqualTo = num1 <= num2;
bool isNotEqualTo = num1 != num2;

Console.WriteLine("************Logic Result******************");
Console.WriteLine($"Is greater than {isGreaterThan}");
Console.WriteLine($"Is less than {isLessThan}");
Console.WriteLine($"Is greater than equal to {isGreaterThanEqualTo}");
Console.WriteLine($"Is less than equal to {isLessThanEqualTo}");
Console.WriteLine($"Is not equal to {isNotEqualTo}");
Console.WriteLine("************End of logic results******************");

/*
 Assignment Operators
 */

Console.Write("Enter random value for assignment operator: ");
int randomValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("*************Assignment Operators Result**********");
Console.WriteLine();
//int randomValue = 5;
//int increaseValue = num1 + 5;

//num1 = num1 + 5; 

num1 += randomValue;
Console.WriteLine($"Increase num1 by 5 {randomValue}");
num1 -= randomValue;
Console.WriteLine($"Num1 reduce by 2 {randomValue}");
num1 /= randomValue;
Console.WriteLine($"Num1 divided by 2 {randomValue}");
num1 %= randomValue;
Console.WriteLine($"Num1 mod {randomValue}");
num1 *= randomValue;
Console.WriteLine($"Num1 muliply by 10 {randomValue}");
Console.WriteLine("*************End of Assignment Operators Result**********");









Console.WriteLine("*************End of Operators Result**********");
