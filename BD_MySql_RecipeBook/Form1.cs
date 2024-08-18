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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void breakfast_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBreakfast formBreakfast = new FormBreakfast();
            formBreakfast.Show();
        }

        private void lunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLunch formLunch = new FormLunch();
            formLunch.Show();
        }

        private void dinner_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDinner formDinner = new FormDinner();
            formDinner.Show();
        }

        private void dessert_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDessert formDessert = new FormDessert();
            formDessert.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddOwnRecipe addOwnRecipe = new AddOwnRecipe();
            addOwnRecipe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyRecipes myRecipes = new MyRecipes();
            myRecipes.Show();
        }
    }
}
