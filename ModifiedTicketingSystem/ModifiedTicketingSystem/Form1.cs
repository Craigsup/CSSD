using System;
using System.Collections.Generic;
using System.IO;
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

        private void button1_Click(object sender, EventArgs e) {
            MobileAppGUI gui = new MobileAppGUI();
            gui.Show();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var stations = File.ReadAllLines(@"UK_TrainStations.txt");
            foreach (var singleLine in stations) {
                _stationList.Add(new Station(new DepartureList(), singleLine));
            }
        }
    }
}
