﻿
namespace Learn_App
{
    partial class UbdatePr
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
            changeN = new Label();
            ChangeP = new Label();
            ChangeE = new Label();
            txtN = new TextBox();
            txtP = new TextBox();
            txtE = new TextBox();
            BN = new Button();
            BP = new Button();
            BE = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // changeN
            // 
            changeN.AutoSize = true;
            changeN.Font = new Font("Stencil", 14F);
            changeN.Location = new Point(62, 153);
            changeN.Margin = new Padding(2, 0, 2, 0);
            changeN.Name = "changeN";
            changeN.Size = new Size(291, 46);
            changeN.TabIndex = 0;
            changeN.Text = "Change Name:";
            // 
            // ChangeP
            // 
            ChangeP.AutoSize = true;
            ChangeP.Font = new Font("Stencil", 14F);
            ChangeP.Location = new Point(62, 304);
            ChangeP.Margin = new Padding(2, 0, 2, 0);
            ChangeP.Name = "ChangeP";
            ChangeP.Size = new Size(386, 46);
            ChangeP.TabIndex = 1;
            ChangeP.Text = "Change Password:";
            ChangeP.Click += label2_Click;
            // 
            // ChangeE
            // 
            ChangeE.AutoSize = true;
            ChangeE.Font = new Font("Stencil", 14F);
            ChangeE.Location = new Point(62, 462);
            ChangeE.Margin = new Padding(2, 0, 2, 0);
            ChangeE.Name = "ChangeE";
            ChangeE.Size = new Size(300, 46);
            ChangeE.TabIndex = 2;
            ChangeE.Text = "Change Email:";
            // 
            // txtN
            // 
            txtN.Font = new Font("Stencil", 14F);
            txtN.Location = new Point(62, 221);
            txtN.Margin = new Padding(2);
            txtN.Name = "txtN";
            txtN.Size = new Size(347, 52);
            txtN.TabIndex = 3;
            // 
            // txtP
            // 
            txtP.Font = new Font("Stencil", 14F);
            txtP.Location = new Point(62, 386);
            txtP.Margin = new Padding(2);
            txtP.Name = "txtP";
            txtP.Size = new Size(347, 52);
            txtP.TabIndex = 4;
            // 
            // txtE
            // 
            txtE.Font = new Font("Stencil", 14F);
            txtE.Location = new Point(62, 520);
            txtE.Margin = new Padding(2);
            txtE.Name = "txtE";
            txtE.Size = new Size(347, 52);
            txtE.TabIndex = 5;
            // 
            // BN
            // 
            BN.Font = new Font("Stencil", 14F);
            BN.Location = new Point(472, 221);
            BN.Margin = new Padding(2);
            BN.Name = "BN";
            BN.Size = new Size(209, 47);
            BN.TabIndex = 6;
            BN.Text = "Confirm";
            BN.UseVisualStyleBackColor = true;
            BN.Click += BN_Click;
            // 
            // BP
            // 
            BP.Font = new Font("Stencil", 14F);
            BP.Location = new Point(472, 388);
            BP.Margin = new Padding(2);
            BP.Name = "BP";
            BP.Size = new Size(209, 47);
            BP.TabIndex = 7;
            BP.Text = "Confirm";
            BP.UseVisualStyleBackColor = true;
            BP.Click += BP_Click;
            // 
            // BE
            // 
            BE.Font = new Font("Stencil", 14F);
            BE.Location = new Point(472, 521);
            BE.Margin = new Padding(2);
            BE.Name = "BE";
            BE.Size = new Size(209, 47);
            BE.TabIndex = 8;
            BE.Text = "Confirm";
            BE.UseVisualStyleBackColor = true;
            BE.Click += BE_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 80);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 18F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(295, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 78);
            label1.TabIndex = 6;
            label1.Text = "Learn App";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Viner Hand ITC", 15F);
            label6.Location = new Point(8, 6);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(129, 65);
            label6.TabIndex = 3;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // UbdatePr
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 1047);
            Controls.Add(panel1);
            Controls.Add(BE);
            Controls.Add(BP);
            Controls.Add(BN);
            Controls.Add(txtE);
            Controls.Add(txtP);
            Controls.Add(txtN);
            Controls.Add(ChangeE);
            Controls.Add(ChangeP);
            Controls.Add(changeN);
            Margin = new Padding(2);
            Name = "UbdatePr";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UbdatePr";
            Load += UbdatePr_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label changeN;
        private System.Windows.Forms.Label ChangeP;
        private System.Windows.Forms.Label ChangeE;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Button BN;
        private System.Windows.Forms.Button BP;
        private System.Windows.Forms.Button BE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Label label1;
    }
}