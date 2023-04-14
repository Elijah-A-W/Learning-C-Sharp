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
            creatPrizeLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            pricePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            priceAmountValue = new TextBox();
            priceAmountLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            label1 = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // creatPrizeLabel
            // 
            creatPrizeLabel.AutoSize = true;
            creatPrizeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            creatPrizeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            creatPrizeLabel.Location = new Point(12, 9);
            creatPrizeLabel.Name = "creatPrizeLabel";
            creatPrizeLabel.Size = new Size(158, 37);
            creatPrizeLabel.TabIndex = 2;
            creatPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(188, 83);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(188, 23);
            placeNumberValue.TabIndex = 10;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNumberLabel.Location = new Point(14, 76);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(144, 30);
            placeNumberLabel.TabIndex = 9;
            placeNumberLabel.Text = "Place Number";
            // 
            // pricePercentageValue
            // 
            pricePercentageValue.Location = new Point(188, 287);
            pricePercentageValue.Name = "pricePercentageValue";
            pricePercentageValue.Size = new Size(188, 23);
            pricePercentageValue.TabIndex = 12;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizePercentageLabel.Location = new Point(14, 280);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(171, 30);
            prizePercentageLabel.TabIndex = 11;
            prizePercentageLabel.Text = "Place Percentage";
            // 
            // priceAmountValue
            // 
            priceAmountValue.Location = new Point(188, 190);
            priceAmountValue.Name = "priceAmountValue";
            priceAmountValue.Size = new Size(188, 23);
            priceAmountValue.TabIndex = 14;
            // 
            // priceAmountLabel
            // 
            priceAmountLabel.AutoSize = true;
            priceAmountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            priceAmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            priceAmountLabel.Location = new Point(14, 183);
            priceAmountLabel.Name = "priceAmountLabel";
            priceAmountLabel.Size = new Size(143, 30);
            priceAmountLabel.TabIndex = 13;
            priceAmountLabel.Text = "Place Amount";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(188, 138);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(188, 23);
            placeNameValue.TabIndex = 16;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNameLabel.Location = new Point(14, 131);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(124, 30);
            placeNameLabel.TabIndex = 15;
            placeNameLabel.Text = "Place Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(51, 153, 255);
            label1.Location = new Point(161, 229);
            label1.Name = "label1";
            label1.Size = new Size(48, 30);
            label1.TabIndex = 17;
            label1.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(91, 349);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(210, 41);
            createPrizeButton.TabIndex = 25;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 450);
            Controls.Add(createPrizeButton);
            Controls.Add(label1);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(priceAmountValue);
            Controls.Add(priceAmountLabel);
            Controls.Add(pricePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(creatPrizeLabel);
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label creatPrizeLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox pricePercentageValue;
        private Label prizePercentageLabel;
        private TextBox priceAmountValue;
        private Label priceAmountLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private Label label1;
        private Button createPrizeButton;
    }
}