using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I, Manan Patel, 000735153 certify that this material is my original work. No other person's work has been used without due acknowledgement.
//File Date - 05/12/2018

namespace Lab5B
{
    class Episode
    {
        public string Story { get; set; }       //to store Story name
        public int Season { get; set; }         //to store Season Number
        public int Year { get; set; }           //to store Year
        public string Title { get; set; }       //to store Episode's Title 

        /// <summary>
        /// Constructor for Episode class
        /// </summary>
        /// <param name="story"></param>
        /// <param name="season"></param>
        /// <param name="year"></param>
        /// <param name="title"></param>
        public Episode(string story, int season, int year, string title)
        {
            Story = story;
            Season = season;
            Year = year;
            Title = title;
        }
    }
}

