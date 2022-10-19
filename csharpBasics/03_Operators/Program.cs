// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// addition (+)

// subtraction (-)

// multiplication (*)

// division (/)

// remainder [Modulus, Modulo] %

// unary Operators
// Ex: increment++ (counting up by one) , 
//     decrement-- (counting down by one)

// lets assume that studentCount holds the value of 30.
int studentCount = 30;

// add one to the studentCount
//we can also use: studentCount+=1;
//todo: this is add one 'after the value'
studentCount++;

//todo: this is addng 'before the value'
++studentCount;

//decrement 
studentCount--;
--studentCount;

//addition (expression)
int additionResult = 5 + 2;
System.Console.WriteLine("5+2= " + additionResult);

//subtraction
int subtractionResult = 5 - 2;
System.Console.WriteLine("5-2= " + subtractionResult);

//multiplication
int multiplicationResult = 5 * 2;
System.Console.WriteLine("5*2= " + multiplicationResult);

//division
//we are using ints so, any decimal values are truncated.
int divisionResult = 5 / 2;
System.Console.WriteLine("5/2= " + divisionResult);

//Modulus
System.Console.WriteLine(10%2);
System.Console.WriteLine(10%9);
System.Console.WriteLine(16%3);
System.Console.WriteLine(19%5);

