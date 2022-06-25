namespace Budget
{
    partial class Budget
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(701, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Stats";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(801, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(544, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 525);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SavingAccountAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CurrentAccountAmount);
            this.Controls.Add(this.label1);
            this.Name = "Budget";
            this.Text = "Budget";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label CurrentAccountAmount;
        private Label label3;
        private Label SavingAccountAmount;
        private Button button1;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
    }
}