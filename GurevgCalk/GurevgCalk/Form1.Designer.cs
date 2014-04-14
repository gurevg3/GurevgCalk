namespace GurevgCalk
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
            this.Adder = new System.Windows.Forms.Button();
            this.Substraction = new System.Windows.Forms.Button();
            this.Multiplayer = new System.Windows.Forms.Button();
            this.Devision = new System.Windows.Forms.Button();
            this.Operand1 = new System.Windows.Forms.TextBox();
            this.Operand2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Adder
            // 
            this.Adder.Location = new System.Drawing.Point(56, 108);
            this.Adder.Name = "Adder";
            this.Adder.Size = new System.Drawing.Size(75, 23);
            this.Adder.TabIndex = 0;
            this.Adder.Text = "+";
            this.Adder.UseVisualStyleBackColor = true;
            this.Adder.Click += new System.EventHandler(this.Adder_Click);
            // 
            // Substraction
            // 
            this.Substraction.Location = new System.Drawing.Point(155, 108);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(75, 23);
            this.Substraction.TabIndex = 1;
            this.Substraction.Text = "-";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.Substraction_Click);
            // 
            // Multiplayer
            // 
            this.Multiplayer.Location = new System.Drawing.Point(56, 156);
            this.Multiplayer.Name = "Multiplayer";
            this.Multiplayer.Size = new System.Drawing.Size(75, 23);
            this.Multiplayer.TabIndex = 2;
            this.Multiplayer.Text = "*";
            this.Multiplayer.UseVisualStyleBackColor = true;
            this.Multiplayer.Click += new System.EventHandler(this.Multiplayer_Click);
            // 
            // Devision
            // 
            this.Devision.Location = new System.Drawing.Point(155, 156);
            this.Devision.Name = "Devision";
            this.Devision.Size = new System.Drawing.Size(75, 23);
            this.Devision.TabIndex = 3;
            this.Devision.Text = "/";
            this.Devision.UseVisualStyleBackColor = true;
            this.Devision.Click += new System.EventHandler(this.Devision_Click);
            // 
            // Operand1
            // 
            this.Operand1.Location = new System.Drawing.Point(27, 33);
            this.Operand1.Name = "Operand1";
            this.Operand1.Size = new System.Drawing.Size(39, 20);
            this.Operand1.TabIndex = 4;
            // 
            // Operand2
            // 
            this.Operand2.Location = new System.Drawing.Point(127, 34);
            this.Operand2.Name = "Operand2";
            this.Operand2.Size = new System.Drawing.Size(49, 20);
            this.Operand2.TabIndex = 5;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(230, 34);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(42, 20);
            this.Result.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Operand2);
            this.Controls.Add(this.Operand1);
            this.Controls.Add(this.Devision);
            this.Controls.Add(this.Multiplayer);
            this.Controls.Add(this.Substraction);
            this.Controls.Add(this.Adder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adder;
        private System.Windows.Forms.Button Substraction;
        private System.Windows.Forms.Button Multiplayer;
        private System.Windows.Forms.Button Devision;
        private System.Windows.Forms.TextBox Operand1;
        private System.Windows.Forms.TextBox Operand2;
        private System.Windows.Forms.TextBox Result;
    }
}

