using System.Text.Json.Serialization;

public class People
{
    [JsonPropertyName("name")]
    public string Name { get; set;}

    [JsonPropertyName("birth_year")]
    public string Birth_year {get; set;}

    [JsonPropertyName("homeworld")]
    public string Homeworld {get; set;}

    
}