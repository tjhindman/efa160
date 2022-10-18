//C# Types

//variable naming Convention:
// camel-cased (typeNameIsCapitalized)
//first letter is lower case and every following word had its first letter capitalized

// bool -> true / false
bool isLoggedIn = true;
System.Console.WriteLine(isLoggedIn);

//integers -> whole numbers
int age = 20;
System.Console.WriteLine(age);  //.ToString()...

//decimal -> vary percise 
//need m suffix to show that the value is a decimal
decimal accountBalance = 90_000m;
System.Console.WriteLine(accountBalance);


int i = 0;            //32bit integer value
//short sh = 32767;     // 16bit integer value
//Int16 anotherShortEx = 32000;
//byte by = 255;       // a group of binary digits (usually eight) operated on as a unit;

string s = "hey!";  //a collection of characters;
                    // this reference type defaults to null
System.Console.WriteLine(s.Length);
char c ='i';       // this represents a single character.

string s2 = @"a\tree"; //use the @ to specify a directory

bool b = false; //true / false

//long L = 7;              // this is A LARGE INTEGER VALUE. X2 :
                        //  -9Q - 9Q (data science)

decimal d = 99.9999999m; // 'm' 128-bit percision, 28-29 decimal places (Money)

double db = 7.8000;      // 'd' 15-16 digits w/ 64-bit size

float f = 10.8f;        // 'f' stored in 32 bits, its half the size of a double.

int? ni = null;        //int is a Struct it default to zero. But, if we (int?) 
                       // we turn int to a "nullable int"

//dealing with decimals
//these values should truncate
System.Console.WriteLine(1.25878058705150144511210841f);
System.Console.WriteLine(1.25878058705150144511210841d);
System.Console.WriteLine(1.25878058705150144511210841m);

//DateTime
DateTime Today = DateTime.Today;

//we can make our own date
DateTime birthday = new DateTime(1972,06,20);

//Enums types that are represented by numbers.
PastryType myPastry = PastryType.Cake;
PastryType anotherOne= PastryType.Croissant;
System.Console.WriteLine("I Like "+myPastry+" and "+ anotherOne);





