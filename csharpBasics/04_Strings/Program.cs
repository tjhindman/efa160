//Strings 

//Collection of characters 
// Any text, single character or number can be a string

//we make strings with (" ")

//3 way to use a string type
// Concatination
// Composite formatting 
// Interpolation

//todo: Concatination
string first = "The cars we sell are ";
string second = "BMW, Lexus, and Mercedes.";

string concatinatedResult = first + second;
System.Console.WriteLine(concatinatedResult);

//Composite Fromatting
string firstName = "Jenn";
string lastName = "Williams";

string compositeResult = string.Format("Her name is {0} {1}", firstName, lastName);
System.Console.WriteLine(compositeResult);

//String Interpolation
string interpolationResult = $"Her name is still {firstName} {lastName}";
System.Console.WriteLine(interpolationResult);

//Challenge
//Practice these three ways of joining strings (3) more examples of each
