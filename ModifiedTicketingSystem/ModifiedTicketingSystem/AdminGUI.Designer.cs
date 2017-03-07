namespace ModifiedTicketingSystem {
    partial class AdminGUI {
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
            this.lblLoginDetails = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tcAdminViews = new System.Windows.Forms.TabControl();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTickets = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTicketCount = new System.Windows.Forms.Label();
            this.cbStations = new System.Windows.Forms.ComboBox();
            this.tcAdminViews.SuspendLayout();
            this.tabTickets.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoginDetails
            // 
            this.lblLoginDetails.AutoSize = true;
            this.lblLoginDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginDetails.Location = new System.Drawing.Point(183, 96);
            this.lblLoginDetails.Name = "lblLoginDetails";
            this.lblLoginDetails.Size = new System.Drawing.Size(261, 24);
            this.lblLoginDetails.TabIndex = 0;
            this.lblLoginDetails.Text = "Please enter your login details";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUsername.Location = new System.Drawing.Point(254, 153);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 24);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPassword.Location = new System.Drawing.Point(254, 225);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 24);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbUsername.Location = new System.Drawing.Point(258, 180);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 29);
            this.tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbPassword.Location = new System.Drawing.Point(258, 252);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 29);
            this.tbPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Turquoise;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLogin.Location = new System.Drawing.Point(258, 301);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tcAdminViews
            // 
            this.tcAdminViews.Controls.Add(this.tabTickets);
            this.tcAdminViews.Controls.Add(this.tabPage2);
            this.tcAdminViews.Location = new System.Drawing.Point(47, 48);
            this.tcAdminViews.Name = "tcAdminViews";
            this.tcAdminViews.SelectedIndex = 0;
            this.tcAdminViews.Size = new System.Drawing.Size(534, 370);
            this.tcAdminViews.TabIndex = 6;
            this.tcAdminViews.Visible = false;
            // 
            // tabTickets
            // 
            this.tabTickets.Controls.Add(this.cbStations);
            this.tabTickets.Controls.Add(this.lblTicketCount);
            this.tabTickets.Controls.Add(this.lblTickets);
            this.tabTickets.Location = new System.Drawing.Point(4, 22);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(526, 344);
            this.tabTickets.TabIndex = 0;
            this.tabTickets.Text = "Tickets";
            this.tabTickets.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(526, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTickets.Location = new System.Drawing.Point(15, 14);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(74, 24);
            this.lblTickets.TabIndex = 0;
            this.lblTickets.Text = "Tickets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // lblTicketCount
            // 
            this.lblTicketCount.AutoSize = true;
            this.lblTicketCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTicketCount.Location = new System.Drawing.Point(96, 14);
            this.lblTicketCount.Name = "lblTicketCount";
            this.lblTicketCount.Size = new System.Drawing.Size(20, 24);
            this.lblTicketCount.TabIndex = 1;
            this.lblTicketCount.Text = "0";
            // 
            // cbStations
            // 
            this.cbStations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStations.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStations.FormattingEnabled = true;
            this.cbStations.Location = new System.Drawing.Point(19, 69);
            this.cbStations.Name = "cbStations";
            this.cbStations.Size = new System.Drawing.Size(391, 21);
            this.cbStations.TabIndex = 2;
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 454);
            this.Controls.Add(this.tcAdminViews);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLoginDetails);
            this.Name = "AdminGUI";
            this.Text = "AdminGUI";
            this.Load += new System.EventHandler(this.AdminGUI_Load);
            this.tcAdminViews.ResumeLayout(false);
            this.tabTickets.ResumeLayout(false);
            this.tabTickets.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginDetails;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TabControl tcAdminViews;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.Label lblTickets;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStations;
        private System.Windows.Forms.Label lblTicketCount;
    }
}