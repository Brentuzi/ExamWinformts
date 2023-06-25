namespace Exam
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.городскойТранспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.городскойТранспортToolStripMenuItem,
            this.контактыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // городскойТранспортToolStripMenuItem
            // 
            this.городскойТранспортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.маршрутыToolStripMenuItem,
            this.путиToolStripMenuItem});
            this.городскойТранспортToolStripMenuItem.Name = "городскойТранспортToolStripMenuItem";
            this.городскойТранспортToolStripMenuItem.Size = new System.Drawing.Size(149, 21);
            this.городскойТранспортToolStripMenuItem.Text = "Городской транспорт";
            // 
            // маршрутыToolStripMenuItem
            // 
            this.маршрутыToolStripMenuItem.Name = "маршрутыToolStripMenuItem";
            this.маршрутыToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.маршрутыToolStripMenuItem.Text = "Маршруты ";
            this.маршрутыToolStripMenuItem.Click += new System.EventHandler(this.маршрутыToolStripMenuItem_Click);
            // 
            // путиToolStripMenuItem
            // 
            this.путиToolStripMenuItem.Name = "путиToolStripMenuItem";
            this.путиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.путиToolStripMenuItem.Text = "Пути";
            this.путиToolStripMenuItem.Click += new System.EventHandler(this.путиToolStripMenuItem_Click);
            // 
            // контактыToolStripMenuItem
            // 
            this.контактыToolStripMenuItem.Name = "контактыToolStripMenuItem";
            this.контактыToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.контактыToolStripMenuItem.Text = "Контакты";
            this.контактыToolStripMenuItem.Click += new System.EventHandler(this.контактыToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Авторизация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Городской транспорт";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Авторизованы как пользователь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(597, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пассажирские перевозки в Санкт-Петербурге";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 382);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem городскойТранспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршрутыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контактыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

