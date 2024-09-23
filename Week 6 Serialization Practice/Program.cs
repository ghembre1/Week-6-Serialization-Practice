using System;
using System.Text.Json;
public class Person
{
public string Name { get; set; }
    public int Age { get; set; }
}
public class Program
{
    static void Main()
    {
        Person person = new Person { Name = "John", Age = 30 };
        // Serialize object to JSON
        string jsonString = JsonSerializer.Serialize(person);
        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(jsonString);
        // Deserialize JSON to object
        Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonString);
        Console.WriteLine($"Deserialized Person: {deserializedPerson.Name},
    { deserializedPerson.Age}");
    }

    Console.Read();
}
