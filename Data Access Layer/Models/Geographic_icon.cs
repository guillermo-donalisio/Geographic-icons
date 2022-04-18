namespace Data_Access_Layer.DAL.Models;

public class Geographic_icon
{
    public string Image {set;get;}
    public string Description {set;get;}
    public DateTime Creation_date {set;get;}
    public decimal Height {set;get;}
    public string Story {set;get;}
    public string Image {set;get;}

    // Collection navigation property 
    public List<City> Cities {set;get;}
}



