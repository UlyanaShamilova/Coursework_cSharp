using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD_MySql_RecipeBook
{
    public partial class AddOwnRecipe : Form
    {
        public AddOwnRecipe()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string ingredients = textBox2.Text;
            string instructions = textBox3.Text;

            DBClass db = new DBClass();

            try
            {
                db.openConnection();

                string query = "INSERT INTO `own_recipes_table` (`name`, `ingredients`, `instructions`) VALUES (@n, @ig, @is)";

                MySqlCommand command = new MySqlCommand(query, db.GetConnection());

                command.Parameters.AddWithValue("@n", name);
                command.Parameters.AddWithValue("@ig", ingredients);
                command.Parameters.AddWithValue("@is", instructions);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Рецепт успішно додано.");
                }
                else
                {
                    MessageBox.Show("Помилка при додаванні рецепту.");
                }
            }
            finally
            {
                db.closeConnection();
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
