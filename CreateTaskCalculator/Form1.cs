using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateTaskCalculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void numberButton_Click(object sender, EventArgs e) {
            int numBeingAdded = Convert.ToInt32((sender as Button).Text);
        }

        private void btEnter_Click(object sender, EventArgs e) {

        }

        private void btClear_Click(object sender, EventArgs e) {

        }

        private void btPlus_Click(object sender, EventArgs e) {

        }

        private void btMinus_Click(object sender, EventArgs e) {

        }

        private void btMultiply_Click(object sender, EventArgs e) {

        }

        private void btDivide_Click(object sender, EventArgs e) {

        }

        private void btPower_Click(object sender, EventArgs e) {

        }

        private void btSqrt_Click(object sender, EventArgs e) {

        }

        private void btHistory_Click(object sender, EventArgs e) {

        }
    }
}
