using System;

//* Remember, variables are 'containers', in C# we just SMACK a lable on them

//1       //2    //3   //4
string firstName = "Terry";

//todo: 1 Type
//todo: 2 variable name
//todo: 3 assignment operator
//todo: 4 value

Console.WriteLine(firstName);
Console.WriteLine("What is your favorite color");

//declare a string color and we want to assign whatever the user types.
string color = Console.ReadLine();  //returns a 'string' type

System.Console.WriteLine("You said your favorite color is " + color);

System.Console.WriteLine("What is your name?");

string newName = Console.ReadLine();

System.Console.WriteLine("Ok, so your name is " + newName);