using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;

namespace SpaceTraderApp
{
    public partial class Form1 : Form
    {    
        //this for putting planets on board bander 17-3-2013
       
        private Graphics vplanetsBoard;
        public readonly string[] TableHeaders = { "Name", "Qty", "Price" };
        private List<Planet> planetsList = new List<Planet>();
      
        
  


        public Form1()
        {
            InitializeComponent();
            InitializeGridViews();

            // define plantes shape  bander 17-3-2013
            planetsList.Add(new Planet("Mercury", 25, 15, 80, 80));
            planetsList.Add(new Planet("Venus", 130, 65, 70, 70));
            planetsList.Add(new Planet("Mars", 20, 125, 60, 65));
            planetsList.Add(new Planet("Jupiter", 220, 115, 60, 65));
            planetsList.Add(new Planet("Neptune", 245, 30, 60, 65));
            vplanetsBoard = picturBoxPlanetsBoard.CreateGraphics();

        }
   

  
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void InitializeGridViews()
        {
            // set up tables: readonly, color scheme
            // Set up markets table
            PopulateGridView(marketGridView, TableHeaders);
            PopulateGridView(holdGridView, TableHeaders);
            
            // Style tables 
            SetupGridViewUI(marketGridView);
            SetupGridViewUI(holdGridView); 
        }

        
        // Handles UI setup 
        private void SetupGridViewUI(DataGridView gridView)
        {   
            // Initialize basic DataGridView properties.
            gridView.Dock = DockStyle.Fill;
            gridView.BorderStyle = BorderStyle.None;
            gridView.RowHeadersVisible = false;            
            //gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 

            // Set property values appropriate for read-only display and  
            // limited interactivity. 
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.AllowUserToOrderColumns = true;
            //gridView.ReadOnly = true;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.MultiSelect = false;
            gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridView.AllowUserToResizeColumns = false;
            gridView.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridView.AllowUserToResizeRows = false;
            gridView.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            /*
             * Colors 
             */

            gridView.GridColor = Color.Green;
            gridView.BackgroundColor = Color.Black;
            gridView.DefaultCellStyle.BackColor = Color.Black;
            gridView.DefaultCellStyle.ForeColor = Color.Green;
            gridView.DefaultCellStyle.SelectionBackColor = Color.Black;
            gridView.DefaultCellStyle.SelectionForeColor = Color.Red;
            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default 
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            gridView.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Green;
            // Set the background color for all rows and for alternating rows.  
            // The value for alternating rows overrides the value for all rows. 
            //gridView.RowsDefaultCellStyle.BackColor = Color.LightGray;
            
            // Set the row and column header styles.
            gridView.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            gridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Yellow;
            gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            gridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            gridView.Columns["Name"].Width = 96;
            gridView.Columns["Qty"].Width = 35;
            gridView.Columns["Price"].Width = 50; 

            gridView.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //// Specify a larger font for the "Ratings" column. 
            //using (Font font = new Font(
            //    gridView.DefaultCellStyle.Font.FontFamily, 25, FontStyle.Bold))
            //{
            //    gridView.Columns["Rating"].DefaultCellStyle.Font = font;
            //}

            gridView.EnableHeadersVisualStyles = false;

        }


        // Handles content setup 
        private void PopulateGridView(DataGridView gridView, Array columnHeaders)
        {
            DataTable dt = new DataTable();

            foreach (String header in columnHeaders)
            {
                dt.Columns.Add(header); 
            }
            
            dt.Rows.Add("Pencil Sharpener Here", "3", "$200");
            dt.Rows.Add("Paper", "30", "$2,000");
            dt.Rows.Add("Box", "300", "$20,000");
            dt.Rows.Add("Book", "3,000", "$20");
            

            gridView.DataSource = dt; 
        }

        private void marketLabel_Paint(object sender, PaintEventArgs e)
        {
            marketLabel.Width = 100; 
            ControlPaint.DrawBorder(e.Graphics, marketLabel.DisplayRectangle, Color.Green, ButtonBorderStyle.Solid);
        }

    
        private void planetsBoard_Click(object sender, EventArgs e)
        {  bool planetSelected = false;
        for (int i = 0; i < planetsList.Count; i++)
        {
            if (planetsList[i].Gp.IsVisible(((MouseEventArgs)e).Location))
            {

                picturBoxPlanetsBoard.Refresh();
                vplanetsBoard.DrawEllipse(System.Drawing.Pens.Yellow, planetsList[i].getSize());
                planetSelected = true;
                planetNameTxt.Text = planetsList[i].name;

            }
        }
          
                
               if  (planetSelected == false)
               { picturBoxPlanetsBoard.Refresh();
               planetNameTxt.Text = null;
               } 
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

            
        }
    }
