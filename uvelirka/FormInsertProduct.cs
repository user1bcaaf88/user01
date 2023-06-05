using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace uvelirka
{
    public partial class FormInsertProduct : Form
    {
        public FormInsertProduct()
        {
            InitializeComponent();

           
        }

        private void FormInsertProduct_Load(object sender, EventArgs e)
        {
            var cmd = new NpgsqlCommand("select manufacturername from manufacturer", Program.connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxManuf.Items.Add(reader["manufacturername"].ToString());
            }
            reader.Close();
            cmd.Cancel();

            var cmd2 = new NpgsqlCommand("select providername from provider", Program.connection);
            NpgsqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                comboBoxProv.Items.Add(reader2["providername"].ToString());
            }
            reader2.Close();
            cmd2.Cancel();

            var cmd3 = new NpgsqlCommand("select unitname from unit", Program.connection);
            NpgsqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                comboBoxUnit.Items.Add(reader3["unitname"].ToString());
            }
            reader3.Close();
            cmd3.Cancel();

            var cmd4 = new NpgsqlCommand("select categoryname from category", Program.connection);
            NpgsqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                comboBoxCategory.Items.Add(reader4["categoryname"].ToString());
            }
            reader4.Close();
            cmd4.Cancel();

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            var cmd = new NpgsqlCommand("select max(productid) from product", Program.connection);
            int maxId = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Cancel();
            if (textBoxCost.Text == "" || textBoxDesc.Text == "" || textBoxName.Text == "" || comboBoxCategory.Text == "" || comboBoxManuf.Text == "" || comboBoxProv.Text == "" || comboBoxUnit.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                if (textBoxCost.Text.All(char.IsDigit) && comboBoxCategory.Text.All(char.IsLetter) && comboBoxManuf.Text.All(char.IsLetter) && comboBoxProv.Text.All(char.IsLetter) )
                {
                    var cmd2 = new NpgsqlCommand($"INSERT INTO  public.product(  productid,  productname,  productdesc,  productcost," +
                    $"productphoto,  productmanufacturer,  productprovider, productunit,productcategory" +
                    $") VALUES( {maxId + 1},  '{textBoxName.Text}',  '{textBoxDesc.Text}',  {textBoxCost.Text},  '{textBoxPhoto.Text}',  {comboBoxManuf.SelectedIndex + 1}," +
                    $" {comboBoxProv.SelectedIndex + 1},  {comboBoxUnit.SelectedIndex + 1},  {comboBoxCategory.SelectedIndex + 1}); ", Program.connection);

                    if (cmd2.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Товар добавлен!");
                        ((FormProduct)Tag).fillMainPanel();
                        this.Close();
                    }
                    cmd2.Cancel();
                }
                else
                {
                    MessageBox.Show("Данные введены некорректно!");
                }

            }
        }
    }
}
