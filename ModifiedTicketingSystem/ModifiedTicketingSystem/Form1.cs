﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    public partial class Form1 : Form {

        private Counter counter;
        public Form1() {
            InitializeComponent();
            counter = new Counter();

        }

        private void btnAddNewGUI_Click(object sender, EventArgs e) {
            TokenMachineGUI gui = new TokenMachineGUI(counter);
            gui.Show();
            counter.RegisterObserver(gui);
        }

        private void button1_Click(object sender, EventArgs e) {
            MobileAppGUI gui = new MobileAppGUI();
            gui.Show();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //InitialStationLoad();
        }

        private void InitialStationLoad() {
            var stations = File.ReadAllLines(@"Stations.txt");
            List<Station> stationsj = new List<Station>();
            foreach (var singleLine in stations) {
                stationsj.Add(new Station(new DepartureList(), singleLine));
            }
            WriteToBinaryFile<List<Station>>(@"Stations.txt", stationsj, false);
        }

        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false) {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create)) {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        private void btnAdminGUI_Click(object sender, EventArgs e) {
            AdminGUI gui = new AdminGUI();
            gui.Show();
            counter.RegisterObserver(gui);
            counter.NotifyObservers();
        }
    }
}
