//Loops Challenges:

//Bronze:
//Write a for loop to print the numbers 500 through 525.
//starting point i = 500; (initialization)
//boolean expression i<=525 (the loop will run as long as this is TRUE)
//i will increment up by one as long as bool value is TRUE
for (int i = 500; i <= 525; i++)
{
    System.Console.WriteLine(i);
}

//Silver:
//Create a for loop to print the numbers from 0-100 by 5's.
for (int i = 0; i <= 100; i += 5)
{
    System.Console.WriteLine(i);
}

//Gold:
//Create a for loop to print the numbers 1-100. 
//If it's divisible by both 3 and 5, print 'FizzBuzz' otherwise print the number.
//If the number is divisible by 3, print 'Fizz' instead of the number. 
//If it's divisible by 5, print 'Buzz', instead of the number. 

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        System.Console.WriteLine($"FizzBuzz: {i}");
    }
    else if (i % 3 == 0)
    {
        System.Console.WriteLine($"Fizz: {i}");
    }
    else if (i % 5 == 0)
    {
        System.Console.WriteLine($"Buzz: {i}");
    }
    else
    {
        System.Console.WriteLine(i);
    }
}