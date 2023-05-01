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
            createTournamentLabel = new Label();
            tournamentNameLabel = new Label();
            tournamentNameValue = new TextBox();
            entryFeeLabel = new Label();
            entryFeeValue = new TextBox();
            selectTeamLabel = new Label();
            selectTeamDropDown = new ComboBox();
            createNewTeamLinkLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            TournamentPlayersListBox = new ListBox();
            prizesListBox = new ListBox();
            teamListedLabel = new Label();
            prizesLabel = new Label();
            deleteSelectedPlayerOrTeam = new Button();
            deleteSelectedPrizes = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.BackColor = Color.White;
            createTournamentLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentLabel.ForeColor = SystemColors.MenuHighlight;
            createTournamentLabel.Location = new Point(12, 9);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(195, 30);
            createTournamentLabel.TabIndex = 0;
            createTournamentLabel.Text = "Create Tournament:";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.BackColor = Color.White;
            tournamentNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentNameLabel.Location = new Point(12, 52);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(191, 30);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "Tournament Name:";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(12, 85);
            tournamentNameValue.Multiline = true;
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(240, 34);
            tournamentNameValue.TabIndex = 2;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.BackColor = Color.White;
            entryFeeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            entryFeeLabel.Location = new Point(12, 142);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(103, 30);
            entryFeeLabel.TabIndex = 3;
            entryFeeLabel.Text = "Entry Fee:";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeValue.Location = new Point(121, 142);
            entryFeeValue.Multiline = true;
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(131, 34);
            entryFeeValue.TabIndex = 4;
            entryFeeValue.Text = "0";
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.BackColor = Color.White;
            selectTeamLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(12, 247);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(123, 30);
            selectTeamLabel.TabIndex = 5;
            selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(12, 280);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(264, 23);
            selectTeamDropDown.TabIndex = 6;
            // 
            // createNewTeamLinkLabel
            // 
            createNewTeamLinkLabel.ActiveLinkColor = Color.RebeccaPurple;
            createNewTeamLinkLabel.AutoSize = true;
            createNewTeamLinkLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createNewTeamLinkLabel.Location = new Point(171, 247);
            createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            createNewTeamLinkLabel.Size = new Size(114, 30);
            createNewTeamLinkLabel.TabIndex = 7;
            createNewTeamLinkLabel.TabStop = true;
            createNewTeamLinkLabel.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.BackColor = Color.White;
            addTeamButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addTeamButton.ForeColor = SystemColors.MenuHighlight;
            addTeamButton.Location = new Point(78, 326);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(125, 46);
            addTeamButton.TabIndex = 8;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = false;
            // 
            // createPrizeButton
            // 
            createPrizeButton.BackColor = Color.White;
            createPrizeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(69, 389);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(138, 45);
            createPrizeButton.TabIndex = 9;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = false;
            // 
            // TournamentPlayersListBox
            // 
            TournamentPlayersListBox.FormattingEnabled = true;
            TournamentPlayersListBox.ItemHeight = 15;
            TournamentPlayersListBox.Location = new Point(341, 62);
            TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            TournamentPlayersListBox.Size = new Size(304, 184);
            TournamentPlayersListBox.TabIndex = 10;
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 15;
            prizesListBox.Location = new Point(341, 293);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(304, 184);
            prizesListBox.TabIndex = 11;
            // 
            // teamListedLabel
            // 
            teamListedLabel.AutoSize = true;
            teamListedLabel.BackColor = Color.White;
            teamListedLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            teamListedLabel.ForeColor = SystemColors.MenuHighlight;
            teamListedLabel.Location = new Point(341, 29);
            teamListedLabel.Name = "teamListedLabel";
            teamListedLabel.Size = new Size(156, 30);
            teamListedLabel.TabIndex = 12;
            teamListedLabel.Text = "Teams / Players";
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.BackColor = Color.White;
            prizesLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            prizesLabel.ForeColor = SystemColors.MenuHighlight;
            prizesLabel.Location = new Point(341, 260);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(67, 30);
            prizesLabel.TabIndex = 13;
            prizesLabel.Text = "Prizes";
            // 
            // deleteSelectedPlayerOrTeam
            // 
            deleteSelectedPlayerOrTeam.BackColor = Color.White;
            deleteSelectedPlayerOrTeam.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteSelectedPlayerOrTeam.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedPlayerOrTeam.Location = new Point(688, 126);
            deleteSelectedPlayerOrTeam.Name = "deleteSelectedPlayerOrTeam";
            deleteSelectedPlayerOrTeam.Size = new Size(103, 78);
            deleteSelectedPlayerOrTeam.TabIndex = 14;
            deleteSelectedPlayerOrTeam.Text = "Delete Selected";
            deleteSelectedPlayerOrTeam.UseVisualStyleBackColor = false;
            // 
            // deleteSelectedPrizes
            // 
            deleteSelectedPrizes.BackColor = Color.White;
            deleteSelectedPrizes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteSelectedPrizes.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedPrizes.Location = new Point(688, 344);
            deleteSelectedPrizes.Name = "deleteSelectedPrizes";
            deleteSelectedPrizes.Size = new Size(103, 78);
            deleteSelectedPrizes.TabIndex = 15;
            deleteSelectedPrizes.Text = "Delete Selected";
            deleteSelectedPrizes.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            createTournamentButton.BackColor = Color.White;
            createTournamentButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(203, 487);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(219, 45);
            createTournamentButton.TabIndex = 16;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 546);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizes);
            Controls.Add(deleteSelectedPlayerOrTeam);
            Controls.Add(prizesLabel);
            Controls.Add(teamListedLabel);
            Controls.Add(prizesListBox);
            Controls.Add(TournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLinkLabel);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(createTournamentLabel);
            Name = "CreateTournamentForm";
            Text = "CreateTournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentLabel;
        private Label tournamentNameLabel;
        private TextBox tournamentNameValue;
        private Label entryFeeLabel;
        private TextBox entryFeeValue;
        private Label selectTeamLabel;
        private ComboBox selectTeamDropDown;
        private LinkLabel createNewTeamLinkLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox TournamentPlayersListBox;
        private ListBox prizesListBox;
        private Label teamListedLabel;
        private Label prizesLabel;
        private Button deleteSelectedPlayerOrTeam;
        private Button deleteSelectedPrizes;
        private Button createTournamentButton;
    }
}