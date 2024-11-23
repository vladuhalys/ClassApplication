namespace ClassApplication.Classes;

public class AdressInfo
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string Country { get; set; }
    public int PostalCode { get; set; }
    
    public AdressInfo()
    {
        Street = "Unknown";
        City = "Unknown";
        Region = "Unknown";
        Country = "Unknown";
        PostalCode = 0;
    }
    public AdressInfo(string street, string city, string region, string country, int postalCode)
    {
        Street = street;
        City = city;
        Region = region;
        Country = country;
        PostalCode = postalCode;
    }
    
    public override string ToString()
    {
        return $"{Street}, {City}, {Region}, {Country} - ({PostalCode})";
    }
}