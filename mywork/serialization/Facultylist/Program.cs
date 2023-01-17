// namespace Facultylist;
using Faculty;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;



Trainer t6 = new Trainer { Id = 6, First_name = "Jhonny", Last_name = "Bravo" };
Trainer t2 = new Trainer { Id = 2, First_name = "kishori", Last_name = "khadilkar" };
Trainer t3 = new Trainer { Id = 3, First_name = "madhura", Last_name = "anturkar" };
Trainer t4 = new Trainer { Id = 4, First_name = "vaishali", Last_name = "chikhalkar" };
Trainer t5 = new Trainer { Id = 5, First_name = "shantanu", Last_name = "pathak" };


List<Trainer> trainerlist = new List<Trainer>();

trainerlist.Add(t6);
trainerlist.Add(t2);
trainerlist.Add(t3);
trainerlist.Add(t4);
trainerlist.Add(t5);

try
{
    var options = new JsonSerializerOptions { IncludeFields = true };
    var trainersJson = JsonSerializer.Serialize<List<Trainer>>(trainerlist, options);
    string fileName = @"F:\Module\MS Dotnet\git_repo_dotnet\ms_dotnet\serialization\trainers.json";
    //serialize

    File.WriteAllText(fileName, trainersJson);
    string jsonString = File.ReadAllText(fileName);
    List<Trainer> jsontrainerlist = JsonSerializer.Deserialize<List<Trainer>>(jsonString);
    Console.WriteLine("\n JSON:Deserializing data from Json file \n \n");
    foreach (Trainer trainer in jsontrainerlist)
    {
        Console.WriteLine($"{trainer.First_name}:{trainer.Last_name}");
    }
}
catch (Exception exp)
{

}
finally { }