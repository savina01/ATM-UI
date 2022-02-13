namespace ATM2
{
    partial class FormATMMain
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
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.buttonSihnIn = new System.Windows.Forms.Button();
            this.textBoxPin = new System.Windows.Forms.TextBox();
            this.textBoxCard = new System.Windows.Forms.TextBox();
            this.labelPin = new System.Windows.Forms.Label();
            this.labelCardNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.panelWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.White;
            this.panelWelcome.Controls.Add(this.buttonSignUp);
            this.panelWelcome.Controls.Add(this.buttonClear);
            this.panelWelcome.Controls.Add(this.buttonSihnIn);
            this.panelWelcome.Controls.Add(this.textBoxPin);
            this.panelWelcome.Controls.Add(this.textBoxCard);
            this.panelWelcome.Controls.Add(this.labelPin);
            this.panelWelcome.Controls.Add(this.labelCardNo);
            this.panelWelcome.Controls.Add(this.label1);
            this.panelWelcome.Location = new System.Drawing.Point(130, 115);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(391, 294);
            this.panelWelcome.TabIndex = 7;
            // 
            // buttonSihnIn
            // 
            this.buttonSihnIn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSihnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSihnIn.ForeColor = System.Drawing.Color.White;
            this.buttonSihnIn.Location = new System.Drawing.Point(205, 196);
            this.buttonSihnIn.Name = "buttonSihnIn";
            this.buttonSihnIn.Size = new System.Drawing.Size(149, 30);
            this.buttonSihnIn.TabIndex = 13;
            this.buttonSihnIn.Text = "SIGN IN";
            this.buttonSihnIn.UseVisualStyleBackColor = false;
            // 
            // textBoxPin
            // 
            this.textBoxPin.Location = new System.Drawing.Point(122, 139);
            this.textBoxPin.Multiline = true;
            this.textBoxPin.Name = "textBoxPin";
            this.textBoxPin.Size = new System.Drawing.Size(232, 22);
            this.textBoxPin.TabIndex = 12;
            // 
            // textBoxCard
            // 
            this.textBoxCard.Location = new System.Drawing.Point(122, 82);
            this.textBoxCard.Multiline = true;
            this.textBoxCard.Name = "textBoxCard";
            this.textBoxCard.Size = new System.Drawing.Size(232, 22);
            this.textBoxCard.TabIndex = 11;
            // 
            // labelPin
            // 
            this.labelPin.AutoSize = true;
            this.labelPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPin.Location = new System.Drawing.Point(71, 141);
            this.labelPin.Name = "labelPin";
            this.labelPin.Size = new System.Drawing.Size(45, 20);
            this.labelPin.TabIndex = 10;
            this.labelPin.Text = "PIN:";
            // 
            // labelCardNo
            // 
            this.labelCardNo.AutoSize = true;
            this.labelCardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCardNo.Location = new System.Drawing.Point(32, 82);
            this.labelCardNo.Name = "labelCardNo";
            this.labelCardNo.Size = new System.Drawing.Size(84, 20);
            this.labelCardNo.TabIndex = 9;
            this.labelCardNo.Text = "Card No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "WELCOME TO ATM";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(571, 9);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(21, 20);
            this.labelX.TabIndex = 9;
            this.labelX.Text = "X";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Tomato;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(36, 196);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(149, 30);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.Black;
            this.buttonSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignUp.ForeColor = System.Drawing.Color.White;
            this.buttonSignUp.Location = new System.Drawing.Point(36, 246);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(318, 30);
            this.buttonSignUp.TabIndex = 15;
            this.buttonSignUp.Text = "SIGN UP";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            // 
            // FormATMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(648, 531);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.panelWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormATMMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM Main";
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSihnIn;
        private System.Windows.Forms.TextBox textBoxPin;
        private System.Windows.Forms.TextBox textBoxCard;
        private System.Windows.Forms.Label labelPin;
        private System.Windows.Forms.Label labelCardNo;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSignUp;
    }
}

