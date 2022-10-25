//For loops


//1.initializer 
//2.condition
//3.iterator ++, --, +=, -=, /= 

//1       //2    //3
for (int i = 0; i < 100; i++)
{
    //body of the for-loop
    System.Console.WriteLine(i);
}

//Challenge
//Promt the user for a number to count to from zero
System.Console.WriteLine("Please give me a number:");

//Take the input from the user and store it
int userInput = int.Parse(Console.ReadLine());

// loop all numbers from zero to the number given by the user.
for (int i = 0; i <= userInput; i++)
{
    if (i % 3 == 0)
    {
        System.Console.WriteLine(i);
    }
}

