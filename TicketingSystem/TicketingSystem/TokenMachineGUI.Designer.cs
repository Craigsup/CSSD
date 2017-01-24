namespace TicketingSystem {
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
            this.lbLanguages = new System.Windows.Forms.ListBox();
            this.lblLanguageTitle = new System.Windows.Forms.Label();
            this.lblAccountTitle = new System.Windows.Forms.Label();
            this.lbAccountTypes = new System.Windows.Forms.ListBox();
            this.lblJourneyTitle = new System.Windows.Forms.Label();
            this.lbJourneyType = new System.Windows.Forms.ListBox();
            this.nudTimedPass = new System.Windows.Forms.NumericUpDown();
            this.lblTimedPassTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimedPass)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLanguages
            // 
            this.lbLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguages.FormattingEnabled = true;
            this.lbLanguages.ItemHeight = 24;
            this.lbLanguages.Location = new System.Drawing.Point(193, 65);
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
            this.lblLanguageTitle.Location = new System.Drawing.Point(193, 36);
            this.lblLanguageTitle.Name = "lblLanguageTitle";
            this.lblLanguageTitle.Size = new System.Drawing.Size(149, 24);
            this.lblLanguageTitle.TabIndex = 1;
            this.lblLanguageTitle.Text = "lblLanguageTitle";
            // 
            // lblAccountTitle
            // 
            this.lblAccountTitle.AutoSize = true;
            this.lblAccountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAccountTitle.Location = new System.Drawing.Point(193, 36);
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
            this.lbAccountTypes.Location = new System.Drawing.Point(193, 65);
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
            this.lblJourneyTitle.Location = new System.Drawing.Point(193, 36);
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
            this.lbJourneyType.Location = new System.Drawing.Point(193, 65);
            this.lbJourneyType.Name = "lbJourneyType";
            this.lbJourneyType.Size = new System.Drawing.Size(256, 196);
            this.lbJourneyType.TabIndex = 5;
            this.lbJourneyType.Visible = false;
            this.lbJourneyType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbJourneyType_KeyDown);
            // 
            // nudTimedPass
            // 
            this.nudTimedPass.Location = new System.Drawing.Point(245, 175);
            this.nudTimedPass.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimedPass.Name = "nudTimedPass";
            this.nudTimedPass.Size = new System.Drawing.Size(120, 20);
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
            this.lblTimedPassTitle.Location = new System.Drawing.Point(193, 36);
            this.lblTimedPassTitle.Name = "lblTimedPassTitle";
            this.lblTimedPassTitle.Size = new System.Drawing.Size(270, 24);
            this.lblTimedPassTitle.TabIndex = 7;
            this.lblTimedPassTitle.Text = "Enter number of days for pass: ";
            this.lblTimedPassTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimedPassTitle.Visible = false;
            // 
            // TokenMachineGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 502);
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
    }
}