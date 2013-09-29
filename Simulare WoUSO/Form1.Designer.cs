namespace Simulare_WoUSO
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
            this.playerList = new System.Windows.Forms.RichTextBox();
            this.simDay = new System.Windows.Forms.Button();
            this.simWeek = new System.Windows.Forms.Button();
            this.dayWeekLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.strategyLabel = new System.Windows.Forms.Label();
            this.formLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerList
            // 
            this.playerList.Location = new System.Drawing.Point(12, 27);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(318, 96);
            this.playerList.TabIndex = 1;
            this.playerList.Text = "";
            // 
            // simDay
            // 
            this.simDay.Location = new System.Drawing.Point(337, 13);
            this.simDay.Name = "simDay";
            this.simDay.Size = new System.Drawing.Size(75, 23);
            this.simDay.TabIndex = 2;
            this.simDay.Text = "Sim 1 day";
            this.simDay.UseVisualStyleBackColor = true;
            this.simDay.Click += new System.EventHandler(this.simDay_Click);
            // 
            // simWeek
            // 
            this.simWeek.Location = new System.Drawing.Point(337, 43);
            this.simWeek.Name = "simWeek";
            this.simWeek.Size = new System.Drawing.Size(75, 23);
            this.simWeek.TabIndex = 3;
            this.simWeek.Text = "Sim week";
            this.simWeek.UseVisualStyleBackColor = true;
            this.simWeek.Click += new System.EventHandler(this.simWeek_Click);
            // 
            // dayWeekLabel
            // 
            this.dayWeekLabel.AutoSize = true;
            this.dayWeekLabel.Location = new System.Drawing.Point(337, 73);
            this.dayWeekLabel.Name = "dayWeekLabel";
            this.dayWeekLabel.Size = new System.Drawing.Size(94, 13);
            this.dayWeekLabel.TabIndex = 5;
            this.dayWeekLabel.Text = "Day: 0     Week: 0";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "ID";
            this.idLabel.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.idLabel.MouseHover += new System.EventHandler(this.idLabel_MouseHover);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(340, 90);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 7;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(52, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(33, 13);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "score";
            this.scoreLabel.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.scoreLabel.MouseHover += new System.EventHandler(this.scoreLabel_MouseHover);
            // 
            // strategyLabel
            // 
            this.strategyLabel.AutoSize = true;
            this.strategyLabel.Location = new System.Drawing.Point(91, 9);
            this.strategyLabel.Name = "strategyLabel";
            this.strategyLabel.Size = new System.Drawing.Size(44, 13);
            this.strategyLabel.TabIndex = 9;
            this.strategyLabel.Text = "strategy";
            this.strategyLabel.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.strategyLabel.MouseHover += new System.EventHandler(this.strategyLabel_MouseHover);
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Location = new System.Drawing.Point(151, 9);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(27, 13);
            this.formLabel.TabIndex = 10;
            this.formLabel.Text = "form";
            this.formLabel.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            this.formLabel.MouseHover += new System.EventHandler(this.formLabel_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 336);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.strategyLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.dayWeekLabel);
            this.Controls.Add(this.simWeek);
            this.Controls.Add(this.simDay);
            this.Controls.Add(this.playerList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Resize += new System.EventHandler(this.Form1_Resize);

        }


        #endregion

        private System.Windows.Forms.RichTextBox playerList;
        private System.Windows.Forms.Button simDay;
        private System.Windows.Forms.Button simWeek;
        private System.Windows.Forms.Label dayWeekLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label strategyLabel;
        private System.Windows.Forms.Label formLabel;

    }
}

