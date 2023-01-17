namespace Prof.Models;

[Serializable]
public class Profile
{
    public Profile(string firstname, string username, string profileurl)
    {
        this.Firstname = firstname;
        this.Username = username;
        this.Profileurl = profileurl;
    }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Profileurl { get; set; }


    public Profile()
    {
        this.Firstname = "Durgesh";
        this.Lastname = "Wagh";
        this.Username = "waghdurgesh";
        this.Email = "durgeshwagh@gmail.com";
        this.Profileurl = "https://github.com/waghdurgesh";
    }

    public Profile(string email, string username)
    {
        this.Email = email;
        this.Username = username;
    }
    public Profile(string firstname, string lastname, string username, string email, string profileurl)
    {
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.Username = username;
        this.Email = email;
        this.Profileurl = profileurl;
    }
}
