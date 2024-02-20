// See https://aka.ms/new-console-template for more information

using T2305M_CSharp.Session1;

Console.WriteLine("Hello, World!");
Person person = new Person(1,"Anh Vu",18,"HN");
Console.WriteLine(person.Id); // person.getId()
person.Id = 2; // person.setId(2)