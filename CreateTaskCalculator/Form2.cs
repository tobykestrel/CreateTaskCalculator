using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CreateTaskCalculator {
    public partial class Form2 : Form {
        private Form1 mainForm = null;
        public Form2(Form callingForm) {
            mainForm = callingForm as Form1;
            InitializeComponent();
            displayHistory(this.mainForm.historyList);
        }

        private void displayHistory(List<string> historyData) {
            for (int i = historyData.Count - 1; i >= 0; i--) {
                if (i > historyData.Count - 6) {
                    rtbHistoryDisplay.Text += (historyData.Count - i) + ".\n" +
                        historyData[i] + "\n-------------------------------\n";
                } else { rtbHistoryDisplay.Text += historyData[i] + "\n"; }
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
