namespace Budget
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentAccountAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SavingAccountAmount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Account";
            // 
            // CurrentAccountAmount
            // 
            this.CurrentAccountAmount.AutoSize = true;
            this.CurrentAccountAmount.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentAccountAmount.Location = new System.Drawing.Point(77, 184);
            this.CurrentAccountAmount.Name = "CurrentAccountAmount";
            this.CurrentAccountAmount.Size = new System.Drawing.Size(137, 45);
            this.CurrentAccountAmount.TabIndex = 1;
            this.CurrentAccountAmount.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saving Account";
            // 
            // SavingAccountAmount
            // 
            this.SavingAccountAmount.AutoSize = true;
            this.SavingAccountAmount.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SavingAccountAmount.Location = new System.Drawing.Point(77, 350);
            this.SavingAccountAmount.Name = "SavingAccountAmount";
            this.SavingAccountAmount.Size = new System.Drawing.Size(137, 45);
            this.SavingAccountAmount.TabIndex = 3;
            this.SavingAccountAmount.Text = "Amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SavingAccountAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CurrentAccountAmount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label CurrentAccountAmount;
        private Label label3;
        private Label SavingAccountAmount;
        private Button button1;
    }
}