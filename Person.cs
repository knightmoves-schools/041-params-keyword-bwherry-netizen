namespace knightmoves;

public class Person
{
    public string FirstName;
    public string LastName;
    public string[] Hobbies;

    public Person(string firstName, string lastName, params string[] addHobbies)
    {
        FirstName = firstName;
        LastName = lastName;
        Hobbies = addHobbies;
    }

    public void AddHobbies(params string[] newHobbies)
    {
        string[] combined = new string[Hobbies.Length + newHobbies.Length];

        for (int i = 0; i < Hobbies.Length; i++)
        {
            combined[i] = Hobbies[i];
        }

        for (int i = 0; i < newHobbies.Length; i++)
        {
            combined[Hobbies.Length + i] = newHobbies[i];
        }

        Hobbies = combined;
    }
}