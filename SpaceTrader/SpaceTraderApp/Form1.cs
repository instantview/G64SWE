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
using System.Media; 


namespace SpaceTraderApp
{
    public partial class Form1 : Form
    {    
        //this for putting planets on board bander 17-3-2013
        public Planet currPlanet;
        private Graphics vplanetsBoard;
        public readonly string[] MarketTableHeaders = { "Name", "Qty", "Price" };
        public readonly string[] CargoHoldTableHeaders = { "Name", "Qty"};
        private List<Planet> planetsList;
        Player player;

        public enum SoundType
        {
            Transaction, SpaceshipFlight
        }

        public Form1()
        {  // Starting the game
            InitializeComponent();
            InitializeGridViews();

            // Set up player
            player = new Player();
            player.Account.Deposit(10000);
            
            // define plantes shape  bander 17-3-2013
            planetsList = new List<Planet>();
            planetsList.Add(new Planet("Mercury", 25, 15, 80, 80));
            planetsList.Add(new Planet("Venus", 130, 65, 70, 70));
            planetsList.Add(new Planet("Mars", 20, 125, 60, 65));
            planetsList.Add(new Planet("Jupiter", 220, 115, 60, 65));
            planetsList.Add(new Planet("Neptune", 245, 30, 60, 65));
            
            currPlanet = planetsList[1];
            vplanetsBoard = picturBoxPlanetsBoard.CreateGraphics();

            // Set up tables 
            PopulateGridView(marketGridView, MarketTableHeaders, planetsList[1].ItemsList);
            PopulateGridView(holdGridView, CargoHoldTableHeaders, player.CargoHold.GetItems());
            
            // Set up UI 
            fundsLabel.Text = InPounds(player.Account.Balance);
            planetNameLabel.Text = currPlanet.name; 
            holdStatsLabel.Text = player.CargoHold.Status();
            fuelBar.Value = 100; 

            // Set up price changing 
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 20000;
            aTimer.Enabled = true;
        }

        /* Helper Methods */        
        private void InitializeGridViews()
        {
            // Add table data
            PopulateGridView(marketGridView, MarketTableHeaders, new List<Item>());
            PopulateGridView(holdGridView, CargoHoldTableHeaders, new List<Item>()); 

            // Style table interface
            StyleGridView(marketGridView);
            StyleGridView(holdGridView);
        }

        // Populates DataGridView with items 
        private void PopulateGridView(DataGridView gridView, Array columnHeaders, List<Item> item)
        {
            int columns = columnHeaders.Length; 
            DataTable dt = new DataTable();

            foreach (String header in columnHeaders)
            {
                dt.Columns.Add(header);
            }

            if (item.Count > 0)
            {
                if (columns == 3)
                {
                    dt.Rows.Add(item[0].name, item[0].Quantities[0].ToString(), item[0].Prices[currPlanet.Status].ToString());
                    dt.Rows.Add(item[1].name, item[1].Quantities[0].ToString(), item[1].Prices[currPlanet.Status].ToString());
                    dt.Rows.Add(item[2].name, item[2].Quantities[0].ToString(), item[2].Prices[currPlanet.Status].ToString());
                }
                else if (columns == 2)
                {
                    dt.Rows.Add(item[0].name, item[0].Quantities[0].ToString());
                    dt.Rows.Add(item[1].name, item[1].Quantities[0].ToString());
                    dt.Rows.Add(item[2].name, item[2].Quantities[0].ToString());
                } 
            }

            gridView.DataSource = dt;
        }

        // Styles the UI of DataGridView 
        private void StyleGridView(DataGridView gridView)
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

            gridView.Columns["Name"].Width = 100;
            gridView.Columns["Qty"].Width = 40;

            gridView.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Extra settings for tables with price 
            if (gridView.Columns.Contains("Price"))
            {
                gridView.Columns["Price"].Width = 56;
                gridView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            //// Specify a larger font for the "Ratings" column. 
            //using (Font font = new Font(
            //    gridView.DefaultCellStyle.Font.FontFamily, 25, FontStyle.Bold))
            //{
            //    gridView.Columns["Rating"].DefaultCellStyle.Font = font;
            //}
            
            gridView.EnableHeadersVisualStyles = false;
        }

        private void SetLabelBorderColor(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ((Label)sender).DisplayRectangle, Color.Green, ButtonBorderStyle.Solid);
        }

        public void DisplayDashboardMessage(string message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(DisplayDashboardMessage), new object[] { message });
                return;
            }
            newsLabel.Text = message;
        }

        private void PlaySound(SoundType soundType)
        {
            System.IO.UnmanagedMemoryStream soundByte;
            switch (soundType)
            {
                case SoundType.SpaceshipFlight:
                    soundByte = global::SpaceTraderApp.Properties.Resources.scifi017;
                    break;
                case SoundType.Transaction:
                    soundByte = global::SpaceTraderApp.Properties.Resources.cashregister;
                    break;
                default:
                    soundByte = global::SpaceTraderApp.Properties.Resources.scifi017;
                    break;
            }
            new SoundPlayer(soundByte).Play();
        }

        private String InPounds(int amount)
        {
            return amount.ToString("c0", System.Globalization.CultureInfo.CreateSpecificCulture("en-GB"));
        }

        private void ClearInputBoxes()
        {
            sellingQty.Text = "0";
            buyingQty.Text = "0"; 
        }

        /* 
         * Events 
         */
        private void marketLabel_Paint(object sender, PaintEventArgs e)
        {
            marketLabel.Width = 100; 
            ControlPaint.DrawBorder(e.Graphics, marketLabel.DisplayRectangle, Color.Green, ButtonBorderStyle.Solid);
        }

        private void planetsBoard_Click(object sender, EventArgs e)
        {  
            bool planetSelected = false;
            for (int i = 0; i < planetsList.Count; i++)
            {
                if (planetsList[i].Gp.IsVisible(((MouseEventArgs)e).Location))
                {
                    if (fuelBar.Value > 0)
                    {
                        fuelBar.Value = fuelBar.Value - 10;
                        PlaySound(SoundType.SpaceshipFlight);
                        System.Threading.Thread.Sleep(3800);
                        ClearInputBoxes(); 
                    }
                    else
                    {
                        TheEnd gameover = new TheEnd();
                        gameover.ShowDialog();
                        Application.Exit();
                    }

                    currPlanet = planetsList[i];
                    picturBoxPlanetsBoard.Refresh();
                    vplanetsBoard.DrawEllipse(System.Drawing.Pens.Yellow, planetsList[i].getSize());
                    planetSelected = true;
                
                    planetNameLabel.Text = planetsList[i].name; 
                    PopulateGridView(marketGridView, MarketTableHeaders, planetsList[i].ItemsList);
                }
            }

            if (planetSelected == false)
            { 
                picturBoxPlanetsBoard.Refresh();
            }

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

            // check spaceship cargo hold has enough space
            if ((player.CargoHold.GetItemQuantity() + quantity) > player.CargoHold.MaxSize)
            {
                MessageBox.Show("No more room!");
                return;
            }
            
            currPlanet.ItemsList[marketGridView.CurrentCell.RowIndex].reduceStock(quantity);
            player.CargoHold.ItemList[marketGridView.CurrentCell.RowIndex].increaseStock(quantity);
            
            PopulateGridView(marketGridView, MarketTableHeaders, currPlanet.ItemsList);
            PopulateGridView(holdGridView, CargoHoldTableHeaders, player.CargoHold.ItemList);
            player.Account.MoneyOut(itemPrice * quantity);
            fundsLabel.Text = InPounds(player.Account.Balance);
            holdStatsLabel.Text = player.CargoHold.Status();
            PlaySound(SoundType.Transaction);
            ClearInputBoxes(); 
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

            PopulateGridView(marketGridView, MarketTableHeaders, currPlanet.ItemsList);
            PopulateGridView(holdGridView, CargoHoldTableHeaders, player.CargoHold.ItemList);
            
            player.Account.Deposit(itemPrice * sellQuantity);
            fundsLabel.Text = InPounds(player.Account.Balance);
            holdStatsLabel.Text = player.CargoHold.Status();
            PlaySound(SoundType.Transaction);
            ClearInputBoxes(); 
        }
        
        private void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            string message;

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
                message = "Good news! Prices in " + eventPlanet.name + " have decreased!";
            else
                message = "Good news! Prices in " + eventPlanet.name + " have increased!";

            DisplayDashboardMessage(message);
        }
            
    }
}
