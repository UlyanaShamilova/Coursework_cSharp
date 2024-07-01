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
    public partial class FormDessert : Form
    {
        public FormDessert()
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
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 31", db.GetConnection());

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

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 32", db.GetConnection());

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

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 33", db.GetConnection());

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

        private void button4_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 34", db.GetConnection());

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

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 35", db.GetConnection());

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

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 36", db.GetConnection());

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

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 37", db.GetConnection());

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

        private void button7_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 38", db.GetConnection());

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

        private void button15_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 39", db.GetConnection());

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

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 40", db.GetConnection());

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

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 41", db.GetConnection());

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

        private void button12_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 42", db.GetConnection());

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
    }
}
