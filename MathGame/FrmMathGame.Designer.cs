namespace MathGame
{
    partial class FrmMathGame
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
            this.Lb_Calculation = new System.Windows.Forms.Label();
            this.Rd_Answer1 = new System.Windows.Forms.RadioButton();
            this.Rd_Answer2 = new System.Windows.Forms.RadioButton();
            this.Rd_Answer3 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btn_CheckAnswer = new System.Windows.Forms.Button();
            this.Lb_CorrectAnswer = new System.Windows.Forms.Label();
            this.Lb_WrongAnswers = new System.Windows.Forms.Label();
            this.Lb_NumCorrectAnswer = new System.Windows.Forms.Label();
            this.Lb_NumWrongAnswer = new System.Windows.Forms.Label();
            this.Lb_Timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lb_Calculation
            // 
            this.Lb_Calculation.AutoSize = true;
            this.Lb_Calculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Calculation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lb_Calculation.Location = new System.Drawing.Point(168, 154);
            this.Lb_Calculation.Name = "Lb_Calculation";
            this.Lb_Calculation.Size = new System.Drawing.Size(0, 32);
            this.Lb_Calculation.TabIndex = 0;
            // 
            // Rd_Answer1
            // 
            this.Rd_Answer1.AutoSize = true;
            this.Rd_Answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Answer1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rd_Answer1.Location = new System.Drawing.Point(174, 222);
            this.Rd_Answer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rd_Answer1.Name = "Rd_Answer1";
            this.Rd_Answer1.Size = new System.Drawing.Size(17, 16);
            this.Rd_Answer1.TabIndex = 1;
            this.Rd_Answer1.TabStop = true;
            this.Rd_Answer1.UseVisualStyleBackColor = true;
            // 
            // Rd_Answer2
            // 
            this.Rd_Answer2.AutoSize = true;
            this.Rd_Answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Answer2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rd_Answer2.Location = new System.Drawing.Point(174, 279);
            this.Rd_Answer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rd_Answer2.Name = "Rd_Answer2";
            this.Rd_Answer2.Size = new System.Drawing.Size(17, 16);
            this.Rd_Answer2.TabIndex = 2;
            this.Rd_Answer2.TabStop = true;
            this.Rd_Answer2.UseVisualStyleBackColor = true;
            // 
            // Rd_Answer3
            // 
            this.Rd_Answer3.AutoSize = true;
            this.Rd_Answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Answer3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Rd_Answer3.Location = new System.Drawing.Point(174, 332);
            this.Rd_Answer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rd_Answer3.Name = "Rd_Answer3";
            this.Rd_Answer3.Size = new System.Drawing.Size(17, 16);
            this.Rd_Answer3.TabIndex = 3;
            this.Rd_Answer3.TabStop = true;
            this.Rd_Answer3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btn_CheckAnswer
            // 
            this.Btn_CheckAnswer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Btn_CheckAnswer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.Btn_CheckAnswer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.Btn_CheckAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CheckAnswer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CheckAnswer.Location = new System.Drawing.Point(285, 416);
            this.Btn_CheckAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_CheckAnswer.Name = "Btn_CheckAnswer";
            this.Btn_CheckAnswer.Size = new System.Drawing.Size(194, 60);
            this.Btn_CheckAnswer.TabIndex = 4;
            this.Btn_CheckAnswer.Text = "Check Answer";
            this.Btn_CheckAnswer.UseVisualStyleBackColor = false;
            this.Btn_CheckAnswer.Click += new System.EventHandler(this.Btn_CheckAnswer_Click);
            // 
            // Lb_CorrectAnswer
            // 
            this.Lb_CorrectAnswer.AutoSize = true;
            this.Lb_CorrectAnswer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_CorrectAnswer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lb_CorrectAnswer.Location = new System.Drawing.Point(312, 38);
            this.Lb_CorrectAnswer.Name = "Lb_CorrectAnswer";
            this.Lb_CorrectAnswer.Size = new System.Drawing.Size(171, 27);
            this.Lb_CorrectAnswer.TabIndex = 5;
            this.Lb_CorrectAnswer.Text = "Correct Answer:";
            // 
            // Lb_WrongAnswers
            // 
            this.Lb_WrongAnswers.AutoSize = true;
            this.Lb_WrongAnswers.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_WrongAnswers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lb_WrongAnswers.Location = new System.Drawing.Point(315, 92);
            this.Lb_WrongAnswers.Name = "Lb_WrongAnswers";
            this.Lb_WrongAnswers.Size = new System.Drawing.Size(168, 27);
            this.Lb_WrongAnswers.TabIndex = 6;
            this.Lb_WrongAnswers.Text = "Wrong Answer:";
            // 
            // Lb_NumCorrectAnswer
            // 
            this.Lb_NumCorrectAnswer.AutoSize = true;
            this.Lb_NumCorrectAnswer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NumCorrectAnswer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lb_NumCorrectAnswer.Location = new System.Drawing.Point(524, 38);
            this.Lb_NumCorrectAnswer.Name = "Lb_NumCorrectAnswer";
            this.Lb_NumCorrectAnswer.Size = new System.Drawing.Size(0, 27);
            this.Lb_NumCorrectAnswer.TabIndex = 7;
            // 
            // Lb_NumWrongAnswer
            // 
            this.Lb_NumWrongAnswer.AutoSize = true;
            this.Lb_NumWrongAnswer.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NumWrongAnswer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Lb_NumWrongAnswer.Location = new System.Drawing.Point(524, 92);
            this.Lb_NumWrongAnswer.Name = "Lb_NumWrongAnswer";
            this.Lb_NumWrongAnswer.Size = new System.Drawing.Size(0, 27);
            this.Lb_NumWrongAnswer.TabIndex = 8;
            // 
            // Lb_Timer
            // 
            this.Lb_Timer.AutoSize = true;
            this.Lb_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Timer.Location = new System.Drawing.Point(55, 59);
            this.Lb_Timer.Name = "Lb_Timer";
            this.Lb_Timer.Size = new System.Drawing.Size(0, 32);
            this.Lb_Timer.TabIndex = 9;
            this.Lb_Timer.Visible = false;
            // 
            // FrmMathGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(597, 554);
            this.Controls.Add(this.Lb_Timer);
            this.Controls.Add(this.Lb_NumWrongAnswer);
            this.Controls.Add(this.Lb_NumCorrectAnswer);
            this.Controls.Add(this.Lb_WrongAnswers);
            this.Controls.Add(this.Lb_CorrectAnswer);
            this.Controls.Add(this.Btn_CheckAnswer);
            this.Controls.Add(this.Rd_Answer3);
            this.Controls.Add(this.Rd_Answer2);
            this.Controls.Add(this.Rd_Answer1);
            this.Controls.Add(this.Lb_Calculation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMathGame";
            this.Text = "Math Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Calculation;
        private System.Windows.Forms.RadioButton Rd_Answer1;
        private System.Windows.Forms.RadioButton Rd_Answer2;
        private System.Windows.Forms.RadioButton Rd_Answer3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_CheckAnswer;
        private System.Windows.Forms.Label Lb_CorrectAnswer;
        private System.Windows.Forms.Label Lb_WrongAnswers;
        private System.Windows.Forms.Label Lb_NumCorrectAnswer;
        private System.Windows.Forms.Label Lb_NumWrongAnswer;
        private System.Windows.Forms.Label Lb_Timer;
    }
}