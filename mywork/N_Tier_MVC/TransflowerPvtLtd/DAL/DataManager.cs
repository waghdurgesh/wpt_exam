namespace DAL;
using BOL;
using System.Text.Json;

public class DataManager
{
    public static List<Trainer> GetTrainers()
    {
        List<Trainer> Trainers_List = new List<Trainer>();
        // Trainers_List.Add(new Trainer(1, "vaishali", "chikhalkar", "vaishali.chikhalkar@gmail.com", 9028437934, "Pune"));
        // Trainers_List.Add(new Trainer(2, "nisarg", "acharya", "nisarg.acharya@gmail.com", 9022960035, "Pune"));
        // Trainers_List.Add(new Trainer(3, "kishori", "khadilkar", "kishori.khadilkar@gmail.com", 9109749373, "Pune"));
        // Trainers_List.Add(new Trainer(4, "madhura", "anturkar", "madhura.anturkar@gmail.com", 9009910231, "Pune"));
        // Trainers_List.Add(new Trainer(5, "vishal", "jagtap", "vishal.jagtap@gmail.com", 9133945903, "Pune"));
        // Trainers_List.Add(new Trainer(6, "ravi", "tambade", "ravi.tambade@gmail.com", 9178200994, "Pune"));
        // Trainers_List.Add(new Trainer(7, "shantanu", "pathak", "shantanu.pathak@gmail.com", 9862228563, "Pune"));
        return Trainers_List;
    }

    public static List<Trainer> GetTrainersDBfromFile(string filepath)
    {
        if (File.Exists(filepath))
        {
            string Trainers_JsonData = System.IO.File.ReadAllText(filepath);
            List<Trainer> Trainers_list = JsonSerializer.Deserialize<List<Trainer>>(Trainers_JsonData);
            return Trainers_list;
        }
        else
        {
            return GetTrainers();
        }
    }
}
