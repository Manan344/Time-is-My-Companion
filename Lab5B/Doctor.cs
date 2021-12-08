using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I, Manan Patel, 000735153 certify that this material is my original work. No other person's work has been used without due acknowledgement.
//File Date - 05/12/2018

namespace Lab5B
{
    class Doctor
    {
        public int Ordinal { get; set; }         //to store ordinal 
        public string Actor { get; set; }        //to store Actor's name
        public int Series { get; set; }          //to store Series Number
        public string Age { get; set; }          //to store Actor's age 
        public string Debut { get; set; }       //to store debute episode

        /// <summary>
        /// Constructor for Doctor Class
        /// </summary>
        /// <param name="ordinal"></param>
        /// <param name="actor"></param>
        /// <param name="series"></param>
        /// <param name="age"></param>
        /// <param name="debut"></param>
        public Doctor(int ordinal, string actor, int series, string age, string debut)
        {
            Ordinal = ordinal;
            Actor = actor;
            Series = series;
            Age = age;
            Debut = debut;
        }
    }

}

