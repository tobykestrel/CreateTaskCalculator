using System;
using System.Windows.Forms;

namespace CreateTaskCalculator {
    public partial class Form2 : Form {
        private Form1 mainForm = null;
        public Form2(Form callingForm) {
            mainForm = callingForm as Form1;
            InitializeComponent();
            for (int i = this.mainForm.historyList.Count - 1; i >= 0; i--) {
                if (i > this.mainForm.historyList.Count - 6) {
                    rtbHistoryDisplay.Text += (this.mainForm.historyList.Count - i) + ".\n" +
                        this.mainForm.historyList[i] + "\n-------------------------------\n";
                } else {
                    rtbHistoryDisplay.Text += this.mainForm.historyList[i] + "\n";
                }
            }
        }

        private void btClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btClearHistory_Click(object sender, EventArgs e) {
            this.mainForm.historyList.Clear();
            rtbHistoryDisplay.Text = "";
        }
    }
}
