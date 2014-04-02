using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceTraderApp
{
    public partial class HighScoresForm : Form
    {
        public HighScoresForm()
        {
            InitializeComponent();
            // load data from file 
            // arrange data 
            // display on form 

            try
            {
                using (StreamReader reader = new StreamReader(@"..\..\Resources\scores.txt"))
                {
                    String line = reader.ReadToEnd();
                    highScoresLabel.Text = line; 
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString()); 
            }
        }
    }
}
