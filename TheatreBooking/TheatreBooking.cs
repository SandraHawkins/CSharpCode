using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBooking
{
    public class TheatreBooking
    {
        // a string for the show name
        public string ShowName { get; set; }    

        // A DateTime object to hold the date
        public DateTime Date { get; set; }  

        // A 2 dimensional character array of seats (F is a free seat, S is a sold seat)
        public char [][] Seats { get; set; }    

        public override string ToString()
        {
            string text = ShowName;
            text += "\n" + Date.ToShortDateString(); // 16/02/2022

            text += "\n";

            // Nested for loop to print out the contents of the 2D array of seats

            for (int i = 0; i < Seats.Length; i++)  // 10 
            {
                for (int j = 0; j < Seats[i].Length; j++)  // 20 
                {
                    text += Seats[i][j].ToString();
                }
                text += "\n";
            }

            return text;
            // Cats
            // 18/02/2022
            // FFFFFFSSSSSSFFFFFFFF
            // FFFSSSSFFFFFFFFFFFFF
            // FFFFFFFFFFFFFSSSFFFF
            // FFFFFFFFFFFFFFFFFFFF
            // FFFFFFFFFFFFFFFFFFFF
            // FFFFFFFFFFFFFFFFFFFF
            // FFFFFFFFFFFFFFFFFFFF
            // FFFFFFFFFFFFFFFFFFFF
            // FFFFFFFFFFFFFFFFFFFF
            // FFFFFFFFFFFFFFFFFFFF
        }
    }
}
