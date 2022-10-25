//Loops 
// we use these to repeat lines of code. 
// We can have a specific operation , function, and 'wrap' a loop around it.

//while loops
// we will define a variable -> this is used for the while loops 'boolean expression'
int number = 0;

//While number is less than or equal to 100, lets do the following
while (number <= 100)
{
    //write to the console
    System.Console.WriteLine(number);

    //count up by one, so "That we can have a way to EXIT the loop"
    number++;
    //++number;
    //number+=1;
}

//Infinite loops (our enemy)
/*
    while(number ==0) 
    {
        Console.WriteLine("Oh, S**t!);
    }
*/

//we can control the behavior 
int value2 = 100;

while (value2 > 0)
{
    value2--;

    if (value2 == 90)
    {
        System.Console.WriteLine("We are going to Jump out of the loop!");
        break;
    }
    if (value2 == 80)
    {
        System.Console.WriteLine("We will just Return or leave the loop.");
        return;
    }
    if (value2 == 10)
    {
        System.Console.WriteLine($"Lets just carry on with the loop. {value2}");
        continue;
    }
}

//do while 
// run just once Always
do
{
    System.Console.WriteLine($"Hello world {value2}");
    value2--;
}
while (value2 > 50);
