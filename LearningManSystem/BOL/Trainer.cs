namespace BOL;

[Serializable]
public class Trainer
{
    public int id { get; set; }
    public string topic { get; set; }
    public string description { get; set; }
    public string faculty { get; set; }
    public string location { get; set; }

    public Trainer()
    {
        this.id = 1;
        this.topic = "NA";
        this.description = "NA";
        this.faculty = "durgesh";
        this.location = "Nashik";
    }
    public Trainer(int id, string topic, string description, string faculty, string location)
    {
        this.id = id;
               this.topic = topic;
               this.description = description;
                this.faculty = faculty;
                this.location=location;
    }
    public Trainer(int id, string topic, string description)
    {
        this.id = id;
               this.topic = topic;
               this.description = description;
    }
}
