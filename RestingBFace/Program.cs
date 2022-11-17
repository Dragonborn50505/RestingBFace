using RestSharp;
using System.Text.Json;

RestClient StarWarsCliet = new RestClient("https://swapi.py4e.com/api/");

RestRequest request = new RestRequest("people/1/");

RestResponse response = StarWarsCliet.GetAsync(request).Result;

//Console.WriteLine(response.StatusCode);
//Console.WriteLine(response.Content);

People p = new();

if (response.StatusCode.ToString() == "OK")
{
    p = JsonSerializer.Deserialize<People>(response.Content);
}

Console.WriteLine(p.Name);
Console.WriteLine(p.Birth_year);
Console.WriteLine(p.Homeworld);


Console.ReadLine();