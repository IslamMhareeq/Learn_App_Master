﻿
namespace Learn_App
{
    partial class Store
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            categoryComboBox = new ComboBox();
            productListBox = new ListBox();
            buyButton = new Button();
            coinsLabel = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Stencil", 12F);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(24, 96);
            categoryComboBox.Margin = new Padding(2, 2, 2, 2);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(310, 37);
            categoryComboBox.TabIndex = 0;
            categoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // productListBox
            // 
            productListBox.Font = new Font("Stencil", 12F);
            productListBox.FormattingEnabled = true;
            productListBox.ItemHeight = 29;
            productListBox.Location = new Point(24, 137);
            productListBox.Margin = new Padding(2, 2, 2, 2);
            productListBox.Name = "productListBox";
            productListBox.Size = new Size(310, 207);
            productListBox.TabIndex = 1;
            productListBox.SelectedIndexChanged += productListBox_SelectedIndexChanged_1;
            // 
            // buyButton
            // 
            buyButton.Font = new Font("Stencil", 12F);
            buyButton.Location = new Point(24, 404);
            buyButton.Margin = new Padding(2, 2, 2, 2);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(200, 44);
            buyButton.TabIndex = 2;
            buyButton.Text = "Buy";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += BuyButton_Click;
            // 
            // coinsLabel
            // 
            coinsLabel.AutoSize = true;
            coinsLabel.Font = new Font("Stencil", 12F);
            coinsLabel.Location = new Point(385, 101);
            coinsLabel.Margin = new Padding(2, 0, 2, 0);
            coinsLabel.Name = "coinsLabel";
            coinsLabel.Size = new Size(110, 29);
            coinsLabel.TabIndex = 3;
            coinsLabel.Text = "Points: ";
            coinsLabel.Click += coinsLabel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 61);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 18F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(216, -2);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(202, 58);
            label2.TabIndex = 6;
            label2.Text = "Learn App";
            // 
            // label6
            // 
            label6.Font = new Font("Viner Hand ITC", 18F);
            label6.Location = new Point(0, 0);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 57);
            label6.TabIndex = 7;
            label6.Text = "Back";
            label6.Click += label6_Click_1;
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 618);
            Controls.Add(panel1);
            Controls.Add(coinsLabel);
            Controls.Add(buyButton);
            Controls.Add(productListBox);
            Controls.Add(categoryComboBox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Store";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store";
            Load += Store_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ComboBox categoryComboBox;
        private ListBox productListBox;
        private Button buyButton;
        private Label coinsLabel;
        private Panel panel1;
        private Label label2;
        private Label label6;
    }
}
