public class InformationOrganizer
{
    public string ListOutHobbies(Person person)
    {
        if(person.Hobbies == null || person.Hobbies.Count < 0)
        {
            return "I have no hobbies";
        }

        int length = person.Hobbies.Count;

        if(length < 2)
        {
            return "My hobby is " + person.Hobbies[0];
        }
        
        string result = string.Join(", ", person.Hobbies.Take(length -1));
        return "My hobbies are " + result + " and " + person.Hobbies[^1];
    }
}