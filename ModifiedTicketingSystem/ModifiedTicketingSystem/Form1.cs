using System;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnAddNewGUI_Click(object sender, EventArgs e) {
            TokenMachineGUI gui = new TokenMachineGUI();
            gui.Show();
        }
    }
}
