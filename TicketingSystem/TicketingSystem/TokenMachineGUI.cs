using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace TicketingSystem {
    public partial class TokenMachineGUI : Form {
        private TokenMachine _machine;
        private Language _lang;
        private LanguageList _langList;

        public TokenMachineGUI() {
            InitializeComponent();
            SetupLanguages();
            DisplayLangList();
        }

        private void DisplayLangList() {
            // Show Select Option Screen
            ToggleLanguageScreen(true);
        }

        private void SetActiveLanguage() {
            DisplayStartOptions();
        }

        private void DisplayStartOptions() {
            // Hide Select Option Screen
            ToggleLanguageScreen(false);

            // Show Select Account Screen
            ToggleAccountOptions(true);
        }


        private void Login() {
            // Hide Select Account Screen
            //ToggleAccountOptions(false);

            
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

        private void DisplayTimedPass() {
            ToggleTimedPass(true);
        }

        private void DisplayPaymentOptions() {

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

        private void FinalMessage() {

        }

        /*
         * Custom Toggle Functions to simplify screens
         */
        private void ToggleAccountOptions(bool show) {
            lblAccountTitle.Visible = !lblAccountTitle.Visible;
            lbAccountTypes.Visible = !lbAccountTypes.Visible;

            if (show) {
                lbAccountTypes.Focus();
                lblAccountTitle.Text = _lang.GetOptionText();
                foreach (var option in _lang.GetGuestOptions()) {
                    lbAccountTypes.Items.Add(option);
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
                var tempString = "";
                foreach (var language in _langList.GetAllLanguages()) {
                    lbLanguages.Items.Add(language);
                    tempString += language.GetStarterOption() + "\n";
                    lbLanguages.Location = new Point(lbLanguages.Location.X, lbLanguages.Location.Y + 19);
                }

                lblLanguageTitle.Text = tempString;

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
                lblJourneyTitle.Text = _lang.GetOptionText();
                foreach (var option in _lang.GetTicketType()) {
                    lbJourneyType.Items.Add(option);
                }

                if (lbJourneyType.Items.Count > 0) {
                    lbJourneyType.SelectedIndex = 0;
                }
            }
        }

        private void ToggleTimedPass(bool show) {
            lbJourneyType.Visible = !lbJourneyType.Visible;
            lblJourneyTitle.Visible = !lblJourneyTitle.Visible;

            if (show) {
                nudTimedPass.Visible = !nudTimedPass.Visible;
                lblTimedPassTitle.Visible = !lblTimedPassTitle.Visible;
                nudTimedPass.Focus();
            }
        }



        /*
         * This is our own functions - not defined in the class diagram
         */
         private void SetupLanguages() {
            _langList = new LanguageList();
            _langList.AddLanguage( new Language("English",
                new List<string> {"Single Journey", "Timed Pass"},
                new List<string>(),
                new List<string> {"Continue as guest", "Continue to account"},
                new List<string>(),
                "Select a Language",
                new List<string> {"Pay by card", "Pay by cash", "Pay using balance"},
                new List<string> {"Printing tickets"},
                "Choose an option"));

            _langList.AddLanguage(new Language("Deutsche",
                new List<string> { "Einzelreise", "Zeitmessung" },
                new List<string>(),
                new List<string> { "Weiter als Gast", "Weiter zum Konto" },
                new List<string>(),
                "Wähle eine Sprache",
                new List<string> { "Bezahlen mit Karte", "Bezahlen mit Bargeld", "Bezahlen mit Balance" },
                new List<string> { "Drucktickets" },
                "Wähle eine Option"));

            _langList.AddLanguage(new Language("Español",
                new List<string> { "Viaje Único", "Pase de Tiempo" },
                new List<string>(),
                new List<string> { "Continuar como invitado", "Continuar a la cuenta" },
                new List<string>(),
                "Selecciona un idioma",
                new List<string> { "Pago por tarjeta", "Pago en efectivo", "Pago por saldo" },
                new List<string> { "Impresión de boletos" },
                "Escoge una opción"));
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

                } else if (lbJourneyType.SelectedIndex == 1) {
                    DisplayTimedPass();
                } else {
                    throw new NotImplementedException();
                }
            }
        }

        private void nudTimedPass_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                
            }
        }
    }
}
