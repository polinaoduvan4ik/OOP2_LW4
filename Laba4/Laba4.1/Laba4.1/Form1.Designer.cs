namespace Laba4._1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sortdown = new System.Windows.Forms.Button();
            this.sortup = new System.Windows.Forms.Button();
            this.generation = new System.Windows.Forms.Button();
            this.request1 = new System.Windows.Forms.Button();
            this.request2 = new System.Windows.Forms.Button();
            this.request3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 22);
            this.textBox1.TabIndex = 0;
            // 
            // sortdown
            // 
            this.sortdown.Location = new System.Drawing.Point(628, 160);
            this.sortdown.Name = "sortdown";
            this.sortdown.Size = new System.Drawing.Size(84, 37);
            this.sortdown.TabIndex = 1;
            this.sortdown.Text = "Sort Down";
            this.sortdown.UseVisualStyleBackColor = true;
            this.sortdown.Click += new System.EventHandler(this.sortdown_Click);
            // 
            // sortup
            // 
            this.sortup.Location = new System.Drawing.Point(91, 160);
            this.sortup.Name = "sortup";
            this.sortup.Size = new System.Drawing.Size(93, 37);
            this.sortup.TabIndex = 2;
            this.sortup.Text = "Sort Up";
            this.sortup.UseVisualStyleBackColor = true;
            this.sortup.Click += new System.EventHandler(this.sortup_Click);
            // 
            // generation
            // 
            this.generation.Location = new System.Drawing.Point(318, 136);
            this.generation.Name = "generation";
            this.generation.Size = new System.Drawing.Size(173, 103);
            this.generation.TabIndex = 3;
            this.generation.Text = "Generation";
            this.generation.UseVisualStyleBackColor = true;
            this.generation.Click += new System.EventHandler(this.generation_Click);
            // 
            // request1
            // 
            this.request1.Location = new System.Drawing.Point(108, 294);
            this.request1.Name = "request1";
            this.request1.Size = new System.Drawing.Size(120, 54);
            this.request1.TabIndex = 4;
            this.request1.Text = "request 1";
            this.request1.UseVisualStyleBackColor = true;
            this.request1.Click += new System.EventHandler(this.request1_Click);
            // 
            // request2
            // 
            this.request2.Location = new System.Drawing.Point(344, 294);
            this.request2.Name = "request2";
            this.request2.Size = new System.Drawing.Size(119, 54);
            this.request2.TabIndex = 5;
            this.request2.Text = "request 2";
            this.request2.UseVisualStyleBackColor = true;
            this.request2.Click += new System.EventHandler(this.request2_Click);
            // 
            // request3
            // 
            this.request3.Location = new System.Drawing.Point(593, 294);
            this.request3.Name = "request3";
            this.request3.Size = new System.Drawing.Size(119, 54);
            this.request3.TabIndex = 6;
            this.request3.Text = "request 3";
            this.request3.UseVisualStyleBackColor = true;
            this.request3.Click += new System.EventHandler(this.request3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.request3);
            this.Controls.Add(this.request2);
            this.Controls.Add(this.request1);
            this.Controls.Add(this.generation);
            this.Controls.Add(this.sortup);
            this.Controls.Add(this.sortdown);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sortdown;
        private System.Windows.Forms.Button sortup;
        private System.Windows.Forms.Button generation;
        private System.Windows.Forms.Button request1;
        private System.Windows.Forms.Button request2;
        private System.Windows.Forms.Button request3;
    }
}

