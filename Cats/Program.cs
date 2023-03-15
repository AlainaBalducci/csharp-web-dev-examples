

//TODO: Try out your skills with inheritance here!
using Cats;

Console.WriteLine("Hello, Cats!");

HouseCat garfield = new HouseCat("Garfield", 12.0);
garfield.Eat();
Console.WriteLine(garfield.Tired);   // prints true
Console.WriteLine(garfield.Name);   // prints Garfield
Console.WriteLine(garfield.Purr());   //prints I'm a housecat
Console.WriteLine(garfield.Family);    //prints felidae
Console.WriteLine(garfield.IsSatisfied()); //prints false
Console.WriteLine(garfield.Species);  //prints felis catus
Console.WriteLine(garfield.Noise()); //prints Hello, my name is Garfield!
Console.WriteLine(garfield.Hungry); //prints false
Console.WriteLine(garfield.Weight); //prints 12

HouseCat spike = new HouseCat("Spike");
Console.WriteLine(spike.Weight);   // prints 13
