using System.Text.Json;
public class Controllers()
{
    public Person GetPerson(string id)
    {
        if(File.Exists("data/people.json"))
        {
            List<Person> list = jsonSerializer.Deserialize<List<Person>>(File.ReadAllText("data/people.json"),
                        new JsonSerializerOptions {WriteIntended = true, PropertyNameCaseInsensitive = true})
                        ?? new List<Person>();
            return list.Single(o => o.id = id);
        }
        return null;
    }
}