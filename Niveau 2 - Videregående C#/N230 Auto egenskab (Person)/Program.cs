
Person newPerson = new Person();
newPerson.FirstName = "Test";
newPerson.LastName = "McTesterson";

Console.WriteLine(newPerson.FullName());

newPerson.LastName = "nul";
Console.WriteLine(newPerson.FullName());


class Person
{
	public string? FirstName { get; set; }
	private string? _lastName;

	public string? LastName
	{
		get { return _lastName; }
        set
        {
            if (value != null && value.Length <= 3)
            {
                _lastName = "";
            }

            else
            {
                _lastName = value;
            }
            
        }
    }

	public string FullName()
	{
		return $"{FirstName} {LastName}";
	}
}