using System.Collections.Generic;
using System;

//WE DONT DO THINS ANYMORE!!!!!!!!
object[] stuff = new object[5];
stuff[0] = "Terry";
stuff[1] = 1;
stuff[2] = 44.75f;
stuff[3] = "Bill Bob";

foreach (var item in stuff)
{
    Console.WriteLine(item);
}

//We need type saftey 
string stringExample = "Hello world!";

//Arrays are FIXED VALUES
//They always start at zero (zero indexed)
//We it comes to retriving data these are quick
// BUT, when it comes to copying and moving data around this SUCKS

//Array of type string
string[] stringArray =
{
    "Hello",
    "Wrold",
    "Why",
    "is it",
    "Always",
    stringExample,
    "?",
};

System.Console.WriteLine(stringArray[3]); //is it

//change a value of an indice
stringArray[1] = "Hey there";
Console.WriteLine(stringArray[1]);

//Arrays have overall length, which tells us how many items there are
System.Console.WriteLine(stringArray.Length); //7

//List<T> -> T is the "Genereic Type" that the collection is composed of
// T can be any 'Type'.

//List are arrays under the hood, but are more dynamic
//They have a max count, 10, and doubles when the array is about to be filled.
// List<T> uses .Count instead of .Length
List<string> listOfStrings = new List<string>();

List<int> ListOfIntegers = new List<int>();

listOfStrings.Add("Tj");
listOfStrings.Add("james");
listOfStrings.Add("jed");

ListOfIntegers.Add(4455);

Console.WriteLine(listOfStrings[0]);

foreach (var name in listOfStrings)
{
    Console.WriteLine(name);
}

listOfStrings.Remove(listOfStrings[listOfStrings.IndexOf("james")]);
System.Console.WriteLine("0------------------------0");
foreach (var name in listOfStrings)
{
    Console.WriteLine(name);
}

//Queues<T>
// F.I.F.O -> First In, First out 
// line in general, who ever is first in line is serviced first

Queue<string> firstInFirstOut = new Queue<string>();

//add to the queue
firstInFirstOut.Enqueue("I'm First.");
firstInFirstOut.Enqueue("I'm Second.");

//see whos next in line
string firstIn = firstInFirstOut.Peek();

System.Console.WriteLine(firstIn);

//to service the first one
firstInFirstOut.Dequeue();

System.Console.WriteLine("---------------------------");

firstIn = firstInFirstOut.Peek();
System.Console.WriteLine(firstIn);


//Dictionary<TKey,TValue>  (key/value) pair
// Can't have the same key
// when it comes to iterations we can constrain them 

Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
keyAndValue.Add(1, "Terry");
keyAndValue.Add(2, "Tj");

//no constraint here -> key/value pair
foreach (KeyValuePair<int, string> values in keyAndValue)
{
    System.Console.WriteLine(values);
}

System.Console.WriteLine("-------Keys---------");
//constraints -> just show me keys....
foreach (int values in keyAndValue.Keys)
{
    System.Console.WriteLine(values);
}

//constraints -> just show me Values....
System.Console.WriteLine("-------Values---------");
foreach (string values in keyAndValue.Values)
{
    System.Console.WriteLine(values);
}

string tj = keyAndValue[2];
Console.WriteLine(tj);

//Other Collections
SortedList<int,string> sortedKeyValuePair = new SortedList<int, string>();
HashSet<int> uniqueList = new HashSet<int>();
Stack<string> lastInFistOut = new Stack<string>();

//------------------------using Random --------------------

//this is based on CPU clock ticks!
Random rng = new Random();

//5 is inclusive and 20 is exclusive
int number = rng.Next(5,20);
System.Console.WriteLine(number);