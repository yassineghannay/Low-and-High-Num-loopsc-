// See https://aka.ms/new-console-template for more information

// Task 1 && 2 
Console.WriteLine("Please enter a low number : ");
var lowNum1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a High number : ");
var highNum1 = Convert.ToInt32(Console.ReadLine());

while (lowNum1 > 0 && highNum1 > lowNum1)
{
    Console.WriteLine("Please enter a low number : ");
    lowNum1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter a High number : ");
    highNum1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(lowNum1 - highNum1);
}



