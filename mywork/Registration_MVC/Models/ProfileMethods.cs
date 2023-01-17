namespace ProfMeth.Models;
using Prof.Models;
using System.Text.Json;

public class ProfileMethods
{
    List<Profile> profile_list = new List<Profile>();
    public void SerializeProfile(Profile profile1)
    {
        try
        {
            profile_list.Add(profile1);
            var options = new JsonSerializerOptions { IncludeFields = true };
            var profile_data = JsonSerializer.Serialize<List<Profile>>(profile_list, options);
            string profile_file = @"F:\Module\MS Dotnet\git_repo_dotnet\ms_dotnet\Registration_MVC\wwwroot\json\List.json";
            File.WriteAllText(profile_file, profile_data);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
        }
    }
    public List<Profile> getprofiledata()
    {
        return profile_list;
    }
}