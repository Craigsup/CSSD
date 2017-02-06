using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace TicketingSystem {
    public partial class MobileAppGUI : Form {
        private MobileApp _app;
        private int _account;
        
        public MobileAppGUI() {
            InitializeComponent();

            lblLogin.Visible = true;
            tbPassword.Visible = true;
            tbUsername.Visible = true;
            lblPassword.Visible = true;
            lblUsername.Visible = true;
            btnLogin.Visible = true;
            btnOpenMenu.Visible = false;
            tbPassword.Text = "password";
            tbUsername.Text = "Bob";


            //ShowLogin();
        }

        private void ShowLogin() {
            // Show login screen
            ToggleLoginScreen();

        }


        private void ShowHome() {
            lblHome.Visible = true;
            btnOpenMenu.Visible = true;
            lblWelcome.Visible = true;
            lblUser.Visible = true;
        }
        private void ShowBalance()
        {
            lblBalance.Visible = true;
            btnOpenMenu.Visible = true;
            lblBalanceValue.Visible = true;
            lblBalanceValue.Text = "£"+new CustomerAccount().GetXByAccountId<float>(_account, "balance").ToString();

        }
        private void ShowTopUp()
        {
            lblTopUp.Visible = true;
            btnOpenMenu.Visible = true;

            btnTopUp.Visible = true;
            tbTopUp.Visible = true;
        }

        /*
        * Custom Toggle Functions to simplify screens
        */

        private void ToggleLoginScreen() {
            lblLogin.Visible = !lblLogin.Visible;
            tbPassword.Visible = !tbPassword.Visible;
            tbUsername.Visible = !tbUsername.Visible;
            lblPassword.Visible = !lblPassword.Visible;
            lblUsername.Visible = !lblUsername.Visible;
            btnLogin.Visible = !btnLogin.Visible;
            btnOpenMenu.Visible = !btnOpenMenu.Visible;
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            LoginToAccount(tbUsername.Text, tbPassword.Text);
        }




        private void HideAll()
        {
            foreach (var x in Controls.OfType<Button>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<Label>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<PictureBox>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<TextBox>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<ListBox>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<NumericUpDown>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<ComboBox>())
            {
                x.Visible = false;
            }

            foreach (var x in Controls.OfType<Panel>())
            {
                x.Visible = false;
            }

            pnlMenu.Width = 0;
        }

        private void LoginToAccount(string username, string password)
        {
            _account = new CustomerAccount().VerifyLogin(username, password);
            lblUser.Text = username;
            if (_account > -1)
            {
                // Hide login screen
                ToggleLoginScreen();

                //Show Home Screen
                ShowHome();


                // Log in successful. Do something.
            }
            else
            {
                // Log in is unsuccessful - show error.
            }
        }

        private void btnOpenMenu_Click(object sender, System.EventArgs e)
        {
            btnOpenMenu.Visible = false;
            pnlMenu.Visible = true;
            for (int i = 0; i < 100;i++) {
                pnlMenu.Width = pnlMenu.Width + 1;
                //await Task.Delay(10);

            }
            lblNavHome.Visible = true;
            lblNavBalance.Visible = true;
            lblNavTopUp.Visible = true;
            btnCloseMenu.Visible = true;
        }

        private void btnCloseMenu_Click(object sender, System.EventArgs e)
        {
            btnCloseMenu.Visible = false;
            for (int i = 0; i < 100; i++)
            {
                pnlMenu.Width = pnlMenu.Width - 1;
                //await Task.Delay(10);

            }
            lblNavHome.Visible = false;
            lblNavBalance.Visible = false;
            lblNavTopUp.Visible = false;
            pnlMenu.Visible = false;
            btnOpenMenu.Visible = true;
        }

        private void lblNavHome_Click(object sender, System.EventArgs e)
        {
            HideAll();
            ShowHome();
        }

        private void lblNavBalance_Click(object sender, System.EventArgs e)
        {
            HideAll();
            ShowBalance();
        }

        private void lblNavTopUp_Click(object sender, System.EventArgs e)
        {
            HideAll();
            ShowTopUp();
        }

        private void tbTopUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblPayment.Visible = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbTopUp_KeyUp(object sender, KeyEventArgs e)
        {
            var indexOfDecimal = ((sender as TextBox).Text.IndexOf('.'));

            if (indexOfDecimal > 0 && (sender as TextBox).Text.Length > indexOfDecimal + 3)
            {
                tbTopUp.Text = tbTopUp.Text.Substring(0, tbTopUp.Text.Length - 1);
                tbTopUp.SelectionStart = tbTopUp.Text.Length;
            }

        }

        private void btnTopUp_Click(object sender, System.EventArgs e)
        {
            new CustomerAccount().TopUpBalance(_account, float.Parse(tbTopUp.Text));
            tbTopUp.Text = "";
            lblPayment.Visible = true;
        }
    }
}
