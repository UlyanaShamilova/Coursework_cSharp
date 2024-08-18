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
    public partial class MyRecipes : Form
    {
        public MyRecipes()
        {
            InitializeComponent();

            dgv1.DefaultCellStyle.Font = new Font("Serif", 16);

            DBClass db = new DBClass();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT name, ingredients, instructions FROM `own_recipes_table`", db.GetConnection());

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
