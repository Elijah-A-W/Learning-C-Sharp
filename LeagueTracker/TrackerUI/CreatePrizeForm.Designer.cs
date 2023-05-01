namespace TrackerUI
{
    partial class CreatePrizeForm
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
            createPrizeLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeAmountLabel = new Label();
            placeAmountValue = new TextBox();
            placeNameLabel = new Label();
            placeNameValue = new TextBox();
            placePercentageLabel = new Label();
            placePercentageValue = new TextBox();
            label1 = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.BackColor = Color.White;
            createPrizeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeLabel.ForeColor = SystemColors.MenuHighlight;
            createPrizeLabel.Location = new Point(226, 23);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(124, 30);
            createPrizeLabel.TabIndex = 0;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(302, 81);
            placeNumberValue.Multiline = true;
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(190, 32);
            placeNumberValue.TabIndex = 2;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.BackColor = Color.White;
            placeNumberLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = SystemColors.MenuHighlight;
            placeNumberLabel.Location = new Point(125, 83);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(144, 30);
            placeNumberLabel.TabIndex = 3;
            placeNumberLabel.Text = "Place Number";
            // 
            // placeAmountLabel
            // 
            placeAmountLabel.AutoSize = true;
            placeAmountLabel.BackColor = Color.White;
            placeAmountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            placeAmountLabel.ForeColor = SystemColors.MenuHighlight;
            placeAmountLabel.Location = new Point(125, 183);
            placeAmountLabel.Name = "placeAmountLabel";
            placeAmountLabel.Size = new Size(143, 30);
            placeAmountLabel.TabIndex = 5;
            placeAmountLabel.Text = "Place Amount";
            // 
            // placeAmountValue
            // 
            placeAmountValue.Location = new Point(302, 183);
            placeAmountValue.Multiline = true;
            placeAmountValue.Name = "placeAmountValue";
            placeAmountValue.Size = new Size(190, 32);
            placeAmountValue.TabIndex = 4;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.BackColor = Color.White;
            placeNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = SystemColors.MenuHighlight;
            placeNameLabel.Location = new Point(125, 135);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(124, 30);
            placeNameLabel.TabIndex = 7;
            placeNameLabel.Text = "Place Name";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(302, 135);
            placeNameValue.Multiline = true;
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(190, 32);
            placeNameValue.TabIndex = 6;
            // 
            // placePercentageLabel
            // 
            placePercentageLabel.AutoSize = true;
            placePercentageLabel.BackColor = Color.White;
            placePercentageLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            placePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            placePercentageLabel.Location = new Point(125, 288);
            placePercentageLabel.Name = "placePercentageLabel";
            placePercentageLabel.Size = new Size(171, 30);
            placePercentageLabel.TabIndex = 9;
            placePercentageLabel.Text = "Place Percentage";
            // 
            // placePercentageValue
            // 
            placePercentageValue.Location = new Point(302, 286);
            placePercentageValue.Multiline = true;
            placePercentageValue.Name = "placePercentageValue";
            placePercentageValue.Size = new Size(190, 32);
            placePercentageValue.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(258, 236);
            label1.Name = "label1";
            label1.Size = new Size(58, 30);
            label1.TabIndex = 10;
            label1.Text = "-OR-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.BackColor = Color.White;
            createPrizeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(191, 360);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(187, 40);
            createPrizeButton.TabIndex = 11;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = false;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 437);
            Controls.Add(createPrizeButton);
            Controls.Add(label1);
            Controls.Add(placePercentageLabel);
            Controls.Add(placePercentageValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeAmountLabel);
            Controls.Add(placeAmountValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(createPrizeLabel);
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private Label placeAmountLabel;
        private TextBox placeAmountValue;
        private Label placeNameLabel;
        private TextBox placeNameValue;
        private Label placePercentageLabel;
        private TextBox placePercentageValue;
        private Label label1;
        private Button createPrizeButton;
    }
}