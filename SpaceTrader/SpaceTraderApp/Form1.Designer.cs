namespace SpaceTraderApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.marketGridView = new System.Windows.Forms.DataGridView();
            this.cargoHoldPanel = new System.Windows.Forms.Panel();
            this.holdGridView = new System.Windows.Forms.DataGridView();
            this.marketLabel = new System.Windows.Forms.Label();
            this.marketPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picturBoxPlanetsBoard = new System.Windows.Forms.PictureBox();
            this.overheadPanel = new System.Windows.Forms.Panel();
            this.newsLabel = new System.Windows.Forms.Label();
            this.planetNameTxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fuelBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutStatusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.planetNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fundsLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.marketGridView)).BeginInit();
            this.cargoHoldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holdGridView)).BeginInit();
            this.marketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturBoxPlanetsBoard)).BeginInit();
            this.overheadPanel.SuspendLayout();
            this.tableLayoutStatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // marketGridView
            // 
            this.marketGridView.AllowUserToAddRows = false;
            this.marketGridView.AllowUserToDeleteRows = false;
            this.marketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marketGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marketGridView.Location = new System.Drawing.Point(0, 0);
            this.marketGridView.Name = "marketGridView";
            this.marketGridView.ReadOnly = true;
            this.marketGridView.Size = new System.Drawing.Size(200, 99);
            this.marketGridView.TabIndex = 1;
            // 
            // cargoHoldPanel
            // 
            this.cargoHoldPanel.Controls.Add(this.holdGridView);
            this.cargoHoldPanel.Location = new System.Drawing.Point(793, 301);
            this.cargoHoldPanel.Name = "cargoHoldPanel";
            this.cargoHoldPanel.Size = new System.Drawing.Size(200, 99);
            this.cargoHoldPanel.TabIndex = 0;
            // 
            // holdGridView
            // 
            this.holdGridView.AllowUserToAddRows = false;
            this.holdGridView.AllowUserToDeleteRows = false;
            this.holdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holdGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.holdGridView.Location = new System.Drawing.Point(0, 0);
            this.holdGridView.Name = "holdGridView";
            this.holdGridView.ReadOnly = true;
            this.holdGridView.Size = new System.Drawing.Size(200, 99);
            this.holdGridView.TabIndex = 2;
            // 
            // marketLabel
            // 
            this.marketLabel.AutoSize = true;
            this.marketLabel.BackColor = System.Drawing.Color.Black;
            this.marketLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.marketLabel.Location = new System.Drawing.Point(244, 278);
            this.marketLabel.Name = "marketLabel";
            this.marketLabel.Padding = new System.Windows.Forms.Padding(72, 5, 70, 5);
            this.marketLabel.Size = new System.Drawing.Size(182, 23);
            this.marketLabel.TabIndex = 1;
            this.marketLabel.Text = "Market";
            this.marketLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.marketLabel_Paint);
            // 
            // marketPanel
            // 
            this.marketPanel.Controls.Add(this.marketGridView);
            this.marketPanel.Location = new System.Drawing.Point(244, 301);
            this.marketPanel.Name = "marketPanel";
            this.marketPanel.Size = new System.Drawing.Size(200, 99);
            this.marketPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(793, 278);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(45, 5, 70, 5);
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cargo Hold (3/100)";
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.marketLabel_Paint);
            // 
            // picturBoxPlanetsBoard
            // 
            this.picturBoxPlanetsBoard.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picturBoxPlanetsBoard.ErrorImage")));
            this.picturBoxPlanetsBoard.Image = global::SpaceTraderApp.Properties.Resources.planets_board;
            this.picturBoxPlanetsBoard.Location = new System.Drawing.Point(460, 266);
            this.picturBoxPlanetsBoard.Name = "picturBoxPlanetsBoard";
            this.picturBoxPlanetsBoard.Size = new System.Drawing.Size(327, 206);
            this.picturBoxPlanetsBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturBoxPlanetsBoard.TabIndex = 3;
            this.picturBoxPlanetsBoard.TabStop = false;
            this.picturBoxPlanetsBoard.Click += new System.EventHandler(this.planetsBoard_Click);
            // 
            // overheadPanel
            // 
            this.overheadPanel.BackColor = System.Drawing.Color.Black;
            this.overheadPanel.Controls.Add(this.newsLabel);
            this.overheadPanel.Location = new System.Drawing.Point(258, 30);
            this.overheadPanel.Name = "overheadPanel";
            this.overheadPanel.Size = new System.Drawing.Size(469, 124);
            this.overheadPanel.TabIndex = 9;
            // 
            // newsLabel
            // 
            this.newsLabel.AutoSize = true;
            this.newsLabel.BackColor = System.Drawing.Color.Transparent;
            this.newsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.newsLabel.Location = new System.Drawing.Point(3, 4);
            this.newsLabel.Name = "newsLabel";
            this.newsLabel.Padding = new System.Windows.Forms.Padding(20, 5, 30, 5);
            this.newsLabel.Size = new System.Drawing.Size(50, 23);
            this.newsLabel.TabIndex = 20;
            this.newsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // planetNameTxt
            // 
            this.planetNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetNameTxt.Location = new System.Drawing.Point(47, 92);
            this.planetNameTxt.Name = "planetNameTxt";
            this.planetNameTxt.Size = new System.Drawing.Size(132, 26);
            this.planetNameTxt.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(47, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 6;
            // 
            // fuelBar
            // 
            this.fuelBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuelBar.Location = new System.Drawing.Point(113, 34);
            this.fuelBar.Name = "fuelBar";
            this.fuelBar.Size = new System.Drawing.Size(160, 25);
            this.fuelBar.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(91, 226);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(20, 5, 30, 5);
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Location:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(3, 93);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(20, 5, 30, 5);
            this.label9.Size = new System.Drawing.Size(104, 31);
            this.label9.TabIndex = 19;
            this.label9.Text = "Time:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(3, 62);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(20, 5, 30, 5);
            this.label7.Size = new System.Drawing.Size(104, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "Funds:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(20, 5, 30, 5);
            this.label5.Size = new System.Drawing.Size(104, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fuel:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutStatusPanel
            // 
            this.tableLayoutStatusPanel.BackColor = System.Drawing.Color.Black;
            this.tableLayoutStatusPanel.ColumnCount = 2;
            this.tableLayoutStatusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.01782F));
            this.tableLayoutStatusPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.98218F));
            this.tableLayoutStatusPanel.Controls.Add(this.fuelBar, 1, 1);
            this.tableLayoutStatusPanel.Controls.Add(this.planetNameLabel, 1, 0);
            this.tableLayoutStatusPanel.Controls.Add(this.label10, 0, 0);
            this.tableLayoutStatusPanel.Controls.Add(this.label5, 0, 1);
            this.tableLayoutStatusPanel.Controls.Add(this.label7, 0, 2);
            this.tableLayoutStatusPanel.Controls.Add(this.label9, 0, 3);
            this.tableLayoutStatusPanel.Controls.Add(this.fundsLabel, 1, 2);
            this.tableLayoutStatusPanel.Controls.Add(this.label12, 1, 3);
            this.tableLayoutStatusPanel.Location = new System.Drawing.Point(730, 30);
            this.tableLayoutStatusPanel.Name = "tableLayoutStatusPanel";
            this.tableLayoutStatusPanel.RowCount = 4;
            this.tableLayoutStatusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutStatusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutStatusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutStatusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutStatusPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutStatusPanel.Size = new System.Drawing.Size(276, 124);
            this.tableLayoutStatusPanel.TabIndex = 10;
            this.tableLayoutStatusPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutStatusPanel_CellPaint);
            // 
            // planetNameLabel
            // 
            this.planetNameLabel.AutoSize = true;
            this.planetNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.planetNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planetNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.planetNameLabel.Location = new System.Drawing.Point(113, 0);
            this.planetNameLabel.Name = "planetNameLabel";
            this.planetNameLabel.Padding = new System.Windows.Forms.Padding(20, 5, 30, 5);
            this.planetNameLabel.Size = new System.Drawing.Size(160, 31);
            this.planetNameLabel.TabIndex = 20;
            this.planetNameLabel.Text = "Earth";
            this.planetNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(20, 5, 30, 5);
            this.label10.Size = new System.Drawing.Size(104, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "Location:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fundsLabel
            // 
            this.fundsLabel.AutoSize = true;
            this.fundsLabel.BackColor = System.Drawing.Color.Transparent;
            this.fundsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fundsLabel.Location = new System.Drawing.Point(113, 62);
            this.fundsLabel.Name = "fundsLabel";
            this.fundsLabel.Padding = new System.Windows.Forms.Padding(20, 5, 30, 5);
            this.fundsLabel.Size = new System.Drawing.Size(160, 31);
            this.fundsLabel.TabIndex = 22;
            this.fundsLabel.Text = "$5,000";
            this.fundsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(113, 93);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(20, 5, 30, 5);
            this.label12.Size = new System.Drawing.Size(160, 31);
            this.label12.TabIndex = 23;
            this.label12.Text = "7 days";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Planet Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Market status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceTraderApp.Properties.Resources.dashboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.planetNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutStatusPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.overheadPanel);
            this.Controls.Add(this.picturBoxPlanetsBoard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marketLabel);
            this.Controls.Add(this.cargoHoldPanel);
            this.Controls.Add(this.marketPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.marketGridView)).EndInit();
            this.cargoHoldPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.holdGridView)).EndInit();
            this.marketPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturBoxPlanetsBoard)).EndInit();
            this.overheadPanel.ResumeLayout(false);
            this.overheadPanel.PerformLayout();
            this.tableLayoutStatusPanel.ResumeLayout(false);
            this.tableLayoutStatusPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cargoHoldPanel;
        private System.Windows.Forms.DataGridView marketGridView;
        private System.Windows.Forms.Label marketLabel;
        private System.Windows.Forms.Panel marketPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView holdGridView;
        private System.Windows.Forms.PictureBox picturBoxPlanetsBoard;
        private System.Windows.Forms.Panel overheadPanel;
        private System.Windows.Forms.TextBox planetNameTxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutStatusPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label planetNameLabel;
        private System.Windows.Forms.Label fundsLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar fuelBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label newsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

