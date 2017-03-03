using System.ComponentModel;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.btnAddNewGUI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewGUI
            // 
            this.btnAddNewGUI.Location = new System.Drawing.Point(141, 66);
            this.btnAddNewGUI.Name = "btnAddNewGUI";
            this.btnAddNewGUI.Size = new System.Drawing.Size(157, 67);
            this.btnAddNewGUI.TabIndex = 0;
            this.btnAddNewGUI.Text = "New GUI";
            this.btnAddNewGUI.UseVisualStyleBackColor = true;
            this.btnAddNewGUI.Click += new System.EventHandler(this.btnAddNewGUI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 224);
            this.Controls.Add(this.btnAddNewGUI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddNewGUI;
    }
}

