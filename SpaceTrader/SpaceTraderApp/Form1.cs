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
using System.Threading; 
using SpaceTrader; 


namespace SpaceTraderApp
{
    public partial class Form1 : Form
    {    
        //this for putting planets on board bander 17-3-2013
        public Planet currPlanet;
        private Graphics vplanetsBoard;
        public readonly string[] TableHeaders = { "Name", "Qty", "Price" };
        public readonly string[] EmptyHeaders = { "", "", "" };
        private List<Planet> planetsList = new List<Planet>();
        Player player;
 

        public Form1()
        {  // Starting the game
            InitializeComponent();
            InitializeGridViews();
    
            fuelBar.Value = 100; 
            // define plantes shape  bander 17-3-2013
            planetsList.Add(new Planet("Mercury", 25, 15, 80, 80));
            planetsList.Add(new Planet("Venus", 130, 65, 70, 70));
            planetsList.Add(new Planet("Mars", 20, 125, 60, 65));
            planetsList.Add(new Planet("Jupiter", 220, 115, 60, 65));
            planetsList.Add(new Planet("Neptune", 245, 30, 60, 65));
            currPlanet = planetsList[1];
            PopulateGridView2(marketGridView, TableHeaders, planetsList[1].ItemsList);

            vplanetsBoard = picturBoxPlanetsBoard.CreateGraphics();

            player = new Player();
            player.Account.Deposit(10000);
            this.fundsLabel.Text = player.Account.Balance.ToString();
            planetNameLabel.Text = currPlanet.name; 
            PopulateGridView2(holdGridView, TableHeaders, player.CargoHold.GetItems());

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 20000;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            // change time 
            Random ro = new Random();
            int rand = ro.Next(0, 4);

            // after every 20 seconds, either increase or decrease prices on some planet and display alert
            // randomly choose planet 
            Planet eventPlanet = planetsList[rand];
            // change planet prices 
            
            int oldStatus = eventPlanet.Status;

            eventPlanet.Status = rand;

            // alert player 
            if (oldStatus > rand)
                MessageBox.Show("Prices in " + eventPlanet.name + "have decreased!"); 
                //newsLabel.Text = "Prices in " + eventPlanet.name + "have decreased!"; 
            else
                MessageBox.Show("Prices in " + eventPlanet.name + "have increased!");
                //newsLabel.Text = "Prices in " + eventPlanet.name + "have increased!";    
        }

        private void InitializeGridViews()
        {
            List<Item> items = new List<Item> { 
                new Item("Pencil Sharpener Here", 300, 20), 
                new Item("Paper", 20000, 2000), 
                new Item("Box", 300, 20), 
                new Item("Book", 3000, 20)
            };

            // Add table content
            PopulateTable(marketGridView, TableHeaders, items);
            PopulateTable(holdGridView, TableHeaders, items);

            // Style table interface
            StyleTable(marketGridView);
            StyleTable(holdGridView);
        }

        // Populates table with item data 
        private void PopulateTable(DataGridView gridView, Array columnHeaders, List<Item> items)
        {
            DataTable dt = new DataTable();

            if (items != null)
            {
                // Add column headers
                foreach (String header in columnHeaders)
                {
                    dt.Columns.Add(header);
                }

                // Add row contents 
                foreach (Item item in items)
                {
                    dt.Rows.Add(item.Name, item.Quantity, item.Price);
                }
            }

            gridView.DataSource = dt;
        }

        // Sets up UI of table
        private void StyleTable(DataGridView gridView)
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

            /* Colors */
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
            gridView.ColumnHeadersVisible = true;

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
                currPlanet = planetsList[i];
                picturBoxPlanetsBoard.Refresh();
                vplanetsBoard.DrawEllipse(System.Drawing.Pens.Yellow, planetsList[i].getSize());
                planetSelected = true;
                planetNameTxt.Text = planetsList[i].name;
                planetNameLabel.Text = planetsList[i].name; 
                PopulateGridView2(marketGridView, TableHeaders, planetsList[i].ItemsList);
                
                if (fuelBar.Value > 0)
                {
                    fuelBar.Value = fuelBar.Value - 10;
                }
                else
                {
                    TheEnd gameover = new TheEnd();

                 
                    gameover.Show();
                }

            }
        }
          
                
               if  (planetSelected == false)
               { picturBoxPlanetsBoard.Refresh();
               planetNameTxt.Text = null;
               }

        }

        private void PopulateGridView2(DataGridView gridView, Array columnHeaders, List<Item> item)
        {
            DataTable dt = new DataTable();

            foreach (String header in columnHeaders)
            {
                dt.Columns.Add(header);
            }
            //List<Item> item = planet.ItemsList;
           // marketLabel.Text = planet.name + " Market";
            dt.Rows.Add(item[0].name, item[0].PlantAmount1[0].ToString(), item[0].PlantPrice1[currPlanet.Status].ToString());
            dt.Rows.Add(item[1].name, item[1].PlantAmount1[0].ToString(), item[1].PlantPrice1[currPlanet.Status].ToString());
            dt.Rows.Add(item[2].name, item[2].PlantAmount1[0].ToString(), item[2].PlantPrice1[currPlanet.Status].ToString());

     


            gridView.DataSource = dt;
        }

        private void setLabelBorderColor(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ((Label) sender).DisplayRectangle, Color.Green, ButtonBorderStyle.Solid);
        }

        private void tableLayoutStatusPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Green), e.CellBounds);
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            string n = buyingQty.Text;
            int quantity;
            bool isNumeric = int.TryParse(n, out quantity);

            int balance = player.Account.Balance; 
            int itemQuantity = int.Parse(marketGridView.SelectedCells[1].Value.ToString());
            int itemPrice = int.Parse(marketGridView.SelectedCells[2].Value.ToString());
            string itemName = marketGridView.SelectedCells[0].Value.ToString();
            

            // check that item quantity provided by player is more than zero
            if (isNumeric != true || quantity < 1)
            {
                MessageBox.Show("Invalid amount entered!");
                return;
            }

            // check that player has enough funds 
            if ((itemPrice * quantity) > player.Account.Balance)
            {
                MessageBox.Show("Not enough funds!");
                return; 
            }

            // check that user entered less quantity than available on market 
            if (quantity > itemQuantity)
            {
                MessageBox.Show("Not enough stock!");
                return; 
            }


            
            if ((player.CargoHold.GetCapacity() + quantity) > player.CargoHold.MaxSize)
            {
                MessageBox.Show("No more room!");
                return;
            }

            // add items to cargo 
            
            // remove items from planet 
            currPlanet.ItemsList[marketGridView.CurrentCell.RowIndex].reduceStock(quantity);
            player.CargoHold.ItemList[marketGridView.CurrentCell.RowIndex].increaseStock(quantity);
            
            PopulateGridView2(marketGridView, TableHeaders, currPlanet.ItemsList);
            PopulateGridView2(holdGridView, TableHeaders, player.CargoHold.ItemList);
            player.Account.MoneyOut(itemPrice * quantity);
            fundsLabel.Text = player.Account.Balance.ToString(); 
        }


        private void sellButton_Click(object sender, EventArgs e)
        {
            string n = sellingQty.Text;
            int sellQuantity;
            bool isNumeric = int.TryParse(n, out sellQuantity);

            int balance = player.Account.Balance;
            int itemQuantity = int.Parse(holdGridView.SelectedCells[1].Value.ToString());
            int itemPrice = int.Parse(marketGridView.SelectedCells[2].Value.ToString());
            string itemName = holdGridView.SelectedCells[0].Value.ToString();
          


            // check that item quantity provided by player is more than zero
            if (isNumeric != true || sellQuantity < 1)
            {
                MessageBox.Show("Invalid amount entered!");
                return;
            }

            // check that user entered less quantity than available on market 
            if (sellQuantity > itemQuantity)
            {
                MessageBox.Show("Not enough stock!");
                return;
            }


            // remove items from planet 
            currPlanet.ItemsList[holdGridView.CurrentCell.RowIndex].increaseStock(sellQuantity);
            player.CargoHold.ItemList[holdGridView.CurrentCell.RowIndex].reduceStock(sellQuantity);

            PopulateGridView2(marketGridView, TableHeaders, currPlanet.ItemsList);
            PopulateGridView2(holdGridView, TableHeaders, player.CargoHold.ItemList);
            player.Account.Deposit(itemPrice * sellQuantity);
            fundsLabel.Text = player.Account.Balance.ToString(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
            
        }
    }
