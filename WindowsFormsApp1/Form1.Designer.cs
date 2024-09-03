namespace WindowsFormsApp1
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
            this.buttonSolve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSystem = new System.Windows.Forms.TextBox();
            this.textBoxPriceOP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxOpRes = new System.Windows.Forms.TextBox();
            this.textBoxOptiRes = new System.Windows.Forms.TextBox();
            this.textBoxPriceOpti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWant = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHave = new System.Windows.Forms.TextBox();
            this.textBoxQueue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(16, 498);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(438, 58);
            this.buttonSolve.TabIndex = 5;
            this.buttonSolve.Text = "Розрахувати";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Матриця вартості";
            // 
            // textBoxSystem
            // 
            this.textBoxSystem.Location = new System.Drawing.Point(16, 39);
            this.textBoxSystem.Multiline = true;
            this.textBoxSystem.Name = "textBoxSystem";
            this.textBoxSystem.Size = new System.Drawing.Size(213, 241);
            this.textBoxSystem.TabIndex = 0;
            // 
            // textBoxPriceOP
            // 
            this.textBoxPriceOP.Location = new System.Drawing.Point(16, 472);
            this.textBoxPriceOP.Name = "textBoxPriceOP";
            this.textBoxPriceOP.Size = new System.Drawing.Size(213, 20);
            this.textBoxPriceOP.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 456);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Вартість";
            // 
            // textBoxOpRes
            // 
            this.textBoxOpRes.Location = new System.Drawing.Point(17, 305);
            this.textBoxOpRes.Multiline = true;
            this.textBoxOpRes.Name = "textBoxOpRes";
            this.textBoxOpRes.Size = new System.Drawing.Size(212, 135);
            this.textBoxOpRes.TabIndex = 28;
            // 
            // textBoxOptiRes
            // 
            this.textBoxOptiRes.Location = new System.Drawing.Point(242, 305);
            this.textBoxOptiRes.Multiline = true;
            this.textBoxOptiRes.Name = "textBoxOptiRes";
            this.textBoxOptiRes.Size = new System.Drawing.Size(212, 135);
            this.textBoxOptiRes.TabIndex = 30;
            // 
            // textBoxPriceOpti
            // 
            this.textBoxPriceOpti.Location = new System.Drawing.Point(241, 472);
            this.textBoxPriceOpti.Name = "textBoxPriceOpti";
            this.textBoxPriceOpti.Size = new System.Drawing.Size(213, 20);
            this.textBoxPriceOpti.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Вартість";
            // 
            // textBoxWant
            // 
            this.textBoxWant.Location = new System.Drawing.Point(242, 117);
            this.textBoxWant.Name = "textBoxWant";
            this.textBoxWant.Size = new System.Drawing.Size(202, 20);
            this.textBoxWant.TabIndex = 32;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(239, 101);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 13);
            this.label.TabIndex = 33;
            this.label.Text = "Заявки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Запаси";
            // 
            // textBoxHave
            // 
            this.textBoxHave.Location = new System.Drawing.Point(242, 60);
            this.textBoxHave.Name = "textBoxHave";
            this.textBoxHave.Size = new System.Drawing.Size(202, 20);
            this.textBoxHave.TabIndex = 34;
            // 
            // textBoxQueue
            // 
            this.textBoxQueue.Location = new System.Drawing.Point(242, 243);
            this.textBoxQueue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxQueue.Multiline = true;
            this.textBoxQueue.Name = "textBoxQueue";
            this.textBoxQueue.Size = new System.Drawing.Size(202, 37);
            this.textBoxQueue.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Базові клітинки що треба змінити";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Опорний план";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Оптимальний план";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 568);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQueue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxHave);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxWant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOptiRes);
            this.Controls.Add(this.textBoxPriceOpti);
            this.Controls.Add(this.textBoxOpRes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxPriceOP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.textBoxSystem);
            this.Name = "Form1";
            this.Text = "LR8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSystem;
        private System.Windows.Forms.TextBox textBoxPriceOP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxOpRes;
        private System.Windows.Forms.TextBox textBoxOptiRes;
        private System.Windows.Forms.TextBox textBoxPriceOpti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWant;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHave;
        private System.Windows.Forms.TextBox textBoxQueue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

