namespace Prof.Models;

[Serializable]
public class Profile
{

    //(1,'COP','Concept of programming','Vaishali Chikhalkar','Pune');
//     `id` INT NOT NULL AUTO_INCREMENT,
//   `topic` VARCHAR(45) NOT NULL,
//   `descriptions` VARCHAR(45) CHARACTER SET 'utf8mb3' NOT NULL,
//   `faculty` VARCHAR(45) CHARACTER SET 'utf8mb3' NOT NULL,
//   `location
    public Profile(int id, string topic, string descriptions,string faculty, string location)
    {   
        this.id = id;
        this.topic = topic;
        this.descriptions =descriptions;
        this.faculty = faculty;
        this.location = location;
    }
     public int id { get; set; }
    public string topic { get; set; }
    public string descriptions { get; set; }
    public string faculty { get; set; }
    public string Email { get; set; }
    public string location { get; set; }


    public Profile()
    {
        this.topic = "COP";
        this.descriptions = "Concept of programming";
        this.faculty = "Vaishali Chikhalkar";
        this.location = "Pune";
    }

    public Profile(string topic)
    {
        this.topic = topic;
    }
    public Profile(string topic, string descriptions, string faculty, string email, string location)
    {
        this.topic = topic;
        this.descriptions = descriptions;
        this.faculty = faculty;
        this.location = location;
    }
}
