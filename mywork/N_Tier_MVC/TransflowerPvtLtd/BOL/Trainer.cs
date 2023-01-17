namespace BOL;

[Serializable]
public class Trainer
{
    public int id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string? email { get; set; }
    public double phone { get; set; }
    public string? address { get; set; }
    public int qualification { get; set; }

    public Trainer()
    {
        this.id = 1;
        this.first_name = "durgesh";
        this.last_name = "wagh";
        this.email = "durgesh@gmail.com";
        this.phone = 9181716151;
        this.address = "Nashik";
        this.qualification = 2;
    }
    public Trainer(int id, string first_name, string last_name, string email, double phone, string address)
    {
        this.id = id;
        this.first_name = first_name;
        this.last_name = last_name;
        this.email = email;
        this.phone = phone;
        this.address = address;
        this.qualification = qualification;
    }
    public Trainer(int id, string first_name, string last_name)
    {
        this.id = id;
        this.first_name = first_name;
        this.last_name = last_name;
    }
}
