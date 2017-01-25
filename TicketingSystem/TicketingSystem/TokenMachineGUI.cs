using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using System.Text.RegularExpressions;

namespace TicketingSystem {
    public partial class TokenMachineGUI : Form {
        private TokenMachine _machine;
        private Language _lang;
        private LanguageList _langList;
        private string[] stations = new string[2533];
        private int _account;

        public TokenMachineGUI() {
            InitializeComponent();

            //SetupFile();

            stations = System.IO.File.ReadAllLines(@"UK_TrainStations.txt");
            comboBox1.DataSource = stations;

            SetupLanguages();
            DisplayLangList();
        }

        private void SetupFile() {
            var rand = new Random();
            var acc1 = new CustomerAccount(rand.Next(1000000, 9999999), 1, 0, "Bob", "password", "Bob Hitler", false);
            var acc2 = new CustomerAccount(rand.Next(1000000, 9999999), 2, 0, "Rudy", "password", "Rudy Smeg", false);
            var acc3 = new CustomerAccount(rand.Next(1000000, 9999999), 3, 0, "Judy", "password", "Judy Spagghettio", false);
            var acc4 = new CustomerAccount(rand.Next(1000000, 9999999), 4, 0, "John", "password", "John Smith", false);
            var acc5 = new CustomerAccount(rand.Next(1000000, 9999999), 5, 0, "Clarence", "password", "Clarence Angel", false);

            AccountList accList = new AccountList();
            accList.AddCustomerAccount(acc1);
            accList.AddCustomerAccount(acc2);
            accList.AddCustomerAccount(acc3);
            accList.AddCustomerAccount(acc4);
            accList.AddCustomerAccount(acc5);

            //System.IO.File.WriteAllText(@"Accounts.txt", Newtonsoft.Json.JsonConvert.SerializeObject(accList));
            accList.SaveData();
            //accList.LoadData();
        }

        private void DisplayLangList() {
            // Show Select Option Screen
            ToggleLanguageScreen(true);
        }

        private void SetActiveLanguage() {
            DisplayStartOptions();
            pbHome.Visible = true;
            pbBack.Visible = true;
        }

        private void DisplayStartOptions() {
            // Hide Select Option Screen
            ToggleLanguageScreen(false);

            // Show Select Account Screen
            ToggleAccountOptions(true);
        }

        private void GuestLogin() {
            // Hide Select Account Screen
            ToggleAccountOptions(false);
                
            // Call DisplayGuestOptions
            DisplayGuestOptions();
        }
            
        private void DisplayGuestOptions() {
            // Show Select Journey Type Screen
            ToggleJourneyOptions(true);
        }

        private void DisplaySingleJourney() {
            // Hide Joruney Options
            ToggleJourneyOptions(false);

            // Show Timed Pass Screen
            ToggleSingleJourney(true);
        }

        private void DisplayTimedPass() {
            // Hide Joruney Options
            ToggleJourneyOptions(false);

            // Show Timed Pass Screen
            ToggleTimedPass(true);
        }

        private void DisplayPaymentOptions() {
            // Hide Timed Pass Screen
            ToggleTimedPass(false);

            // Show Payment Screen
            TogglePaymentScreen(true);
        }

        private void DisplayFinalMessage() {
            // Hide Timed Pass Screen
            TogglePaymentScreen(false);

            // Show Payment Screen
            FinalMessage();
        }

        private void Login() {
            // Hide Select Account Screen
            ToggleAccountOptions(false);

            DisplayLoginScreen();
        }

        private void DisplayLoginScreen() {
            ToggleLoginScreen(true);
        }

        private void DisplayLoginOptions() {
            ToggleLoginScreen(false);
            ToggleJourneyOptions(true);
        }

        private void InsertMoney() {

        }

        private void SelectTicketType() {

        }

        private void SelectRoute() {

        }

        private void SelectDeparture() {

        }

        private void SelectPassDays() {

        }

        /*
         * Custom Toggle Functions to simplify screens
         */
        private void ToggleAccountOptions(bool show) {
            lblAccountTitle.Visible = !lblAccountTitle.Visible;
            lbAccountTypes.Visible = !lbAccountTypes.Visible;

            if (show) {
                lbAccountTypes.Focus();
                if (lbAccountTypes.Items.Count < 1) {
                    lblAccountTitle.Text = _lang.GetOptionText();
                    foreach (var option in _lang.GetGuestOptions()) {
                        lbAccountTypes.Items.Add(option);
                    }
                }

                if (lbAccountTypes.Items.Count > 0) {
                    lbAccountTypes.SelectedIndex = 0;
                }
            }

        }

        private void ToggleLanguageScreen(bool show) {
            lbLanguages.Visible = !lbLanguages.Visible;
            lblLanguageTitle.Visible = !lblLanguageTitle.Visible;

            if (show) {
                pbHome.Visible = false;
                pbBack.Visible = false;
                lbLanguages.Focus();
                if (lbLanguages.Items.Count < 1) {
                    var tempString = "";
                    foreach (var language in _langList.GetAllLanguages()) {
                        lbLanguages.Items.Add(language);
                        tempString += language.GetStarterOption() + "\n";
                        lbLanguages.Location = new Point(lbLanguages.Location.X, lbLanguages.Location.Y + 19);
                    }

                    lblLanguageTitle.Text = tempString;
                }
                if (lbLanguages.Items.Count > 0) {
                    lbLanguages.SelectedIndex = 0;
                }
            }
        }

        private void ToggleJourneyOptions(bool show) {
            lblJourneyTitle.Visible = !lblJourneyTitle.Visible;
            lbJourneyType.Visible = !lbJourneyType.Visible;

            if (show) {
                lbJourneyType.Focus();
                if (lbJourneyType.Items.Count < 1) {
                    lblJourneyTitle.Text = _lang.GetOptionText();
                    foreach (var option in _lang.GetTicketType()) {
                        lbJourneyType.Items.Add(option);
                    }
                }
                if (lbJourneyType.Items.Count > 0) {
                    lbJourneyType.SelectedIndex = 0;
                }
            }
        }

        private void ToggleSingleJourney(bool show) {
            lblStartStation.Visible = !lblStartStation.Visible;
            lblEndStation.Visible = !lblEndStation.Visible;
            tbStartStation.Visible = !tbStartStation.Visible;
            tbEndStation.Visible = !tbEndStation.Visible;
            if (show) {
                tbStartStation.Focus();
                
            }
        }

        private void ToggleTimedPass(bool show) {
            nudTimedPass.Visible = !nudTimedPass.Visible;
            lblTimedPassTitle.Visible = !lblTimedPassTitle.Visible;
            lblNudQuantity.Visible = !lblNudQuantity.Visible;
            nudTicketQuantity.Visible = !nudTicketQuantity.Visible;
            if (show) {
                nudTimedPass.Focus();
                nudTimedPass.Value = 1;
                nudTicketQuantity.Value = 1;
            }
        }

        private void TogglePaymentScreen(bool show) {
            lblPaymentMethods.Visible = !lblPaymentMethods.Visible;
            lbPaymentMethods.Visible = !lbPaymentMethods.Visible;

            if (show) {
                lbPaymentMethods.Focus();
                if (lbPaymentMethods.Items.Count < 1) {
                    lblPaymentMethods.Text = _lang.GetPaymentOptions()[0];
                    foreach (var option in _lang.GetPaymentOptions().GetRange(1, _lang.GetPaymentOptions().Count - 1)) {
                        lbPaymentMethods.Items.Add(option);
                    }
                }
                if (lbPaymentMethods.Items.Count > 0) {
                    lbPaymentMethods.SelectedIndex = 0;
                }
            }
        }

        private void ToggleLoginScreen(bool show) {
            lblLoginScreen.Visible = !lblLoginScreen.Visible;
            lblUsername.Visible = !lblUsername.Visible;
            tbUsername.Visible = !tbUsername.Visible;
            lblPassword.Visible = !lblPassword.Visible;
            tbPassword.Visible = !tbPassword.Visible;

            if (show) {
                tbUsername.Focus();
                lblLoginScreen.Text = _lang.GetLoginText()[0];
                lblUsername.Text = _lang.GetLoginText()[1];
                lblPassword.Text = _lang.GetLoginText()[2];
            }
        }

        private async void FinalMessage() {
            lblFinalMessage.Visible = true;
            lblFinalMessage.Text = "";
            await Task.Delay(1000);
            foreach (var message in _lang.GetFinalMessage()) {
                lblFinalMessage.Text = message;
                await Task.Delay(3000);
            }
            lblFinalMessage.Visible = false;
            ToggleLanguageScreen(true);
        }



        /*
         * This is our own functions - not defined in the class diagram
         */
        private void SetupLanguages() {
            _langList = new LanguageList();
            _langList.AddLanguage(new Language("English",
                new List<string> { "Single Journey", "Timed Pass" },
                new List<string>(),
                new List<string> { "Continue as guest", "Continue to account" },
                new List<string>(),
                "Select a Language",
                new List<string> { "Pay by card", "Pay by cash", "Pay using balance" },
                new List<string> { "Printing tickets" },
                "Choose an option",
                new List<string> { "Enter login details", "Username", "Password" },
                new List<string> { "Top-up balance", "Print temporary pass", "Single Journey" }));

            _langList.AddLanguage(new Language("Deutsche",
                new List<string> { "Einzelreise", "Zeitmessung" },
                new List<string>(),
                new List<string> { "Weiter als Gast", "Weiter zum Konto" },
                new List<string>(),
                "Wähle eine Sprache",
                new List<string> { "Bezahlen mit Karte", "Bezahlen mit Bargeld", "Bezahlen mit Balance" },
                new List<string> { "Drucktickets" },
                "Wähle eine Option",
                new List<string> { "Login-Details eingeben", "Benutzername", "Passwort" },
                new List<string> { "Top-up balance", "Temporary Pass drucken", "Single Journey" }));

            _langList.AddLanguage(new Language("Español",
                new List<string> { "Viaje Único", "Pase de Tiempo" },
                new List<string>(),
                new List<string> { "Continuar como invitado", "Continuar a la cuenta" },
                new List<string>(),
                "Selecciona un idioma",
                new List<string> { "Pago por tarjeta", "Pago en efectivo", "Pago por saldo" },
                new List<string> { "Impresión de boletos" },
                "Escoge una opción",
                new List<string> { "Introduzca los datos de acceso", "Nombre de usuario", "Contraseña" },
                new List<string> { "Saldo complementario", "Pase impreso", "Viaje único" }));
                new List<string> { "Saldo complementario", "Pase impreso", "Viaje único" };
        }


        /*
         * Design Patterns
         * Listener for change of language.
         */
        private void SelectLanguage(object sender, EventArgs e) {
            _lang = (Language)lbLanguages.SelectedItem;
        }

        private void lbLanguages_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                SetActiveLanguage();
            }
        }

        private void lbAccountTypes_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                if (lbAccountTypes.SelectedIndex == 0) {
                    GuestLogin();
                } else if (lbAccountTypes.SelectedIndex == 1) {
                    Login();
                } else {
                    Login();
                }
            }
        }

        private void lbJourneyType_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                if (lbJourneyType.SelectedIndex == 0) {
                    DisplaySingleJourney();
                } else if (lbJourneyType.SelectedIndex == 1) {
                    DisplayTimedPass();
                } else {
                    throw new NotImplementedException();
                }
            }
        }

        private void nudTimedPass_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                DisplayPaymentOptions();
            }
        }

        private void nudTicketQuantity_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                DisplayPaymentOptions();
            }
        }

        private void lbPaymentMethods_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                if (lbPaymentMethods.SelectedIndex == 0) {
                    DisplayFinalMessage();
                } else if (lbPaymentMethods.SelectedIndex == 1) {
                    DisplayFinalMessage();
                } else {
                    throw new NotImplementedException();
                }
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e) {
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e) {
        }

        private void LoginToAccount(string username, string password) {
        }

        private void pbHome_Click(object sender, EventArgs e) {
            HideAll();

            ToggleLanguageScreen(true);
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
        }

        private void pbBack_Click(object sender, EventArgs e) {

        }
    }
}
