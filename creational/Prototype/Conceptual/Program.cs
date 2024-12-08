// See https://aka.ms/new-console-template for more information

using Conceptual;

var person1 = new Person
{
    Age = 42,
    Name = "Sam",
    IdInfo = new IdInfo
    {
        IdNumber = 6565,
    },
};

var person2 = (Person)person1.Clone();

Console.WriteLine("Original values of person1 and person2:");
Console.WriteLine("   person1 instance values: ");
DisplayValues(person1);
Console.WriteLine("   person2 instance values:");
DisplayValues(person2);

person1.Age = 32;
person1.Name = "Frank";
person1.IdInfo.IdNumber = 7878;
Console.WriteLine("\nValues of person1 and person2 after changes to person1:");
Console.WriteLine("   person1 instance values: ");
DisplayValues(person1);
Console.WriteLine("   person2 instance values:");
DisplayValues(person2);

return;

static void DisplayValues(Person p)
{
    Console.WriteLine($"      Name: {p.Name:s}, Age: {p.Age:d}");
    Console.WriteLine($"      Value: {p.IdInfo.IdNumber:d}");
}
