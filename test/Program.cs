

// Task 1 && 2 
//Getting user input and then using Convert.ToInt32 in order to do calculations 
Console.WriteLine("Please enter a low number : ");
var lowNum1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter a high number : ");
var highNum1 = Convert.ToInt32(Console.ReadLine());



// While loop that is true if the first input is not negative AND it is lower then second input( highNum1)
//test commit1234
while (lowNum1 > 0 && highNum1 > lowNum1)
{
    Console.WriteLine("Please enter a low number : ");
    lowNum1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter a High number : ");
    highNum1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(lowNum1 - highNum1);
}


