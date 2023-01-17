namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;


public class DBConnectedSQL
{
    //DB connnecttion parameters
    public static string conAuthDetails = @"server=localhost;port=3306;user=root;password=123456789;database=transflower_mis";

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
            string query = "SELECT * FROM trainers";
            //send query
            cmdDB.CommandText = query;
            //Read response
            MySqlDataReader readDB = cmdDB.ExecuteReader();
            while (readDB.Read())
            {
                int id = int.Parse(readDB["id"].ToString());
                string first_name = readDB["first_name"].ToString();
                string last_name = readDB["last_name"].ToString();
                string email = readDB["email"].ToString();
                double phone = double.Parse(readDB["phone"].ToString());
                string address = readDB["address"].ToString();
                int qualification = int.Parse(readDB["qualification"].ToString());

                Trainer trainerData = new Trainer
                {
                    id = id,
                    first_name = first_name,
                    last_name = last_name,
                    email = email,
                    phone = phone,
                    address = address,
                    qualification = qualification
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
            string query = "SELECT * FROM trainers where id =" + id;
            connDB.Open();
            MySqlCommand cmd = new MySqlCommand(query, connDB);
            MySqlDataReader readDB = cmd.ExecuteReader();
            if (readDB.Read())
            {
                id = int.Parse(readDB["id"].ToString());
                string first_name = readDB["first_name"].ToString();
                string last_name = readDB["last_name"].ToString();
                string email = readDB["email"].ToString();
                double phone = double.Parse(readDB["phone"].ToString());
                string address = readDB["address"].ToString();
                int qualification = int.Parse(readDB["qualification"].ToString());
                Trainer trainerDetails = new Trainer
                {
                    id = id,
                    first_name = first_name,
                    last_name = last_name,
                    email = email,
                    phone = phone,
                    address = address,
                    qualification = qualification
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
