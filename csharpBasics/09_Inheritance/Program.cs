Console.Clear();

Cat cat = new Cat();
cat.MakeSound();
cat.Move();


System.Console.WriteLine("-- Tabby Cat --");

TabbyCat tCat = new TabbyCat();
tCat.Move();
tCat.MakeSound();

System.Console.WriteLine("-- Dragon --");
Hydra hydra =new Hydra();
System.Console.WriteLine(hydra.HeadCount);



System.Console.WriteLine("-- Sloth --");
Sloth sloth = new Sloth();
sloth.Move();


List<Animal> animals = new List<Animal>()
{
    new Cat(),
    new Dragon(),
    new Sloth(),
    new Hydra(80),
    new TabbyCat()
};


void ReadOutMyType()
{
    foreach(var animal in animals)
    {
        Console.WriteLine(animal.GetType().Name);
        animal.Move();
    }
}

ReadOutMyType();