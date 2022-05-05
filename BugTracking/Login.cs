using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    public class Login
    {
        public Login() { }

        public Login(int id, string username, string password, string role)
        {
            Id = id;
            Username = username;
            Password = password;
            Role = role;
        }

        public int Id { get; set; } 
        public string Username { get; set; }    
        public string Password { get; set; }
        public string Role { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Username: {Username}, Password: {Password}, Role: {Role}";
        }
    }
}
