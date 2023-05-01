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
            tournamentNameLabel = new Label();
            tournamentRoundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedCheckBox = new CheckBox();
            matchUpListBox = new ListBox();
            teamTwoLabel = new Label();
            teamOneLabel = new Label();
            scoreTeamOneLabel = new Label();
            scoreTeamTwoLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            versusTournamentViewerLabel = new Label();
            scoreLabel = new Button();
            SuspendLayout();
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Location = new Point(35, 23);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(205, 30);
            tournamentNameLabel.TabIndex = 0;
            tournamentNameLabel.Text = "Tournament <none>";
            tournamentNameLabel.Click += label1_Click;
            // 
            // tournamentRoundLabel
            // 
            tournamentRoundLabel.AutoSize = true;
            tournamentRoundLabel.Location = new Point(35, 68);
            tournamentRoundLabel.Name = "tournamentRoundLabel";
            tournamentRoundLabel.Size = new Size(73, 30);
            tournamentRoundLabel.TabIndex = 1;
            tournamentRoundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(114, 68);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(238, 38);
            roundDropDown.TabIndex = 2;
            // 
            // unplayedCheckBox
            // 
            unplayedCheckBox.AutoSize = true;
            unplayedCheckBox.Location = new Point(114, 123);
            unplayedCheckBox.Name = "unplayedCheckBox";
            unplayedCheckBox.Size = new Size(168, 34);
            unplayedCheckBox.TabIndex = 3;
            unplayedCheckBox.Text = "Unplayed Only";
            unplayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchUpListBox
            // 
            matchUpListBox.FormattingEnabled = true;
            matchUpListBox.ItemHeight = 30;
            matchUpListBox.Location = new Point(35, 163);
            matchUpListBox.Name = "matchUpListBox";
            matchUpListBox.Size = new Size(393, 304);
            matchUpListBox.TabIndex = 4;
            // 
            // teamTwoLabel
            // 
            teamTwoLabel.AutoSize = true;
            teamTwoLabel.Location = new Point(458, 361);
            teamTwoLabel.Name = "teamTwoLabel";
            teamTwoLabel.Size = new Size(134, 30);
            teamTwoLabel.TabIndex = 5;
            teamTwoLabel.Text = " <team two>";
            // 
            // teamOneLabel
            // 
            teamOneLabel.AutoSize = true;
            teamOneLabel.Location = new Point(463, 198);
            teamOneLabel.Name = "teamOneLabel";
            teamOneLabel.Size = new Size(129, 30);
            teamOneLabel.TabIndex = 6;
            teamOneLabel.Text = "<team one>";
            // 
            // scoreTeamOneLabel
            // 
            scoreTeamOneLabel.AutoSize = true;
            scoreTeamOneLabel.Location = new Point(472, 240);
            scoreTeamOneLabel.Name = "scoreTeamOneLabel";
            scoreTeamOneLabel.Size = new Size(64, 30);
            scoreTeamOneLabel.TabIndex = 7;
            scoreTeamOneLabel.Text = "Score";
            // 
            // scoreTeamTwoLabel
            // 
            scoreTeamTwoLabel.AutoSize = true;
            scoreTeamTwoLabel.Location = new Point(472, 404);
            scoreTeamTwoLabel.Name = "scoreTeamTwoLabel";
            scoreTeamTwoLabel.Size = new Size(64, 30);
            scoreTeamTwoLabel.TabIndex = 8;
            scoreTeamTwoLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(542, 237);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(128, 35);
            teamOneScoreValue.TabIndex = 9;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(542, 404);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(128, 35);
            teamTwoScoreValue.TabIndex = 10;
            // 
            // versusTournamentViewerLabel
            // 
            versusTournamentViewerLabel.AutoSize = true;
            versusTournamentViewerLabel.Location = new Point(527, 302);
            versusTournamentViewerLabel.Name = "versusTournamentViewerLabel";
            versusTournamentViewerLabel.Size = new Size(53, 30);
            versusTournamentViewerLabel.TabIndex = 11;
            versusTournamentViewerLabel.Text = "-VS-";
            // 
            // scoreLabel
            // 
            scoreLabel.FlatStyle = FlatStyle.Popup;
            scoreLabel.Location = new Point(714, 302);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(102, 63);
            scoreLabel.TabIndex = 12;
            scoreLabel.Text = "Score";
            scoreLabel.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(835, 470);
            Controls.Add(scoreLabel);
            Controls.Add(versusTournamentViewerLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamOneScoreValue);
            Controls.Add(scoreTeamTwoLabel);
            Controls.Add(scoreTeamOneLabel);
            Controls.Add(teamOneLabel);
            Controls.Add(teamTwoLabel);
            Controls.Add(matchUpListBox);
            Controls.Add(unplayedCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(tournamentRoundLabel);
            Controls.Add(tournamentNameLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "TournamentViewerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentNameLabel;
        private Label tournamentRoundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedCheckBox;
        private ListBox matchUpListBox;
        private Label teamTwoLabel;
        private Label teamOneLabel;
        private Label scoreTeamOneLabel;
        private Label scoreTeamTwoLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label versusTournamentViewerLabel;
        private Button scoreLabel;
    }
}