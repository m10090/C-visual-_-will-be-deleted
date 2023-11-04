namespace calc
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
            displayCalc = new TextBox();
            clear = new Button();
            power = new Button();
            divided = new Button();
            delete = new Button();
            multiply = new Button();
            nine = new Button();
            eight = new Button();
            seven = new Button();
            minus = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            plus = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            equal = new Button();
            dot = new Button();
            zero = new Button();
            doubleZero = new Button();
            SuspendLayout();
            // 
            // displayCalc
            // 
            displayCalc.BackColor = SystemColors.ControlText;
            displayCalc.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            displayCalc.ForeColor = Color.White;
            displayCalc.Location = new Point(12, 12);
            displayCalc.Name = "displayCalc";
            displayCalc.ReadOnly = true;
            displayCalc.Size = new Size(404, 44);
            displayCalc.TabIndex = 0;
            // 
            // clear
            // 
            clear.BackColor = Color.Teal;
            clear.ForeColor = Color.Chartreuse;
            clear.Location = new Point(13, 62);
            clear.Name = "clear";
            clear.Size = new Size(82, 64);
            clear.TabIndex = 1;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += Clear_click;
            // 
            // power
            // 
            power.BackColor = Color.Teal;
            power.ForeColor = Color.Chartreuse;
            power.Location = new Point(119, 62);
            power.Name = "power";
            power.Size = new Size(82, 64);
            power.TabIndex = 2;
            power.Text = "^";
            power.UseVisualStyleBackColor = false;
            power.Click += power_click;
            // 
            // divided
            // 
            divided.BackColor = Color.Teal;
            divided.ForeColor = Color.Chartreuse;
            divided.Location = new Point(225, 62);
            divided.Name = "divided";
            divided.Size = new Size(82, 64);
            divided.TabIndex = 3;
            divided.Text = "/";
            divided.UseVisualStyleBackColor = false;
            divided.Click += divided_click;
            // 
            // delete
            // 
            delete.BackColor = Color.Teal;
            delete.ForeColor = Color.Chartreuse;
            delete.Location = new Point(331, 62);
            delete.Name = "delete";
            delete.Size = new Size(82, 64);
            delete.TabIndex = 4;
            delete.Text = "⌫";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_click;
            // 
            // multiply
            // 
            multiply.BackColor = Color.Teal;
            multiply.ForeColor = Color.Chartreuse;
            multiply.Location = new Point(331, 133);
            multiply.Name = "multiply";
            multiply.Size = new Size(82, 64);
            multiply.TabIndex = 8;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += times_click;
            // 
            // nine
            // 
            nine.BackColor = Color.Teal;
            nine.ForeColor = Color.Chartreuse;
            nine.Location = new Point(225, 133);
            nine.Name = "nine";
            nine.Size = new Size(82, 64);
            nine.TabIndex = 7;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += nine_click;
            // 
            // eight
            // 
            eight.BackColor = Color.Teal;
            eight.ForeColor = Color.Chartreuse;
            eight.Location = new Point(119, 133);
            eight.Name = "eight";
            eight.Size = new Size(82, 64);
            eight.TabIndex = 6;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += eight_click;
            // 
            // seven
            // 
            seven.BackColor = Color.Teal;
            seven.ForeColor = Color.Chartreuse;
            seven.Location = new Point(13, 133);
            seven.Name = "seven";
            seven.Size = new Size(82, 64);
            seven.TabIndex = 5;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += seven_click;
            // 
            // minus
            // 
            minus.BackColor = Color.Teal;
            minus.ForeColor = Color.Chartreuse;
            minus.Location = new Point(331, 204);
            minus.Name = "minus";
            minus.Size = new Size(82, 64);
            minus.TabIndex = 12;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += minus_click;
            // 
            // six
            // 
            six.BackColor = Color.Teal;
            six.ForeColor = Color.Chartreuse;
            six.Location = new Point(225, 204);
            six.Name = "six";
            six.Size = new Size(82, 64);
            six.TabIndex = 11;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += six_click;
            // 
            // five
            // 
            five.BackColor = Color.Teal;
            five.ForeColor = Color.Chartreuse;
            five.Location = new Point(119, 204);
            five.Name = "five";
            five.Size = new Size(82, 64);
            five.TabIndex = 10;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += five_click;
            // 
            // four
            // 
            four.BackColor = Color.Teal;
            four.ForeColor = Color.Chartreuse;
            four.Location = new Point(13, 204);
            four.Name = "four";
            four.Size = new Size(82, 64);
            four.TabIndex = 9;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += four_click;
            // 
            // plus
            // 
            plus.BackColor = Color.Teal;
            plus.ForeColor = Color.Chartreuse;
            plus.Location = new Point(331, 275);
            plus.Name = "plus";
            plus.Size = new Size(82, 64);
            plus.TabIndex = 16;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_click;
            // 
            // three
            // 
            three.BackColor = Color.Teal;
            three.ForeColor = Color.Chartreuse;
            three.Location = new Point(225, 275);
            three.Name = "three";
            three.Size = new Size(82, 64);
            three.TabIndex = 15;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += three_click;
            // 
            // two
            // 
            two.BackColor = Color.Teal;
            two.ForeColor = Color.Chartreuse;
            two.Location = new Point(119, 275);
            two.Name = "two";
            two.Size = new Size(82, 64);
            two.TabIndex = 14;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += two_click;
            // 
            // one
            // 
            one.BackColor = Color.Teal;
            one.ForeColor = Color.Chartreuse;
            one.Location = new Point(13, 275);
            one.Name = "one";
            one.Size = new Size(82, 64);
            one.TabIndex = 13;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += one_click;
            // 
            // equal
            // 
            equal.BackColor = Color.Teal;
            equal.ForeColor = Color.Chartreuse;
            equal.Location = new Point(331, 346);
            equal.Name = "equal";
            equal.Size = new Size(82, 64);
            equal.TabIndex = 20;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_click;
            // 
            // dot
            // 
            dot.BackColor = Color.Teal;
            dot.ForeColor = Color.Chartreuse;
            dot.Location = new Point(225, 346);
            dot.Name = "dot";
            dot.Size = new Size(82, 64);
            dot.TabIndex = 19;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += dot_click;
            // 
            // zero
            // 
            zero.BackColor = Color.Teal;
            zero.ForeColor = Color.Chartreuse;
            zero.Location = new Point(119, 346);
            zero.Name = "zero";
            zero.Size = new Size(82, 64);
            zero.TabIndex = 18;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += zero_click;
            // 
            // doubleZero
            // 
            doubleZero.BackColor = Color.Teal;
            doubleZero.ForeColor = Color.Chartreuse;
            doubleZero.Location = new Point(13, 346);
            doubleZero.Name = "doubleZero";
            doubleZero.Size = new Size(82, 64);
            doubleZero.TabIndex = 17;
            doubleZero.Text = "00";
            doubleZero.UseVisualStyleBackColor = false;
            doubleZero.Click += plusMinus_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(424, 431);
            Controls.Add(equal);
            Controls.Add(dot);
            Controls.Add(zero);
            Controls.Add(doubleZero);
            Controls.Add(plus);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(minus);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(multiply);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(delete);
            Controls.Add(divided);
            Controls.Add(power);
            Controls.Add(clear);
            Controls.Add(displayCalc);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox displayCalc;
        private Button clear;
        private Button power;
        private Button divided;
        private Button delete;
        private Button multiply;
        private Button nine;
        private Button eight;
        private Button seven;
        private Button minus;
        private Button six;
        private Button five;
        private Button four;
        private Button plus;
        private Button three;
        private Button two;
        private Button one;
        private Button equal;
        private Button dot;
        private Button zero;
        private Button doubleZero;
    }
}