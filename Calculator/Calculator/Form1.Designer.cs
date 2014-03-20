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
            this.SuspendLayout();
            // 
            // FirstArgument
            // 
            this.FirstArgument.Location = new System.Drawing.Point(13, 25);
            this.FirstArgument.Name = "FirstArgument";
            this.FirstArgument.Size = new System.Drawing.Size(259, 20);
            this.FirstArgument.TabIndex = 0;
            // 
            // SecondArgument
            // 
            this.SecondArgument.Location = new System.Drawing.Point(13, 70);
            this.SecondArgument.Name = "SecondArgument";
            this.SecondArgument.Size = new System.Drawing.Size(259, 20);
            this.SecondArgument.TabIndex = 1;
            // 
            // ResultField
            // 
            this.ResultField.Location = new System.Drawing.Point(13, 113);
            this.ResultField.Name = "ResultField";
            this.ResultField.Size = new System.Drawing.Size(259, 20);
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
            // 
            // Substraction
            // 
            this.Substraction.Location = new System.Drawing.Point(12, 169);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(80, 23);
            this.Substraction.TabIndex = 7;
            this.Substraction.Text = "Вычитание";
            this.Substraction.UseVisualStyleBackColor = true;
            // 
            // Multiplication
            // 
            this.Multiplication.Location = new System.Drawing.Point(13, 199);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(79, 23);
            this.Multiplication.TabIndex = 8;
            this.Multiplication.Text = "Умножение";
            this.Multiplication.UseVisualStyleBackColor = true;
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(13, 229);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(79, 23);
            this.Division.TabIndex = 9;
            this.Division.Text = "Деление";
            this.Division.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
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
    }
}

