using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking
{
    internal class UserDetails
    {
        public UserDetails() { }

        public UserDetails(int id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public int Id { get; set; } 

        public string FirstName { get; set; }

        public string LastName { get; set; }  
        
        public string FullName { 
            get {  return FirstName + " " + LastName; } 
        }    

        public string Email { get; set; }   

        public override string ToString()
        {
            return $"Id: {Id}, Full Name : {FullName}, Email : {Email}";
        }
    }
}
