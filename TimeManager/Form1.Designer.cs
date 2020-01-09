namespace TimeManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.addHoursI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addMinutesI = new System.Windows.Forms.TextBox();
            this.addTimeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.remMinutesO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.remHoursO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.avrgRemMinutesO = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.avrgRemHoursO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.avrgSpentMinutesO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.avrgSpentHoursO = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.spentMinutesO = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.spentHoursO = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.todayMinutesO = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.todayHoursO = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить время:";
            // 
            // addHoursI
            // 
            this.addHoursI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addHoursI.Location = new System.Drawing.Point(274, 61);
            this.addHoursI.Name = "addHoursI";
            this.addHoursI.Size = new System.Drawing.Size(40, 29);
            this.addHoursI.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(320, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "часов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(449, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "минут";
            // 
            // addMinutesI
            // 
            this.addMinutesI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMinutesI.Location = new System.Drawing.Point(403, 61);
            this.addMinutesI.Name = "addMinutesI";
            this.addMinutesI.Size = new System.Drawing.Size(40, 29);
            this.addMinutesI.TabIndex = 5;
            // 
            // addTimeButton
            // 
            this.addTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTimeButton.Location = new System.Drawing.Point(324, 115);
            this.addTimeButton.Name = "addTimeButton";
            this.addTimeButton.Size = new System.Drawing.Size(108, 30);
            this.addTimeButton.TabIndex = 6;
            this.addTimeButton.Text = "Добавить";
            this.addTimeButton.UseVisualStyleBackColor = true;
            this.addTimeButton.Click += new System.EventHandler(this.addTimeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(547, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Оставшееся время:";
            // 
            // remMinutesO
            // 
            this.remMinutesO.BackColor = System.Drawing.Color.LightGray;
            this.remMinutesO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remMinutesO.Location = new System.Drawing.Point(660, 61);
            this.remMinutesO.Name = "remMinutesO";
            this.remMinutesO.ReadOnly = true;
            this.remMinutesO.Size = new System.Drawing.Size(40, 29);
            this.remMinutesO.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(706, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "минут";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(577, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "часов";
            // 
            // remHoursO
            // 
            this.remHoursO.BackColor = System.Drawing.Color.LightGray;
            this.remHoursO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remHoursO.Location = new System.Drawing.Point(531, 61);
            this.remHoursO.Name = "remHoursO";
            this.remHoursO.ReadOnly = true;
            this.remHoursO.Size = new System.Drawing.Size(40, 29);
            this.remHoursO.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(559, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "В среднем на день:";
            // 
            // avrgRemMinutesO
            // 
            this.avrgRemMinutesO.BackColor = System.Drawing.Color.LightGray;
            this.avrgRemMinutesO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avrgRemMinutesO.Location = new System.Drawing.Point(660, 157);
            this.avrgRemMinutesO.Name = "avrgRemMinutesO";
            this.avrgRemMinutesO.ReadOnly = true;
            this.avrgRemMinutesO.Size = new System.Drawing.Size(40, 29);
            this.avrgRemMinutesO.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(706, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "минут";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(577, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "часов";
            // 
            // avrgRemHoursO
            // 
            this.avrgRemHoursO.BackColor = System.Drawing.Color.LightGray;
            this.avrgRemHoursO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avrgRemHoursO.Location = new System.Drawing.Point(531, 157);
            this.avrgRemHoursO.Name = "avrgRemHoursO";
            this.avrgRemHoursO.ReadOnly = true;
            this.avrgRemHoursO.Size = new System.Drawing.Size(40, 29);
            this.avrgRemHoursO.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(71, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Потрачено:";
            // 
            // avrgSpentMinutesO
            // 
            this.avrgSpentMinutesO.BackColor = System.Drawing.Color.LightGray;
            this.avrgSpentMinutesO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avrgSpentMinutesO.Location = new System.Drawing.Point(143, 157);
            this.avrgSpentMinutesO.Name = "avrgSpentMinutesO";
            this.avrgSpentMinutesO.ReadOnly = true;
            this.avrgSpentMinutesO.Size = new System.Drawing.Size(40, 29);
            this.avrgSpentMinutesO.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(189, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "минут";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(60, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "часов";
            // 
            // avrgSpentHoursO
            // 
            this.avrgSpentHoursO.BackColor = System.Drawing.Color.LightGray;
            this.avrgSpentHoursO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avrgSpentHoursO.Location = new System.Drawing.Point(14, 157);
            this.avrgSpentHoursO.Name = "avrgSpentHoursO";
            this.avrgSpentHoursO.ReadOnly = true;
            this.avrgSpentHoursO.Size = new System.Drawing.Size(40, 29);
            this.avrgSpentHoursO.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(42, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "В среднем в день:";
            // 
            // spentMinutesO
            // 
            this.spentMinutesO.BackColor = System.Drawing.Color.LightGray;
            this.spentMinutesO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spentMinutesO.Location = new System.Drawing.Point(143, 61);
            this.spentMinutesO.Name = "spentMinutesO";
            this.spentMinutesO.ReadOnly = true;
            this.spentMinutesO.Size = new System.Drawing.Size(40, 29);
            this.spentMinutesO.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(189, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "минут";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(60, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "часов";
            // 
            // spentHoursO
            // 
            this.spentHoursO.BackColor = System.Drawing.Color.LightGray;
            this.spentHoursO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spentHoursO.Location = new System.Drawing.Point(14, 61);
            this.spentHoursO.Name = "spentHoursO";
            this.spentHoursO.ReadOnly = true;
            this.spentHoursO.Size = new System.Drawing.Size(40, 29);
            this.spentHoursO.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(304, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "Время сегодня:";
            // 
            // todayMinutesO
            // 
            this.todayMinutesO.BackColor = System.Drawing.Color.LightGray;
            this.todayMinutesO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todayMinutesO.Location = new System.Drawing.Point(403, 214);
            this.todayMinutesO.Name = "todayMinutesO";
            this.todayMinutesO.ReadOnly = true;
            this.todayMinutesO.Size = new System.Drawing.Size(40, 29);
            this.todayMinutesO.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(449, 220);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "минут";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.Silver;
            this.label18.Location = new System.Drawing.Point(320, 220);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 20);
            this.label18.TabIndex = 30;
            this.label18.Text = "часов";
            // 
            // todayHoursO
            // 
            this.todayHoursO.BackColor = System.Drawing.Color.LightGray;
            this.todayHoursO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todayHoursO.Location = new System.Drawing.Point(274, 214);
            this.todayHoursO.Name = "todayHoursO";
            this.todayHoursO.ReadOnly = true;
            this.todayHoursO.Size = new System.Drawing.Size(40, 29);
            this.todayHoursO.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 24);
            this.button1.TabIndex = 33;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(770, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.todayMinutesO);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.todayHoursO);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.avrgSpentMinutesO);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.avrgSpentHoursO);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.spentMinutesO);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.spentHoursO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.avrgRemMinutesO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.avrgRemHoursO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.remMinutesO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.remHoursO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addTimeButton);
            this.Controls.Add(this.addMinutesI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addHoursI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addHoursI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addMinutesI;
        private System.Windows.Forms.Button addTimeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox remMinutesO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox remHoursO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox avrgRemMinutesO;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox avrgRemHoursO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox avrgSpentMinutesO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox avrgSpentHoursO;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox spentMinutesO;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox spentHoursO;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox todayMinutesO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox todayHoursO;
        private System.Windows.Forms.Button button1;
    }
}

