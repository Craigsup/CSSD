using System;
using System.Windows.Forms;

namespace ModifiedTicketingSystem {
    public partial class MoneyForm : Form {
        private TokenMachine _machine;
        private string _totalPrice;
        private Label _due;
        public MoneyForm(TokenMachine machine, string totalPrice, Label due) {
            InitializeComponent();
            _machine = machine;
            _totalPrice = totalPrice.Substring(1);
            _due = due;
        }

        protected void moneyButtonClick(object sender, EventArgs e) {
            Button button = sender as Button;
            bool result = _machine.MakeCashPayment(decimal.Parse(_totalPrice), decimal.Parse(button.Text.Substring(1)), _due);
            if (result) {
                //MessageBox.Show("PAID");
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
