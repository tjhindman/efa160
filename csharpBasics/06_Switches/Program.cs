// Switch 
// 'switch' keyword
// like if statements, but does away with "branching"

//1. value thats going to be evaluated

//2. "value" will be checked w/n the switch statement by a "case"

//3. "break" to indicate that we want to leave the switch statement

//4. "defult" -> if all else fails

//Ex:
System.Console.WriteLine("Please input your Name...");
//value to be evaluated:
//      1.
string name = Console.ReadLine();

//todo: we are going to switch on of this 'name' value.
switch (name)
{

    //this is the value passed in which is being "checked" by case (2)
    case "Pete":
    case "pete":
        System.Console.WriteLine("Hi, Pete!");

        //we have to leave the switch statement to prevent 'falling-through'
        break;

    //so, if the user types any other name then:
    default:
        System.Console.WriteLine("Invalid Option (Name).");
        break;
}

System.Console.WriteLine("How are you feeling (1-5)");
string userInput = Console.ReadLine();

switch (userInput)
{
    case "1":
        System.Console.WriteLine("I hope your day gets better.");
        break;
    case "2":
        System.Console.WriteLine("Oh, sorry to hear that.");
        break;
    case "3":
        System.Console.WriteLine("Hope things improve.");
        break;
    case "4":
        System.Console.WriteLine("Good Stuff!");
        break;
    case "5":
        System.Console.WriteLine("Wow, thats great to hear!");
        break;
    default:
        System.Console.WriteLine("Invalid Key Entry.");
        break;
}


//Challenge 
//Creating a switch statement
//want to output discriptions for a few of your friends
//Prompt the user's input to enter a friends name
//Take in a user's input from the Console
//If the input is one of the listed friends write a fact about that person to the Console

//Extra Challenge:
    // what can you do with cases like "Paul" and "paul" as these are different values