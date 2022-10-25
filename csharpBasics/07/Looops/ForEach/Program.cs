//Foreach syntax 
// foreach (declaredIterator in enumerableCollection)
//{
// body 
//}


//Ex:

string intstructorName = "Amanda";

//we need to make a collection 
string[] instructors = new string[]{
    "Michael",
    "Joshua"
    ,intstructorName
};

foreach (string instuctor in instructors)
{
    System.Console.WriteLine(instuctor);
}

int[] intArray = new int[]
{
    1,
    2,
    -3,
    4,
    5,
    0
};

//*manual way
//*int[] myArray = new int[3];
//*myArray[0] = 300;
//*myArray[1] = 30;


foreach (int number in intArray)
{
    // if(number <0)
    // System.Console.WriteLine($"This is a negative number. {number}");
    // else if(number>0) 
    // System.Console.WriteLine($"This is a positive number. {number}");
    // else
    // System.Console.WriteLine($"This is a neutral number. {number}");

    switch (number)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            System.Console.WriteLine($"This is a positive number. {number}");
            break;

        case -3:
            System.Console.WriteLine($"This is a negative number. {number}");
            break;

        default:
            System.Console.WriteLine($"This is a neutral number. {number}");
            break;
    }
}