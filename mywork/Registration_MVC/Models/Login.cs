namespace Log.Models;
[Serializable]
public class Login
{

    public string First { get; set; }
    public string Last { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Login()
    {
        this.First = "admin";
        this.Last = "admin";
        this.Email = "admin@gmail.com";
        this.Password = "admin";
    }
    public Login(string First, string Last, string Email, string Password)
    {
        this.First = First;
        this.Last = Last;
        this.Email = Email;
        this.Password = Password;
    }

    public Login(string Email, string Password)
    {
        this.Email = Email;
        this.Password = Password;
    }

}