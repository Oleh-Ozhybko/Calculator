
namespace Calculator
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exponentiationButton = new System.Windows.Forms.Button();
            this.squareRoot = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.abs = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.derivative = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exponentiationButton);
            this.groupBox1.Controls.Add(this.squareRoot);
            this.groupBox1.Controls.Add(this.Backspace);
            this.groupBox1.Controls.Add(this.percent);
            this.groupBox1.Controls.Add(this.C);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // exponentiationButton
            // 
            this.exponentiationButton.BackColor = System.Drawing.SystemColors.Control;
            this.exponentiationButton.Location = new System.Drawing.Point(170, 51);
            this.exponentiationButton.Name = "exponentiationButton";
            this.exponentiationButton.Size = new System.Drawing.Size(76, 33);
            this.exponentiationButton.TabIndex = 14;
            this.exponentiationButton.Text = "x²";
            this.exponentiationButton.UseVisualStyleBackColor = false;
            this.exponentiationButton.Click += new System.EventHandler(this.exponentiationButton_Click);
            // 
            // squareRoot
            // 
            this.squareRoot.BackColor = System.Drawing.SystemColors.Control;
            this.squareRoot.Location = new System.Drawing.Point(88, 51);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(76, 33);
            this.squareRoot.TabIndex = 12;
            this.squareRoot.Text = "√";
            this.squareRoot.UseVisualStyleBackColor = false;
            this.squareRoot.Click += new System.EventHandler(this.squareRoot_Click);
            // 
            // Backspace
            // 
            this.Backspace.BackColor = System.Drawing.SystemColors.Control;
            this.Backspace.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backspace.Location = new System.Drawing.Point(131, 12);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(115, 33);
            this.Backspace.TabIndex = 13;
            this.Backspace.Text = "←";
            this.Backspace.UseVisualStyleBackColor = false;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.SystemColors.Control;
            this.percent.Location = new System.Drawing.Point(6, 51);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(76, 33);
            this.percent.TabIndex = 12;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.SystemColors.Control;
            this.C.Location = new System.Drawing.Point(6, 12);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(115, 33);
            this.C.TabIndex = 12;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(18, 12);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(335, 20);
            this.textBoxResult.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.abs);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 166);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Control;
            this.button12.Location = new System.Drawing.Point(170, 127);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(76, 33);
            this.button12.TabIndex = 11;
            this.button12.Text = ".";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.dot_Click);
            // 
            // abs
            // 
            this.abs.BackColor = System.Drawing.SystemColors.Control;
            this.abs.Location = new System.Drawing.Point(6, 127);
            this.abs.Name = "abs";
            this.abs.Size = new System.Drawing.Size(76, 33);
            this.abs.TabIndex = 10;
            this.abs.Text = "±";
            this.abs.UseVisualStyleBackColor = false;
            this.abs.Click += new System.EventHandler(this.abs_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Control;
            this.button10.Location = new System.Drawing.Point(88, 127);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(76, 33);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(170, 88);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 33);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(88, 88);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 33);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(6, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 33);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(170, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 33);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(88, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(6, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(170, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(88, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(6, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.derivative);
            this.groupBox3.Controls.Add(this.divide);
            this.groupBox3.Controls.Add(this.multiply);
            this.groupBox3.Controls.Add(this.minus);
            this.groupBox3.Controls.Add(this.plus);
            this.groupBox3.Controls.Add(this.total);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(270, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(88, 255);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // derivative
            // 
            this.derivative.BackColor = System.Drawing.SystemColors.Control;
            this.derivative.Location = new System.Drawing.Point(7, 12);
            this.derivative.Name = "derivative";
            this.derivative.Size = new System.Drawing.Size(76, 33);
            this.derivative.TabIndex = 12;
            this.derivative.Text = "1/x";
            this.derivative.UseVisualStyleBackColor = false;
            this.derivative.Click += new System.EventHandler(this.derivative_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.Control;
            this.divide.Location = new System.Drawing.Point(6, 51);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(76, 33);
            this.divide.TabIndex = 12;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.Control;
            this.multiply.Location = new System.Drawing.Point(7, 99);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(76, 33);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.Control;
            this.minus.Location = new System.Drawing.Point(6, 138);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(76, 33);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.Control;
            this.plus.Location = new System.Drawing.Point(6, 177);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(76, 33);
            this.plus.TabIndex = 12;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.Control;
            this.total.Location = new System.Drawing.Point(6, 216);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(76, 33);
            this.total.TabIndex = 12;
            this.total.Text = "=";
            this.total.UseVisualStyleBackColor = false;
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(371, 293);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button abs;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button exponentiationButton;
        private System.Windows.Forms.Button squareRoot;
        private System.Windows.Forms.Button total;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button derivative;
    }
}

