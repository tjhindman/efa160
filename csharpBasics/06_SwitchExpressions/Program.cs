//Syntax
// value being evalueate, often be a variable
// The switch keyword
// A body that contains 'cases', called "expression arms", denoted by {}
// Commas will seperate the "experession arms"
// Made up of 3 parts

//1. The expected value, called a "Pattern"
//2. The "Fat Arrow", denoted as  '=>'
//3. The actual expression (the value returned)
//4. '_', this is the default

System.Console.WriteLine("Please enter a user name.");
string userName = Console.ReadLine();
//I need a variable container to store what I'm switching through
string greeting = userName switch
{
    "Pete" or
    "P-e-t-e" or 
    "pete" =>"Hello, Pete!", //if there are any other cases
     _ =>"Who are you"
};

System.Console.WriteLine(greeting);

System.Console.WriteLine("How are you feeling (1-5)");
string userInput = Console.ReadLine();

string userFeeling = userInput switch
{
    "1"=>"That Sucks",
    "2"=>"Things are beginning to suck",
    "3"=>"I guess this is common ground",
    "4"=>"Things are good",
    "5"=>"Thats awesome!",
    _ =>"Invald operation"
};

System.Console.WriteLine(userFeeling);


//Challenge 
//We have 2 questions in our code:
//"How are you feeling today?
//"How were you feeling yesterday?

//we got 2 variables
//feelingRating
//yesterdayRating

//The challenge is to compare these two values and display how much better or worse 
//they are feeling today than yesterday.

//you don't have to use switch expressions for this challenge.
//use whatever works for you.

//Tools you should think about using:
//Converting strings to numbers
//Comparison Operators
//Conditionals