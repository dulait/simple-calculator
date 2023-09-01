namespace SimpleCalculator
{
    partial class SimpleCalculator
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
            btnLn = new Button();
            btnSignChange = new Button();
            btnZero = new Button();
            btnDecimal = new Button();
            btnEquals = new Button();
            btnAdd = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnLog = new Button();
            btnSubtract = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnTenExp = new Button();
            btnMultiply = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnExpY = new Button();
            btnDivide = new Button();
            btnFactorial = new Button();
            btnCosin = new Button();
            btnSin = new Button();
            btnSqrt = new Button();
            btnMod = new Button();
            btnExp = new Button();
            btnAbsolute = new Button();
            btnReciprocative = new Button();
            btnSquared = new Button();
            btnClear = new Button();
            btnClearAll = new Button();
            btnEuler = new Button();
            btnPi = new Button();
            btnChange = new Button();
            outputBox = new TextBox();
            inputLabel = new Label();
            SuspendLayout();
            // 
            // btnLn
            // 
            btnLn.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLn.Location = new Point(12, 337);
            btnLn.Name = "btnLn";
            btnLn.Size = new Size(67, 38);
            btnLn.TabIndex = 0;
            btnLn.Text = "ln";
            btnLn.UseVisualStyleBackColor = true;
            // 
            // btnSignChange
            // 
            btnSignChange.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignChange.Location = new Point(79, 337);
            btnSignChange.Name = "btnSignChange";
            btnSignChange.Size = new Size(67, 38);
            btnSignChange.TabIndex = 1;
            btnSignChange.Text = "±";
            btnSignChange.UseVisualStyleBackColor = true;
            btnSignChange.Click += SignClick;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnZero.Location = new Point(148, 337);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(67, 38);
            btnZero.TabIndex = 2;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += NumberInputClick;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecimal.Location = new Point(216, 337);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(67, 38);
            btnDecimal.TabIndex = 3;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += DecimalClick;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEquals.Location = new Point(283, 337);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(67, 38);
            btnEquals.TabIndex = 4;
            btnEquals.Text = "₌";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += EqualsClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(283, 299);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(67, 38);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "＋";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BasicArithmeticClick;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnThree.Location = new Point(216, 299);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(67, 38);
            btnThree.TabIndex = 8;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += NumberInputClick;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTwo.Location = new Point(148, 299);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(67, 38);
            btnTwo.TabIndex = 7;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += NumberInputClick;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOne.Location = new Point(79, 299);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(67, 38);
            btnOne.TabIndex = 6;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += NumberInputClick;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLog.Location = new Point(12, 299);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(67, 38);
            btnLog.TabIndex = 5;
            btnLog.Text = "log";
            btnLog.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubtract.Location = new Point(283, 260);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(67, 38);
            btnSubtract.TabIndex = 14;
            btnSubtract.Text = "－";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += BasicArithmeticClick;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSix.Location = new Point(216, 260);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(67, 38);
            btnSix.TabIndex = 13;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += NumberInputClick;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFive.Location = new Point(148, 260);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(67, 38);
            btnFive.TabIndex = 12;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += NumberInputClick;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFour.Location = new Point(79, 260);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(67, 38);
            btnFour.TabIndex = 11;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += NumberInputClick;
            // 
            // btnTenExp
            // 
            btnTenExp.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTenExp.Location = new Point(12, 260);
            btnTenExp.Name = "btnTenExp";
            btnTenExp.Size = new Size(67, 38);
            btnTenExp.TabIndex = 10;
            btnTenExp.Text = "10^x";
            btnTenExp.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiply.Location = new Point(283, 222);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(67, 38);
            btnMultiply.TabIndex = 19;
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += BasicArithmeticClick;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNine.Location = new Point(216, 222);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(67, 38);
            btnNine.TabIndex = 18;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += NumberInputClick;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEight.Location = new Point(148, 222);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(67, 38);
            btnEight.TabIndex = 17;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += NumberInputClick;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeven.Location = new Point(79, 222);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(67, 38);
            btnSeven.TabIndex = 16;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += NumberInputClick;
            // 
            // btnExpY
            // 
            btnExpY.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExpY.Location = new Point(12, 222);
            btnExpY.Name = "btnExpY";
            btnExpY.Size = new Size(67, 38);
            btnExpY.TabIndex = 15;
            btnExpY.Text = "x^y";
            btnExpY.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivide.Location = new Point(283, 183);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(67, 38);
            btnDivide.TabIndex = 24;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += BasicArithmeticClick;
            // 
            // btnFactorial
            // 
            btnFactorial.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFactorial.Location = new Point(216, 183);
            btnFactorial.Name = "btnFactorial";
            btnFactorial.Size = new Size(67, 38);
            btnFactorial.TabIndex = 23;
            btnFactorial.Text = "x!";
            btnFactorial.UseVisualStyleBackColor = true;
            // 
            // btnCosin
            // 
            btnCosin.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCosin.Location = new Point(148, 183);
            btnCosin.Name = "btnCosin";
            btnCosin.Size = new Size(67, 38);
            btnCosin.TabIndex = 22;
            btnCosin.Text = "cos";
            btnCosin.UseVisualStyleBackColor = true;
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSin.Location = new Point(79, 183);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(67, 38);
            btnSin.TabIndex = 21;
            btnSin.Text = "sin";
            btnSin.UseVisualStyleBackColor = true;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSqrt.Location = new Point(12, 183);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(67, 38);
            btnSqrt.TabIndex = 20;
            btnSqrt.Text = "sqrt(x)";
            btnSqrt.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMod.Location = new Point(283, 144);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(67, 38);
            btnMod.TabIndex = 29;
            btnMod.Text = "mod";
            btnMod.UseVisualStyleBackColor = true;
            // 
            // btnExp
            // 
            btnExp.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExp.Location = new Point(216, 144);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(67, 38);
            btnExp.TabIndex = 28;
            btnExp.Text = "exp";
            btnExp.UseVisualStyleBackColor = true;
            // 
            // btnAbsolute
            // 
            btnAbsolute.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbsolute.Location = new Point(148, 144);
            btnAbsolute.Name = "btnAbsolute";
            btnAbsolute.Size = new Size(67, 38);
            btnAbsolute.TabIndex = 27;
            btnAbsolute.Text = "|x|";
            btnAbsolute.UseVisualStyleBackColor = true;
            // 
            // btnReciprocative
            // 
            btnReciprocative.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReciprocative.Location = new Point(80, 144);
            btnReciprocative.Name = "btnReciprocative";
            btnReciprocative.Size = new Size(67, 38);
            btnReciprocative.TabIndex = 26;
            btnReciprocative.Text = "1/x";
            btnReciprocative.UseVisualStyleBackColor = true;
            // 
            // btnSquared
            // 
            btnSquared.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSquared.Location = new Point(12, 144);
            btnSquared.Name = "btnSquared";
            btnSquared.Size = new Size(67, 38);
            btnSquared.TabIndex = 25;
            btnSquared.Text = "x^2";
            btnSquared.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(283, 105);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(67, 38);
            btnClear.TabIndex = 34;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += ClearClick;
            // 
            // btnClearAll
            // 
            btnClearAll.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearAll.Location = new Point(216, 105);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(67, 38);
            btnClearAll.TabIndex = 33;
            btnClearAll.Text = "CE";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += ClearClick;
            // 
            // btnEuler
            // 
            btnEuler.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEuler.Location = new Point(148, 105);
            btnEuler.Name = "btnEuler";
            btnEuler.Size = new Size(67, 38);
            btnEuler.TabIndex = 32;
            btnEuler.Text = "e";
            btnEuler.UseVisualStyleBackColor = true;
            // 
            // btnPi
            // 
            btnPi.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPi.Location = new Point(80, 105);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(67, 38);
            btnPi.TabIndex = 31;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            btnChange.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnChange.Location = new Point(12, 105);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(67, 38);
            btnChange.TabIndex = 30;
            btnChange.Text = "2nd";
            btnChange.UseVisualStyleBackColor = true;
            // 
            // outputBox
            // 
            outputBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            outputBox.Location = new Point(13, 45);
            outputBox.Name = "outputBox";
            outputBox.ReadOnly = true;
            outputBox.Size = new Size(337, 43);
            outputBox.TabIndex = 35;
            outputBox.TextAlign = HorizontalAlignment.Right;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputLabel.Location = new Point(13, 21);
            inputLabel.Name = "inputLabel";
            inputLabel.RightToLeft = RightToLeft.No;
            inputLabel.Size = new Size(0, 21);
            inputLabel.TabIndex = 36;
            // 
            // SimpleCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 411);
            Controls.Add(inputLabel);
            Controls.Add(outputBox);
            Controls.Add(btnClear);
            Controls.Add(btnClearAll);
            Controls.Add(btnEuler);
            Controls.Add(btnPi);
            Controls.Add(btnChange);
            Controls.Add(btnMod);
            Controls.Add(btnExp);
            Controls.Add(btnAbsolute);
            Controls.Add(btnReciprocative);
            Controls.Add(btnSquared);
            Controls.Add(btnDivide);
            Controls.Add(btnFactorial);
            Controls.Add(btnCosin);
            Controls.Add(btnSin);
            Controls.Add(btnSqrt);
            Controls.Add(btnMultiply);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnExpY);
            Controls.Add(btnSubtract);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnTenExp);
            Controls.Add(btnAdd);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnLog);
            Controls.Add(btnEquals);
            Controls.Add(btnDecimal);
            Controls.Add(btnZero);
            Controls.Add(btnSignChange);
            Controls.Add(btnLn);
            MaximumSize = new Size(380, 450);
            MinimumSize = new Size(380, 450);
            Name = "SimpleCalculator";
            Text = "SimpleCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLn;
        private Button btnSignChange;
        private Button btnZero;
        private Button btnDecimal;
        private Button btnEquals;
        private Button btnAdd;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnLog;
        private Button btnSubtract;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnTenExp;
        private Button btnMultiply;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnExpY;
        private Button btnDivide;
        private Button btnFactorial;
        private Button btnCosin;
        private Button btnSin;
        private Button btnSqrt;
        private Button btnMod;
        private Button btnExp;
        private Button btnAbsolute;
        private Button btnReciprocative;
        private Button btnSquared;
        private Button btnClear;
        private Button btnClearAll;
        private Button btnEuler;
        private Button btnPi;
        private Button btnChange;
        private TextBox outputBox;
        private Label inputLabel;
    }
}