// See https://aka.ms/new-console-template for more information

using T2305M_CSharp.Session1;
using T2305M_CSharp.Session2;

Console.WriteLine("Hello, World!");
Person person = new Person(1,"Anh Vu",18,"HN");
Console.WriteLine(person.Id); // person.getId()
person.Id = 2; // person.setId(2)
Animal animal = new Animal(){Type = "Lion", Age = 3};
animal.Age = 2;
int[] arr = new int[5];
List<int> intArray = new List<int>();
intArray.Add(1);
intArray.Add(3);
intArray.Add(5);
intArray.Add(7);
intArray.Add(9);

Console.WriteLine(intArray[2]);

person.Telephones[0] = "2345678";
person[0] = "11234567";

Asian asian = new Asian();
asian.Id = 12;