
namespace UI_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.clearNumberButton = new System.Windows.Forms.Button();
            this.clearExpressionButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.ninthDigit = new System.Windows.Forms.Button();
            this.eightDigit = new System.Windows.Forms.Button();
            this.seventhDigit = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.sixthDigit = new System.Windows.Forms.Button();
            this.fifthDigit = new System.Windows.Forms.Button();
            this.fourthDigit = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.thirdDigit = new System.Windows.Forms.Button();
            this.secondDigit = new System.Windows.Forms.Button();
            this.firstDigit = new System.Windows.Forms.Button();
            this.calcButton = new System.Windows.Forms.Button();
            this.zeroDigit = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            this.expression = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clearNumberButton
            // 
            this.clearNumberButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearNumberButton.Location = new System.Drawing.Point(104, 181);
            this.clearNumberButton.Margin = new System.Windows.Forms.Padding(0);
            this.clearNumberButton.Name = "clearNumberButton";
            this.clearNumberButton.Size = new System.Drawing.Size(100, 105);
            this.clearNumberButton.TabIndex = 0;
            this.clearNumberButton.Text = "CE";
            this.clearNumberButton.UseVisualStyleBackColor = false;
            this.clearNumberButton.Click += new System.EventHandler(this.ClearNumber);
            // 
            // clearExpressionButton
            // 
            this.clearExpressionButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.clearExpressionButton.Location = new System.Drawing.Point(204, 181);
            this.clearExpressionButton.Margin = new System.Windows.Forms.Padding(0);
            this.clearExpressionButton.Name = "clearExpressionButton";
            this.clearExpressionButton.Size = new System.Drawing.Size(100, 105);
            this.clearExpressionButton.TabIndex = 1;
            this.clearExpressionButton.Text = "C";
            this.clearExpressionButton.UseVisualStyleBackColor = false;
            this.clearExpressionButton.Click += new System.EventHandler(this.ClearExpression);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(304, 391);
            this.subtractButton.Margin = new System.Windows.Forms.Padding(0);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(100, 105);
            this.subtractButton.TabIndex = 3;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.AddOperation);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(304, 181);
            this.divideButton.Margin = new System.Windows.Forms.Padding(0);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(100, 105);
            this.divideButton.TabIndex = 7;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.AddOperation);
            // 
            // ninthDigit
            // 
            this.ninthDigit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ninthDigit.Location = new System.Drawing.Point(204, 286);
            this.ninthDigit.Margin = new System.Windows.Forms.Padding(0);
            this.ninthDigit.Name = "ninthDigit";
            this.ninthDigit.Size = new System.Drawing.Size(100, 105);
            this.ninthDigit.TabIndex = 6;
            this.ninthDigit.Text = "9";
            this.ninthDigit.UseVisualStyleBackColor = false;
            this.ninthDigit.Click += new System.EventHandler(this.AddDigit);
            // 
            // eightDigit
            // 
            this.eightDigit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.eightDigit.Location = new System.Drawing.Point(104, 286);
            this.eightDigit.Margin = new System.Windows.Forms.Padding(0);
            this.eightDigit.Name = "eightDigit";
            this.eightDigit.Size = new System.Drawing.Size(100, 105);
            this.eightDigit.TabIndex = 5;
            this.eightDigit.Text = "8";
            this.eightDigit.UseVisualStyleBackColor = false;
            this.eightDigit.Click += new System.EventHandler(this.AddDigit);
            // 
            // seventhDigit
            // 
            this.seventhDigit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.seventhDigit.Location = new System.Drawing.Point(4, 286);
            this.seventhDigit.Margin = new System.Windows.Forms.Padding(0);
            this.seventhDigit.Name = "seventhDigit";
            this.seventhDigit.Size = new System.Drawing.Size(100, 105);
            this.seventhDigit.TabIndex = 4;
            this.seventhDigit.Text = "7";
            this.seventhDigit.UseVisualStyleBackColor = false;
            this.seventhDigit.Click += new System.EventHandler(this.AddDigit);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(304, 286);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(0);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(100, 105);
            this.multiplyButton.TabIndex = 11;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.AddOperation);
            // 
            // sixthDigit
            // 
            this.sixthDigit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sixthDigit.Location = new System.Drawing.Point(204, 391);
            this.sixthDigit.Margin = new System.Windows.Forms.Padding(0);
            this.sixthDigit.Name = "sixthDigit";
            this.sixthDigit.Size = new System.Drawing.Size(100, 105);
            this.sixthDigit.TabIndex = 10;
            this.sixthDigit.Text = "6";
            this.sixthDigit.UseVisualStyleBackColor = false;
            this.sixthDigit.Click += new System.EventHandler(this.AddDigit);
            // 
            // fifthDigit
            // 
            this.fifthDigit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fifthDigit.Location = new System.Drawing.Point(103, 391);
            this.fifthDigit.Margin = new System.Windows.Forms.Padding(0);
            this.fifthDigit.Name = "fifthDigit";
            this.fifthDigit.Size = new System.Drawing.Size(100, 105);
            this.fifthDigit.TabIndex = 9;
            this.fifthDigit.Text = "5";
            this.fifthDigit.UseVisualStyleBackColor = false;
            this.fifthDigit.Click += new System.EventHandler(this.AddDigit);
            // 
            // fourthDigit
            // 
            this.fourthDigit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fourthDigit.Location = new System.Drawing.Point(3, 391);
            this.fourthDigit.Margin = new System.Windows.Forms.Padding(0);
            this.fourthDigit.Name = "fourthDigit";
            this.fourthDigit.Size = new System.Drawing.Size(100, 105);
            this.fourthDigit.TabIndex = 8;
            this.fourthDigit.Text = "4";
            this.fourthDigit.UseVisualStyleBackColor = false;
            this.fourthDigit.Click += new System.EventHandler(this.AddDigit);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(304, 496);
            this.plusButton.Margin = new System.Windows.Forms.Padding(0);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(100, 105);
            this.plusButton.TabIndex = 15;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.AddOperation);
            // 
            // thirdDigit
            // 
            this.thirdDigit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.thirdDigit.Location = new System.Drawing.Point(204, 496);
            this.thirdDigit.Margin = new System.Windows.Forms.Padding(0);
            this.thirdDigit.Name = "thirdDigit";
            this.thirdDigit.Size = new System.Drawing.Size(100, 105);
            this.thirdDigit.TabIndex = 14;
            this.thirdDigit.Text = "3";
            this.thirdDigit.UseVisualStyleBackColor = false;
            this.thirdDigit.Click += new System.EventHandler(this.AddDigit);
            // 
            // secondDigit
            // 
            this.secondDigit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.secondDigit.Location = new System.Drawing.Point(103, 496);
            this.secondDigit.Margin = new System.Windows.Forms.Padding(0);
            this.secondDigit.Name = "secondDigit";
            this.secondDigit.Size = new System.Drawing.Size(100, 105);
            this.secondDigit.TabIndex = 13;
            this.secondDigit.Text = "2";
            this.secondDigit.UseVisualStyleBackColor = false;
            this.secondDigit.Click += new System.EventHandler(this.AddDigit);
            // 
            // firstDigit
            // 
            this.firstDigit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstDigit.Location = new System.Drawing.Point(3, 496);
            this.firstDigit.Margin = new System.Windows.Forms.Padding(0);
            this.firstDigit.Name = "firstDigit";
            this.firstDigit.Size = new System.Drawing.Size(100, 105);
            this.firstDigit.TabIndex = 12;
            this.firstDigit.Text = "1";
            this.firstDigit.UseVisualStyleBackColor = false;
            this.firstDigit.Click += new System.EventHandler(this.AddDigit);
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calcButton.Location = new System.Drawing.Point(304, 601);
            this.calcButton.Margin = new System.Windows.Forms.Padding(0);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 105);
            this.calcButton.TabIndex = 19;
            this.calcButton.Text = "=";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.CalcExpression);
            // 
            // zeroDigit
            // 
            this.zeroDigit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.zeroDigit.Location = new System.Drawing.Point(104, 601);
            this.zeroDigit.Margin = new System.Windows.Forms.Padding(0);
            this.zeroDigit.Name = "zeroDigit";
            this.zeroDigit.Size = new System.Drawing.Size(100, 105);
            this.zeroDigit.TabIndex = 17;
            this.zeroDigit.Text = "0";
            this.zeroDigit.UseVisualStyleBackColor = false;
            this.zeroDigit.Click += new System.EventHandler(this.AddDigit);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("SF Pro Display", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.Location = new System.Drawing.Point(3, 81);
            this.number.Margin = new System.Windows.Forms.Padding(0);
            this.number.Name = "number";
            this.number.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.number.Size = new System.Drawing.Size(401, 90);
            this.number.TabIndex = 20;
            this.number.Text = "0";
            // 
            // expression
            // 
            this.expression.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expression.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.expression.Location = new System.Drawing.Point(3, 31);
            this.expression.Name = "expression";
            this.expression.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.expression.Size = new System.Drawing.Size(401, 17);
            this.expression.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 707);
            this.Controls.Add(this.expression);
            this.Controls.Add(this.number);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.zeroDigit);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.thirdDigit);
            this.Controls.Add(this.secondDigit);
            this.Controls.Add(this.firstDigit);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.sixthDigit);
            this.Controls.Add(this.fifthDigit);
            this.Controls.Add(this.fourthDigit);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.ninthDigit);
            this.Controls.Add(this.eightDigit);
            this.Controls.Add(this.seventhDigit);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.clearExpressionButton);
            this.Controls.Add(this.clearNumberButton);
            this.Font = new System.Drawing.Font("SF Pro Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearNumberButton;
        private System.Windows.Forms.Button clearExpressionButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button ninthDigit;
        private System.Windows.Forms.Button eightDigit;
        private System.Windows.Forms.Button seventhDigit;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button sixthDigit;
        private System.Windows.Forms.Button fifthDigit;
        private System.Windows.Forms.Button fourthDigit;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button thirdDigit;
        private System.Windows.Forms.Button secondDigit;
        private System.Windows.Forms.Button firstDigit;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button zeroDigit;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label expression;
    }
}

