namespace ExchangeApp
{
    partial class ShowProductForm
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
            this.MinimalWholeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WholePriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RetailPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UnitTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SellerTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MinimalWholeTextBox
            // 
            this.MinimalWholeTextBox.Location = new System.Drawing.Point(35, 329);
            this.MinimalWholeTextBox.Name = "MinimalWholeTextBox";
            this.MinimalWholeTextBox.ReadOnly = true;
            this.MinimalWholeTextBox.Size = new System.Drawing.Size(153, 22);
            this.MinimalWholeTextBox.TabIndex = 23;
            this.MinimalWholeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Minimal quantity for whole price";
            // 
            // WholePriceTextBox
            // 
            this.WholePriceTextBox.Location = new System.Drawing.Point(34, 216);
            this.WholePriceTextBox.Name = "WholePriceTextBox";
            this.WholePriceTextBox.ReadOnly = true;
            this.WholePriceTextBox.Size = new System.Drawing.Size(153, 22);
            this.WholePriceTextBox.TabIndex = 21;
            this.WholePriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Whole Price";
            // 
            // RetailPriceTextBox
            // 
            this.RetailPriceTextBox.Location = new System.Drawing.Point(34, 159);
            this.RetailPriceTextBox.Name = "RetailPriceTextBox";
            this.RetailPriceTextBox.ReadOnly = true;
            this.RetailPriceTextBox.Size = new System.Drawing.Size(153, 22);
            this.RetailPriceTextBox.TabIndex = 19;
            this.RetailPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Retail Price";
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(36, 272);
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.ReadOnly = true;
            this.StockTextBox.Size = new System.Drawing.Size(153, 22);
            this.StockTextBox.TabIndex = 17;
            this.StockTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Stock";
            // 
            // UnitTextBox
            // 
            this.UnitTextBox.Location = new System.Drawing.Point(34, 97);
            this.UnitTextBox.Name = "UnitTextBox";
            this.UnitTextBox.ReadOnly = true;
            this.UnitTextBox.Size = new System.Drawing.Size(153, 22);
            this.UnitTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Unit";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(34, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(153, 22);
            this.NameTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // SellerTextBox
            // 
            this.SellerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellerTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SellerTextBox.Location = new System.Drawing.Point(35, 391);
            this.SellerTextBox.Name = "SellerTextBox";
            this.SellerTextBox.ReadOnly = true;
            this.SellerTextBox.Size = new System.Drawing.Size(153, 22);
            this.SellerTextBox.TabIndex = 25;
            this.SellerTextBox.DoubleClick += new System.EventHandler(this.SellerTextBox_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(32, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Seller";
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditButton.Location = new System.Drawing.Point(232, 430);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(99, 37);
            this.EditButton.TabIndex = 26;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.Location = new System.Drawing.Point(442, 430);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(99, 37);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelButton.Location = new System.Drawing.Point(127, 430);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(99, 37);
            this.CancelButton.TabIndex = 28;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(243, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image files (*.png)|*.png|Image files (*.jpg)|*.jpg";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteButton.Location = new System.Drawing.Point(337, 430);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(99, 37);
            this.DeleteButton.TabIndex = 30;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OrderButton.Location = new System.Drawing.Point(273, 430);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(99, 37);
            this.OrderButton.TabIndex = 31;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // ShowProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 477);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SellerTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MinimalWholeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WholePriceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RetailPriceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StockTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UnitTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(640, 520);
            this.Name = "ShowProductForm";
            this.Text = "ShowProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowProductForm_FormClosing);
            this.Load += new System.EventHandler(this.ShowProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MinimalWholeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox WholePriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RetailPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StockTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UnitTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SellerTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button OrderButton;
    }
}