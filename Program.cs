using BuilderCattern.ConcreteBuilder;
using BuilderCattern.Director;

var director = new SpringfieldDirector();

var homer = director.BuildCitizen(new HomerBuilder());
Console.WriteLine(homer);

var burns = director.BuildCitizen(new MrBurnsBuilder());
Console.WriteLine(burns);
