namespace BLL;
using BOL;
using DAL;
// using DAL.Connected;
using DAL.DisConnected;
public class Coordinator
{
    //from json file list
    // public List<Trainer> GetAllTrainer()
    // {
    //     string path = @"F:\Module\MS Dotnet\git_repo_dotnet\ms_dotnet\N_Tier_MVC\TransflowerPvtLtd\MetaData\mis_trainer_Json.json";
    //     List<Trainer> trainersList = new List<Trainer>();
    //     trainersList = DataManager.GetTrainersDBfromFile(path);
    //     return trainersList;
    // }

    //from sql list
    //connected
    // public List<Trainer>  GetTrainersSQLData()
    // {
    //     List<Trainer> trainersSQLData = new List<Trainer>();
    //     trainersSQLData = DBConnectedSQL.GetAllTrainersSQLData();
    //     return trainersSQLData;
    // }
    //Disconnected 
    public List<Trainer>  GetTrainersSQLData()
    {
        List<Trainer> trainersSQLData = new List<Trainer>();
        trainersSQLData = DBDisconnectedSQL.GetAllTrainersSQLData();
        return trainersSQLData;
    }
    //from json file getdetails
    // public Trainer? GetTrainerDetails(int id)
    // {
    //     List<Trainer> trainersList = GetAllTrainer();
    //     Trainer? trainerData = trainersList.Find((trainer) => trainer.id == id);
    //     return trainerData;
    // }

    //sql get details
    //Connected
    public Trainer GetTrainerDetailsSQL(int id){
        Trainer trainerSQLDetails = DBDisconnectedSQL.GetAllTrainerDetailsSQL(id);
        return trainerSQLDetails;
    }
}
