namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.Header = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchupListBox = new System.Windows.Forms.ListBox();
            this.TeamOneLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoLabel = new System.Windows.Forms.Label();
            this.VSlabel = new System.Windows.Forms.Label();
            this.ButtonScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Header.Location = new System.Drawing.Point(107, 66);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(155, 29);
            this.Header.TabIndex = 0;
            this.Header.Text = "Tournament:";
            this.Header.Click += new System.EventHandler(this.label1_Click);
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TournamentName.Location = new System.Drawing.Point(413, 66);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(97, 29);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.Color.Red;
            this.RoundLabel.Location = new System.Drawing.Point(107, 213);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(87, 29);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(312, 206);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(148, 38);
            this.RoundDropDown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckBox
            // 
            this.UnplayedOnlyCheckBox.AutoSize = true;
            this.UnplayedOnlyCheckBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UnplayedOnlyCheckBox.Location = new System.Drawing.Point(281, 301);
            this.UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            this.UnplayedOnlyCheckBox.Size = new System.Drawing.Size(189, 34);
            this.UnplayedOnlyCheckBox.TabIndex = 4;
            this.UnplayedOnlyCheckBox.Text = "Unplayed Only";
            this.UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchupListBox
            // 
            this.MatchupListBox.FormattingEnabled = true;
            this.MatchupListBox.ItemHeight = 30;
            this.MatchupListBox.Location = new System.Drawing.Point(113, 402);
            this.MatchupListBox.Name = "MatchupListBox";
            this.MatchupListBox.Size = new System.Drawing.Size(389, 304);
            this.MatchupListBox.TabIndex = 5;
            // 
            // TeamOneLabel
            // 
            this.TeamOneLabel.AutoSize = true;
            this.TeamOneLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TeamOneLabel.Location = new System.Drawing.Point(702, 370);
            this.TeamOneLabel.Name = "TeamOneLabel";
            this.TeamOneLabel.Size = new System.Drawing.Size(142, 29);
            this.TeamOneLabel.TabIndex = 6;
            this.TeamOneLabel.Text = "<team one>";
            this.TeamOneLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(702, 448);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(75, 29);
            this.TeamOneScoreLabel.TabIndex = 7;
            this.TeamOneScoreLabel.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Location = new System.Drawing.Point(863, 441);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(118, 36);
            this.TeamOneScoreValue.TabIndex = 8;
            // 
            // TeamTwoScoreValue
            // 
            this.TeamTwoScoreValue.Location = new System.Drawing.Point(863, 676);
            this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            this.TeamTwoScoreValue.Size = new System.Drawing.Size(118, 36);
            this.TeamTwoScoreValue.TabIndex = 11;
            this.TeamTwoScoreValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoScoreLabel.ForeColor = System.Drawing.Color.Orange;
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(702, 683);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(75, 29);
            this.TeamTwoScoreLabel.TabIndex = 10;
            this.TeamTwoScoreLabel.Text = "Score";
            this.TeamTwoScoreLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TeamTwoLabel
            // 
            this.TeamTwoLabel.AutoSize = true;
            this.TeamTwoLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.TeamTwoLabel.Location = new System.Drawing.Point(702, 605);
            this.TeamTwoLabel.Name = "TeamTwoLabel";
            this.TeamTwoLabel.Size = new System.Drawing.Size(144, 29);
            this.TeamTwoLabel.TabIndex = 9;
            this.TeamTwoLabel.Text = "<team two>";
            this.TeamTwoLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // VSlabel
            // 
            this.VSlabel.AutoSize = true;
            this.VSlabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSlabel.ForeColor = System.Drawing.Color.Black;
            this.VSlabel.Location = new System.Drawing.Point(788, 529);
            this.VSlabel.Name = "VSlabel";
            this.VSlabel.Size = new System.Drawing.Size(48, 29);
            this.VSlabel.TabIndex = 12;
            this.VSlabel.Text = "VS";
            this.VSlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VSlabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // ButtonScore
            // 
            this.ButtonScore.Location = new System.Drawing.Point(1199, 529);
            this.ButtonScore.Name = "ButtonScore";
            this.ButtonScore.Size = new System.Drawing.Size(170, 41);
            this.ButtonScore.TabIndex = 13;
            this.ButtonScore.Text = "Score";
            this.ButtonScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1600, 984);
            this.Controls.Add(this.ButtonScore);
            this.Controls.Add(this.VSlabel);
            this.Controls.Add(this.TeamTwoScoreValue);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamTwoLabel);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.TeamOneLabel);
            this.Controls.Add(this.MatchupListBox);
            this.Controls.Add(this.UnplayedOnlyCheckBox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundDropDown;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox MatchupListBox;
        private System.Windows.Forms.Label TeamOneLabel;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox TeamOneScoreValue;
        private System.Windows.Forms.TextBox TeamTwoScoreValue;
        private System.Windows.Forms.Label TeamTwoScoreLabel;
        private System.Windows.Forms.Label TeamTwoLabel;
        private System.Windows.Forms.Label VSlabel;
        private System.Windows.Forms.Button ButtonScore;
    }
}

