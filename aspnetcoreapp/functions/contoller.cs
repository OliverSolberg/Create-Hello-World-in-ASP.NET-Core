using System.Text.Json;
public class Controllers()
{
    public Person? GetPerson(int id)
    {
        if(File.Exists("data/people.json"))
        {
            List<Person> list = JsonSerializer.Deserialize<List<Person>>(File.ReadAllText("data/people.json"),
                        new JsonSerializerOptions {WriteIndented = true, PropertyNameCaseInsensitive = true})
                        ?? new List<Person>();
            return list.Single(o => o.Id == id);
        }
        return null;
    }
}