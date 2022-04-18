namespace Data_Access_Layer.DAL.Models;

public class Country
{
    public int CountryID {set;get;}
    public string Image {set;get;}
    public string Denomination {set;get;}
    public int Population {set;get;}
    public double Area {set;get;}

    // fk
    public int ContinentD {set;get;}
    public Continent Continent {set;get;}
}
