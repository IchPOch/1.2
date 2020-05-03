namespace Практика
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
            this.Trex = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Chis = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.Label();
            this.Perexod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Trex
            // 
            this.Trex.AutoSize = true;
            this.Trex.Location = new System.Drawing.Point(9, 119);
            this.Trex.Name = "Trex";
            this.Trex.Size = new System.Drawing.Size(104, 13);
            this.Trex.TabIndex = 0;
            this.Trex.Text = "Трёхзначное число";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(98, 161);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 1;
            this.Search.Text = "Найти";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Chis
            // 
            this.Chis.Location = new System.Drawing.Point(12, 135);
            this.Chis.Name = "Chis";
            this.Chis.Size = new System.Drawing.Size(100, 20);
            this.Chis.TabIndex = 2;
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(127, 138);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(0, 13);
            this.Max.TabIndex = 4;
            // 
            // Perexod
            // 
            this.Perexod.Location = new System.Drawing.Point(630, 376);
            this.Perexod.Name = "Perexod";
            this.Perexod.Size = new System.Drawing.Size(149, 29);
            this.Perexod.TabIndex = 5;
            this.Perexod.Text = "Переход ко 2 заданию";
            this.Perexod.UseVisualStyleBackColor = true;
            this.Perexod.Click += new System.EventHandler(this.Perexod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Perexod);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Chis);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Trex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Trex;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Chis;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Button Perexod;
    }
}

