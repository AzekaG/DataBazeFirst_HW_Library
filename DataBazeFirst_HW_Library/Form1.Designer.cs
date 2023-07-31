namespace DataBazeFirst_HW_Library
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelnameBook = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAmountPages = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelPublishHouse = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, -17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(615, 290);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(621, 42);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(166, 23);
            this.buttonChange.TabIndex = 16;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(621, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(166, 23);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelnameBook
            // 
            this.labelnameBook.AutoSize = true;
            this.labelnameBook.Location = new System.Drawing.Point(-3, 293);
            this.labelnameBook.Name = "labelnameBook";
            this.labelnameBook.Size = new System.Drawing.Size(90, 13);
            this.labelnameBook.TabIndex = 18;
            this.labelnameBook.Text = "Название Книги";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 19;
            // 
            // labelAmountPages
            // 
            this.labelAmountPages.AutoSize = true;
            this.labelAmountPages.Location = new System.Drawing.Point(-3, 332);
            this.labelAmountPages.Name = "labelAmountPages";
            this.labelAmountPages.Size = new System.Drawing.Size(110, 13);
            this.labelAmountPages.TabIndex = 20;
            this.labelAmountPages.Text = "Количество страниц";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 348);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 20);
            this.textBox2.TabIndex = 21;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(-3, 371);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(60, 13);
            this.labelCategory.TabIndex = 22;
            this.labelCategory.Text = "Категория";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 387);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 20);
            this.textBox3.TabIndex = 23;
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(-3, 410);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(37, 13);
            this.labelAuthorName.TabIndex = 24;
            this.labelAuthorName.Text = "Автор";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 426);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(252, 20);
            this.textBox4.TabIndex = 25;
            // 
            // labelPublishHouse
            // 
            this.labelPublishHouse.AutoSize = true;
            this.labelPublishHouse.Location = new System.Drawing.Point(-3, 449);
            this.labelPublishHouse.Name = "labelPublishHouse";
            this.labelPublishHouse.Size = new System.Drawing.Size(79, 13);
            this.labelPublishHouse.TabIndex = 26;
            this.labelPublishHouse.Text = "Издательство";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(0, 465);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(252, 20);
            this.textBox5.TabIndex = 27;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(295, 462);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBook.TabIndex = 28;
            this.buttonAddBook.Text = "Добавить книгу";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labelPublishHouse);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelAuthorName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelAmountPages);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelnameBook);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelnameBook;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelAmountPages;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelPublishHouse;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button buttonAddBook;
    }
}

