namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;


public class DBConnectedSQL
{
    //DB connnecttion parameters
    public static string conAuthDetails = @"server=127.0.0.1;port=3306;user=root;password=root123;database=lms";

    public static List<Trainer> GetAllTrainersSQLData()
    {
        List<Trainer> allTrainers = new List<Trainer>();
        //mysql connection
        MySqlConnection connectDB = new MySqlConnection();
        connectDB.ConnectionString = conAuthDetails;
        try
        {
            connectDB.Open();
            //Query
            MySqlCommand cmdDB = new MySqlCommand();
            //supply connection to query
            cmdDB.Connection = connectDB;
            //write query string
            string query = "SELECT * FROM trainings";
            //send query
            cmdDB.CommandText = query;
            //Read response
            MySqlDataReader readDB = cmdDB.ExecuteReader();
            while (readDB.Read())
            {
                int id = int.Parse(readDB["id"].ToString());
                string topic = readDB["topic"].ToString();
                string description = readDB["description"].ToString();
                string faculty = readDB["faculty"].ToString();
                string location = readDB["location"].ToString();

                Trainer trainerData = new Trainer
                {
                    id = id,
               topic = topic,
               description = description,
                faculty = faculty,
                location = location
                };
                allTrainers.Add(trainerData);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connectDB.Close();
        }
        return allTrainers;
    }

    public static Trainer GetAllTrainerDetailsSQL(int id)
    {
        Trainer allTrainerDetails = new Trainer();
        MySqlConnection connDB = new MySqlConnection();
        connDB.ConnectionString = conAuthDetails;
        try
        {
            string query = "SELECT * FROM trainings where id =" + id;
            connDB.Open();
            MySqlCommand cmd = new MySqlCommand(query, connDB);
            MySqlDataReader readDB = cmd.ExecuteReader();
            if (readDB.Read())
            {
               id = int.Parse(readDB["id"].ToString());
                string topic = readDB["topic"].ToString();
                string description = readDB["description"].ToString();
                string faculty = readDB["faculty"].ToString();
                string location = readDB["location"].ToString();
                Trainer trainerDetails = new Trainer
                {
                    id = id,
                    topic = topic,
                    description = description,
                    faculty = faculty,
                    location = location
                };
                allTrainerDetails = trainerDetails;
            }
        }
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            connDB.Close();
        }
        return allTrainerDetails;
    }
}
