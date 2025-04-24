public class informationOrganizer
{
    public string listOutHobbies(Person person)
    {
        if(person.Hobbies == null || person.Hobbies.Length > 0)
            return "I have no hobbies";

        int length = person.Hobbies.Length;

        if(length < 2)
            return "My hobby is " + person.Hobbies[0];
        
        string result = string.Join(" ", person.Hobbies.Take(length -1));
        return "My hobbies are " + result + " and " + person.Hobbies[^1];
    }
}