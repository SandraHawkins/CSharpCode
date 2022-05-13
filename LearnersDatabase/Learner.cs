using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    internal class Learner
    {
        // If you don't type any constructor into a class, you will get a parameterless 
        // constructor. If you type any constructors into a class, e.g. one that take
        // a value for all properties, you will no longer get the parameterless constructor
        // provided by the the compiler. 
        // If you type in a constructor that takes paraemters, make sure to also insert
        // a parameterless constructor, which will allow you to call use an object-init 
        // block:
        //      Learner learner = new Learner() 
        //      {
        //          Id = .....,
        //      }
        public Learner() {}

        // This constructor can be used to create a Learner object instead of using
        // the object initialisation block.
        // Right clicking: Quick Actions and Refactoring... -> Genearte Constructor...
        public Learner(int id, string name, string address, DateTime dateOfBirth,
                       decimal registrationFee, bool isEnrolled)
        {
            Id = id;
            Name = name;
            Address = address;
            DateOfBirth = dateOfBirth;
            RegistrationFee = registrationFee;
            IsEnrolled = isEnrolled;
        }

        public int Id { get; set; } 

        public string Name { get; set; }    

        public string Address { get; set; } 

        public DateTime DateOfBirth { get; set; }   

        public decimal RegistrationFee { get; set; }

        public bool IsEnrolled { get; set; }    

        public override String ToString()
        {
            return String.Format($"Id: {Id}" +
                $"\nName: {Name}\nAddress: {Address}" +
                $"\nDate of Birth: {DateOfBirth.ToShortDateString()}" +
                $"\nRegistration Fee: {RegistrationFee}" +
                $"\nIsEnrolled: {IsEnrolled}");
        }
    }
}
