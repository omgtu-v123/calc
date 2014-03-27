namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstArgument = new System.Windows.Forms.TextBox();
            this.SecondArgument = new System.Windows.Forms.TextBox();
            this.ResultField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Addition = new System.Windows.Forms.Button();
            this.Substraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.Root = new System.Windows.Forms.Button();
            this.Logarithm = new System.Windows.Forms.Button();
            this.Radius = new System.Windows.Forms.Button();
            this.Sine = new System.Windows.Forms.Button();
            this.Cosine = new System.Windows.Forms.Button();
            this.Tangent = new System.Windows.Forms.Button();
            this.Cotangent = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Arctan = new System.Windows.Forms.Button();
            this.Arcctg = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.CubeSqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstArgument
            // 
            this.FirstArgument.Location = new System.Drawing.Point(13, 25);
            this.FirstArgument.Name = "FirstArgument";
            this.FirstArgument.Size = new System.Drawing.Size(336, 20);
            this.FirstArgument.TabIndex = 0;
            // 
            // SecondArgument
            // 
            this.SecondArgument.Location = new System.Drawing.Point(13, 70);
            this.SecondArgument.Name = "SecondArgument";
            this.SecondArgument.Size = new System.Drawing.Size(336, 20);
            this.SecondArgument.TabIndex = 1;
            // 
            // ResultField
            // 
            this.ResultField.Location = new System.Drawing.Point(13, 113);
            this.ResultField.Name = "ResultField";
            this.ResultField.Size = new System.Drawing.Size(336, 20);
            this.ResultField.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Аргумент 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Аргумент 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат";
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(12, 139);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(80, 23);
            this.Addition.TabIndex = 6;
            this.Addition.Text = "Сложение";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Substraction
            // 
            this.Substraction.Location = new System.Drawing.Point(12, 169);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(80, 23);
            this.Substraction.TabIndex = 7;
            this.Substraction.Text = "Вычитание";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.Substraction_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(13, 199);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(79, 23);
            this.Multiplication.TabIndex = 8;
            this.Multiplication.Text = "Умножение";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Multiplication_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(13, 229);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(79, 23);
            this.Division.TabIndex = 9;
            this.Division.Text = "Деление";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Pow
            // 
            this.Pow.Location = new System.Drawing.Point(99, 139);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(75, 23);
            this.Pow.TabIndex = 10;
            this.Pow.Text = "Степень";
            this.Pow.UseVisualStyleBackColor = true;
            this.Pow.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Root
            // 
            this.Root.Location = new System.Drawing.Point(99, 169);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(75, 23);
            this.Root.TabIndex = 11;
            this.Root.Text = "Корень";
            this.Root.UseVisualStyleBackColor = true;
            this.Root.Click += new System.EventHandler(this.Root_Click);
            // 
            // Logarithm
            // 
            this.Logarithm.Location = new System.Drawing.Point(99, 199);
            this.Logarithm.Name = "Logarithm";
            this.Logarithm.Size = new System.Drawing.Size(75, 23);
            this.Logarithm.TabIndex = 12;
            this.Logarithm.Text = "Логарифм";
            this.Logarithm.UseVisualStyleBackColor = true;
            this.Logarithm.Click += new System.EventHandler(this.Logarithm_Click);
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(99, 229);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(75, 23);
            this.Radius.TabIndex = 13;
            this.Radius.Text = "Радиус";
            this.Radius.UseVisualStyleBackColor = true;
            this.Radius.Click += new System.EventHandler(this.Radius_Click);
            // 
            // Sine
            // 
            this.Sine.Location = new System.Drawing.Point(181, 138);
            this.Sine.Name = "Sine";
            this.Sine.Size = new System.Drawing.Size(39, 24);
            this.Sine.TabIndex = 14;
            this.Sine.Text = "Sin";
            this.Sine.UseVisualStyleBackColor = true;
            this.Sine.Click += new System.EventHandler(this.Sine_Click);
            // 
            // Cosine
            // 
            this.Cosine.Location = new System.Drawing.Point(181, 168);
            this.Cosine.Name = "Cosine";
            this.Cosine.Size = new System.Drawing.Size(39, 24);
            this.Cosine.TabIndex = 15;
            this.Cosine.Text = "Cos";
            this.Cosine.UseVisualStyleBackColor = true;
            this.Cosine.Click += new System.EventHandler(this.Cosine_Click);
            // 
            // Tangent
            // 
            this.Tangent.Location = new System.Drawing.Point(181, 200);
            this.Tangent.Name = "Tangent";
            this.Tangent.Size = new System.Drawing.Size(39, 22);
            this.Tangent.TabIndex = 16;
            this.Tangent.Text = "Tan";
            this.Tangent.UseVisualStyleBackColor = true;
            this.Tangent.Click += new System.EventHandler(this.Tangent_Click);
            // 
            // Cotangent
            // 
            this.Cotangent.Location = new System.Drawing.Point(181, 228);
            this.Cotangent.Name = "Cotangent";
            this.Cotangent.Size = new System.Drawing.Size(39, 24);
            this.Cotangent.TabIndex = 17;
            this.Cotangent.Text = "Ctg";
            this.Cotangent.UseVisualStyleBackColor = true;
            this.Cotangent.Click += new System.EventHandler(this.Cotangent_Click);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(227, 140);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(62, 22);
            this.Arcsin.TabIndex = 18;
            this.Arcsin.Text = "Arcsin";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.Arcsin_Click);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(227, 169);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(62, 23);
            this.Arccos.TabIndex = 19;
            this.Arccos.Text = "Arccos";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.Arccos_Click);
            // 
            // Arctan
            // 
            this.Arctan.Location = new System.Drawing.Point(227, 200);
            this.Arctan.Name = "Arctan";
            this.Arctan.Size = new System.Drawing.Size(62, 22);
            this.Arctan.TabIndex = 20;
            this.Arctan.Text = "Arctng";
            this.Arctan.UseVisualStyleBackColor = true;
            this.Arctan.Click += new System.EventHandler(this.Arctan_Click);
            // 
            // Arcctg
            // 
            this.Arcctg.Location = new System.Drawing.Point(227, 229);
            this.Arcctg.Name = "Arcctg";
            this.Arcctg.Size = new System.Drawing.Size(62, 23);
            this.Arcctg.TabIndex = 21;
            this.Arcctg.Text = "Arcctg";
            this.Arcctg.UseVisualStyleBackColor = true;
            this.Arcctg.Click += new System.EventHandler(this.Arcctg_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(295, 140);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(54, 22);
            this.Sqrt.TabIndex = 22;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click_1);
            // 
            // CubeSqrt
            // 
            this.CubeSqrt.Location = new System.Drawing.Point(296, 169);
            this.CubeSqrt.Name = "CubeSqrt";
            this.CubeSqrt.Size = new System.Drawing.Size(53, 23);
            this.CubeSqrt.TabIndex = 23;
            this.CubeSqrt.Text = "CSqrt";
            this.CubeSqrt.UseVisualStyleBackColor = true;
            this.CubeSqrt.Click += new System.EventHandler(this.CubeSqrt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 262);
            this.Controls.Add(this.CubeSqrt);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Arcctg);
            this.Controls.Add(this.Arctan);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Cotangent);
            this.Controls.Add(this.Tangent);
            this.Controls.Add(this.Cosine);
            this.Controls.Add(this.Sine);
            this.Controls.Add(this.Radius);
            this.Controls.Add(this.Logarithm);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Substraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultField);
            this.Controls.Add(this.SecondArgument);
            this.Controls.Add(this.FirstArgument);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstArgument;
        private System.Windows.Forms.TextBox SecondArgument;
        private System.Windows.Forms.TextBox ResultField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Substraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Pow;
        private System.Windows.Forms.Button Root;
        private System.Windows.Forms.Button Logarithm;
        private System.Windows.Forms.Button Radius;
        private System.Windows.Forms.Button Sine;
        private System.Windows.Forms.Button Cosine;
        private System.Windows.Forms.Button Tangent;
        private System.Windows.Forms.Button Cotangent;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Arctan;
        private System.Windows.Forms.Button Arcctg;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button CubeSqrt;
    }
}

