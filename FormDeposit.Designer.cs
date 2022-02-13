namespace ATM2
{
    partial class FormDeposit
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
            this.labelDeposit = new System.Windows.Forms.Label();
            this.labelEnterAmount = new System.Windows.Forms.Label();
            this.textBoxDeposit = new System.Windows.Forms.TextBox();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDeposit
            // 
            this.panelDeposit.BackColor = System.Drawing.Color.White;
            this.panelDeposit.Controls.Add(this.buttonExit);
            this.panelDeposit.Controls.Add(this.buttonBack);
            this.panelDeposit.Controls.Add(this.buttonDeposit);
            this.panelDeposit.Controls.Add(this.textBoxDeposit);
            this.panelDeposit.Controls.Add(this.labelEnterAmount);
            this.panelDeposit.Controls.Add(this.labelDeposit);
            this.panelDeposit.Location = new System.Drawing.Point(128, 58);
            this.panelDeposit.Name = "panelDeposit";
            this.panelDeposit.Size = new System.Drawing.Size(488, 391);
            this.panelDeposit.TabIndex = 0;
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeposit.Location = new System.Drawing.Point(209, 19);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(74, 20);
            this.labelDeposit.TabIndex = 0;
            this.labelDeposit.Text = "Deposit";
            // 
            // labelEnterAmount
            // 
            this.labelEnterAmount.AutoSize = true;
            this.labelEnterAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnterAmount.Location = new System.Drawing.Point(66, 102);
            this.labelEnterAmount.Name = "labelEnterAmount";
            this.labelEnterAmount.Size = new System.Drawing.Size(374, 20);
            this.labelEnterAmount.TabIndex = 1;
            this.labelEnterAmount.Text = "ENTER AMOUNT YOU WANT TO DEPOSIT";
            // 
            // textBoxDeposit
            // 
            this.textBoxDeposit.Location = new System.Drawing.Point(70, 142);
            this.textBoxDeposit.Multiline = true;
            this.textBoxDeposit.Name = "textBoxDeposit";
            this.textBoxDeposit.Size = new System.Drawing.Size(370, 53);
            this.textBoxDeposit.TabIndex = 2;
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.Color.Black;
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeposit.ForeColor = System.Drawing.Color.White;
            this.buttonDeposit.Location = new System.Drawing.Point(70, 226);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(370, 38);
            this.buttonDeposit.TabIndex = 9;
            this.buttonDeposit.Text = "DEPOSIT";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(316, 330);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(160, 38);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Black;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(150, 330);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(160, 38);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // FormDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(763, 531);
            this.Controls.Add(this.panelDeposit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDeposit";
            this.Text = "FormDeposit";
            this.panelDeposit.ResumeLayout(false);
            this.panelDeposit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDeposit;
        private System.Windows.Forms.TextBox textBoxDeposit;
        private System.Windows.Forms.Label labelEnterAmount;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDeposit;
    }
}