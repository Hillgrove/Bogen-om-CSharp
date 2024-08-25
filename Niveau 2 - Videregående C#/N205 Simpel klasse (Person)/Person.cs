
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BirthYear { get; set; }

    public Person()
    {
        FirstName = "";
        LastName = "";
    }

    public Person(string firstName, string lastName, int birthYear)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthYear = birthYear;
    }

    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }

    public int Age()
    {
        int presentYear = DateTime.Now.Year;
        int approxAge = presentYear - BirthYear;
        return approxAge; // We can't know without full birthday info
    }
}