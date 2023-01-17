namespace BLL;
using BOL;
using DAL;
using DAL.Connected;
public class Coordinator
{
    //Disconnected 
    public List<Trainer>  GetTrainersSQLData()
    {
        List<Trainer> trainersSQLData = new List<Trainer>();
        trainersSQLData = DBConnectedSQL.GetAllTrainersSQLData();
        return trainersSQLData;
    }
    //Connected
    public Trainer GetTrainerDetailsSQL(int id){
        Trainer trainerSQLDetails = DBConnectedSQL.GetAllTrainerDetailsSQL(id);
        return trainerSQLDetails;
    }
}
