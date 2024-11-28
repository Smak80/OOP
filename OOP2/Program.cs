using OOP2;

var p1 = new Person(
    "Иванов", "Иван", 20, 10000, Gender.Male
);
var p0 = new Person();

var p2 = new Person()
{
    Lastname = "Петров",
    Firstname = "Пётр"
};

var p3 = new Person(p2)
{
    Firstname = "Александр"
};

Console.WriteLine(p0);
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);