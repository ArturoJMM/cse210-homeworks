public class Owner
{
    public string _firstName;
    public string _lastName;
    public int _age;

    public Owner(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }

    public void DisplayOwnerData()
    {
        string fullName = $"This Journal belongs to: {_firstName} {_lastName} and I'm {_age} years old";
        Console.WriteLine(fullName);
    }


}