//Booleans

// can hold true / false

bool isCool = false;
isCool = true;

//todo: Booleans and logical operators
// Operators that perform logic 
//*  AND
//*  OR
//*  NOT

//NOT
// C# has a logical negation operator, or what we call the bang operator (!)
// !isCool evaluates to the opposite  of whatever value isCool is holding

//AND
// C# used ampersands (&) to indicate AND statements
// A single (&) evaluates both conditions always
// the (&&) only evaluates the right side if its required

//OR
// C# uses pipes (|) to indicate OR statements
// Similar to AND, one pipe checks both conditions and
// (||) will evaluate the first then the right

//XOR
// C# uses the caret character (^) indicates XOR statements.

//--Boolean Operators

//todo: Negation Operator
bool isTrue = !false; //true
bool isFalse = !true; //false

//todo: And Operator
bool trueAndExample = true && true; // true b/c BOTH HAVE TO BE TRUE!
bool falseAndExample = true && false; //false

//todo: Or Operator
bool trueOrExample = true || false; // true b/c one of them is true
bool falseOrExample = false || false;

//todo: XOR Operator
bool trueExclusiveOr = true ^ false; // true
bool falseExclusiveOr = true ^ true; // false
bool falseExclusiveOr2 = false ^ false; //false

System.Console.WriteLine($"NOT False = {isTrue}");
System.Console.WriteLine($"False AND True = {falseAndExample}");
System.Console.WriteLine($"True OR True = {trueOrExample}");
System.Console.WriteLine($"True XOR True = {falseExclusiveOr}");
System.Console.WriteLine($"False XOR False = {falseExclusiveOr2}");

Console.WriteLine(true ^ true);    // output: False
Console.WriteLine(true ^ false);   // output: True
Console.WriteLine(false ^ true);   // output: True
Console.WriteLine(false ^ false);  // output: False

//Comparison Operators

//Equal
// To declare that the values are equal

//Not Equal
// To declare that values are not equal

//Greater Than 
// (>)

//Less Than 
// (<)

//Greater than or Equal to
// (>=)

//Less than or Equal to
// (<=)

//Example:
bool isGreaterThan = 10 > 10;
bool isGreaterThanOrEqual = 10 >= 10;
System.Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 {isGreaterThanOrEqual}");

bool isLessThan = 5 < 5;
bool isLessThanOrEqual = 5 <= 5;
System.Console.WriteLine($"5 < 5 is {isLessThan}, and 5 <= 5 {isLessThanOrEqual}");

bool equality = 17 == 19;
bool inequality = 17 != 19;
System.Console.WriteLine($"17 == 19 is {equality}, and 17 != 19 {inequality}");

