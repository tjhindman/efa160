using Classes;
//Constructor -> what we use to "new-up" a version of the object
// "versions" are called overloads 

//Syntax of a constructor 

//1. Access Modifier -> public, private (default), protected (inheritance),
                   //   internal (objs can only be used/referenced w/n the assembly)

//2. name of the Type, in our case a Donut

//3. A pair of parenthesis that can contain Parameters

//4. The body that executes code.

Donut doug = new Donut("Creme Filled");
Console.WriteLine(doug);
Console.WriteLine(doug._donutType);

//our first class:
namespace Classes
{
    class Donut
    {
        
        //public field -> a variable that lives w/n a Class
        public string? _donutType;
        
        //ctor -> tab will create the constructor for you !
        //1     //2        //3
        public Donut(string donutType)
        {
            //4
            _donutType = donutType;
        }

    }
}
