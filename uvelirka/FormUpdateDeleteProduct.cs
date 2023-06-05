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
    public partial class FormUpdateDeleteProduct : Form
    {
        int idProd;
        public FormUpdateDeleteProduct(string str)
        {
            InitializeComponent();
            idProd = Convert.ToInt32(str);
        }

        private void FormUpdateDeleteProduct_Load(object sender, EventArgs e)
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


            var cmd5 = new NpgsqlCommand($"select productname, productdesc, productcost, categoryname, manufacturername, providername, unitname from product, manufacturer, provider, unit, category where product.productmanufacturer = manufacturer.manufacturerid and product.productprovider = provider.providerid and product.productcategory = category.categoryid and product.productunit = unit.unitid and productid = {idProd}", Program.connection);
            NpgsqlDataReader reader5 = cmd5.ExecuteReader();
            while (reader5.Read())
            {

                textBoxCost.Text = reader5.GetValue(2).ToString();
                textBoxDesc.Text = reader5.GetValue(1).ToString();
                textBoxName.Text = reader5.GetValue(0).ToString();
                comboBoxCategory.Text = reader5.GetValue(3).ToString();
                comboBoxManuf.Text = reader5.GetValue(4).ToString();
                comboBoxUnit.Text = reader5.GetValue(6).ToString();
                comboBoxProv.Text = reader5.GetValue(5).ToString();

            }
            reader5.Close();
            cmd5.Cancel();


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var cmd = new NpgsqlCommand($"select * from orders where productid = {idProd}", Program.connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Невозможно удалить товар, тк он присутствует в заказе");
                cmd.Cancel();
                reader.Close();
            }
            
            else
            {
                cmd.Cancel();
                reader.Close();
                if (MessageBox.Show("Вы действительно хотите удалить товар?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var cmdDel = new NpgsqlCommand($"delete from product where productid = {idProd}", Program.connection);
                    if (cmdDel.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("Запись успешно удалена");
                        ((FormProduct)Tag).fillMainPanel();
                        this.Close();
                        
                    }
                    cmdDel.Cancel();

                    
                }

            }
           



        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxCost.Text == "" || textBoxDesc.Text == "" || textBoxName.Text == "" || comboBoxCategory.Text == "" || comboBoxManuf.Text == "" || comboBoxProv.Text == "" || comboBoxUnit.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                if (textBoxCost.Text.All(char.IsDigit) && comboBoxCategory.Text.All(char.IsLetter) && comboBoxManuf.Text.All(char.IsLetter) && comboBoxProv.Text.All(char.IsLetter))
                {
                    var cmd = new NpgsqlCommand($"UPDATE  public.product SET   productname = '{textBoxName.Text}',  productdesc = '{textBoxDesc.Text}'," +
               $"productcost = @cost,   productmanufacturer = {comboBoxManuf.SelectedIndex + 1}, " +
               $"productprovider = {comboBoxProv.SelectedIndex + 1}, productunit = {comboBoxUnit.SelectedIndex + 1}, productcategory = {comboBoxCategory.SelectedIndex + 1} WHERE  productid = {idProd} ", Program.connection);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDecimal(textBoxCost.Text));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Запись изменена");
                        ((FormProduct)Tag).fillMainPanel();
                        this.Close();
                        cmd.Cancel();
                    }
                    else
                    {
                        MessageBox.Show("Данные введены некорректно!");
                        cmd.Cancel();
                    }
                }
            }
           
        }
    }
}
