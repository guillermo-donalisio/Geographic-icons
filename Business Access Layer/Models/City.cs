namespace Data_Access_Layer.DAL.Models;

public class City
{
    public int CityID {set;get;}
    public string Image {set;get;}
    public string Denomination {set;get;}
    public int Population {set;get;}
    public double Area {set;get;}

    // fk
    public int CountryID {set;get;}
    public Country Country {set;get;}
}
