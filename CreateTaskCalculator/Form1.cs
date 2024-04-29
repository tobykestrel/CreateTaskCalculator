/*
 * All code in the following program was written by myself without outside help from peers or AI
 * All components of the design are built with the .NET toolbox provided by Visual Studio
 */


using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CreateTaskCalculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        public List<string> historyList = new List<string>();
        string num1_S = "";
        string numOperator = "";
        string num2_S = "";
        string result_S = "";

        private void updateDisplay() {
            rtbIO.Text = num1_S + " " + numOperator + " " + num2_S;
        }
        private void resetOperationVariables() {
            num1_S = "";
            numOperator = "";
            num2_S = "";
            result_S = "";
        }

        private void numberButton_Click(object sender, EventArgs e) {
            string newNum = (sender as Button).Text;
            if (numOperator == "") {
                num1_S += newNum;
            } else {
                num2_S += newNum;
            }
            updateDisplay();
        }

        private void operatorButton_Click(object sender, EventArgs e) {
            if (num1_S != "" && num2_S == "") {
                numOperator = (sender as Button).Text;
                updateDisplay();
            }
        }

        private void btEnter_Click(object sender, EventArgs e) {
            if (num2_S != "") {
                decimal num1_D = Convert.ToDecimal(num1_S);
                decimal num2_D = Convert.ToDecimal(num2_S);
                decimal result_D = 0;
                switch (numOperator) {
                    case "+": result_D = num1_D + num2_D; break;
                    case "-": result_D = num1_D - num2_D; break;
                    case "×": result_D = num1_D * num2_D; break;
                    case "÷": result_D = num1_D / num2_D; break;
                }
                result_S = Convert.ToString(result_D);
                rtbIO.Text = result_S;
                historyList.Add(num1_S + " " + numOperator + " " + num2_S + " = " + result_S);
                resetOperationVariables();
            }
        }

        private void btClear_Click(object sender, EventArgs e) {
            resetOperationVariables();
            updateDisplay();
        }

        private void btHistory_Click(object sender, EventArgs e) {
            if (num1_S == "") {
                rtbIO.Text = "";
            }
            Form2 f = new Form2(this);
            f.Show();
        }

        private void btNegative_Click(object sender, EventArgs e) {
            if (num1_S == "") {
                num1_S += "-";
                updateDisplay();
            } else if (numOperator != "" && num2_S == "") {
                num2_S += "-";
                updateDisplay();
            }
        }

        private void btDecimal_Click(object sender, EventArgs e) {
            if (numOperator == "") {
                num1_S += ".";
            } else {
                num2_S += ".";
            }
            updateDisplay();
        }
    }
}
