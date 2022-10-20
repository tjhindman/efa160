//Ternary Expressions

//conditional operator
// composed of 3 parts

//Syntax:

//1            //2                    //3
// booolean expression  ?    expression if true : expression if false;

//3 parts
//1. booolean expression to be evaluated
//2. signals to the compiler that we are useing a ternary operator
//3. seperates the true : false evaluation

//Ex:
System.Console.WriteLine("Enter your age:");
string response = Console.ReadLine();
//now we may have an issue....
int age = int.Parse(response);
//int age2 = Convert.ToInt32(response); 

string output = (age >= 18) ? "Lets party!" : "your too young.";
System.Console.WriteLine(output);