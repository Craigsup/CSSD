﻿namespace TicketingSystem {
    partial class TokenMachineGUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TokenMachineGUI));
            this.lbLanguages = new System.Windows.Forms.ListBox();
            this.lblLanguageTitle = new System.Windows.Forms.Label();
            this.lblAccountTitle = new System.Windows.Forms.Label();
            this.lbAccountTypes = new System.Windows.Forms.ListBox();
            this.lblJourneyTitle = new System.Windows.Forms.Label();
            this.lbJourneyType = new System.Windows.Forms.ListBox();
            this.nudTimedPass = new System.Windows.Forms.NumericUpDown();
            this.lblTimedPassTitle = new System.Windows.Forms.Label();
            this.nudTicketQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblNudQuantity = new System.Windows.Forms.Label();
            this.lblPaymentMethods = new System.Windows.Forms.Label();
            this.lbPaymentMethods = new System.Windows.Forms.ListBox();
            this.lblFinalMessage = new System.Windows.Forms.Label();
            this.tbStartStation = new System.Windows.Forms.TextBox();
            this.lblStartStation = new System.Windows.Forms.Label();
            this.lblEndStation = new System.Windows.Forms.Label();
            this.tbEndStation = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLoginScreen = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimedPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTicketQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLanguages
            // 
            this.lbLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguages.FormattingEnabled = true;
            this.lbLanguages.ItemHeight = 24;
            this.lbLanguages.Location = new System.Drawing.Point(117, 97);
            this.lbLanguages.Name = "lbLanguages";
            this.lbLanguages.Size = new System.Drawing.Size(256, 196);
            this.lbLanguages.TabIndex = 0;
            this.lbLanguages.SelectedIndexChanged += new System.EventHandler(this.SelectLanguage);
            this.lbLanguages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbLanguages_KeyDown);
            // 
            // lblLanguageTitle
            // 
            this.lblLanguageTitle.AutoSize = true;
            this.lblLanguageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLanguageTitle.Location = new System.Drawing.Point(117, 68);
            this.lblLanguageTitle.Name = "lblLanguageTitle";
            this.lblLanguageTitle.Size = new System.Drawing.Size(149, 24);
            this.lblLanguageTitle.TabIndex = 1;
            this.lblLanguageTitle.Text = "lblLanguageTitle";
            // 
            // lblAccountTitle
            // 
            this.lblAccountTitle.AutoSize = true;
            this.lblAccountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAccountTitle.Location = new System.Drawing.Point(117, 68);
            this.lblAccountTitle.Name = "lblAccountTitle";
            this.lblAccountTitle.Size = new System.Drawing.Size(134, 24);
            this.lblAccountTitle.TabIndex = 2;
            this.lblAccountTitle.Text = "lblAccountTitle";
            this.lblAccountTitle.Visible = false;
            // 
            // lbAccountTypes
            // 
            this.lbAccountTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbAccountTypes.FormattingEnabled = true;
            this.lbAccountTypes.ItemHeight = 24;
            this.lbAccountTypes.Location = new System.Drawing.Point(117, 97);
            this.lbAccountTypes.Name = "lbAccountTypes";
            this.lbAccountTypes.Size = new System.Drawing.Size(256, 196);
            this.lbAccountTypes.TabIndex = 3;
            this.lbAccountTypes.Visible = false;
            this.lbAccountTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbAccountTypes_KeyDown);
            // 
            // lblJourneyTitle
            // 
            this.lblJourneyTitle.AutoSize = true;
            this.lblJourneyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblJourneyTitle.Location = new System.Drawing.Point(117, 68);
            this.lblJourneyTitle.Name = "lblJourneyTitle";
            this.lblJourneyTitle.Size = new System.Drawing.Size(132, 24);
            this.lblJourneyTitle.TabIndex = 4;
            this.lblJourneyTitle.Text = "lblJourneyTitle";
            this.lblJourneyTitle.Visible = false;
            // 
            // lbJourneyType
            // 
            this.lbJourneyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbJourneyType.FormattingEnabled = true;
            this.lbJourneyType.ItemHeight = 24;
            this.lbJourneyType.Location = new System.Drawing.Point(117, 97);
            this.lbJourneyType.Name = "lbJourneyType";
            this.lbJourneyType.Size = new System.Drawing.Size(256, 196);
            this.lbJourneyType.TabIndex = 5;
            this.lbJourneyType.Visible = false;
            this.lbJourneyType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbJourneyType_KeyDown);
            // 
            // nudTimedPass
            // 
            this.nudTimedPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimedPass.Location = new System.Drawing.Point(119, 207);
            this.nudTimedPass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimedPass.Name = "nudTimedPass";
            this.nudTimedPass.Size = new System.Drawing.Size(81, 29);
            this.nudTimedPass.TabIndex = 6;
            this.nudTimedPass.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimedPass.Visible = false;
            this.nudTimedPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudTimedPass_KeyDown);
            // 
            // lblTimedPassTitle
            // 
            this.lblTimedPassTitle.AutoSize = true;
            this.lblTimedPassTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTimedPassTitle.Location = new System.Drawing.Point(117, 180);
            this.lblTimedPassTitle.Name = "lblTimedPassTitle";
            this.lblTimedPassTitle.Size = new System.Drawing.Size(101, 24);
            this.lblTimedPassTitle.TabIndex = 7;
            this.lblTimedPassTitle.Text = "Pass Days:";
            this.lblTimedPassTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimedPassTitle.Visible = false;
            // 
            // nudTicketQuantity
            // 
            this.nudTicketQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTicketQuantity.Location = new System.Drawing.Point(294, 207);
            this.nudTicketQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTicketQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTicketQuantity.Name = "nudTicketQuantity";
            this.nudTicketQuantity.Size = new System.Drawing.Size(79, 29);
            this.nudTicketQuantity.TabIndex = 8;
            this.nudTicketQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTicketQuantity.Visible = false;
            this.nudTicketQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudTicketQuantity_KeyDown);
            // 
            // lblNudQuantity
            // 
            this.lblNudQuantity.AutoSize = true;
            this.lblNudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNudQuantity.Location = new System.Drawing.Point(290, 180);
            this.lblNudQuantity.Name = "lblNudQuantity";
            this.lblNudQuantity.Size = new System.Drawing.Size(88, 24);
            this.lblNudQuantity.TabIndex = 9;
            this.lblNudQuantity.Text = "Quantity: ";
            this.lblNudQuantity.Visible = false;
            // 
            // lblPaymentMethods
            // 
            this.lblPaymentMethods.AutoSize = true;
            this.lblPaymentMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPaymentMethods.Location = new System.Drawing.Point(121, 68);
            this.lblPaymentMethods.Name = "lblPaymentMethods";
            this.lblPaymentMethods.Size = new System.Drawing.Size(208, 24);
            this.lblPaymentMethods.TabIndex = 10;
            this.lblPaymentMethods.Text = "Select payment method";
            this.lblPaymentMethods.Visible = false;
            // 
            // lbPaymentMethods
            // 
            this.lbPaymentMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbPaymentMethods.FormattingEnabled = true;
            this.lbPaymentMethods.ItemHeight = 24;
            this.lbPaymentMethods.Location = new System.Drawing.Point(117, 97);
            this.lbPaymentMethods.Name = "lbPaymentMethods";
            this.lbPaymentMethods.Size = new System.Drawing.Size(256, 196);
            this.lbPaymentMethods.TabIndex = 11;
            this.lbPaymentMethods.Visible = false;
            this.lbPaymentMethods.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbPaymentMethods_KeyDown);
            // 
            // lblFinalMessage
            // 
            this.lblFinalMessage.AutoSize = true;
            this.lblFinalMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblFinalMessage.Location = new System.Drawing.Point(109, 247);
            this.lblFinalMessage.Name = "lblFinalMessage";
            this.lblFinalMessage.Size = new System.Drawing.Size(307, 46);
            this.lblFinalMessage.TabIndex = 12;
            this.lblFinalMessage.Text = "lblFinalMessage";
            this.lblFinalMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinalMessage.Visible = false;
            // 
            // tbStartStation
            // 
            this.tbStartStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbStartStation.Location = new System.Drawing.Point(117, 154);
            this.tbStartStation.Name = "tbStartStation";
            this.tbStartStation.Size = new System.Drawing.Size(171, 29);
            this.tbStartStation.TabIndex = 13;
            this.tbStartStation.Visible = false;
            // 
            // lblStartStation
            // 
            this.lblStartStation.AutoSize = true;
            this.lblStartStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblStartStation.Location = new System.Drawing.Point(119, 126);
            this.lblStartStation.Name = "lblStartStation";
            this.lblStartStation.Size = new System.Drawing.Size(121, 24);
            this.lblStartStation.TabIndex = 14;
            this.lblStartStation.Text = "lblStartStation";
            this.lblStartStation.Visible = false;
            // 
            // lblEndStation
            // 
            this.lblEndStation.AutoSize = true;
            this.lblEndStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEndStation.Location = new System.Drawing.Point(119, 197);
            this.lblEndStation.Name = "lblEndStation";
            this.lblEndStation.Size = new System.Drawing.Size(120, 24);
            this.lblEndStation.TabIndex = 15;
            this.lblEndStation.Text = "lblEndStation";
            this.lblEndStation.Visible = false;
            // 
            // tbEndStation
            // 
            this.tbEndStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbEndStation.Location = new System.Drawing.Point(117, 226);
            this.tbEndStation.Name = "tbEndStation";
            this.tbEndStation.Size = new System.Drawing.Size(171, 29);
            this.tbEndStation.TabIndex = 16;
            this.tbEndStation.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(193, 349);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPassword.Location = new System.Drawing.Point(117, 188);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 24);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Password";
            this.lblPassword.Visible = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbPassword.Location = new System.Drawing.Point(121, 215);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 29);
            this.tbPassword.TabIndex = 21;
            this.tbPassword.Visible = false;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbUsername.Location = new System.Drawing.Point(121, 156);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 29);
            this.tbUsername.TabIndex = 20;
            this.tbUsername.Visible = false;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUsername_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUsername.Location = new System.Drawing.Point(117, 129);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 24);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username";
            this.lblUsername.Visible = false;
            // 
            // lblLoginScreen
            // 
            this.lblLoginScreen.AutoSize = true;
            this.lblLoginScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLoginScreen.Location = new System.Drawing.Point(117, 70);
            this.lblLoginScreen.Name = "lblLoginScreen";
            this.lblLoginScreen.Size = new System.Drawing.Size(159, 24);
            this.lblLoginScreen.TabIndex = 18;
            this.lblLoginScreen.Text = "Enter login details";
            this.lblLoginScreen.Visible = false;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 314);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(56, 56);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 23;
            this.pbBack.TabStop = false;
            this.pbBack.Visible = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbHome
            // 
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(12, 13);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(56, 56);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHome.TabIndex = 24;
            this.pbHome.TabStop = false;
            this.pbHome.Visible = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // TokenMachineGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 404);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLoginScreen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbEndStation);
            this.Controls.Add(this.lblEndStation);
            this.Controls.Add(this.lblStartStation);
            this.Controls.Add(this.tbStartStation);
            this.Controls.Add(this.lblFinalMessage);
            this.Controls.Add(this.lbPaymentMethods);
            this.Controls.Add(this.lblPaymentMethods);
            this.Controls.Add(this.lblNudQuantity);
            this.Controls.Add(this.nudTicketQuantity);
            this.Controls.Add(this.lblTimedPassTitle);
            this.Controls.Add(this.nudTimedPass);
            this.Controls.Add(this.lbJourneyType);
            this.Controls.Add(this.lblJourneyTitle);
            this.Controls.Add(this.lblAccountTitle);
            this.Controls.Add(this.lblLanguageTitle);
            this.Controls.Add(this.lbAccountTypes);
            this.Controls.Add(this.lbLanguages);
            this.Name = "TokenMachineGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TokenMachineGUI";
            ((System.ComponentModel.ISupportInitialize)(this.nudTimedPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTicketQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLanguages;
        public System.Windows.Forms.Label lblLanguageTitle;
        private System.Windows.Forms.Label lblAccountTitle;
        private System.Windows.Forms.ListBox lbAccountTypes;
        private System.Windows.Forms.Label lblJourneyTitle;
        private System.Windows.Forms.ListBox lbJourneyType;
        private System.Windows.Forms.NumericUpDown nudTimedPass;
        private System.Windows.Forms.Label lblTimedPassTitle;
        private System.Windows.Forms.NumericUpDown nudTicketQuantity;
        private System.Windows.Forms.Label lblNudQuantity;
        private System.Windows.Forms.Label lblPaymentMethods;
        private System.Windows.Forms.ListBox lbPaymentMethods;
        private System.Windows.Forms.Label lblFinalMessage;
        private System.Windows.Forms.TextBox tbStartStation;
        private System.Windows.Forms.Label lblStartStation;
        private System.Windows.Forms.Label lblEndStation;
        private System.Windows.Forms.TextBox tbEndStation;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLoginScreen;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbHome;
    }
}