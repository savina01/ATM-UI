namespace ATM2
{
    partial class Page3
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
            this.panelPage3 = new System.Windows.Forms.Panel();
            this.labelPage3 = new System.Windows.Forms.Label();
            this.labelAccountType = new System.Windows.Forms.Label();
            this.groupBoxAccountTupe = new System.Windows.Forms.GroupBox();
            this.radioButtonSaving = new System.Windows.Forms.RadioButton();
            this.radioButtonCurrentAccount = new System.Windows.Forms.RadioButton();
            this.radioButtonFixedDepositAccount = new System.Windows.Forms.RadioButton();
            this.radioButtonRecurring = new System.Windows.Forms.RadioButton();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.labelYour16digit = new System.Windows.Forms.Label();
            this.labelPIN = new System.Windows.Forms.Label();
            this.labelYour4digit = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.checkedListBoxService = new System.Windows.Forms.CheckedListBox();
            this.checkBoxDeclare = new System.Windows.Forms.CheckBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelPage3.SuspendLayout();
            this.groupBoxAccountTupe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPage3
            // 
            this.panelPage3.BackColor = System.Drawing.Color.White;
            this.panelPage3.Controls.Add(this.button1);
            this.panelPage3.Controls.Add(this.buttonSubmit);
            this.panelPage3.Controls.Add(this.checkBoxDeclare);
            this.panelPage3.Controls.Add(this.checkedListBoxService);
            this.panelPage3.Controls.Add(this.labelService);
            this.panelPage3.Controls.Add(this.labelYour4digit);
            this.panelPage3.Controls.Add(this.labelPIN);
            this.panelPage3.Controls.Add(this.labelYour16digit);
            this.panelPage3.Controls.Add(this.labelCardNumber);
            this.panelPage3.Controls.Add(this.groupBoxAccountTupe);
            this.panelPage3.Controls.Add(this.labelAccountType);
            this.panelPage3.Controls.Add(this.labelPage3);
            this.panelPage3.Location = new System.Drawing.Point(124, 61);
            this.panelPage3.Name = "panelPage3";
            this.panelPage3.Size = new System.Drawing.Size(508, 565);
            this.panelPage3.TabIndex = 0;
            // 
            // labelPage3
            // 
            this.labelPage3.AutoSize = true;
            this.labelPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPage3.Location = new System.Drawing.Point(148, 39);
            this.labelPage3.Name = "labelPage3";
            this.labelPage3.Size = new System.Drawing.Size(209, 20);
            this.labelPage3.TabIndex = 0;
            this.labelPage3.Text = "Page 3: Account details";
            // 
            // labelAccountType
            // 
            this.labelAccountType.AutoSize = true;
            this.labelAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccountType.Location = new System.Drawing.Point(54, 73);
            this.labelAccountType.Name = "labelAccountType";
            this.labelAccountType.Size = new System.Drawing.Size(129, 20);
            this.labelAccountType.TabIndex = 1;
            this.labelAccountType.Text = "Account Type:";
            // 
            // groupBoxAccountTupe
            // 
            this.groupBoxAccountTupe.Controls.Add(this.radioButtonRecurring);
            this.groupBoxAccountTupe.Controls.Add(this.radioButtonFixedDepositAccount);
            this.groupBoxAccountTupe.Controls.Add(this.radioButtonCurrentAccount);
            this.groupBoxAccountTupe.Controls.Add(this.radioButtonSaving);
            this.groupBoxAccountTupe.Location = new System.Drawing.Point(58, 96);
            this.groupBoxAccountTupe.Name = "groupBoxAccountTupe";
            this.groupBoxAccountTupe.Size = new System.Drawing.Size(398, 90);
            this.groupBoxAccountTupe.TabIndex = 2;
            this.groupBoxAccountTupe.TabStop = false;
            // 
            // radioButtonSaving
            // 
            this.radioButtonSaving.AutoSize = true;
            this.radioButtonSaving.Location = new System.Drawing.Point(6, 11);
            this.radioButtonSaving.Name = "radioButtonSaving";
            this.radioButtonSaving.Size = new System.Drawing.Size(121, 20);
            this.radioButtonSaving.TabIndex = 0;
            this.radioButtonSaving.TabStop = true;
            this.radioButtonSaving.Text = "Saving Account";
            this.radioButtonSaving.UseVisualStyleBackColor = true;
            // 
            // radioButtonCurrentAccount
            // 
            this.radioButtonCurrentAccount.AutoSize = true;
            this.radioButtonCurrentAccount.Location = new System.Drawing.Point(6, 61);
            this.radioButtonCurrentAccount.Name = "radioButtonCurrentAccount";
            this.radioButtonCurrentAccount.Size = new System.Drawing.Size(121, 20);
            this.radioButtonCurrentAccount.TabIndex = 1;
            this.radioButtonCurrentAccount.TabStop = true;
            this.radioButtonCurrentAccount.Text = "Current Account";
            this.radioButtonCurrentAccount.UseVisualStyleBackColor = true;
            // 
            // radioButtonFixedDepositAccount
            // 
            this.radioButtonFixedDepositAccount.AutoSize = true;
            this.radioButtonFixedDepositAccount.Location = new System.Drawing.Point(205, 11);
            this.radioButtonFixedDepositAccount.Name = "radioButtonFixedDepositAccount";
            this.radioButtonFixedDepositAccount.Size = new System.Drawing.Size(162, 20);
            this.radioButtonFixedDepositAccount.TabIndex = 2;
            this.radioButtonFixedDepositAccount.TabStop = true;
            this.radioButtonFixedDepositAccount.Text = "Fixed Deposit Account";
            this.radioButtonFixedDepositAccount.UseVisualStyleBackColor = true;
            // 
            // radioButtonRecurring
            // 
            this.radioButtonRecurring.AutoSize = true;
            this.radioButtonRecurring.Location = new System.Drawing.Point(205, 61);
            this.radioButtonRecurring.Name = "radioButtonRecurring";
            this.radioButtonRecurring.Size = new System.Drawing.Size(187, 20);
            this.radioButtonRecurring.TabIndex = 3;
            this.radioButtonRecurring.TabStop = true;
            this.radioButtonRecurring.Text = "Recurring Deposti Account";
            this.radioButtonRecurring.UseVisualStyleBackColor = true;
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCardNumber.Location = new System.Drawing.Point(54, 209);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(126, 20);
            this.labelCardNumber.TabIndex = 3;
            this.labelCardNumber.Text = "Card Number:";
            // 
            // labelYour16digit
            // 
            this.labelYour16digit.AutoSize = true;
            this.labelYour16digit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYour16digit.Location = new System.Drawing.Point(55, 229);
            this.labelYour16digit.Name = "labelYour16digit";
            this.labelYour16digit.Size = new System.Drawing.Size(186, 17);
            this.labelYour16digit.TabIndex = 4;
            this.labelYour16digit.Text = "(Your 16 digit Card Number)";
            // 
            // labelPIN
            // 
            this.labelPIN.AutoSize = true;
            this.labelPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPIN.Location = new System.Drawing.Point(54, 256);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(45, 20);
            this.labelPIN.TabIndex = 5;
            this.labelPIN.Text = "PIN:";
            // 
            // labelYour4digit
            // 
            this.labelYour4digit.AutoSize = true;
            this.labelYour4digit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYour4digit.Location = new System.Drawing.Point(55, 276);
            this.labelYour4digit.Name = "labelYour4digit";
            this.labelYour4digit.Size = new System.Drawing.Size(154, 17);
            this.labelYour4digit.TabIndex = 6;
            this.labelYour4digit.Text = "(Your 4 digit password)";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelService.Location = new System.Drawing.Point(54, 313);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(159, 20);
            this.labelService.TabIndex = 7;
            this.labelService.Text = "Service Required:";
            // 
            // checkedListBoxService
            // 
            this.checkedListBoxService.FormattingEnabled = true;
            this.checkedListBoxService.Items.AddRange(new object[] {
            "ATM CARD",
            "Mobile Banking",
            "Cheque Book",
            "Internet Banking",
            "Email Alerts",
            "E-Statement"});
            this.checkedListBoxService.Location = new System.Drawing.Point(58, 336);
            this.checkedListBoxService.Name = "checkedListBoxService";
            this.checkedListBoxService.Size = new System.Drawing.Size(393, 106);
            this.checkedListBoxService.TabIndex = 8;
            // 
            // checkBoxDeclare
            // 
            this.checkBoxDeclare.AutoSize = true;
            this.checkBoxDeclare.Location = new System.Drawing.Point(22, 468);
            this.checkBoxDeclare.Name = "checkBoxDeclare";
            this.checkBoxDeclare.Size = new System.Drawing.Size(471, 20);
            this.checkBoxDeclare.TabIndex = 9;
            this.checkBoxDeclare.Text = "I hareby declare that the above details correct to the best of my knowledge.";
            this.checkBoxDeclare.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Black;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(282, 503);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(97, 41);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(385, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Page3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(756, 693);
            this.Controls.Add(this.panelPage3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Page3";
            this.Text = "Page3";
            this.panelPage3.ResumeLayout(false);
            this.panelPage3.PerformLayout();
            this.groupBoxAccountTupe.ResumeLayout(false);
            this.groupBoxAccountTupe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPage3;
        private System.Windows.Forms.Label labelPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.CheckBox checkBoxDeclare;
        private System.Windows.Forms.CheckedListBox checkedListBoxService;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelYour4digit;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.Label labelYour16digit;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.GroupBox groupBoxAccountTupe;
        private System.Windows.Forms.RadioButton radioButtonRecurring;
        private System.Windows.Forms.RadioButton radioButtonFixedDepositAccount;
        private System.Windows.Forms.RadioButton radioButtonCurrentAccount;
        private System.Windows.Forms.RadioButton radioButtonSaving;
        private System.Windows.Forms.Label labelAccountType;
    }
}