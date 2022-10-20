// what if the if statement didn't work? 
// what else can we do?

//Ex:
bool isRaining= false;

if(!isRaining){
    System.Console.WriteLine("I'll cut the grass.");
}
else{
    System.Console.WriteLine("I guess I can't cut the grass!");
}

//another example
bool isGoingOutside = true;

if(isGoingOutside){
    System.Console.WriteLine("Make sure to dress for the weather.");
}
else{
    System.Console.WriteLine("Sounds like a sweater kind of day.");
}

//another one:
if(isGoingOutside){
    System.Console.WriteLine("Make sure to dress for the weather.");
}
else if(isRaining){
    //..code
}
else{
     System.Console.WriteLine("Sounds like a sweater kind of day.");
}

//else is "if all else fails" or "default"

//We want to ask the user, how are you feeling today?
System.Console.WriteLine("How are you feeling (1-5)");

//we want to store the users input w/n a 'string' container 
string userInput = Console.ReadLine();

if(userInput == "1"){
    System.Console.WriteLine("I hope your day gets better.");
}
else if(userInput =="2"){
    System.Console.WriteLine("Oh, sorry to hear that.");
}
else if(userInput =="3"){
    System.Console.WriteLine("Hope things improve.");
}
else if(userInput == "4"){
    System.Console.WriteLine("Good Stuff!");
}
else if(userInput =="5"){
    System.Console.WriteLine("Wow, thats great to hear!");
}else{
    System.Console.WriteLine("Invalid Key Entry.");
}
