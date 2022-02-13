namespace ATM2
{
    partial class Transaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDeposit = new System.Windows.Forms.Panel();
            this.labelTransaction = new System.Windows.Forms.Label();
            this.labelPleaseSelect = new System.Windows.Forms.Label();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonFastCash = new System.Windows.Forms.Button();
            this.buttonCashWithdrawl = new System.Windows.Forms.Button();
            this.buttonMiniStatemnet = new System.Windows.Forms.Button();
            this.buttonPinChange = new System.Windows.Forms.Button();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDeposit
            // 
            this.panelDeposit.BackColor = System.Drawing.Color.White;
            this.panelDeposit.Controls.Add(this.buttonExit);
            this.panelDeposit.Controls.Add(this.buttonBalance);
            this.panelDeposit.Controls.Add(this.buttonPinChange);
            this.panelDeposit.Controls.Add(this.buttonMiniStatemnet);
            this.panelDeposit.Controls.Add(this.buttonCashWithdrawl);
            this.panelDeposit.Controls.Add(this.buttonFastCash);
            this.panelDeposit.Controls.Add(this.buttonDeposit);
            this.panelDeposit.Controls.Add(this.labelPleaseSelect);
            this.panelDeposit.Controls.Add(this.labelTransaction);
            this.panelDeposit.Location = new System.Drawing.Point(166, 102);
            this.panelDeposit.Name = "panelDeposit";
            this.panelDeposit.Size = new System.Drawing.Size(488, 391);
            this.panelDeposit.TabIndex = 1;
            // 
            // labelTransaction
            // 
            this.labelTransaction.AutoSize = true;
            this.labelTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTransaction.Location = new System.Drawing.Point(165, 32);
            this.labelTransaction.Name = "labelTransaction";
            this.labelTransaction.Size = new System.Drawing.Size(138, 20);
            this.labelTransaction.TabIndex = 1;
            this.labelTransaction.Text = "TRANSACTION";
            // 
            // labelPleaseSelect
            // 
            this.labelPleaseSelect.AutoSize = true;
            this.labelPleaseSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPleaseSelect.Location = new System.Drawing.Point(138, 67);
            this.labelPleaseSelect.Name = "labelPleaseSelect";
            this.labelPleaseSelect.Size = new System.Drawing.Size(202, 17);
            this.labelPleaseSelect.TabIndex = 2;
            this.labelPleaseSelect.Text = "Please select your transaction:";
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.Color.Black;
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeposit.ForeColor = System.Drawing.Color.White;
            this.buttonDeposit.Location = new System.Drawing.Point(36, 108);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(194, 40);
            this.buttonDeposit.TabIndex = 3;
            this.buttonDeposit.Text = "DEPOSIT";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            // 
            // buttonFastCash
            // 
            this.buttonFastCash.BackColor = System.Drawing.Color.Black;
            this.buttonFastCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFastCash.ForeColor = System.Drawing.Color.White;
            this.buttonFastCash.Location = new System.Drawing.Point(36, 172);
            this.buttonFastCash.Name = "buttonFastCash";
            this.buttonFastCash.Size = new System.Drawing.Size(194, 40);
            this.buttonFastCash.TabIndex = 4;
            this.buttonFastCash.Text = "FAST CASH";
            this.buttonFastCash.UseVisualStyleBackColor = false;
            // 
            // buttonCashWithdrawl
            // 
            this.buttonCashWithdrawl.BackColor = System.Drawing.Color.Black;
            this.buttonCashWithdrawl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCashWithdrawl.ForeColor = System.Drawing.Color.White;
            this.buttonCashWithdrawl.Location = new System.Drawing.Point(251, 108);
            this.buttonCashWithdrawl.Name = "buttonCashWithdrawl";
            this.buttonCashWithdrawl.Size = new System.Drawing.Size(194, 40);
            this.buttonCashWithdrawl.TabIndex = 5;
            this.buttonCashWithdrawl.Text = "CASH WITHDRAWL";
            this.buttonCashWithdrawl.UseVisualStyleBackColor = false;
            // 
            // buttonMiniStatemnet
            // 
            this.buttonMiniStatemnet.BackColor = System.Drawing.Color.Black;
            this.buttonMiniStatemnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMiniStatemnet.ForeColor = System.Drawing.Color.White;
            this.buttonMiniStatemnet.Location = new System.Drawing.Point(251, 172);
            this.buttonMiniStatemnet.Name = "buttonMiniStatemnet";
            this.buttonMiniStatemnet.Size = new System.Drawing.Size(194, 40);
            this.buttonMiniStatemnet.TabIndex = 6;
            this.buttonMiniStatemnet.Text = "MINI STATEMENT";
            this.buttonMiniStatemnet.UseVisualStyleBackColor = false;
            // 
            // buttonPinChange
            // 
            this.buttonPinChange.BackColor = System.Drawing.Color.Black;
            this.buttonPinChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPinChange.ForeColor = System.Drawing.Color.White;
            this.buttonPinChange.Location = new System.Drawing.Point(36, 239);
            this.buttonPinChange.Name = "buttonPinChange";
            this.buttonPinChange.Size = new System.Drawing.Size(194, 40);
            this.buttonPinChange.TabIndex = 7;
            this.buttonPinChange.Text = "PIN CHANGE";
            this.buttonPinChange.UseVisualStyleBackColor = false;
            // 
            // buttonBalance
            // 
            this.buttonBalance.BackColor = System.Drawing.Color.Black;
            this.buttonBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBalance.ForeColor = System.Drawing.Color.White;
            this.buttonBalance.Location = new System.Drawing.Point(251, 239);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(194, 40);
            this.buttonBalance.TabIndex = 8;
            this.buttonBalance.Text = "BALANCE";
            this.buttonBalance.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Black;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(146, 309);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(194, 40);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(820, 594);
            this.Controls.Add(this.panelDeposit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.panelDeposit.ResumeLayout(false);
            this.panelDeposit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDeposit;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.Button buttonPinChange;
        private System.Windows.Forms.Button buttonMiniStatemnet;
        private System.Windows.Forms.Button buttonCashWithdrawl;
        private System.Windows.Forms.Button buttonFastCash;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Label labelPleaseSelect;
        private System.Windows.Forms.Label labelTransaction;
    }
}