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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.marketGridView = new System.Windows.Forms.DataGridView();
            this.cargoHoldPanel = new System.Windows.Forms.Panel();
            this.holdGridView = new System.Windows.Forms.DataGridView();
            this.marketLabel = new System.Windows.Forms.Label();
            this.marketPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picturBoxPlanetsBoard = new System.Windows.Forms.PictureBox();
            this.planetNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.marketGridView)).BeginInit();
            this.cargoHoldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holdGridView)).BeginInit();
            this.marketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturBoxPlanetsBoard)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hold (3/100)";
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
            // planetNameTxt
            // 
            this.planetNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planetNameTxt.Location = new System.Drawing.Point(379, 38);
            this.planetNameTxt.Name = "planetNameTxt";
            this.planetNameTxt.Size = new System.Drawing.Size(132, 26);
            this.planetNameTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Planet Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Market status:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(379, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceTraderApp.Properties.Resources.dashboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.planetNameTxt);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marketGridView)).EndInit();
            this.cargoHoldPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.holdGridView)).EndInit();
            this.marketPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturBoxPlanetsBoard)).EndInit();
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
        private System.Windows.Forms.TextBox planetNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

