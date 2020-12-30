namespace MVC.Models
{
    public class User
    {

        public string Name { get; set; }
        public string Password { get; set; }
        public User InvitedBy { get; set; }
        public int InvitedCode { get; set; }
    }
}