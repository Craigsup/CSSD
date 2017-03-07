using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModifiedTicketingSystem.Properties;

namespace ModifiedTicketingSystem {
    public partial class AdminGUI : Form {
        private int _account;
        private StationList _stations;

        public AdminGUI() {
            InitializeComponent();

            lblLoginDetails.Visible = true;
            tbPassword.Visible = true;
            tbUsername.Visible = true;
            lblPassword.Visible = true;
            lblUsername.Visible = true;
            btnLogin.Visible = true;
            tbPassword.Text = "password";
            tbUsername.Text = "admin-pete-w";

            LoadStations();
            /*cbStations.DataSource = _stations.GetStations();
            cbStations.BindingContext = new BindingContext();
            cbStations.DisplayMember = "_location";*/
            


            cbStations.DataSource = null;
            cbStations.DisplayMember = "_location";
            cbStations.DataSource = _stations.GetStations();


            SetupFile();
        }

        private void SetupFile() {
            var acc0 = new AdminAccount(0, "admin-pete-w", "password", "Pete Wilkinson", false);

            AccountList accList = new AccountList(true);
            accList.AddAdminAccount(acc0);
            accList.SaveAdminData();
        }

        private void LoadStations() {
            List<Station> stationsTemp = ReadFromBinaryFile<List<Station>>(@"Stations.txt");
            _stations = new StationList(stationsTemp);
        }

        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open(filePath, FileMode.Open)) {
                var binaryFormatter = new BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        private void ShowLogin() {
            // Show login screen
            ToggleLoginScreen();
            tbUsername.Focus();
        }

        private void ShowHome() {
            HideAll();
            ToggleHomeScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            LoginToAccount(tbUsername.Text, tbPassword.Text);
        }

        private void ToggleLoginScreen() {
            lblLoginDetails.Visible = !lblLoginDetails.Visible;
            tbPassword.Visible = !tbPassword.Visible;
            tbUsername.Visible = !tbUsername.Visible;
            lblPassword.Visible = !lblPassword.Visible;
            lblUsername.Visible = !lblUsername.Visible;
            btnLogin.Visible = !btnLogin.Visible;
        }

        private void ToggleHomeScreen() {
            tcAdminViews.Visible = !tcAdminViews.Visible;
        }

        private void LoginToAccount(string username, string password) {
            _account = new AdminAccount().VerifyLogin(username, password);
            lblUsername.Text = username;
            if (_account > -1) {
                // Hide login screen
                ToggleLoginScreen();

                //Show Home Screen
                ShowHome();


                // Log in successful. Do something.
            }
        }

        private void ConfigureGuiForLogin() {
            PictureBox userPicture = new PictureBox {
                Location = new Point(Width - 150, 15),
                Image = (Image)Resources.ResourceManager.GetObject("_" + _account),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(38, 38),
                Visible = true,
                Name = "account"
            };
            Controls.Add(userPicture);
            Label userName = new Label {
                Name = "lblAccountUsername",
                Text =
                    new CustomerAccount().GetXByAccountId<string>(_account, "username") + "\n£" +
                    string.Format("{0:0000000.00}", new CustomerAccount().GetXByAccountId<string>(_account, "balance")),
                Location = new Point(Width - 150 + userPicture.Width + 3, 15),
                AutoSize = true
            };
            Controls.Add(userName);
        }

        private void HideAll() {
            foreach (var x in Controls.OfType<Button>()) {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<Label>()) {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<PictureBox>()) {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<TextBox>()) {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<ListBox>()) {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<NumericUpDown>()) {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<ComboBox>()) {
                x.Visible = false;
            }
        }

        private void AdminGUI_Load(object sender, EventArgs e) {

        }
    }
}
