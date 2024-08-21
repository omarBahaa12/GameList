namespace GameList
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Lb_XO = new System.Windows.Forms.Label();
            this.Lb_StonePapperScissors = new System.Windows.Forms.Label();
            this.Lb_GameList = new System.Windows.Forms.Label();
            this.Lb_MathGame = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mathGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xOGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stonePapperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mathGameToolStripMenuItem,
            this.xOGameToolStripMenuItem,
            this.stonePapperToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(224, 618);
            this.menuStrip1.TabIndex = 1;
            // 
            // Lb_XO
            // 
            this.Lb_XO.AutoSize = true;
            this.Lb_XO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_XO.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_XO.Location = new System.Drawing.Point(946, 334);
            this.Lb_XO.Name = "Lb_XO";
            this.Lb_XO.Size = new System.Drawing.Size(130, 31);
            this.Lb_XO.TabIndex = 4;
            this.Lb_XO.Text = "X O Game";
            this.Lb_XO.Click += new System.EventHandler(this.Lb_XO_Click);
            // 
            // Lb_StonePapperScissors
            // 
            this.Lb_StonePapperScissors.AutoSize = true;
            this.Lb_StonePapperScissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_StonePapperScissors.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_StonePapperScissors.Location = new System.Drawing.Point(274, 345);
            this.Lb_StonePapperScissors.Name = "Lb_StonePapperScissors";
            this.Lb_StonePapperScissors.Size = new System.Drawing.Size(267, 31);
            this.Lb_StonePapperScissors.TabIndex = 5;
            this.Lb_StonePapperScissors.Text = "Stone Papper Scissors";
            this.Lb_StonePapperScissors.Click += new System.EventHandler(this.Lb_StonePapperScissors_Click);
            // 
            // Lb_GameList
            // 
            this.Lb_GameList.AutoSize = true;
            this.Lb_GameList.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_GameList.Location = new System.Drawing.Point(654, 0);
            this.Lb_GameList.Name = "Lb_GameList";
            this.Lb_GameList.Size = new System.Drawing.Size(158, 52);
            this.Lb_GameList.TabIndex = 7;
            this.Lb_GameList.Text = "Games";
            // 
            // Lb_MathGame
            // 
            this.Lb_MathGame.AutoSize = true;
            this.Lb_MathGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_MathGame.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_MathGame.Location = new System.Drawing.Point(657, 559);
            this.Lb_MathGame.Name = "Lb_MathGame";
            this.Lb_MathGame.Size = new System.Drawing.Size(150, 31);
            this.Lb_MathGame.TabIndex = 10;
            this.Lb_MathGame.Text = "Math Game";
            this.Lb_MathGame.Click += new System.EventHandler(this.Lb_MathGame_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GameList.Properties.Resources.MathGame;
            this.pictureBox4.Location = new System.Drawing.Point(588, 312);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(272, 232);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GameList.Properties.Resources.حجر_ورقه_مقص;
            this.pictureBox2.Location = new System.Drawing.Point(280, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 232);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameList.Properties.Resources.XO;
            this.pictureBox1.Location = new System.Drawing.Point(870, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mathGameToolStripMenuItem
            // 
            this.mathGameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathGameToolStripMenuItem.Image = global::GameList.Properties.Resources.MathGame;
            this.mathGameToolStripMenuItem.Name = "mathGameToolStripMenuItem";
            this.mathGameToolStripMenuItem.Size = new System.Drawing.Size(211, 27);
            this.mathGameToolStripMenuItem.Text = "Math Game";
            this.mathGameToolStripMenuItem.Click += new System.EventHandler(this.mathGameToolStripMenuItem_Click);
            // 
            // xOGameToolStripMenuItem
            // 
            this.xOGameToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.xOGameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xOGameToolStripMenuItem.Image = global::GameList.Properties.Resources.XO;
            this.xOGameToolStripMenuItem.Name = "xOGameToolStripMenuItem";
            this.xOGameToolStripMenuItem.Size = new System.Drawing.Size(211, 27);
            this.xOGameToolStripMenuItem.Text = "X O Game";
            this.xOGameToolStripMenuItem.Click += new System.EventHandler(this.xOGameToolStripMenuItem_Click);
            // 
            // stonePapperToolStripMenuItem
            // 
            this.stonePapperToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stonePapperToolStripMenuItem.Image = global::GameList.Properties.Resources.حجر_ورقه_مقص;
            this.stonePapperToolStripMenuItem.Name = "stonePapperToolStripMenuItem";
            this.stonePapperToolStripMenuItem.Size = new System.Drawing.Size(211, 27);
            this.stonePapperToolStripMenuItem.Text = "Stone Papper Scissors";
            this.stonePapperToolStripMenuItem.Click += new System.EventHandler(this.stonePapperToolStripMenuItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(229, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(956, 618);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1186, 618);
            this.Controls.Add(this.Lb_MathGame);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Lb_GameList);
            this.Controls.Add(this.Lb_StonePapperScissors);
            this.Controls.Add(this.Lb_XO);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox3);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Game_List";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xOGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stonePapperToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Lb_XO;
        private System.Windows.Forms.Label Lb_StonePapperScissors;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Lb_GameList;
        private System.Windows.Forms.ToolStripMenuItem mathGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Lb_MathGame;
    }
}

