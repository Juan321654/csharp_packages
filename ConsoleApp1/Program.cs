using Newtonsoft.Json;

// create a dummy json data
var jsonData = @"
{
    ""name"": ""John Doe"",
    ""age"": 30,
    ""isEmployed"": true,
    ""skills"": [""C#"", ""JavaScript"", ""Python""]
}";

// Deserialize the JSON data into a dynamic object
var person = JsonConvert.DeserializeObject<dynamic>(jsonData);
// Access the properties of the dynamic object
Console.WriteLine($"Name: {person.name}");
Console.WriteLine($"Age: {person.age}");
Console.WriteLine($"Is Employed: {person.isEmployed}");
Console.WriteLine("Skills: " + string.Join(", ", person.skills));
// Serialize the dynamic object back to JSON
var serializedJson = JsonConvert.SerializeObject(person, Formatting.Indented);
// Output the serialized JSON
Console.WriteLine("Serialized JSON:");
Console.WriteLine(serializedJson);
// Output:
// Serialized JSON:
// {
//   "name": "John Doe",
//   "age": 30,
//   "isEmployed": true,
//   "skills": [
//     "C#",
//     "JavaScript",
//     "Python"
//   ]
// }
// Note: Ensure you have the Newtonsoft.Json package installed in your project.
// You can install it via NuGet Package Manager with the command:
// Install-Package Newtonsoft.Json
// or by adding it to your .csproj file:
// <PackageReference Include="Newtonsoft.Json" Version="13.0.1" />