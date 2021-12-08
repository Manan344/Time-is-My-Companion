using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//I, Manan Patel, 000735153 certify that this material is my original work. No other person's work has been used without due acknowledgement.
//File Date - 05/12/2018

namespace Lab5B
{
    public partial class Form1 : Form
    {
        List<Doctor> doctorList;          //list to store doctor class
        List<Companion> companionList;     //list to store companion class
        List<Episode> episodeList;          //list to store episode class
        String line = "";

        /// <summary>
        /// Main Form Class
        /// </summary>
        public Form1()
        {
            doctorList = new List<Doctor>();
            companionList = new List<Companion>();
            episodeList = new List<Episode>();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method will display OpenFileDialog which allows 
        /// user to select txt files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadFile_Click(object sender, EventArgs e)
        {
            actorBox.Clear();
            ageBox.Enabled = false;
            episodeBox.Enabled = true;
            OpenFileDialog ofd = new OpenFileDialog();       //configure the Open file dialog box and display it
            ofd.Filter = "Text Files (*.txt)|*.txt";         //display all .txt files

            if(ofd.ShowDialog() == DialogResult.OK)         //If user clicked OK in the dialog and .txt file was selected, open it
            {
                   StreamReader sr = new StreamReader(ofd.FileName);
                    while(line != null)
                    {
                        line = sr.ReadLine();

                        if(line != null)
                        {
                            listBox1.Items.Add(line);
                        }
                    }

                //comboBox1.SelectedIndex = 0;
            }

            //loading combobox after file is read 
            comboBox1.Items.Add("First");
            comboBox1.Items.Add("Second");
            comboBox1.Items.Add("Third");
            comboBox1.Items.Add("Fourth");
            comboBox1.Items.Add("Fifth");
            comboBox1.Items.Add("Sixth");
            comboBox1.Items.Add("Seventh");
            comboBox1.Items.Add("Eighth");
            comboBox1.Items.Add("Ninth");
            comboBox1.Items.Add("Tenth");
            comboBox1.Items.Add("Eleventh");
            comboBox1.Items.Add("Twelfth");

        }

        /// <summary>
        /// This method will store contents of the file
        /// </summary>
        /// <param name="fileData"></param>
        private void storeContent(List<String>fileData)
        {
            foreach(String line in fileData)
            {
                String[] data = line.Split('|')
                                    .Select(text => text.Trim())
                                    .ToArray();

                switch (data[0].ToUpper())
                {
                    case "D":
                        {
                            int Ordinal = Convert.ToInt32(data[1]);
                            string Actor = data[2];
                            int Series = Convert.ToInt32(data[3]);
                            string Age = data[4];
                            string Debut = data[5];

                            Doctor doc = new Doctor(Ordinal, Actor, Series, Age, Debut);
                            doctorList.Add(doc);
                        }
                        break;

                    case "C":
                        {
                            string Name = data[1];
                            string Actor = data[2];
                            int Doctor = Convert.ToInt32(data[3]);
                            string Debut = data[4];

                            Companion comp = new Companion(Name, Actor, Doctor, Debut);
                            companionList.Add(comp);
                        }
                        break;

                    case "E":
                        {
                            string Story = data[1];
                            int Season = Convert.ToInt32(data[2]);
                            int Year = Convert.ToInt32(data[3]);
                            string Title = data[4];

                            Episode episode = new Episode(Story, Season, Year, Title);
                            episodeList.Add(episode);
                        }
                        break;

                }
            }

            doctorList =                        //sorting doctors in ascending order
                doctorList.OrderBy
                (d => d.Ordinal)
                .ToList();

            companionList =                     //sorting companions in ascending order
                companionList
                .OrderBy(c => c.Debut)
                .ToList();
                
            episodeList =                       //sorting episodes in ascending order
                episodeList
                .OrderBy(e => e.Story)
                .ToList();
        }

        /// <summary>
        /// This will exit the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();                       //exit the window
        }
    }
}
