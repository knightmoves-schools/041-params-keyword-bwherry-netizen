namespace knightmoves;

public class Person{
   public string FirstName;
   public string LastName;
   public string[] Hobbies;

   public Person(string firstName, string lastName, params string[] addHobbies){
      FirstName = firstName;
      LastName = lastName;
      Hobbies = addHobbies;
   }
}