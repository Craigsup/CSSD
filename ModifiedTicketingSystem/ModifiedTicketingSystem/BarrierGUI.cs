using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModifiedTicketingSystem.Properties;

namespace ModifiedTicketingSystem {
    public partial class BarrierGUI : Form {
        private Scanner _scanner;
        private Barrier _barrier;

        public BarrierGUI() {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            if (tbTicketId.Text != "") {
                bool type = _scanner.GetScannerType();
                if (type == true) {
                    Station station = _scanner.GetStation();
                    //_scanner.ValidateTicket();
                } else {

                }
            }
        }
    }
}
