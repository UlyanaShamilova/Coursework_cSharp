using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_MySql_RecipeBook
{
    public partial class FormMain : Form
    {
        private MySqlConnection connection;
        public FormMain()
        {
            InitializeComponent();
            // Ініціалізація з'єднання
            string connectionString = "server=localhost;port=3306;username=root;password=root; database=recipes;";
            connection = new MySqlConnection(connectionString);
            connection.Open(); // Открываем соединение с базой данных
            GenerateRandomMenu();
        }

        // Функція для виконання SQL-запиту та повернення данних в DataTable
        private DataTable GetDataFromQuery(DBClass db, string query)
        {
            // Створюємо SQL-команду для виконання запиту
            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            // Створюємо адаптер для заповнення DataTable
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            // Створюємо таблицю для збереження результату запиту
            DataTable table = new DataTable();

            // Заповнюємо таблицю результатами виконання SQL-запиту
            adapter.Fill(table);

            // Повертаємо таблицу
            return table;
        }

        private void GenerateRandomMenu()
        {
            // Екземпляр класу для роботи з базою данних
            DBClass db = new DBClass();

            // SQL-запити для отримання 3 випадкових назв страв
            string breakfastQuery = "SELECT name FROM breakfast ORDER BY RAND() LIMIT 3";
            string lunchQuery = "SELECT name FROM lunch ORDER BY RAND() LIMIT 3";
            string dinnerQuery = "SELECT name FROM dinner ORDER BY RAND() LIMIT 3";
            string dessertQuery = "SELECT name FROM dessert ORDER BY RAND() LIMIT 3";

            // Після виконання запитів отримуємо данні у вигляді таблиць
            DataTable breakfastTable = GetDataFromQuery(db, breakfastQuery);
            DataTable lunchTable = GetDataFromQuery(db, lunchQuery);
            DataTable dinnerTable = GetDataFromQuery(db, dinnerQuery);
            DataTable dessertTable = GetDataFromQuery(db, dessertQuery);

            // Формуємо текст для категорії "Сніданок"
            label2.Text = ""; // Очищуємо label
            for (int i = 0; i < 3; i++)
            {
                string breakfastName = breakfastTable.Rows[i]["name"].ToString(); // Назва страви для сніданку
                label2.Text += "•" + breakfastName + "\n"; // Додаємо страву до label
            }

            // Формуємо текст для категорії "Обід"
            label4.Text = "";
            for (int i = 0; i < 3; i++)
            {
                string lunchName = lunchTable.Rows[i]["name"].ToString();
                label4.Text += "•" + lunchName + "\n";
            }

            // Формуємо текст для категорії "Вечеря"
            label3.Text = "";
            for (int i = 0; i < 3; i++)
            {
                string dinnerName = dinnerTable.Rows[i]["name"].ToString();
                label3.Text += "•" + dinnerName + "\n";
            }

            // Формуємо текст для категорії "Десерти"
            label6.Text = "";
            for (int i = 0; i < 3; i++)
            {
                string dessertName = dessertTable.Rows[i]["name"].ToString();
                label6.Text += "•" + dessertName + "\n";
            }
        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            label19.Visible = false;
            flowLayoutPanel1.Padding = new Padding(120, 150, 10, 10);
            flowLayoutPanel1.Enabled = true;
            flowLayoutPanel1.Controls.Clear(); // Очищуємо панель перед додаванням нових елементів

            // Налаштовуємо FlowLayoutPanel
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.AutoScroll = true;

            // Створення екземпляру классу для роботи з базою данних
            DBClass db = new DBClass();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM breakfast", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                string name = row["name"].ToString();
                string ingredients = row["ingredients"].ToString();
                string instructions = row["instructions"].ToString();

                Panel panel = new Panel { Width = 220, Height = 220, Margin = new Padding(10) };

                string dataForSend = $"{name}\n {ingredients}\n: {instructions}\n"; // зміст листа

                // Обробка зображення
                if (row["image"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row["image"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        try
                        {
                            Image image = Image.FromStream(ms);
                            PictureBox pictureBox = new PictureBox
                            {
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Image = image,
                                Height = 150,
                                Width = 200,
                                Tag = dataForSend // Якщо Tag установлено на картинці з рецептом, то при натисканні на цю картинку Tag можна використовувати для отримання інформації про рецепт
                            };
                            pictureBox.Click += PictureBox_Click; // додає обробника подій для події Click елементу pictureBox
                            panel.Controls.Add(pictureBox);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                        }
                    }
                }

                // Створення label для назви рецепту
                Label labelName = new Label
                {
                    Font = new Font("Segoe Script", 14, FontStyle.Regular),
                    Text = name,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Bottom,
                    AutoSize = false,
                    Height = 70
                };
                labelName.Click += LabelName_Click; // Додаємо обробник кліку

                panel.Controls.Add(labelName);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            button2.Visible = false;
            button2.Enabled = false;

            // Відображаємо всі рецепти знову
            label19_Click(null, null);
        }

        // Метод для відправки рецепта поштою
        private void SendRecipeEmail(string recipeDetails)
        {
            try
            {
                MailMessage mail = new MailMessage("ulanasamileva1@gmail.com", "ulanasamileva1@gmail.com");
                mail.Subject = "Рецепт блюда";
                mail.Body = $"Вот детали рецепта:\n\n{recipeDetails}";

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("ulanasamileva1@gmail.com", "zgqt bkwf pikm gkpq");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);

                MessageBox.Show("Рецепт успешно отправлен на почту.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отправке рецепта: {ex.Message}");
            }
        }

        // Обробник кліку для PictureBox
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null && pictureBox.Tag != null)
            {
                string recipeDetails = pictureBox.Tag.ToString();
                SendRecipeEmail(recipeDetails);
            }
            else
            {
                MessageBox.Show("Ошибка: информация о рецепте не найдена.");
            }
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            string selectedRecipeName = clickedLabel.Text;

            // Очищуємо поточні елементи керування
            flowLayoutPanel1.Controls.Clear();

            // Очищаємо DataGridView перед показом нових данних
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

            // Приховуємо DataGridView за замовченням
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;

            DBClass db = new DBClass();
            MySqlCommand command = new MySqlCommand("SELECT ingredients, instructions FROM breakfast WHERE name = @name", db.GetConnection());
            command.Parameters.AddWithValue("@name", selectedRecipeName);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            int rowCount = adapter.Fill(table);

            if (rowCount > 0)
            {
                // Підготовка таблиці для інгредієнтів
                DataTable ingredientsTable = new DataTable();
                ingredientsTable.Columns.Add("Інгредієнти");
                string[] ingredients = table.Rows[0]["ingredients"].ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string ingredient in ingredients)
                {
                    ingredientsTable.Rows.Add(ingredient.Trim());
                }

                dataGridView1.DataSource = ingredientsTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Підгон ширини стовбців
                dataGridView1.Visible = true; // Робимо його видимим тільки після завантаження данних

                // Підготовка таблиці для інструкції приготування
                DataTable instructionsTable = new DataTable();
                instructionsTable.Columns.Add("Інструкції приготування");
                instructionsTable.Rows.Add(table.Rows[0]["instructions"].ToString());

                dataGridView2.DataSource = instructionsTable;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView2.Visible = true;

                button2.Enabled = true;
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("Не найдено данных для этого рецепта.");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            label18.Visible = false;
            flowLayoutPanel2.Padding = new Padding(120, 150, 10, 10);
            flowLayoutPanel2.Enabled = true;
            flowLayoutPanel2.Controls.Clear();

            flowLayoutPanel2.WrapContents = true;
            flowLayoutPanel2.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel2.AutoScroll = true;

            DBClass db = new DBClass();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM lunch", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                string name = row["name"].ToString();
                string ingredients = row["ingredients"].ToString();
                string instructions = row["instructions"].ToString();

                Panel panel = new Panel { Width = 220, Height = 220, Margin = new Padding(10) };

                string dataForSend = $"{name}\n {ingredients}\n: {instructions}\n";

                if (row["image"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row["image"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        try
                        {
                            Image image = Image.FromStream(ms);
                            PictureBox pictureBox = new PictureBox
                            {
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Image = image,
                                Height = 150,
                                Width = 200,
                                Tag = dataForSend
                            };
                            pictureBox.Click += PictureBox_Click;
                            panel.Controls.Add(pictureBox);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                        }
                    }
                }

                Label labelName2 = new Label
                {
                    Font = new Font("Segoe Script", 14, FontStyle.Regular),
                    Text = name,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Bottom,
                    AutoSize = false,
                    Height = 70
                };
                labelName2.Click += LabelName2_Click;

                panel.Controls.Add(labelName2);
                flowLayoutPanel2.Controls.Add(panel);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            button3.Visible = false;
            button3.Enabled = false;

            // Відображаємо всі рецепти знову
            label18_Click(null, null);
        }
        private void LabelName2_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            string selectedRecipeName = clickedLabel.Text;

            flowLayoutPanel2.Controls.Clear();

            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;

            dataGridView3.Visible = false;
            dataGridView4.Visible = false;

            DBClass db = new DBClass();
            MySqlCommand command = new MySqlCommand("SELECT ingredients, instructions FROM lunch WHERE name = @name", db.GetConnection());
            command.Parameters.AddWithValue("@name", selectedRecipeName);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            int rowCount = adapter.Fill(table);

            if (rowCount > 0)
            {
                DataTable ingredientsTable = new DataTable();
                ingredientsTable.Columns.Add("Інгредієнти");
                string[] ingredients = table.Rows[0]["ingredients"].ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string ingredient in ingredients)
                {
                    ingredientsTable.Rows.Add(ingredient.Trim());
                }

                dataGridView3.DataSource = ingredientsTable;
                dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView3.Visible = true;

                DataTable instructionsTable = new DataTable();
                instructionsTable.Columns.Add("Інструкції приготування");
                instructionsTable.Rows.Add(table.Rows[0]["instructions"].ToString());

                dataGridView4.DataSource = instructionsTable;
                dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView4.Visible = true;

                button3.Enabled = true;
                button3.Visible = true;
            }
            else
            {
                MessageBox.Show("Не найдено данных для этого рецепта.");
            }
        }

        private void LabelName3_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            string selectedRecipeName = clickedLabel.Text;

            flowLayoutPanel2.Controls.Clear();

            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;

            dataGridView3.Visible = false;
            dataGridView4.Visible = false;

            DBClass db = new DBClass();
            MySqlCommand command = new MySqlCommand("SELECT ingredients, instructions FROM lunch WHERE name = @name", db.GetConnection());
            command.Parameters.AddWithValue("@name", selectedRecipeName);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            int rowCount = adapter.Fill(table);

            if (rowCount > 0)
            {
                DataTable ingredientsTable = new DataTable();
                ingredientsTable.Columns.Add("Інгредієнти");
                string[] ingredients = table.Rows[0]["ingredients"].ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string ingredient in ingredients)
                {
                    ingredientsTable.Rows.Add(ingredient.Trim());
                }

                dataGridView3.DataSource = ingredientsTable;
                dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView3.Visible = true;

                DataTable instructionsTable = new DataTable();
                instructionsTable.Columns.Add("Інструкції приготування");
                instructionsTable.Rows.Add(table.Rows[0]["instructions"].ToString());

                dataGridView4.DataSource = instructionsTable;
                dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView4.Visible = true;
            }
            else
            {
                MessageBox.Show("Не найдено данных для этого рецепта.");
            }
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {
            
        }

        // Вечеря
        private void label17_Click(object sender, EventArgs e)
        {
            label17.Visible = false; // label "Натисніть, щоб переглянути рецепти"
            flowLayoutPanel3.Padding = new Padding(120, 150, 10, 10);
            flowLayoutPanel3.Enabled = true;
            flowLayoutPanel3.Controls.Clear();

            flowLayoutPanel3.WrapContents = true;
            flowLayoutPanel3.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel3.AutoScroll = true;

            DBClass db = new DBClass();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM dinner", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                string name = row["name"].ToString();
                string ingredients = row["ingredients"].ToString();
                string instructions = row["instructions"].ToString();

                Panel panel = new Panel { Width = 220, Height = 220, Margin = new Padding(10) };

                string dataForSend = $"{name}\n {ingredients}\n: {instructions}\n";

                if (row["image"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row["image"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        try
                        {
                            Image image = Image.FromStream(ms);
                            PictureBox pictureBox = new PictureBox
                            {
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Image = image,
                                Height = 150,
                                Width = 200,
                                Tag = dataForSend
                            };
                            pictureBox.Click += PictureBox_Click;
                            panel.Controls.Add(pictureBox);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                        }
                    }
                }

                Label labelName4 = new Label
                {
                    Font = new Font("Segoe Script", 14, FontStyle.Regular),
                    Text = name,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Bottom,
                    AutoSize = false,
                    Height = 70
                };
                labelName4.Click += LabelName4_Click;

                panel.Controls.Add(labelName4);
                flowLayoutPanel3.Controls.Add(panel);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView5.Visible = false;
            dataGridView6.Visible = false;
            button4.Visible = false;
            button4.Enabled = false;

            // Відображаємо всі рецепти знову
            label17_Click(null, null);
        }

        private void LabelName4_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            string selectedRecipeName = clickedLabel.Text;

            flowLayoutPanel3.Controls.Clear();

            dataGridView5.DataSource = null;
            dataGridView6.DataSource = null;

            dataGridView5.Visible = false;
            dataGridView6.Visible = false;

            DBClass db = new DBClass();
            MySqlCommand command = new MySqlCommand("SELECT ingredients, instructions FROM dinner WHERE name = @name", db.GetConnection());
            command.Parameters.AddWithValue("@name", selectedRecipeName);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            int rowCount = adapter.Fill(table);

            if (rowCount > 0)
            {
                DataTable ingredientsTable = new DataTable();
                ingredientsTable.Columns.Add("Інгредієнти");
                string[] ingredients = table.Rows[0]["ingredients"].ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string ingredient in ingredients)
                {
                    ingredientsTable.Rows.Add(ingredient.Trim());
                }

                dataGridView5.DataSource = ingredientsTable;
                dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView5.Visible = true;

                DataTable instructionsTable = new DataTable();
                instructionsTable.Columns.Add("Інструкції приготування");
                instructionsTable.Rows.Add(table.Rows[0]["instructions"].ToString());

                dataGridView6.DataSource = instructionsTable;
                dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView6.Visible = true;

                button4.Enabled = true;
                button4.Visible = true;
            }
            else
            {
                MessageBox.Show("Не найдено данных для этого рецепта.");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            label14.Visible = false; // label "Натисніть, щоб переглянути рецепти"
            flowLayoutPanel4.Padding = new Padding(120, 150, 10, 10);
            flowLayoutPanel4.Enabled = true;
            flowLayoutPanel4.Controls.Clear();

            flowLayoutPanel4.WrapContents = true;
            flowLayoutPanel4.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel4.AutoScroll = true;

            DBClass db = new DBClass();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM dessert", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                string name = row["name"].ToString();
                string ingredients = row["ingredients"].ToString();
                string instructions = row["instructions"].ToString();

                Panel panel = new Panel { Width = 220, Height = 220, Margin = new Padding(10) };

                string dataForSend = $"{name}\n {ingredients}\n: {instructions}\n";

                if (row["image"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row["image"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        try
                        {
                            Image image = Image.FromStream(ms);
                            PictureBox pictureBox = new PictureBox
                            {
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Image = image,
                                Height = 150,
                                Width = 200,
                                Tag = dataForSend
                            };
                            pictureBox.Click += PictureBox_Click;
                            panel.Controls.Add(pictureBox);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                        }
                    }
                }

                Label labelName5 = new Label
                {
                    Font = new Font("Segoe Script", 14, FontStyle.Regular),
                    Text = name,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Bottom,
                    AutoSize = false,
                    Height = 70
                };
                labelName5.Click += LabelName5_Click;

                panel.Controls.Add(labelName5);
                flowLayoutPanel4.Controls.Add(panel);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView7.Visible = false;
            dataGridView8.Visible = false;
            button5.Visible = false;
            button5.Enabled = false;

            // Відображаємо всі рецепти знову
            label14_Click(null, null);
        }

        private void LabelName5_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            string selectedRecipeName = clickedLabel.Text;

            flowLayoutPanel4.Controls.Clear();

            dataGridView7.DataSource = null;
            dataGridView8.DataSource = null;

            dataGridView7.Visible = false;
            dataGridView8.Visible = false;

            DBClass db = new DBClass();
            MySqlCommand command = new MySqlCommand("SELECT ingredients, instructions FROM dessert WHERE name = @name", db.GetConnection());
            command.Parameters.AddWithValue("@name", selectedRecipeName);

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            int rowCount = adapter.Fill(table);

            if (rowCount > 0)
            {
                DataTable ingredientsTable = new DataTable();
                ingredientsTable.Columns.Add("Інгредієнти");
                string[] ingredients = table.Rows[0]["ingredients"].ToString().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string ingredient in ingredients)
                {
                    ingredientsTable.Rows.Add(ingredient.Trim());
                }

                dataGridView7.DataSource = ingredientsTable;
                dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView7.Visible = true;

                DataTable instructionsTable = new DataTable();
                instructionsTable.Columns.Add("Інструкції приготування");
                instructionsTable.Rows.Add(table.Rows[0]["instructions"].ToString());

                dataGridView8.DataSource = instructionsTable;
                dataGridView8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView8.Visible = true;

                button5.Enabled = true;
                button5.Visible = true;
            }
            else
            {
                MessageBox.Show("Не найдено данных для этого рецепта.");
            }
        }

        // Завантаження категорій в ComboBox
        private void LoadCategories()
        {
            comboBox1.Items.Add("breakfast");
            comboBox1.Items.Add("dessert");
            comboBox1.Items.Add("dinner");
            comboBox1.Items.Add("lunch");
        }

        // Завантаження інгредієнтів в ComboBox
        private void LoadIngredients()
        {
            comboBox2.Items.Clear();
            string[] tables = { "breakfast", "dessert", "dinner", "lunch" };

            foreach (string table in tables)
            {
                string query = $"SELECT DISTINCT ingredients FROM {table}";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string ingredient = reader.GetString("ingredients");
                    if (!comboBox2.Items.Contains(ingredient)) // виключаємо повторення
                    {
                        comboBox2.Items.Add(ingredient);
                    }
                }
                reader.Close();
            }
        }

        private void LoadRecipes()
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию.");
                return;
            }

            string categoryTable = comboBox1.SelectedItem.ToString(); 
            string query = $"SELECT * FROM {categoryTable} WHERE 1=1";

            if (comboBox2.SelectedItem != null)
            {
                query += " AND ingredient = @ingredients";
            }

            MySqlCommand cmd = new MySqlCommand(query, connection);

            if (comboBox2.SelectedItem != null)
            {
                cmd.Parameters.AddWithValue("@ingredients", comboBox2.SelectedItem.ToString());
            }

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView9.DataSource = dataTable;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecipes();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRecipes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadRecipes();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadIngredients();
        }

    }
}