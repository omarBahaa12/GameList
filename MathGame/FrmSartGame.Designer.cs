namespace MathGame
{
    partial class FrmStartGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Rd_20 = new System.Windows.Forms.RadioButton();
            this.Rd_15 = new System.Windows.Forms.RadioButton();
            this.Rd_10 = new System.Windows.Forms.RadioButton();
            this.Rd_5 = new System.Windows.Forms.RadioButton();
            this.Cb_Diffculty = new System.Windows.Forms.ComboBox();
            this.Lb_Diffculty = new System.Windows.Forms.Label();
            this.Cb_Operation = new System.Windows.Forms.ComboBox();
            this.Lb_Operation = new System.Windows.Forms.Label();
            this.Lb_NumberQuetions = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lb_No = new System.Windows.Forms.RadioButton();
            this.Rd_Yes = new System.Windows.Forms.RadioButton();
            this.Lb_Timer = new System.Windows.Forms.Label();
            this.Btn_StartGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.Rd_20);
            this.panel1.Controls.Add(this.Rd_15);
            this.panel1.Controls.Add(this.Rd_10);
            this.panel1.Controls.Add(this.Rd_5);
            this.panel1.Location = new System.Drawing.Point(208, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 117);
            this.panel1.TabIndex = 0;
            // 
            // Rd_20
            // 
            this.Rd_20.AutoSize = true;
            this.Rd_20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rd_20.Location = new System.Drawing.Point(158, 72);
            this.Rd_20.Name = "Rd_20";
            this.Rd_20.Size = new System.Drawing.Size(57, 29);
            this.Rd_20.TabIndex = 3;
            this.Rd_20.TabStop = true;
            this.Rd_20.Text = "20";
            this.Rd_20.UseVisualStyleBackColor = true;
            this.Rd_20.CheckedChanged += new System.EventHandler(this.Rd_20_CheckedChanged);
            // 
            // Rd_15
            // 
            this.Rd_15.AutoSize = true;
            this.Rd_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rd_15.Location = new System.Drawing.Point(31, 72);
            this.Rd_15.Name = "Rd_15";
            this.Rd_15.Size = new System.Drawing.Size(57, 29);
            this.Rd_15.TabIndex = 2;
            this.Rd_15.TabStop = true;
            this.Rd_15.Text = "15";
            this.Rd_15.UseVisualStyleBackColor = true;
            this.Rd_15.CheckedChanged += new System.EventHandler(this.Rd_15_CheckedChanged);
            // 
            // Rd_10
            // 
            this.Rd_10.AutoSize = true;
            this.Rd_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rd_10.Location = new System.Drawing.Point(158, 20);
            this.Rd_10.Name = "Rd_10";
            this.Rd_10.Size = new System.Drawing.Size(57, 29);
            this.Rd_10.TabIndex = 1;
            this.Rd_10.TabStop = true;
            this.Rd_10.Text = "10";
            this.Rd_10.UseVisualStyleBackColor = true;
            this.Rd_10.CheckedChanged += new System.EventHandler(this.Rd_10_CheckedChanged);
            // 
            // Rd_5
            // 
            this.Rd_5.AutoSize = true;
            this.Rd_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rd_5.Location = new System.Drawing.Point(31, 20);
            this.Rd_5.Name = "Rd_5";
            this.Rd_5.Size = new System.Drawing.Size(45, 29);
            this.Rd_5.TabIndex = 0;
            this.Rd_5.TabStop = true;
            this.Rd_5.Text = "5";
            this.Rd_5.UseVisualStyleBackColor = true;
            this.Rd_5.CheckedChanged += new System.EventHandler(this.Rd_5_CheckedChanged);
            // 
            // Cb_Diffculty
            // 
            this.Cb_Diffculty.BackColor = System.Drawing.Color.RoyalBlue;
            this.Cb_Diffculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Diffculty.FormattingEnabled = true;
            this.Cb_Diffculty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Very Hard"});
            this.Cb_Diffculty.Location = new System.Drawing.Point(271, 171);
            this.Cb_Diffculty.Name = "Cb_Diffculty";
            this.Cb_Diffculty.Size = new System.Drawing.Size(174, 26);
            this.Cb_Diffculty.TabIndex = 0;
            this.Cb_Diffculty.SelectedIndexChanged += new System.EventHandler(this.Cb_Diffculty_SelectedIndexChanged);
            // 
            // Lb_Diffculty
            // 
            this.Lb_Diffculty.AutoSize = true;
            this.Lb_Diffculty.BackColor = System.Drawing.Color.RoyalBlue;
            this.Lb_Diffculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Diffculty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_Diffculty.Location = new System.Drawing.Point(296, 106);
            this.Lb_Diffculty.Name = "Lb_Diffculty";
            this.Lb_Diffculty.Size = new System.Drawing.Size(89, 25);
            this.Lb_Diffculty.TabIndex = 1;
            this.Lb_Diffculty.Text = "Diffculty";
            // 
            // Cb_Operation
            // 
            this.Cb_Operation.BackColor = System.Drawing.Color.RoyalBlue;
            this.Cb_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Operation.FormattingEnabled = true;
            this.Cb_Operation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "All"});
            this.Cb_Operation.Location = new System.Drawing.Point(559, 171);
            this.Cb_Operation.Name = "Cb_Operation";
            this.Cb_Operation.Size = new System.Drawing.Size(197, 26);
            this.Cb_Operation.TabIndex = 2;
            this.Cb_Operation.SelectedIndexChanged += new System.EventHandler(this.Cb_Operation_SelectedIndexChanged);
            // 
            // Lb_Operation
            // 
            this.Lb_Operation.AutoSize = true;
            this.Lb_Operation.BackColor = System.Drawing.Color.RoyalBlue;
            this.Lb_Operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Operation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_Operation.Location = new System.Drawing.Point(590, 106);
            this.Lb_Operation.Name = "Lb_Operation";
            this.Lb_Operation.Size = new System.Drawing.Size(107, 25);
            this.Lb_Operation.TabIndex = 3;
            this.Lb_Operation.Text = "Operation";
            // 
            // Lb_NumberQuetions
            // 
            this.Lb_NumberQuetions.AutoSize = true;
            this.Lb_NumberQuetions.BackColor = System.Drawing.Color.RoyalBlue;
            this.Lb_NumberQuetions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NumberQuetions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_NumberQuetions.Location = new System.Drawing.Point(219, 263);
            this.Lb_NumberQuetions.Name = "Lb_NumberQuetions";
            this.Lb_NumberQuetions.Size = new System.Drawing.Size(204, 25);
            this.Lb_NumberQuetions.TabIndex = 4;
            this.Lb_NumberQuetions.Text = "Number of Quetions";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.Lb_No);
            this.panel2.Controls.Add(this.Rd_Yes);
            this.panel2.Location = new System.Drawing.Point(551, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 53);
            this.panel2.TabIndex = 6;
            // 
            // Lb_No
            // 
            this.Lb_No.AutoSize = true;
            this.Lb_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_No.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_No.Location = new System.Drawing.Point(155, 12);
            this.Lb_No.Name = "Lb_No";
            this.Lb_No.Size = new System.Drawing.Size(60, 29);
            this.Lb_No.TabIndex = 1;
            this.Lb_No.TabStop = true;
            this.Lb_No.Text = "No";
            this.Lb_No.UseVisualStyleBackColor = true;
            // 
            // Rd_Yes
            // 
            this.Rd_Yes.AutoSize = true;
            this.Rd_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Yes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rd_Yes.Location = new System.Drawing.Point(27, 12);
            this.Rd_Yes.Name = "Rd_Yes";
            this.Rd_Yes.Size = new System.Drawing.Size(70, 29);
            this.Rd_Yes.TabIndex = 0;
            this.Rd_Yes.TabStop = true;
            this.Rd_Yes.Text = "Yes";
            this.Rd_Yes.UseVisualStyleBackColor = true;
            this.Rd_Yes.CheckedChanged += new System.EventHandler(this.Rd_Yes_CheckedChanged);
            // 
            // Lb_Timer
            // 
            this.Lb_Timer.AutoSize = true;
            this.Lb_Timer.BackColor = System.Drawing.Color.RoyalBlue;
            this.Lb_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Timer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lb_Timer.Location = new System.Drawing.Point(594, 249);
            this.Lb_Timer.Name = "Lb_Timer";
            this.Lb_Timer.Size = new System.Drawing.Size(117, 25);
            this.Lb_Timer.TabIndex = 7;
            this.Lb_Timer.Text = "With Timer";
            // 
            // Btn_StartGame
            // 
            this.Btn_StartGame.BackColor = System.Drawing.Color.RoyalBlue;
            this.Btn_StartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.Btn_StartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Btn_StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_StartGame.Location = new System.Drawing.Point(559, 435);
            this.Btn_StartGame.Name = "Btn_StartGame";
            this.Btn_StartGame.Size = new System.Drawing.Size(152, 48);
            this.Btn_StartGame.TabIndex = 8;
            this.Btn_StartGame.Text = "Start Game";
            this.Btn_StartGame.UseVisualStyleBackColor = false;
            this.Btn_StartGame.Click += new System.EventHandler(this.Btn_StartGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Khaki;
            this.pictureBox1.Image = global::MathGame.Properties.Resources.mg;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 522);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MathGame.Properties.Resources.MathGame;
            this.pictureBox2.Location = new System.Drawing.Point(3, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // FrmStartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.Btn_StartGame);
            this.Controls.Add(this.Lb_Timer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Lb_NumberQuetions);
            this.Controls.Add(this.Lb_Operation);
            this.Controls.Add(this.Cb_Operation);
            this.Controls.Add(this.Lb_Diffculty);
            this.Controls.Add(this.Cb_Diffculty);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmStartGame";
            this.Text = "Start Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Cb_Diffculty;
        private System.Windows.Forms.Label Lb_Diffculty;
        private System.Windows.Forms.ComboBox Cb_Operation;
        private System.Windows.Forms.Label Lb_Operation;
        private System.Windows.Forms.RadioButton Rd_20;
        private System.Windows.Forms.RadioButton Rd_15;
        private System.Windows.Forms.RadioButton Rd_10;
        private System.Windows.Forms.RadioButton Rd_5;
        private System.Windows.Forms.Label Lb_NumberQuetions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Lb_No;
        private System.Windows.Forms.RadioButton Rd_Yes;
        private System.Windows.Forms.Label Lb_Timer;
        private System.Windows.Forms.Button Btn_StartGame;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

