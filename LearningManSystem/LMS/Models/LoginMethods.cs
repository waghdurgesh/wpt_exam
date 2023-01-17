namespace Logmeth.Models;
using Log.Models;
using System.Text.Json;

public class LoginMethods{

    List<Login> signuplist  = new List<Login>();

    public void SerializeSignUp(Login log){

        try{
            signuplist.Add(log);
            var options = new JsonSerializerOptions { IncludeFields = true };
            var signup_data = JsonSerializer.Serialize<List<Login>>(signuplist, options);
            string signup_file = @"E:\229028_Durgesh_Wagh\LearningManSystem\LMS\wwwroot\MetaDATA\Login.json";
            File.WriteAllText(signup_file, signup_data);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
        }
    }

    public List<Login> getsighnupdata(){
        return signuplist;
    }
}