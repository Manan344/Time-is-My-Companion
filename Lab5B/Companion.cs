using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I, Manan Patel, 000735153 certify that this material is my original work. No other person's work has been used without due acknowledgement.
//File Date - 05/12/2018

namespace Lab5B
{
    class Companion
    {
        public string Name { get; set; }         //to store Companion name
        public string Actor { get; set; }        // to store Actor 'sname
        public int Doctor { get; set; }          //to store Doctor number
        public string Debut { get; set; }       //to store debute episode

        /// <summary>
        /// Constructor for Companion class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="actor"></param>
        /// <param name="doctor"></param>
        /// <param name="debut"></param>
        public Companion(string name, string actor, int doctor, string debut)
        {
            Name = name;
            Actor = actor;
            Doctor = doctor;
            Debut = debut;
        }
    }
}

