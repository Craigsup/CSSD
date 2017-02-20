using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketingSystem {
    public partial class MoneyForm : Form {
        private TokenMachine _machine;
        private string _totalPrice;
        private Label _due;
        public MoneyForm(TokenMachine machine, string totalPrice, Label due) {
            InitializeComponent();
            _machine = machine;
            _totalPrice = totalPrice;
            _due = due;
        }

        protected void moneyButtonClick(object sender, EventArgs e) {
            Button button = sender as Button;
            bool result = _machine.MakeCashPayment(decimal.Parse(_totalPrice), decimal.Parse(button.Text.Substring(1)), _due);
            if (result) {
                //MessageBox.Show("PAID");
                Close();
            }
        }
    }
}
