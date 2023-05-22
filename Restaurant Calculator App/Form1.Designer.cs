namespace Restaurant_Calculator_App
{
    partial class BillCalc
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
            this.mainCombo = new System.Windows.Forms.ComboBox();
            this.bevCombo = new System.Windows.Forms.ComboBox();
            this.appeCombo = new System.Windows.Forms.ComboBox();
            this.dessCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.overviewlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mainCombo
            // 
            this.mainCombo.FormattingEnabled = true;
            this.mainCombo.Items.AddRange(new object[] {
            "Seafood Alfredo $15.95",
            "Chicken Alfredo $13.95",
            "Chicken Picatta $13.95",
            "Turkey Club $11.95",
            "Lobster Pie $19.95",
            "Prime Rib $20.95",
            "Shrimp Scampi $18.95",
            "Turkey Dinner $13.95",
            "Stuffed Chicken $14.95"});
            this.mainCombo.Location = new System.Drawing.Point(198, 150);
            this.mainCombo.Name = "mainCombo";
            this.mainCombo.Size = new System.Drawing.Size(121, 21);
            this.mainCombo.TabIndex = 0;
            this.mainCombo.SelectedIndexChanged += new System.EventHandler(this.dropdownSelected);
            // 
            // bevCombo
            // 
            this.bevCombo.FormattingEnabled = true;
            this.bevCombo.Items.AddRange(new object[] {
            "Soda $1.95",
            "Tea $1.50",
            "Coffee $1.25",
            "Mineral Water $2.95",
            "Juice $2.50",
            "Milk $1.50"});
            this.bevCombo.Location = new System.Drawing.Point(198, 178);
            this.bevCombo.Name = "bevCombo";
            this.bevCombo.Size = new System.Drawing.Size(121, 21);
            this.bevCombo.TabIndex = 1;
            this.bevCombo.SelectedIndexChanged += new System.EventHandler(this.dropdownSelected);
            // 
            // appeCombo
            // 
            this.appeCombo.FormattingEnabled = true;
            this.appeCombo.Items.AddRange(new object[] {
            "Buffalo Wings $5.95",
            "Buffalo Fingers $6.95",
            "Potato Skins $8.95",
            "Nachos $8.95",
            "Mushrooms Caps $10.95",
            "Shrimp Cocktail $12.95",
            "Chips and Salsa $6.95"});
            this.appeCombo.Location = new System.Drawing.Point(198, 206);
            this.appeCombo.Name = "appeCombo";
            this.appeCombo.Size = new System.Drawing.Size(121, 21);
            this.appeCombo.TabIndex = 2;
            this.appeCombo.SelectedIndexChanged += new System.EventHandler(this.dropdownSelected);
            // 
            // dessCombo
            // 
            this.dessCombo.FormattingEnabled = true;
            this.dessCombo.Items.AddRange(new object[] {
            "Apple Pie $5.95",
            "Sundae $3.95",
            "Carrot Cake $5.95",
            "Mud Pie $4.95",
            "Apple Crisp $5.95"});
            this.dessCombo.Location = new System.Drawing.Point(198, 234);
            this.dessCombo.Name = "dessCombo";
            this.dessCombo.Size = new System.Drawing.Size(121, 21);
            this.dessCombo.TabIndex = 3;
            this.dessCombo.SelectedIndexChanged += new System.EventHandler(this.dropdownSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main Course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Beverage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Appetizer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dessert:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(164, 281);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear Bill";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 365);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 392);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Before Tax:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(116, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tax at .725% :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Restaurant Bill Tool";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(480, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Overview:";
            // 
            // overviewlistBox
            // 
            this.overviewlistBox.FormattingEnabled = true;
            this.overviewlistBox.Location = new System.Drawing.Point(443, 150);
            this.overviewlistBox.Name = "overviewlistBox";
            this.overviewlistBox.Size = new System.Drawing.Size(206, 277);
            this.overviewlistBox.TabIndex = 19;
            // 
            // BillCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 519);
            this.Controls.Add(this.overviewlistBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dessCombo);
            this.Controls.Add(this.appeCombo);
            this.Controls.Add(this.bevCombo);
            this.Controls.Add(this.mainCombo);
            this.Name = "BillCalc";
            this.Text = "Restaurant Bill Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox mainCombo;
        private System.Windows.Forms.ComboBox bevCombo;
        private System.Windows.Forms.ComboBox appeCombo;
        private System.Windows.Forms.ComboBox dessCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox overviewlistBox;
    }
}

