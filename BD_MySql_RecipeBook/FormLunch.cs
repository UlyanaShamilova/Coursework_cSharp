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
    public partial class FormLunch : Form
    {
        public FormLunch()
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

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 19", db.GetConnection());

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

            dgv.Visible = true;

            dgv.DataSource = table;

            dgv.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 20", db.GetConnection());

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

            dgv.Visible = true;

            dgv.DataSource = table;

            dgv.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 21", db.GetConnection());

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

            dgv.Visible = true;

            dgv.DataSource = table;

            dgv.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 22", db.GetConnection());

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

            dgv.Visible = true;

            dgv.DataSource = table;

            dgv.ClearSelection();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 23", db.GetConnection());

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

            dgv.Visible = true;

            dgv.DataSource = table;

            dgv.ClearSelection();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 24", db.GetConnection());

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

            dgv.Visible = true;

            dgv.DataSource = table;

            dgv.ClearSelection();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 25", db.GetConnection());

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

            dgv.Visible = true;

            dgv.DataSource = table;

            dgv.ClearSelection();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 26", db.GetConnection());

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

            dgv.Visible = true;

            dgv.DataSource = table;

            dgv.ClearSelection();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 27", db.GetConnection());

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

            dgv.Visible = true;

            dgv.DataSource = table;

            dgv.ClearSelection();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 28", db.GetConnection());

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

            dgv.Visible = true;

            dgv.DataSource = table;

            dgv.ClearSelection();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 29", db.GetConnection());

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

            dgv.Visible = true;

            dgv.DataSource = table;

            dgv.ClearSelection();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM recipes_table WHERE id = 30", db.GetConnection());

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

            dgv.Visible = true;

            dgv.DataSource = table;

            dgv.ClearSelection();
        }
    }
}
