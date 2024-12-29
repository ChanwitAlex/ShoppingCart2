namespace WinFormsApp1
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
            tbCoffeePrice = new TextBox();
            tbCoffeeQuantity = new TextBox();
            tbGreenTeaPrice = new TextBox();
            tbGreenTeaQuantity = new TextBox();
            button1 = new Button();
            chbCoffee = new CheckBox();
            chbGreenTea = new CheckBox();
            label1 = new Label();
            Cash = new Label();
            Change = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tbTotal = new TextBox();
            tbCash = new TextBox();
            tbChange = new TextBox();
            tb1000 = new TextBox();
            tb500 = new TextBox();
            tb100 = new TextBox();
            tb50 = new TextBox();
            tb20 = new TextBox();
            tb10 = new TextBox();
            tb5 = new TextBox();
            tb1 = new TextBox();
            SuspendLayout();
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(134, 12);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(125, 27);
            tbCoffeePrice.TabIndex = 0;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(294, 12);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(125, 27);
            tbCoffeeQuantity.TabIndex = 1;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(134, 50);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(125, 27);
            tbGreenTeaPrice.TabIndex = 2;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(294, 50);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(125, 27);
            tbGreenTeaQuantity.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(453, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 377);
            button1.TabIndex = 4;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(12, 12);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(75, 24);
            chbCoffee.TabIndex = 5;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            chbCoffee.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chbGreenTea
            // 
            chbGreenTea.AutoSize = true;
            chbGreenTea.Location = new Point(12, 52);
            chbGreenTea.Name = "chbGreenTea";
            chbGreenTea.Size = new Size(97, 24);
            chbGreenTea.TabIndex = 6;
            chbGreenTea.Text = "Green Tea";
            chbGreenTea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(565, 26);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 7;
            label1.Text = "Total";
            // 
            // Cash
            // 
            Cash.AutoSize = true;
            Cash.Location = new Point(565, 59);
            Cash.Name = "Cash";
            Cash.Size = new Size(40, 20);
            Cash.TabIndex = 8;
            Cash.Text = "Cash";
            // 
            // Change
            // 
            Change.AutoSize = true;
            Change.Location = new Point(565, 92);
            Change.Name = "Change";
            Change.Size = new Size(59, 20);
            Change.TabIndex = 9;
            Change.Text = "Change";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(565, 130);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 10;
            label4.Text = "1000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(565, 201);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 11;
            label5.Text = "100";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(565, 167);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 12;
            label6.Text = "500";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(565, 236);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 13;
            label7.Text = "50";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(565, 270);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 14;
            label8.Text = "20";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(565, 303);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 15;
            label9.Text = "10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(565, 336);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 16;
            label10.Text = "5";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(565, 365);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 17;
            label11.Text = "1";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(641, 19);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(125, 27);
            tbTotal.TabIndex = 18;
            // 
            // tbCash
            // 
            tbCash.Location = new Point(641, 52);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(125, 27);
            tbCash.TabIndex = 19;
            // 
            // tbChange
            // 
            tbChange.Location = new Point(641, 85);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(125, 27);
            tbChange.TabIndex = 20;
            // 
            // tb1000
            // 
            tb1000.Location = new Point(641, 123);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(125, 27);
            tb1000.TabIndex = 21;
            // 
            // tb500
            // 
            tb500.Location = new Point(641, 160);
            tb500.Name = "tb500";
            tb500.Size = new Size(125, 27);
            tb500.TabIndex = 22;
            // 
            // tb100
            // 
            tb100.Location = new Point(641, 194);
            tb100.Name = "tb100";
            tb100.Size = new Size(125, 27);
            tb100.TabIndex = 23;
            // 
            // tb50
            // 
            tb50.Location = new Point(641, 229);
            tb50.Name = "tb50";
            tb50.Size = new Size(125, 27);
            tb50.TabIndex = 24;
            // 
            // tb20
            // 
            tb20.Location = new Point(641, 263);
            tb20.Name = "tb20";
            tb20.Size = new Size(125, 27);
            tb20.TabIndex = 25;
            // 
            // tb10
            // 
            tb10.Location = new Point(641, 296);
            tb10.Name = "tb10";
            tb10.Size = new Size(125, 27);
            tb10.TabIndex = 26;
            // 
            // tb5
            // 
            tb5.Location = new Point(641, 329);
            tb5.Name = "tb5";
            tb5.Size = new Size(125, 27);
            tb5.TabIndex = 27;
            // 
            // tb1
            // 
            tb1.Location = new Point(641, 362);
            tb1.Name = "tb1";
            tb1.Size = new Size(125, 27);
            tb1.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb1);
            Controls.Add(tb5);
            Controls.Add(tb10);
            Controls.Add(tb20);
            Controls.Add(tb50);
            Controls.Add(tb100);
            Controls.Add(tb500);
            Controls.Add(tb1000);
            Controls.Add(tbChange);
            Controls.Add(tbCash);
            Controls.Add(tbTotal);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Change);
            Controls.Add(Cash);
            Controls.Add(label1);
            Controls.Add(chbGreenTea);
            Controls.Add(chbCoffee);
            Controls.Add(button1);
            Controls.Add(tbGreenTeaQuantity);
            Controls.Add(tbGreenTeaPrice);
            Controls.Add(tbCoffeeQuantity);
            Controls.Add(tbCoffeePrice);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCoffeePrice;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreenTeaPrice;
        private TextBox tbGreenTeaQuantity;
        private Button button1;
        private CheckBox chbCoffee;
        private CheckBox chbGreenTea;
        private Label label1;
        private Label Cash;
        private Label Change;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tbTotal;
        private TextBox tbCash;
        private TextBox tbChange;
        private TextBox tb1000;
        private TextBox tb500;
        private TextBox tb100;
        private TextBox tb50;
        private TextBox tb20;
        private TextBox tb10;
        private TextBox tb5;
        private TextBox tb1;
    }
}
