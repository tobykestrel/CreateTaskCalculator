namespace CreateTaskCalculator {
    partial class CalculatorHistory {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.rtbHistoryDisplay = new System.Windows.Forms.RichTextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btClearHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbHistoryDisplay
            // 
            this.rtbHistoryDisplay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbHistoryDisplay.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHistoryDisplay.Location = new System.Drawing.Point(12, 12);
            this.rtbHistoryDisplay.Name = "rtbHistoryDisplay";
            this.rtbHistoryDisplay.Size = new System.Drawing.Size(403, 465);
            this.rtbHistoryDisplay.TabIndex = 1;
            this.rtbHistoryDisplay.Text = "";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.LightGray;
            this.btClose.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(13, 483);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(198, 85);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btClearHistory
            // 
            this.btClearHistory.BackColor = System.Drawing.Color.LightGray;
            this.btClearHistory.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClearHistory.Location = new System.Drawing.Point(217, 483);
            this.btClearHistory.Name = "btClearHistory";
            this.btClearHistory.Size = new System.Drawing.Size(198, 85);
            this.btClearHistory.TabIndex = 3;
            this.btClearHistory.Text = "Clear History";
            this.btClearHistory.UseVisualStyleBackColor = false;
            this.btClearHistory.Click += new System.EventHandler(this.btClearHistory_Click);
            // 
            // CalculatorHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 580);
            this.Controls.Add(this.btClearHistory);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.rtbHistoryDisplay);
            this.Name = "CalculatorHistory";
            this.Text = "Calculator History";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbHistoryDisplay;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btClearHistory;
    }
}