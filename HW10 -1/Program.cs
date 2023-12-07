using System;

using System;

class City
{
    
    private string cityName;
    private string regionName;
    private string countryName;
    private int population;
    private string postalCode;
    private string phoneCode;

    
    public City(string cityName, string regionName, string countryName, int population, string postalCode, string phoneCode)
    {
        this.cityName = cityName;
        this.regionName = regionName;
        this.countryName = countryName;
        this.population = population;
        this.postalCode = postalCode;
        this.phoneCode = phoneCode;
    }

   
    public void DisplayCityInfo()
    {
        Console.WriteLine("Название города: " + cityName);
        Console.WriteLine("Название региона: " + regionName);
        Console.WriteLine("Название страны: " + countryName);
        Console.WriteLine("Количество жителей: " + population);
        Console.WriteLine("Почтовый индекс: " + postalCode);
        Console.WriteLine("Телефонный код: " + phoneCode);
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        City city = new City("Киев", "Киевская область", "Украина", 12678079, "101000", "+8093");
        city.DisplayCityInfo();
    }
}