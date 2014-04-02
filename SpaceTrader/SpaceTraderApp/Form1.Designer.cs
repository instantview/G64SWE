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
            this.holdPanel = new System.Windows.Forms.Panel();
            this.holdGridView = new System.Windows.Forms.DataGridView();
            this.marketLabel = new System.Windows.Forms.Label();
            this.marketPanel = new System.Windows.Forms.Panel();
            this.cargoLabel = new System.Windows.Forms.Label();
            this.picturBoxPlanetsBoard = new System.Windows.Forms.PictureBox();
            this.overheadPanel = new System.Windows.Forms.Panel();
            this.newsLabel = new System.Windows.Forms.Label();
            this.fuelBar = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutStatusPanel = new System.Windows.Forms.TableLayoutPanel();
            this.planetNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fundsLabel = new System.Windows.Forms.Label();
            this.holdStatsLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.buyingQty = new System.Windows.Forms.TextBox();
            this.sellingQty = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.highScoresBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.marketGridView)).BeginInit();
            this.holdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holdGridView)).BeginInit();
            this.marketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturBoxPlanetsBoard)).BeginInit();
            this.overheadPanel.SuspendLayout();
            this.tableLayoutStatusPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
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
            this.marketGridView.Size = new System.Drawing.Size(197, 90);
            this.marketGridView.TabIndex = 1;
            // 
            // holdPanel
            // 
            this.holdPanel.Controls.Add(this.holdGridView);
            this.holdPanel.Location = new System.Drawing.Point(800, 289);
            this.holdPanel.Name = "holdPanel";
            this.holdPanel.Size = new System.Drawing.Size(142, 99);
            this.holdPanel.TabIndex = 0;
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
            this.holdGridView.Size = new System.Drawing.Size(142, 99);
            this.holdGridView.TabIndex = 2;
            // 
            // marketLabel
            // 
            this.marketLabel.AutoSize = true;
            this.marketLabel.BackColor = System.Drawing.Color.Black;
            this.marketLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.marketLabel.Location = new System.Drawing.Point(244, 267);
            this.marketLabel.Name = "marketLabel";
            this.marketLabel.Padding = new System.Windows.Forms.Padding(78, 5, 79, 5);
            this.marketLabel.Size = new System.Drawing.Size(197, 23);
            this.marketLabel.TabIndex = 1;
            this.marketLabel.Text = "Market";
            this.marketLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.marketLabel_Paint);
            // 
            // marketPanel
            // 
            this.marketPanel.Controls.Add(this.marketGridView);
            this.marketPanel.Location = new System.Drawing.Point(244, 290);
            this.marketPanel.Name = "marketPanel";
            this.marketPanel.Size = new System.Drawing.Size(197, 90);
            this.marketPanel.TabIndex = 0;
            // 
            // cargoLabel
            // 
            this.cargoLabel.AutoSize = true;
            this.cargoLabel.BackColor = System.Drawing.Color.Black;
            this.cargoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cargoLabel.Location = new System.Drawing.Point(800, 266);
            this.cargoLabel.Name = "cargoLabel";
            this.cargoLabel.Padding = new System.Windows.Forms.Padding(50, 5, 56, 5);
            this.cargoLabel.Size = new System.Drawing.Size(141, 23);
            this.cargoLabel.TabIndex = 2;
            this.cargoLabel.Text = "Cargo";
            this.cargoLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.marketLabel_Paint);
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
            this.overheadPanel.Size = new System.Drawing.Size(383, 124);
            this.overheadPanel.TabIndex = 9;
            // 
            // newsLabel
            // 
            this.newsLabel.AutoSize = true;
            this.newsLabel.BackColor = System.Drawing.Color.Transparent;
            this.newsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.newsLabel.Location = new System.Drawing.Point(11, 31);
            this.newsLabel.Name = "newsLabel";
            this.newsLabel.Padding = new System.Windows.Forms.Padding(20, 5, 30, 5);
            this.newsLabel.Size = new System.Drawing.Size(50, 23);
            this.newsLabel.TabIndex = 20;
            this.newsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fuelBar
            // 
            this.fuelBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuelBar.Location = new System.Drawing.Point(113, 34);
            this.fuelBar.Name = "fuelBar";
            this.fuelBar.Size = new System.Drawing.Size(160, 25);
            this.fuelBar.TabIndex = 11;
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
            this.label9.Text = "Hold:";
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
            this.tableLayoutStatusPanel.Controls.Add(this.holdStatsLabel, 1, 3);
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
            this.fundsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // holdStatsLabel
            // 
            this.holdStatsLabel.AutoSize = true;
            this.holdStatsLabel.BackColor = System.Drawing.Color.Transparent;
            this.holdStatsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.holdStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdStatsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.holdStatsLabel.Location = new System.Drawing.Point(113, 93);
            this.holdStatsLabel.Name = "holdStatsLabel";
            this.holdStatsLabel.Padding = new System.Windows.Forms.Padding(20, 5, 30, 5);
            this.holdStatsLabel.Size = new System.Drawing.Size(160, 31);
            this.holdStatsLabel.TabIndex = 23;
            this.holdStatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buyButton.FlatAppearance.BorderSize = 0;
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buyButton.Location = new System.Drawing.Point(244, 386);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 2;
            this.buyButton.Text = "Buy >>";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sellButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sellButton.FlatAppearance.BorderSize = 0;
            this.sellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sellButton.Location = new System.Drawing.Point(868, 392);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(75, 23);
            this.sellButton.TabIndex = 3;
            this.sellButton.Text = "<< Sell ";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // buyingQty
            // 
            this.buyingQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buyingQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyingQty.Location = new System.Drawing.Point(388, 389);
            this.buyingQty.Name = "buyingQty";
            this.buyingQty.Size = new System.Drawing.Size(53, 16);
            this.buyingQty.TabIndex = 20;
            this.buyingQty.Text = "0";
            // 
            // sellingQty
            // 
            this.sellingQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellingQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingQty.Location = new System.Drawing.Point(800, 394);
            this.sellingQty.Name = "sellingQty";
            this.sellingQty.Size = new System.Drawing.Size(53, 16);
            this.sellingQty.TabIndex = 21;
            this.sellingQty.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Shopping";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // highScoresBtn
            // 
            this.highScoresBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.highScoresBtn.FlatAppearance.BorderSize = 0;
            this.highScoresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highScoresBtn.ForeColor = System.Drawing.Color.Black;
            this.highScoresBtn.Location = new System.Drawing.Point(3, 30);
            this.highScoresBtn.Name = "highScoresBtn";
            this.highScoresBtn.Size = new System.Drawing.Size(75, 23);
            this.highScoresBtn.TabIndex = 23;
            this.highScoresBtn.Text = "High Scores";
            this.highScoresBtn.UseVisualStyleBackColor = false;
            this.highScoresBtn.Click += new System.EventHandler(this.highScoresBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(3, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Save/Load";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(3, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "New / Quit";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.controlPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.controlPanel.Controls.Add(this.button4);
            this.controlPanel.Controls.Add(this.button1);
            this.controlPanel.Controls.Add(this.button3);
            this.controlPanel.Controls.Add(this.highScoresBtn);
            this.controlPanel.Location = new System.Drawing.Point(642, 34);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(85, 120);
            this.controlPanel.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceTraderApp.Properties.Resources.dashboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.sellingQty);
            this.Controls.Add(this.buyingQty);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.tableLayoutStatusPanel);
            this.Controls.Add(this.overheadPanel);
            this.Controls.Add(this.picturBoxPlanetsBoard);
            this.Controls.Add(this.cargoLabel);
            this.Controls.Add(this.marketLabel);
            this.Controls.Add(this.holdPanel);
            this.Controls.Add(this.marketPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Trader v0.4";
            ((System.ComponentModel.ISupportInitialize)(this.marketGridView)).EndInit();
            this.holdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.holdGridView)).EndInit();
            this.marketPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturBoxPlanetsBoard)).EndInit();
            this.overheadPanel.ResumeLayout(false);
            this.overheadPanel.PerformLayout();
            this.tableLayoutStatusPanel.ResumeLayout(false);
            this.tableLayoutStatusPanel.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel holdPanel;
        private System.Windows.Forms.DataGridView marketGridView;
        private System.Windows.Forms.Label marketLabel;
        private System.Windows.Forms.Panel marketPanel;
        private System.Windows.Forms.Label cargoLabel;
        private System.Windows.Forms.DataGridView holdGridView;
        private System.Windows.Forms.PictureBox picturBoxPlanetsBoard;
        private System.Windows.Forms.Panel overheadPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutStatusPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label planetNameLabel;
        private System.Windows.Forms.Label fundsLabel;
        private System.Windows.Forms.Label holdStatsLabel;
        private System.Windows.Forms.ProgressBar fuelBar;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.TextBox buyingQty;
        private System.Windows.Forms.TextBox sellingQty;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label newsLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button highScoresBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel controlPanel;
    }
}

