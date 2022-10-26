Console.Clear();
//Methods

//Usually used in a class but for now well use "Functional Programming"

//perform small tasks (modular)

// They can give us something back (return value)

// They can give us "nothing" back (void)

/*
  1      2      3          4
public  void SayHello(string Name)
{
     5
    Console.WriteLine($"Hello {Name}");
}
*/

// 1 is access Modifier public , private, protected, internal
// 2 RETURN TYPE (void means return nothing), but we can return any Type that we want
// 3 Method Name 
// 4 Method Parameters -> we can pass values to the method to perform tasks
// 3 + 4 -> Method Signature, seen by the compiler and checked for method overloading ... for now
// 5 Method body -> the task performed by the method.

            // At this state string Name is a Parameter
void SayHello(string Name)
{
    Console.WriteLine($"Hello {Name}");
}

          // We are passing in an Argument
SayHello("Bill Esquire");
SayHello("Ted Thedore Rogan");

//Sometimes methods have no parameters
void Greeting()
{
    Console.WriteLine("Hello!");
}

Greeting();
Greeting();
Greeting();

//Add 2 int together -> 2 parameters
int AddMe (int valueA, int valueB)
{
    int answer = valueA + valueB;
    return answer;
//    return valueA + valueB;
}

Console.WriteLine(AddMe(3,5));   //8

//When we are using Methods with return types, we can store them inside a variable
// A VARIABLE IS NOTHING MORE THAN A BOX (CONTAINER)
// as long as the Types match we can store the variable

int sum = AddMe(3,5); //8

//So sum will the value stored for future use.

Console.WriteLine(AddMe(sum,sum));  //16

//subtraction

int SubtractMe(int valueA, int valueB)
{
    return valueB - valueA;
}


int SubtractMeDouble(double valueA, double valueB)
{
    //this chopps off the decimal values ....
    return Convert.ToInt32(valueB - valueA);
}

Console.WriteLine(SubtractMe(2,3));
Console.WriteLine(SubtractMeDouble(2.7,33.5));


double SquareMe(int value)
{
    return value*value;
}

Console.WriteLine(SquareMe(3));

// crazy?

Console.WriteLine(SquareMe(AddMe(sum,3)));

int CrazyMath_AddUs(params int[] values)
{
    //this is were we want to start from
    int startingPoint = 0;

    //use foreach loop
    foreach(int value in values)
    {
        //continual adding
        //so, 0+= (whatever is the first number)
        startingPoint+=value;
    }

    return startingPoint;
}

int addValues = CrazyMath_AddUs(1,7,8,9,10,200,22,300,1000,40);

Console.WriteLine(addValues);

//Setting up something Random
Random _random = new Random();

void GetRandomGreeting()
{
    string[] availableGreetings =
    {
        "Hello",  //0
        "Howdy",  //1
        "Hola",   //2
        "Yo",     //3
        "Greetings",  //4
    };

    int randomNumber = _random.Next(0,5);  //0 -4

    string randomGreeting = availableGreetings[randomNumber];

    Console.WriteLine($"{randomGreeting}");
}

GetRandomGreeting();


