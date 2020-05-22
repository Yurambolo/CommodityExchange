namespace ExchangeApp
{
    partial class NewOrderForm
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
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SellerTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuyerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PayMethodComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(201, 89);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(153, 22);
            this.PriceTextBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Price";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(201, 32);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(153, 22);
            this.AmountTextBox.TabIndex = 19;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.AmountTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Amount";
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Location = new System.Drawing.Point(12, 151);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.ReadOnly = true;
            this.ProductTextBox.Size = new System.Drawing.Size(153, 22);
            this.ProductTextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Product";
            // 
            // SellerTextBox
            // 
            this.SellerTextBox.Location = new System.Drawing.Point(12, 89);
            this.SellerTextBox.Name = "SellerTextBox";
            this.SellerTextBox.ReadOnly = true;
            this.SellerTextBox.Size = new System.Drawing.Size(153, 22);
            this.SellerTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Seller";
            // 
            // BuyerTextBox
            // 
            this.BuyerTextBox.Location = new System.Drawing.Point(12, 32);
            this.BuyerTextBox.Name = "BuyerTextBox";
            this.BuyerTextBox.ReadOnly = true;
            this.BuyerTextBox.Size = new System.Drawing.Size(153, 22);
            this.BuyerTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buyer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Pay method";
            // 
            // PayMethodComboBox
            // 
            this.PayMethodComboBox.FormattingEnabled = true;
            this.PayMethodComboBox.Items.AddRange(new object[] {
            "Cash payment",
            "Non-cash payment"});
            this.PayMethodComboBox.Location = new System.Drawing.Point(201, 151);
            this.PayMethodComboBox.Name = "PayMethodComboBox";
            this.PayMethodComboBox.Size = new System.Drawing.Size(153, 24);
            this.PayMethodComboBox.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PayMethodComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SellerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuyerTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NewOrderForm";
            this.Text = "NewOrderForm";
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SellerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BuyerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PayMethodComboBox;
        private System.Windows.Forms.Button button1;
    }
}