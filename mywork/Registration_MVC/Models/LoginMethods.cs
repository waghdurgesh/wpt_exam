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
            string signup_file = @"F:\Module\MS Dotnet\git_repo_dotnet\ms_dotnet\Registration_MVC\wwwroot\json\Login.json";
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