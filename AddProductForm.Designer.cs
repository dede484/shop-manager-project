﻿namespace shopManager
{
    partial class AddProductForm
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
            quantityNumericUpDown = new NumericUpDown();
            nameLabel = new Label();
            costLabel = new Label();
            nameTextBox = new TextBox();
            profitTextBox = new TextBox();
            profitLabel = new Label();
            categoryLabel = new Label();
            costTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            quantityLabel = new Label();
            addButton = new Button();
            addProdLapel = new Label();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            quantityNumericUpDown.BackColor = Color.LightGray;
            quantityNumericUpDown.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            quantityNumericUpDown.ForeColor = Color.Black;
            quantityNumericUpDown.Location = new Point(307, 488);
            quantityNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            quantityNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(286, 35);
            quantityNumericUpDown.TabIndex = 3;
            quantityNumericUpDown.TextAlign = HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.WhiteSmoke;
            nameLabel.Location = new Point(63, 309);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(86, 40);
            nameLabel.TabIndex = 20;
            nameLabel.Text = "Name";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // costLabel
            // 
            costLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            costLabel.BackColor = Color.Transparent;
            costLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            costLabel.ForeColor = Color.WhiteSmoke;
            costLabel.Location = new Point(63, 385);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(86, 40);
            costLabel.TabIndex = 23;
            costLabel.Text = "Cost";
            costLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nameTextBox.BackColor = Color.FromArgb(44, 45, 60);
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.ForeColor = Color.White;
            nameTextBox.Location = new Point(169, 309);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(424, 36);
            nameTextBox.TabIndex = 0;
            // 
            // profitTextBox
            // 
            profitTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            profitTextBox.BackColor = Color.FromArgb(44, 45, 60);
            profitTextBox.BorderStyle = BorderStyle.None;
            profitTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            profitTextBox.ForeColor = Color.White;
            profitTextBox.Location = new Point(456, 384);
            profitTextBox.Name = "profitTextBox";
            profitTextBox.Size = new Size(137, 36);
            profitTextBox.TabIndex = 2;
            // 
            // profitLabel
            // 
            profitLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            profitLabel.BackColor = Color.Transparent;
            profitLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            profitLabel.ForeColor = Color.WhiteSmoke;
            profitLabel.Location = new Point(347, 385);
            profitLabel.Name = "profitLabel";
            profitLabel.Size = new Size(79, 40);
            profitLabel.TabIndex = 25;
            profitLabel.Text = "Profit";
            // 
            // categoryLabel
            // 
            categoryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            categoryLabel.AutoSize = true;
            categoryLabel.BackColor = Color.Transparent;
            categoryLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.ForeColor = Color.WhiteSmoke;
            categoryLabel.Location = new Point(63, 551);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(135, 35);
            categoryLabel.TabIndex = 21;
            categoryLabel.Text = "Category";
            // 
            // costTextBox
            // 
            costTextBox.BackColor = Color.FromArgb(44, 45, 60);
            costTextBox.BorderStyle = BorderStyle.None;
            costTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            costTextBox.ForeColor = Color.White;
            costTextBox.Location = new Point(171, 385);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(137, 36);
            costTextBox.TabIndex = 1;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            categoryComboBox.BackColor = Color.LightGray;
            categoryComboBox.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            categoryComboBox.ForeColor = Color.Black;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Cameras", "Phones", "Accessories" });
            categoryComboBox.Location = new Point(307, 551);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(285, 37);
            categoryComboBox.TabIndex = 4;
            // 
            // quantityLabel
            // 
            quantityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            quantityLabel.BackColor = Color.Transparent;
            quantityLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quantityLabel.ForeColor = Color.WhiteSmoke;
            quantityLabel.Location = new Point(63, 488);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(125, 40);
            quantityLabel.TabIndex = 22;
            quantityLabel.Text = "Quantity";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButton.BackColor = Color.FromArgb(114, 0, 0);
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(63, 696);
            addButton.Name = "addButton";
            addButton.Size = new Size(246, 49);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // addProdLapel
            // 
            addProdLapel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addProdLapel.BackColor = Color.Transparent;
            addProdLapel.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            addProdLapel.ForeColor = Color.White;
            addProdLapel.Location = new Point(126, 89);
            addProdLapel.Name = "addProdLapel";
            addProdLapel.Size = new Size(391, 72);
            addProdLapel.TabIndex = 26;
            addProdLapel.Text = "ADD NEW PRODUCT!";
            addProdLapel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancelButton.BackColor = Color.Transparent;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(347, 696);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(246, 49);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 22, 32);
            ClientSize = new Size(663, 831);
            Controls.Add(cancelButton);
            Controls.Add(addProdLapel);
            Controls.Add(quantityLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(costTextBox);
            Controls.Add(categoryLabel);
            Controls.Add(addButton);
            Controls.Add(profitLabel);
            Controls.Add(profitTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(costLabel);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(nameLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(686, 960);
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label costLabel;
        private TextBox nameTextBox;
        private TextBox profitTextBox;
        private Label profitLabel;
        private Label categoryLabel;
        private TextBox costTextBox;
        private ComboBox categoryComboBox;
        private Label quantityLabel;
        private NumericUpDown quantityNumericUpDown;
        private Button addButton;
        private Label addProdLapel;
        private Button cancelButton;
    }
}