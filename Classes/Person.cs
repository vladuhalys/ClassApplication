namespace ClassApplication.Classes;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOfBirthday DateOfBirthday { get; set; }
    public AdressInfo AdressInfo { get; set; }
    
    public Person()
    {
        FirstName = "Unknown";
        LastName = "Unknown";
        DateOfBirthday = new DateOfBirthday();
        AdressInfo = new AdressInfo();
    }
    
    public Person(string firstName, string lastName, DateOfBirthday dateOfBirthday, AdressInfo adressInfo)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirthday = dateOfBirthday;
        AdressInfo = adressInfo;
    }
    
    public override string ToString()
    {
        return $"{FirstName} {LastName} - {DateOfBirthday} - {AdressInfo}";
    }
    
}