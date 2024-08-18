using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace BD_MySql_RecipeBook
{
    public partial class FormBreakfast : Form
    {
        private int selectedRecipeId = -1;
        public FormBreakfast()
        {
            InitializeComponent();
        }

        private void breakfast_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 7", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);

            bool dgvFound = false;

            // Проходження крізь усі елементи на формі
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];

                // Перевірка, чи це DataGridView
                if (control is DataGridView)
                {
                    dgvFound = true;
                    continue;
                }

                // Якщо dataGridView вже знайдено, видаляємо решту елементів
                if (dgvFound)
                {
                    control.Dispose();
                }
            }

            dgv1.Visible = true;

            dgv1.DataSource = table;

            // снятие выделения активной клетки при запуске
            dgv1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 1", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);

            bool dgvFound = false;

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];

                if (control is DataGridView)
                {
                    dgvFound = true;
                    continue;
                }

                if (dgvFound)
                {
                    control.Dispose();
                }
            }

            dgv1.Visible = true;

            dgv1.DataSource = table;

            dgv1.ClearSelection();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 2", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);

            bool dgvFound = false;

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];

                if (control is DataGridView)
                {
                    dgvFound = true;
                    continue;
                }

                if (dgvFound)
                {
                    control.Dispose();
                }
            }

            dgv1.Visible = true;

            dgv1.DataSource = table;

            dgv1.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 3", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);

            bool dgvFound = false;

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];

                if (control is DataGridView)
                {
                    dgvFound = true;
                    continue;
                }

                if (dgvFound)
                {
                    control.Dispose();
                }
            }

            dgv1.Visible = true;

            dgv1.DataSource = table;

            dgv1.ClearSelection();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 4", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);

            bool dgvFound = false;

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];

                if (control is DataGridView)
                {
                    dgvFound = true;
                    continue;
                }

                if (dgvFound)
                {
                    control.Dispose();
                }
            }

            dgv1.Visible = true;

            dgv1.DataSource = table;

            dgv1.ClearSelection();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 5", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);

            bool dgvFound = false;

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];

                if (control is DataGridView)
                {
                    dgvFound = true;
                    continue;
                }

                if (dgvFound)
                {
                    control.Dispose();
                }
            }

            dgv1.Visible = true;

            dgv1.DataSource = table;

            dgv1.ClearSelection();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 6", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);

            bool dgvFound = false;

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];

                if (control is DataGridView)
                {
                    dgvFound = true;
                    continue;
                }

                if (dgvFound)
                {
                    control.Dispose();
                }
            }

            dgv1.Visible = true;

            dgv1.DataSource = table;

            dgv1.ClearSelection();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 8", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);

            bool dgvFound = false;

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];

                if (control is DataGridView)
                {
                    dgvFound = true;
                    continue;
                }

                if (dgvFound)
                {
                    control.Dispose();
                }
            }

            dgv1.Visible = true;

            dgv1.DataSource = table;

            dgv1.ClearSelection();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 9", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);

            bool dgvFound = false;

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];

                if (control is DataGridView)
                {
                    dgvFound = true;
                    continue;
                }

                if (dgvFound)
                {
                    control.Dispose();
                }
            }

            dgv1.Visible = true;

            dgv1.DataSource = table;

            dgv1.ClearSelection();
        }

        private void search_bt_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 7", db.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                string recipeName = row["name"].ToString();
                string ingredients = row["ingredients"].ToString();
                string instructions = row["instructions"].ToString();

                // Вызов метода отправки рецепта на почту
                string recipientEmail = Convert.ToString(textBox1.Text);
                SendEmail(recipeName, ingredients, instructions, recipientEmail);
            }
            else
            {
                MessageBox.Show("Рецепт не найден.");
            }
        }




        private void SendEmail(string recipeName, string ingredients, string instructions, string recipientEmail)
        {
            try
            {
                // Создаем письмо
                MailMessage mail = new MailMessage(); // объект письма
                mail.From = new MailAddress("ulanasamileva1@gmail.com"); // адрес отправителя письма
                mail.To.Add(recipientEmail); // адрес получателя
                mail.Subject = $"Recipe: {recipeName}"; // тема письма

                // Формируем тело письма
                StringBuilder sb = new StringBuilder(); // объект для работы со строкой
                sb.AppendLine($"Recipe Name: {recipeName}"); // добавляем название рецепта в письмо
                sb.AppendLine(); // добавляем пустую строку
                sb.AppendLine("Ingredients:"); // добавляем заголовок "ингредиенты"
                sb.AppendLine(ingredients); // добавляем список ингредиентов
                sb.AppendLine(); // добавляем пустую строку
                sb.AppendLine("Instructions:"); // добавляем заголовок "инструкции"
                sb.AppendLine(instructions); // добавляем инструкции приготовления

                mail.Body = sb.ToString(); // преобразует собранный текст в StringBuilder в строку и установит ее как тело письма

                // Настройки SMTP клиента
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com") // объект для отправки письма через SMTP сервер
                {
                    Port = 587,
                    Credentials = new NetworkCredential("ulanasamileva1@gmail.com", "abrv woqs xotl cuax"),
                    EnableSsl = true,
                };

                // Отправка письма
                smtpClient.Send(mail); // отправка письма
                MessageBox.Show("Рецепт успешно отправлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отправке письма: {ex.Message}");
            }
        }



    }
}