using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace TicketingSystem {
    public partial class TokenMachineGUI : Form {
        private TokenMachine _machine;
        private Language _lang;
        private LanguageList _langList;
        private string[] stations = new string[2533];
        private int _account;
        private Stack<string> _actionStack = new Stack<string>();
        private List<int> nudAcceptedValues = new List<int>() { 1, 3, 5, 7, 10, 28 };


        private AccountList _accList;

        public TokenMachineGUI() {
            InitializeComponent();

            SetupFile();

            stations = System.IO.File.ReadAllLines(@"UK_TrainStations.txt");
            cbStartStation.DataSource = stations;
            cbEndStation.BindingContext = new BindingContext();
            cbEndStation.DataSource = stations;

            SetupLanguages();
            DisplayLangList();
        }

        private void SetupFile() {
            var rand = new Random();
            var acc1 = new CustomerAccount(rand.Next(1000000, 9999999), 0, 1, "Bob", "password", "Bob Hitler", false);
            var acc2 = new CustomerAccount(rand.Next(1000000, 9999999), 0, 2, "Rudy", "password", "Rudy Smeg", false);
            var acc3 = new CustomerAccount(rand.Next(1000000, 9999999), 0, 3, "Judy", "password", "Judy Spagghettio", false);
            var acc4 = new CustomerAccount(rand.Next(1000000, 9999999), 0, 4, "John", "password", "John Smith", false);
            var acc5 = new CustomerAccount(rand.Next(1000000, 9999999), 0, 5, "Clarence", "password", "Clarence Angel", false);

            AccountList accList = new AccountList();
            accList.AddCustomerAccount(acc1);
            accList.AddCustomerAccount(acc2);
            accList.AddCustomerAccount(acc3);
            accList.AddCustomerAccount(acc4);
            accList.AddCustomerAccount(acc5);

            //System.IO.File.WriteAllText(@"Accounts.txt", Newtonsoft.Json.JsonConvert.SerializeObject(accList));
            accList.SaveData();
            //accList.LoadData();
            _accList = accList;
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

        private void DisplayPaymentOptions2() {
            // Hide Single Journey Screen
            ToggleSingleJourney(false);

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
            // Show Login Screen
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
            if (_actionStack.Count > 0 && _actionStack.Peek() != "AccountOptions") {
                _actionStack.Push("AccountOptions");
            }
            lblAccountTitle.Visible = !lblAccountTitle.Visible;
            lbAccountTypes.Visible = !lbAccountTypes.Visible;
            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;

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
            if (_actionStack.Count == 0) {
                _actionStack.Push("LanguageScreen");
            }
            lbLanguages.Visible = !lbLanguages.Visible;
            lblLanguageTitle.Visible = !lblLanguageTitle.Visible;
            pbHome.Visible = false;
            pbBack.Visible = false;

            if (show) {
                pbHome.Visible = false;
                pbBack.Visible = false;
                lbLanguages.Focus();
                if (lbLanguages.Items.Count < 1) {
                    var tempString = "";
                    var gap = lbLanguages.Location.Y - lblLanguageTitle.Location.Y;
                    foreach (var language in _langList.GetAllLanguages()) {
                        lbLanguages.Items.Add(language);
                        //tempString += language.GetStarterOption() + "\n";
                        //lbLanguages.Location = new Point(lbLanguages.Location.X, lbLanguages.Location.Y + 19);
                    }

                    //lblLanguageTitle.Text = _lang.GetStarterOption();
                }
                if (lbLanguages.Items.Count > 0) {
                    lbLanguages.SelectedIndex = 0;
                }
            }
        }

        private void ToggleJourneyOptions(bool show) {
            if (_actionStack.Count > 0 && _actionStack.Peek() != "JourneyOptions") {
                _actionStack.Push("JourneyOptions");
            }
            lblJourneyTitle.Visible = !lblJourneyTitle.Visible;
            lbJourneyType.Visible = !lbJourneyType.Visible;
            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;

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
            if (_actionStack.Count > 0 && _actionStack.Peek() != "SingleJourney") {
                _actionStack.Push("SingleJourney");
            }
            lblStartStation.Visible = !lblStartStation.Visible;
            lblEndStation.Visible = !lblEndStation.Visible;
            lblSingleJourneyPrice.Visible = !lblSingleJourneyPrice.Visible;
            cbStartStation.Visible = !cbStartStation.Visible;
            cbEndStation.Visible = !cbEndStation.Visible;
            tbSingleJourneyPrice.Visible = !tbSingleJourneyPrice.Visible;
            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;

            if (show) {
                cbStartStation.Focus();

            }
        }

        private void ToggleTimedPass(bool show) {
            if (_actionStack.Count > 0 && _actionStack.Peek() != "TimedPass") {
                _actionStack.Push("TimedPass");
            }
            nudTimedPass.Visible = !nudTimedPass.Visible;
            lblTimedPassTitle.Visible = !lblTimedPassTitle.Visible;
            lblNudQuantity.Visible = !lblNudQuantity.Visible;
            nudTicketQuantity.Visible = !nudTicketQuantity.Visible;
            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;

            if (show) {
                nudTimedPass.Focus();
                nudTimedPass.Value = 1;
                nudTicketQuantity.Value = 1;
            }
        }

        private void TogglePaymentScreen(bool show) {
            if (_actionStack.Count > 0 && _actionStack.Peek() != "PaymentScreen") {
                _actionStack.Push("PaymentScreen");
            }

            lblPaymentMethods.Visible = !lblPaymentMethods.Visible;
            lbPaymentMethods.Visible = !lbPaymentMethods.Visible;
            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;

            if (show) {
                lbPaymentMethods.Focus();
                if (lbPaymentMethods.Items.Count < 1) {
                    lblPaymentMethods.Text = _lang.GetPaymentOptions()[0];
                    if (_account > -1) {
                        foreach (
                            var option in _lang.GetPaymentOptions().GetRange(1, _lang.GetPaymentOptions().Count - 1)) {
                            lbPaymentMethods.Items.Add(option);
                        }
                    }
                    else {
                        foreach (var option in _lang.GetPaymentOptions().GetRange(1, _lang.GetPaymentOptions().Count - 2)) {
                            lbPaymentMethods.Items.Add(option);
                        }
                    }
                }
                if (lbPaymentMethods.Items.Count > 0) {
                    lbPaymentMethods.SelectedIndex = 0;
                }
            }
        }

        private void ToggleLoginScreen(bool show) {
            if (_actionStack.Count > 0 && _actionStack.Peek() != "LoginScreen") {
                _actionStack.Push("LoginScreen");
            }
            lblLoginScreen.Visible = !lblLoginScreen.Visible;
            lblUsername.Visible = !lblUsername.Visible;
            tbUsername.Visible = !tbUsername.Visible;
            lblPassword.Visible = !lblPassword.Visible;
            tbPassword.Visible = !tbPassword.Visible;
            pbBack.Visible = !pbBack.Visible;
            pbHome.Visible = !pbHome.Visible;

            if (show) {
                tbUsername.Focus();
                lblLoginScreen.Text = _lang.GetLoginText()[0];
                lblUsername.Text = _lang.GetLoginText()[1];
                lblPassword.Text = _lang.GetLoginText()[2];
            }
        }

        private async void FinalMessage() {
            if (_actionStack.Count > 0 && _actionStack.Peek() != "FinalMessage") {
                _actionStack.Push("FinalMessage");
            }
            lblFinalMessage.Visible = true;
            lblFinalMessage.Text = "";
            await Task.Delay(1000);
            foreach (var message in _lang.GetFinalMessage()) {
                lblFinalMessage.Text = message;
                await Task.Delay(3000);
            }
            lblFinalMessage.Visible = false;
            ResetControls();
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
                new List<string> { "Select payment option", "Pay by card", "Pay by cash", "Pay using balance" },
                new List<string> { "Printing tickets" },
                "Choose an option",
                new List<string> { "Enter login details", "Username", "Password" },
                new List<string> { "Top-up balance", "Print temporary pass", "Single Journey" },
                new List<string> { "Pass Days", "Quantity" }));

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
                new List<string> { "Top-up balance", "Temporary Pass drucken", "Single Farht" },
                new List<string> { "Pass Tage", "Anzahl" }));

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
                new List<string> { "Saldo complementario", "Pase impreso", "Viaje único" },
                new List<string> { "Pasar días", "Cantidad" }));
        }


        /*
         * Design Patterns
         * Listener for change of language.
         */
        private void SelectLanguage(object sender, EventArgs e) {
            _lang = (Language)lbLanguages.SelectedItem;
            lblLanguageTitle.Text = _lang.GetStarterOption();
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
                    _account = -1;
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

        private void cbEndStation_KeyDown(object sender, KeyEventArgs e) {
            // Maybe change how to advance to payment screen - pressing enter is also how you pick the station in this combo box.
            if (e.KeyData == Keys.Enter) {
                DisplayPaymentOptions2();
            }
        }

        private void cbStartStation_SelectedIndexChanged(object sender, EventArgs e) {
            //Update price of ticket
            if (cbEndStation.SelectedText != null) {
                tbSingleJourneyPrice.Text = "£4.00";
            }
        }

        private void cbEndStation_SelectedIndexChanged(object sender, EventArgs e) {
            //Update price of ticket
            if (cbStartStation.SelectedText != null) {
                tbSingleJourneyPrice.Text = "£5.00";
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                if (tbUsername.Text != "" && tbPassword.Text != "") {
                    LoginToAccount(tbUsername.Text, tbPassword.Text);
                }
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                if (tbUsername.Text != "" && tbPassword.Text != "") {
                    LoginToAccount(tbUsername.Text, tbPassword.Text);
                }
            }
        }

        private void LoginToAccount(string username, string password) {
            _account = new CustomerAccount().VerifyLogin(username, password);
            if (_account > -1) {    
                // Log in successful. Do something.
                MessageBox.Show(this, "Succesfull");
                ConfigureGuiForLogin();
                ToggleLoginScreen(false);
                ToggleJourneyOptions(true);
            } else {
                // Log in is unsuccessful - show error.
                MessageBox.Show(this, "FAILURE KILL YOURSELF");
            }
        }

        private void ConfigureGuiForLogin() {
            PictureBox userPicture = new PictureBox();
            userPicture.Location = new Point(Width - 150, 15);
            userPicture.Image = (Image) Properties.Resources.ResourceManager.GetObject("_"+_account);
            userPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            userPicture.Size = new Size(38, 38);
            userPicture.Visible = true;
            Controls.Add(userPicture);
            Label userName = new Label();
            userName.Text = new CustomerAccount().GetXByAccountId<string>(_account, "username");
            userName.Location = new Point(Width - 150 + userPicture.Width+3, 15);
            userName.AutoSize = true;
            userPicture.Visible = true;
            Controls.Add(userName);
        }

        private void pbHome_Click(object sender, EventArgs e) {
            _actionStack.Clear();
            HideAll();

            ResetControls();
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

            foreach (var x in Controls.OfType<NumericUpDown>()) {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<ComboBox>()) {
                x.Visible = false;
            }
        }

        private void ResetControls() {
            foreach (var x in Controls.OfType<Button>()) {
                x.Text = "";
            }

            //foreach (var x in Controls.OfType<Label>()) {
                //x.Text = "";
            //}

            foreach (var x in Controls.OfType<TextBox>()) {
                x.Text = "";
            }

            foreach (var x in Controls.OfType<ListBox>()) {
                x.Items.Clear();
            }

            foreach (var x in Controls.OfType<NumericUpDown>()) {
                x.Value = 1;
            }

            foreach (var x in Controls.OfType<ComboBox>()) {
                // x.Items.Clear();
                // Cannot do this as it's bound by a datasource. Need to change the datasource to change the items in the combobox. 
                // So when changing language, set the new datasource.
            }

            foreach (var x in Controls.OfType<PictureBox>()) {
                if (x.Name.Contains("account")) {
                    Controls.Remove(x);
                    x.Dispose();
                }
            }
        }

        private void pbBack_Click(object sender, EventArgs e) {
            // Pop first to remove the page we are currently on. Then the next Pop is the actual page we want to return to.
            _actionStack.Pop();
            switch (_actionStack.Pop()) {
                case "LanguageScreen":
                    HideAll();
                    ResetControls();
                    ToggleLanguageScreen(true);
                    lbLanguages.Focus();
                    break;
                case "AccountOptions":
                    HideAll();
                    ToggleAccountOptions(false);
                    lbAccountTypes.Focus();
                    break;
                case "LoginScreen":
                    HideAll();
                    ToggleLoginScreen(false);
                    tbUsername.Focus();
                    break;
                case "JourneyOptions":
                    HideAll();
                    ToggleJourneyOptions(false);
                    lbJourneyType.Focus();
                    break;
                case "TimedPass":
                    HideAll();
                    ToggleTimedPass(false);
                    nudTimedPass.Focus();
                    break;
            }
        }

        private void nudTimedPass_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                DisplayPaymentOptions();
            }

            if (e.KeyData == Keys.Down) {
                int number = (int)nudTimedPass.Value;
                if (nudAcceptedValues.Contains(number)) {
                    var currentIndex = nudAcceptedValues.IndexOf(number) - 1;
                    nudTimedPass.Value =
                        nudAcceptedValues[currentIndex < 0 ? nudAcceptedValues.Count - 1 : currentIndex];
                }
            }
        }

        private void nudTimedPass_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Up) {
                int number = (int)nudTimedPass.Value;
                if (nudAcceptedValues.Contains(number)) {
                    var currentIndex = nudAcceptedValues.IndexOf(number)+1;
                    nudTimedPass.Value =
                        nudAcceptedValues[currentIndex >= nudAcceptedValues.Count ? 0 : currentIndex];
                }
            }
        }

        private void nudTimedPass_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                int number = (int)nudTimedPass.Value;
                if (nudAcceptedValues.Contains(number)) {
                    var currentIndex = nudAcceptedValues.IndexOf(number) + 1;
                    nudTimedPass.Value =
                        nudAcceptedValues[currentIndex >= nudAcceptedValues.Count ? 0 : currentIndex];
                }
            }
           
        }
    }
}
