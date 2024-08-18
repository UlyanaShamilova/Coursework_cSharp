namespace BD_MySql_RecipeBook
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.breakfast = new System.Windows.Forms.Button();
            this.lunch = new System.Windows.Forms.Button();
            this.dinner = new System.Windows.Forms.Button();
            this.dessert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(369, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1142, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваша електронна книга рецептів";
            // 
            // breakfast
            // 
            this.breakfast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.breakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.breakfast.Location = new System.Drawing.Point(220, 199);
            this.breakfast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.breakfast.Name = "breakfast";
            this.breakfast.Size = new System.Drawing.Size(244, 71);
            this.breakfast.TabIndex = 1;
            this.breakfast.Text = "Сніданок";
            this.breakfast.UseVisualStyleBackColor = true;
            this.breakfast.Click += new System.EventHandler(this.breakfast_Click);
            // 
            // lunch
            // 
            this.lunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lunch.Location = new System.Drawing.Point(827, 199);
            this.lunch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lunch.Name = "lunch";
            this.lunch.Size = new System.Drawing.Size(244, 71);
            this.lunch.TabIndex = 2;
            this.lunch.Text = "Обід";
            this.lunch.UseVisualStyleBackColor = true;
            this.lunch.Click += new System.EventHandler(this.lunch_Click);
            // 
            // dinner
            // 
            this.dinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dinner.Location = new System.Drawing.Point(220, 624);
            this.dinner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dinner.Name = "dinner";
            this.dinner.Size = new System.Drawing.Size(244, 71);
            this.dinner.TabIndex = 3;
            this.dinner.Text = "Вечеря";
            this.dinner.UseVisualStyleBackColor = true;
            this.dinner.Click += new System.EventHandler(this.dinner_Click);
            // 
            // dessert
            // 
            this.dessert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dessert.Location = new System.Drawing.Point(843, 623);
            this.dessert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dessert.Name = "dessert";
            this.dessert.Size = new System.Drawing.Size(244, 71);
            this.dessert.TabIndex = 5;
            this.dessert.Text = "Десерти";
            this.dessert.UseVisualStyleBackColor = true;
            this.dessert.Click += new System.EventHandler(this.dessert_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(239, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 194);
            this.label2.TabIndex = 6;
            this.label2.Text = "Каші та овсянки\r\n\r\nТости та блинчики\r\n\r\nФруктові салати";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(843, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 194);
            this.label3.TabIndex = 7;
            this.label3.Text = "Супи та бульйони\r\n\r\nСалати та закуски\r\n\r\nГарніри та каші";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(212, 732);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 194);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пасти та ризотто\r\n\r\nМ\'ясні та рибні страви\r\n\r\nБарбекю";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(883, 732);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 194);
            this.label6.TabIndex = 10;
            this.label6.Text = "Торти \r\n\r\nТістечка \r\n\r\nПироги\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1253, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(483, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Бажаєте додати свій рецепт? ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1407, 362);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1353, 854);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(345, 58);
            this.button2.TabIndex = 13;
            this.button2.Text = "Мої рецепти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1784, 976);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dessert);
            this.Controls.Add(this.dinner);
            this.Controls.Add(this.lunch);
            this.Controls.Add(this.breakfast);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button breakfast;
        private System.Windows.Forms.Button lunch;
        private System.Windows.Forms.Button dinner;
        private System.Windows.Forms.Button dessert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

