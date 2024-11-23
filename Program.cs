using ClassApplication.Classes;

namespace ClassApplication;

class Program
{
    private static int Sum(params Object [] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
   
    private static void EditPersonName(ref Person person, string firstName, string lastName)
    {
        person.FirstName = firstName;
        person.LastName = lastName;
    }
    static void Main()
    {
       var person = new Person(firstName: "Bob", lastName: "Dylan", 
            dateOfBirthday: new DateOfBirthday(day: 24, month: 5, year: 1941), 
            adressInfo: new AdressInfo(street: "Wall str. 56/6", city: "New York", region: "-", country: "USA", postalCode: 99900));
        
        Console.WriteLine(person);
        EditPersonName(ref person, "John", "Doe");
        Console.WriteLine(person);
        Console.WriteLine(Sum(1, 2));
        Console.WriteLine(Sum(1, 2, 3));
        Console.WriteLine(Sum(1, 2, 3, 4 , 5, 6 , 7));
        Object [] array = {1, 2, 3, 4, 5, 6, 7};
        Console.WriteLine(Sum(array));
    }
}