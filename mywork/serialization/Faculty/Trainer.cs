namespace Faculty;

using System.ComponentModel.DataAnnotations;

[Serializable]

public class Trainer
{
    
    public int Id { get; set; }
    [Required]
    public string First_name { get; set; }

    public string Last_name { get; set; }

    // public string Email{get;set;}

    // public double Phone {get;set;}

    // public string Address{get;set;}

    // public string Qualification{get;set;}


    public Trainer()
    {
        this.Id = 1;
        this.First_name = "Nisarg";
        this.Last_name = "Acharya";
    }

    public Trainer(int id, string first_name, string last_name)
    {
        this.Id = id;
        this.First_name = first_name;
        this.Last_name = last_name;
    }

}
