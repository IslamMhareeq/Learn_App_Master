﻿namespace WinFormsApp2
{
    partial class RegisterForm
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label5 = new Label();
            label6 = new Label();
            maleButton = new RadioButton();
            femaleButton = new RadioButton();
            passwordBox = new Guna.UI2.WinForms.Guna2TextBox();
            label8 = new Label();
            label9 = new Label();
            usernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            emailBox = new Guna.UI2.WinForms.Guna2TextBox();
            idBox = new Guna.UI2.WinForms.Guna2TextBox();
            label11 = new Label();
            label10 = new Label();
            RegisterButton = new Guna.UI2.WinForms.Guna2GradientButton();
            label1 = new Label();
            closeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ShowButton = new Guna.UI2.WinForms.Guna2ImageButton();
            HideButton = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            returnDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            closeDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            registerDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            infoError = new Guna.UI2.WinForms.Guna2MessageDialog();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            guna2Transition1.SetDecoration(label5, Guna.UI2.AnimatorNS.DecorationType.None);
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(189, 472);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(758, 82);
            label5.TabIndex = 12;
            label5.Text = "Contains between 6 and 8 characters. 2 digits at max\r\nand the rest are letters\r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            guna2Transition1.SetDecoration(label6, Guna.UI2.AnimatorNS.DecorationType.None);
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(189, 874);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(812, 82);
            label6.TabIndex = 13;
            label6.Text = "Between 8 and 10 characters. Contains at least one letter\r\nand one digit and one special character (!$, #, etc.)";
            // 
            // maleButton
            // 
            maleButton.AutoSize = true;
            maleButton.Checked = true;
            guna2Transition1.SetDecoration(maleButton, Guna.UI2.AnimatorNS.DecorationType.None);
            maleButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            maleButton.Location = new Point(197, 1693);
            maleButton.Margin = new Padding(4, 7, 4, 7);
            maleButton.Name = "maleButton";
            maleButton.Size = new Size(155, 63);
            maleButton.TabIndex = 19;
            maleButton.TabStop = true;
            maleButton.Text = "Male";
            maleButton.UseVisualStyleBackColor = true;
            // 
            // femaleButton
            // 
            femaleButton.AutoSize = true;
            guna2Transition1.SetDecoration(femaleButton, Guna.UI2.AnimatorNS.DecorationType.None);
            femaleButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            femaleButton.Location = new Point(377, 1693);
            femaleButton.Margin = new Padding(4, 7, 4, 7);
            femaleButton.Name = "femaleButton";
            femaleButton.Size = new Size(198, 63);
            femaleButton.TabIndex = 20;
            femaleButton.Text = "Female";
            femaleButton.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            passwordBox.Animated = true;
            passwordBox.BorderRadius = 10;
            passwordBox.BorderThickness = 2;
            passwordBox.CustomizableEdges = customizableEdges1;
            guna2Transition1.SetDecoration(passwordBox, Guna.UI2.AnimatorNS.DecorationType.None);
            passwordBox.DefaultText = "";
            passwordBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordBox.FocusedState.BorderColor = Color.DodgerBlue;
            passwordBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.ForeColor = Color.Black;
            passwordBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordBox.Location = new Point(189, 719);
            passwordBox.Margin = new Padding(11, 15, 11, 15);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.PlaceholderText = "";
            passwordBox.SelectedText = "";
            passwordBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            passwordBox.Size = new Size(731, 104);
            passwordBox.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            guna2Transition1.SetDecoration(label8, Guna.UI2.AnimatorNS.DecorationType.None);
            label8.Font = new Font("Andalus", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(167, 608);
            label8.Margin = new Padding(9, 0, 9, 0);
            label8.Name = "label8";
            label8.Size = new Size(342, 110);
            label8.TabIndex = 24;
            label8.Text = "Password:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            guna2Transition1.SetDecoration(label9, Guna.UI2.AnimatorNS.DecorationType.None);
            label9.Font = new Font("Andalus", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(167, 181);
            label9.Margin = new Padding(9, 0, 9, 0);
            label9.Name = "label9";
            label9.Size = new Size(309, 93);
            label9.TabIndex = 23;
            label9.Text = "Username:";
            // 
            // usernameBox
            // 
            usernameBox.Animated = true;
            usernameBox.BorderRadius = 10;
            usernameBox.BorderThickness = 2;
            usernameBox.CustomizableEdges = customizableEdges3;
            guna2Transition1.SetDecoration(usernameBox, Guna.UI2.AnimatorNS.DecorationType.None);
            usernameBox.DefaultText = "";
            usernameBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            usernameBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            usernameBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            usernameBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            usernameBox.FocusedState.BorderColor = Color.DodgerBlue;
            usernameBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.ForeColor = Color.Black;
            usernameBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            usernameBox.Location = new Point(189, 319);
            usernameBox.Margin = new Padding(11, 15, 11, 15);
            usernameBox.Name = "usernameBox";
            usernameBox.PasswordChar = '\0';
            usernameBox.PlaceholderText = "";
            usernameBox.SelectedText = "";
            usernameBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            usernameBox.Size = new Size(731, 109);
            usernameBox.TabIndex = 22;
            // 
            // emailBox
            // 
            emailBox.Animated = true;
            emailBox.BorderRadius = 10;
            emailBox.BorderThickness = 2;
            emailBox.CustomizableEdges = customizableEdges5;
            guna2Transition1.SetDecoration(emailBox, Guna.UI2.AnimatorNS.DecorationType.None);
            emailBox.DefaultText = "";
            emailBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            emailBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            emailBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            emailBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            emailBox.FocusedState.BorderColor = Color.DodgerBlue;
            emailBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailBox.ForeColor = Color.Black;
            emailBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            emailBox.Location = new Point(189, 1138);
            emailBox.Margin = new Padding(11, 15, 11, 15);
            emailBox.Name = "emailBox";
            emailBox.PasswordChar = '\0';
            emailBox.PlaceholderText = "";
            emailBox.SelectedText = "";
            emailBox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            emailBox.Size = new Size(731, 111);
            emailBox.TabIndex = 28;
            // 
            // idBox
            // 
            idBox.Animated = true;
            idBox.BorderRadius = 10;
            idBox.BorderThickness = 2;
            idBox.CustomizableEdges = customizableEdges7;
            guna2Transition1.SetDecoration(idBox, Guna.UI2.AnimatorNS.DecorationType.None);
            idBox.DefaultText = "";
            idBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            idBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            idBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            idBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            idBox.FocusedState.BorderColor = Color.DodgerBlue;
            idBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idBox.ForeColor = Color.Black;
            idBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            idBox.Location = new Point(189, 1422);
            idBox.Margin = new Padding(11, 15, 11, 15);
            idBox.Name = "idBox";
            idBox.PasswordChar = '\0';
            idBox.PlaceholderText = "";
            idBox.SelectedText = "";
            idBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            idBox.Size = new Size(731, 104);
            idBox.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            guna2Transition1.SetDecoration(label11, Guna.UI2.AnimatorNS.DecorationType.None);
            label11.Font = new Font("Andalus", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(189, 1281);
            label11.Margin = new Padding(9, 0, 9, 0);
            label11.Name = "label11";
            label11.Size = new Size(135, 110);
            label11.TabIndex = 31;
            label11.Text = "ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            guna2Transition1.SetDecoration(label10, Guna.UI2.AnimatorNS.DecorationType.None);
            label10.Font = new Font("Andalus", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(167, 997);
            label10.Margin = new Padding(9, 0, 9, 0);
            label10.Name = "label10";
            label10.Size = new Size(229, 110);
            label10.TabIndex = 29;
            label10.Text = "Email:";
            // 
            // RegisterButton
            // 
            RegisterButton.Animated = true;
            RegisterButton.BorderRadius = 15;
            RegisterButton.BorderThickness = 1;
            RegisterButton.CustomizableEdges = customizableEdges9;
            guna2Transition1.SetDecoration(RegisterButton, Guna.UI2.AnimatorNS.DecorationType.None);
            RegisterButton.DisabledState.BorderColor = Color.DarkGray;
            RegisterButton.DisabledState.CustomBorderColor = Color.DarkGray;
            RegisterButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            RegisterButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            RegisterButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            RegisterButton.FillColor = Color.FromArgb(255, 224, 192);
            RegisterButton.FillColor2 = Color.RosyBrown;
            RegisterButton.Font = new Font("Andalus", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterButton.ForeColor = Color.Black;
            RegisterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            RegisterButton.Location = new Point(352, 1871);
            RegisterButton.Margin = new Padding(4, 7, 4, 7);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            RegisterButton.Size = new Size(456, 168);
            RegisterButton.TabIndex = 32;
            RegisterButton.Text = "Register";
            RegisterButton.Click += Register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            guna2Transition1.SetDecoration(label1, Guna.UI2.AnimatorNS.DecorationType.None);
            label1.Font = new Font("Andalus", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 1570);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(258, 101);
            label1.TabIndex = 33;
            label1.Text = "Gender:";
            // 
            // closeButton
            // 
            closeButton.Animated = true;
            closeButton.BackColor = Color.Transparent;
            closeButton.Checked = true;
            guna2Transition1.SetDecoration(closeButton, Guna.UI2.AnimatorNS.DecorationType.None);
            closeButton.DisabledState.BorderColor = Color.DarkGray;
            closeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            closeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            closeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            closeButton.FillColor = Color.Red;
            closeButton.Font = new Font("Poor Richard", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(1196, 32);
            closeButton.Margin = new Padding(4, 7, 4, 7);
            closeButton.Name = "closeButton";
            closeButton.ShadowDecoration.CustomizableEdges = customizableEdges11;
            closeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            closeButton.Size = new Size(79, 101);
            closeButton.TabIndex = 34;
            closeButton.Text = "X";
            closeButton.TextOffset = new Point(1, 0);
            closeButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            closeButton.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            closeButton.Click += CloseButton_Click;
            // 
            // guna2Transition1
            // 
            guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            guna2Transition1.DefaultAnimation = animation1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.RosyBrown;
            guna2Transition1.SetDecoration(iconButton1, Guna.UI2.AnimatorNS.DecorationType.BottomMirror);
            iconButton1.DialogResult = DialogResult.OK;
            iconButton1.FlatAppearance.BorderColor = Color.RosyBrown;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton1.IconColor = Color.Navy;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(17, 32);
            iconButton1.Margin = new Padding(0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(107, 128);
            iconButton1.TabIndex = 35;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // ShowButton
            // 
            ShowButton.AnimatedGIF = true;
            ShowButton.CheckedState.ImageSize = new Size(64, 64);
            guna2Transition1.SetDecoration(ShowButton, Guna.UI2.AnimatorNS.DecorationType.None);
            ShowButton.HoverState.ImageSize = new Size(70, 30);
            ShowButton.Image = (Image)resources.GetObject("ShowButton.Image");
            ShowButton.ImageOffset = new Point(0, 0);
            ShowButton.ImageRotate = 0F;
            ShowButton.ImageSize = new Size(70, 30);
            ShowButton.Location = new Point(935, 751);
            ShowButton.Margin = new Padding(4, 7, 4, 7);
            ShowButton.Name = "ShowButton";
            ShowButton.PressedState.ImageSize = new Size(70, 30);
            ShowButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            ShowButton.Size = new Size(137, 74);
            ShowButton.TabIndex = 27;
            ShowButton.Click += showButton_Click;
            // 
            // HideButton
            // 
            HideButton.AnimatedGIF = true;
            HideButton.CheckedState.ImageSize = new Size(64, 64);
            guna2Transition1.SetDecoration(HideButton, Guna.UI2.AnimatorNS.DecorationType.None);
            HideButton.HoverState.ImageSize = new Size(70, 30);
            HideButton.Image = (Image)resources.GetObject("HideButton.Image");
            HideButton.ImageOffset = new Point(0, 0);
            HideButton.ImageRotate = 0F;
            HideButton.ImageSize = new Size(70, 30);
            HideButton.Location = new Point(935, 751);
            HideButton.Margin = new Padding(4, 7, 4, 7);
            HideButton.Name = "HideButton";
            HideButton.PressedState.ImageSize = new Size(70, 30);
            HideButton.ShadowDecoration.CustomizableEdges = customizableEdges13;
            HideButton.Size = new Size(137, 74);
            HideButton.TabIndex = 26;
            HideButton.Click += hideButton_Click;
            // 
            // guna2AnimateWindow1
            // 
            guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            guna2AnimateWindow1.TargetForm = this;
            // 
            // returnDialog
            // 
            returnDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel;
            returnDialog.Caption = "Warning!";
            returnDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            returnDialog.Parent = this;
            returnDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            returnDialog.Text = "You're gonna lose your info, are you sure?";
            // 
            // closeDialog
            // 
            closeDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            closeDialog.Caption = null;
            closeDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            closeDialog.Parent = this;
            closeDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            closeDialog.Text = "Are you sure that you want to exit?";
            // 
            // registerDialog
            // 
            registerDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            registerDialog.Caption = null;
            registerDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            registerDialog.Parent = this;
            registerDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            registerDialog.Text = "Are you done with your info?";
            // 
            // infoError
            // 
            infoError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            infoError.Caption = null;
            infoError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            infoError.Parent = this;
            infoError.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            infoError.Text = null;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1301, 2171);
            Controls.Add(iconButton1);
            Controls.Add(closeButton);
            Controls.Add(label1);
            Controls.Add(RegisterButton);
            Controls.Add(label11);
            Controls.Add(idBox);
            Controls.Add(label10);
            Controls.Add(emailBox);
            Controls.Add(passwordBox);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(usernameBox);
            Controls.Add(ShowButton);
            Controls.Add(HideButton);
            Controls.Add(femaleButton);
            Controls.Add(maleButton);
            Controls.Add(label6);
            Controls.Add(label5);
            guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 7, 4, 7);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton maleButton;
        private System.Windows.Forms.RadioButton femaleButton;
        private Guna.UI2.WinForms.Guna2TextBox passwordBox;
        private Label label8;
        private Label label9;
        private Guna.UI2.WinForms.Guna2TextBox usernameBox;
        private Guna.UI2.WinForms.Guna2TextBox emailBox;
        private Guna.UI2.WinForms.Guna2TextBox idBox;
        private Label label11;
        private Label label10;
        private Guna.UI2.WinForms.Guna2GradientButton RegisterButton;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton closeButton;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2MessageDialog returnDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog closeDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog registerDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog infoError;
        private Guna.UI2.WinForms.Guna2ImageButton ShowButton;
        private Guna.UI2.WinForms.Guna2ImageButton HideButton;
    }
}