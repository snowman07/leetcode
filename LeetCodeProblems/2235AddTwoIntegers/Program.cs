// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int totalSum = AddTwoIntegers(num1, num2);
Console.WriteLine($"The sum of {num1} and {num2} is {totalSum}.");

static int AddTwoIntegers(int a, int b)
{
    return a + b;
}
