namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamLabel = new System.Windows.Forms.ComboBox();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.CreateNewLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamLabel = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TeamPlayersLabel = new System.Windows.Forms.Label();
            this.TournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedButon = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.TeamPlayersLabel2 = new System.Windows.Forms.Label();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Header.Location = new System.Drawing.Point(33, 27);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(233, 29);
            this.Header.TabIndex = 1;
            this.Header.Text = "Create Tournament:";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(50, 112);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(213, 20);
            this.TournamentNameValue.TabIndex = 10;
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(45, 80);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(218, 29);
            this.TeamOneScoreLabel.TabIndex = 9;
            this.TeamOneScoreLabel.Text = "Tournament Name";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(195, 194);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(114, 20);
            this.EntryFeeValue.TabIndex = 12;
            this.EntryFeeValue.Text = "0";
            this.EntryFeeValue.TextChanged += new System.EventHandler(this.TeamOneScoreValue_TextChanged);
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.EntryFeeLabel.Location = new System.Drawing.Point(45, 186);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(121, 29);
            this.EntryFeeLabel.TabIndex = 11;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.FormattingEnabled = true;
            this.SelectTeamLabel.Location = new System.Drawing.Point(50, 290);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(259, 21);
            this.SelectTeamLabel.TabIndex = 14;
            this.SelectTeamLabel.SelectedIndexChanged += new System.EventHandler(this.RoundDropDown_SelectedIndexChanged);
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.Color.Maroon;
            this.RoundLabel.Location = new System.Drawing.Point(45, 248);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(148, 29);
            this.RoundLabel.TabIndex = 13;
            this.RoundLabel.Text = "Select Team";
            this.RoundLabel.Click += new System.EventHandler(this.RoundLabel_Click);
            // 
            // CreateNewLabel
            // 
            this.CreateNewLabel.AccessibleName = "CreateLinkLabel";
            this.CreateNewLabel.AutoSize = true;
            this.CreateNewLabel.Location = new System.Drawing.Point(249, 259);
            this.CreateNewLabel.Name = "CreateNewLabel";
            this.CreateNewLabel.Size = new System.Drawing.Size(60, 13);
            this.CreateNewLabel.TabIndex = 15;
            this.CreateNewLabel.TabStop = true;
            this.CreateNewLabel.Text = "create new";
            // 
            // AddTeamLabel
            // 
            this.AddTeamLabel.AutoSize = true;
            this.AddTeamLabel.Location = new System.Drawing.Point(81, 333);
            this.AddTeamLabel.Name = "AddTeamLabel";
            this.AddTeamLabel.Size = new System.Drawing.Size(170, 41);
            this.AddTeamLabel.TabIndex = 16;
            this.AddTeamLabel.Text = "Add Team";
            this.AddTeamLabel.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.Location = new System.Drawing.Point(81, 397);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(170, 41);
            this.CreatePrizeButton.TabIndex = 17;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TeamPlayersLabel
            // 
            this.TeamPlayersLabel.AutoSize = true;
            this.TeamPlayersLabel.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamPlayersLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TeamPlayersLabel.Location = new System.Drawing.Point(399, 18);
            this.TeamPlayersLabel.Name = "TeamPlayersLabel";
            this.TeamPlayersLabel.Size = new System.Drawing.Size(177, 29);
            this.TeamPlayersLabel.TabIndex = 18;
            this.TeamPlayersLabel.Text = "Team / Players";
            // 
            // TournamentPlayersListBox
            // 
            this.TournamentPlayersListBox.AccessibleName = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TournamentPlayersListBox.FormattingEnabled = true;
            this.TournamentPlayersListBox.Location = new System.Drawing.Point(404, 50);
            this.TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(154, 108);
            this.TournamentPlayersListBox.TabIndex = 19;
            // 
            // DeleteSelectedButon
            // 
            this.DeleteSelectedButon.AutoSize = true;
            this.DeleteSelectedButon.Location = new System.Drawing.Point(606, 80);
            this.DeleteSelectedButon.Name = "DeleteSelectedButon";
            this.DeleteSelectedButon.Size = new System.Drawing.Size(170, 41);
            this.DeleteSelectedButon.TabIndex = 20;
            this.DeleteSelectedButon.Text = "Delete Selected ";
            this.DeleteSelectedButon.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.AutoSize = true;
            this.DeleteSelectedButton.Location = new System.Drawing.Point(606, 270);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(170, 41);
            this.DeleteSelectedButton.TabIndex = 21;
            this.DeleteSelectedButton.Text = "Delete Selected";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.AccessibleName = "PrizesListBox";
            this.PrizesListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.Location = new System.Drawing.Point(404, 233);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(154, 121);
            this.PrizesListBox.TabIndex = 22;
            // 
            // TeamPlayersLabel2
            // 
            this.TeamPlayersLabel2.AutoSize = true;
            this.TeamPlayersLabel2.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamPlayersLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.TeamPlayersLabel2.Location = new System.Drawing.Point(399, 185);
            this.TeamPlayersLabel2.Name = "TeamPlayersLabel2";
            this.TeamPlayersLabel2.Size = new System.Drawing.Size(177, 29);
            this.TeamPlayersLabel2.TabIndex = 23;
            this.TeamPlayersLabel2.Text = "Team / Players";
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.AutoSize = true;
            this.CreateTournamentButton.Location = new System.Drawing.Point(468, 383);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(212, 55);
            this.CreateTournamentButton.TabIndex = 24;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AccessibleName = "CreateLinkLabel";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.TeamPlayersLabel2);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.DeleteSelectedButton);
            this.Controls.Add(this.DeleteSelectedButon);
            this.Controls.Add(this.TournamentPlayersListBox);
            this.Controls.Add(this.TeamPlayersLabel);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamLabel);
            this.Controls.Add(this.CreateNewLabel);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.Header);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ComboBox SelectTeamLabel;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.LinkLabel CreateNewLabel;
        public System.Windows.Forms.Button AddTeamLabel;
        private System.Windows.Forms.Button CreatePrizeButton;
        private System.Windows.Forms.Label TeamPlayersLabel;
        private System.Windows.Forms.ListBox TournamentPlayersListBox;
        public System.Windows.Forms.Button DeleteSelectedButon;
        public System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.ListBox PrizesListBox;
        private System.Windows.Forms.Label TeamPlayersLabel2;
        public System.Windows.Forms.Button CreateTournamentButton;
    }
}