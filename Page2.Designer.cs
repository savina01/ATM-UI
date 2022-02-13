namespace ATM2
{
    partial class Page2
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
            this.labelAdditionalDetails = new System.Windows.Forms.Label();
            this.labelReligion = new System.Windows.Forms.Label();
            this.labelCategoory = new System.Windows.Forms.Label();
            this.labelIncome = new System.Windows.Forms.Label();
            this.textBoxReligion = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelPage2 = new System.Windows.Forms.Panel();
            this.panelPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdditionalDetails
            // 
            this.labelAdditionalDetails.AutoSize = true;
            this.labelAdditionalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdditionalDetails.Location = new System.Drawing.Point(165, 45);
            this.labelAdditionalDetails.Name = "labelAdditionalDetails";
            this.labelAdditionalDetails.Size = new System.Drawing.Size(168, 17);
            this.labelAdditionalDetails.TabIndex = 0;
            this.labelAdditionalDetails.Text = "Page 2: Additional details";
            // 
            // labelReligion
            // 
            this.labelReligion.AutoSize = true;
            this.labelReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReligion.Location = new System.Drawing.Point(21, 107);
            this.labelReligion.Name = "labelReligion";
            this.labelReligion.Size = new System.Drawing.Size(72, 17);
            this.labelReligion.TabIndex = 2;
            this.labelReligion.Text = "Religion:";
            // 
            // labelCategoory
            // 
            this.labelCategoory.AutoSize = true;
            this.labelCategoory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategoory.Location = new System.Drawing.Point(15, 152);
            this.labelCategoory.Name = "labelCategoory";
            this.labelCategoory.Size = new System.Drawing.Size(78, 17);
            this.labelCategoory.TabIndex = 3;
            this.labelCategoory.Text = "Category:";
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIncome.Location = new System.Drawing.Point(29, 200);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(64, 17);
            this.labelIncome.TabIndex = 4;
            this.labelIncome.Text = "Income:";
            // 
            // textBoxReligion
            // 
            this.textBoxReligion.Location = new System.Drawing.Point(114, 104);
            this.textBoxReligion.Multiline = true;
            this.textBoxReligion.Name = "textBoxReligion";
            this.textBoxReligion.Size = new System.Drawing.Size(363, 26);
            this.textBoxReligion.TabIndex = 5;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(114, 150);
            this.textBoxCategory.Multiline = true;
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(363, 27);
            this.textBoxCategory.TabIndex = 6;
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.Location = new System.Drawing.Point(114, 196);
            this.textBoxIncome.Multiline = true;
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(363, 28);
            this.textBoxIncome.TabIndex = 7;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Black;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(401, 290);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(89, 38);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            // 
            // panelPage2
            // 
            this.panelPage2.BackColor = System.Drawing.Color.White;
            this.panelPage2.Controls.Add(this.labelAdditionalDetails);
            this.panelPage2.Controls.Add(this.buttonNext);
            this.panelPage2.Controls.Add(this.textBoxReligion);
            this.panelPage2.Controls.Add(this.textBoxIncome);
            this.panelPage2.Controls.Add(this.labelReligion);
            this.panelPage2.Controls.Add(this.textBoxCategory);
            this.panelPage2.Controls.Add(this.labelCategoory);
            this.panelPage2.Controls.Add(this.labelIncome);
            this.panelPage2.Location = new System.Drawing.Point(94, 86);
            this.panelPage2.Name = "panelPage2";
            this.panelPage2.Size = new System.Drawing.Size(505, 340);
            this.panelPage2.TabIndex = 9;
            // 
            // Page2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(692, 512);
            this.Controls.Add(this.panelPage2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Page2";
            this.Text = "Page2";
            this.panelPage2.ResumeLayout(false);
            this.panelPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAdditionalDetails;
        private System.Windows.Forms.Label labelReligion;
        private System.Windows.Forms.Label labelCategoory;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.TextBox textBoxReligion;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel panelPage2;
    }
}