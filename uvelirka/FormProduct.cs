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
    public partial class FormProduct : Form
    {
        int idRole = 0;
        string surname;
        string name;
        string patr;
        private int count = 0;

        public FormProduct(int id, string s, string n, string p)
        {
            InitializeComponent();
            idRole = id;
            surname = s;
            name = n;
            patr = p;
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            Program.connection.Open();

            if (idRole == 0 || idRole == 3)
            {
                buttonInsert.Visible = false;
                labelFIO.Visible = false;
            }
            labelFIO.Text = $"{surname} {name} {patr}";

            comboBoxFiltr.Items.Add("Все производители");
            comboBoxFiltr.SelectedIndex = 0;

            var cmd = new NpgsqlCommand("select manufacturername from manufacturer", Program.connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxFiltr.Items.Add(reader["manufacturername"].ToString());
            }
            reader.Close();
            cmd.Cancel();
        }

        public void fillMainPanel()
        {
            mainPanel.Controls.Clear();
            string filtr = "";
            string sort = "";
            if (comboBoxFiltr.SelectedIndex>0)
            {
                filtr = $" and productmanufacturer = {comboBoxFiltr.SelectedIndex}";
            }
            if (radioButtonAsc.Checked)
            {
                sort = "asc";
            }
            else
            {
                sort = "desc";
            }
            int i = 0;

            var cmd = new NpgsqlCommand($"select *, manufacturername from product, manufacturer where (productname like '%{textBoxSearch.Text}%' or productdesc like '%{textBoxSearch.Text}%' or manufacturername like '%{textBoxSearch.Text}%') and (product.productmanufacturer = manufacturer.manufacturerid " + filtr + $") order by productcost {sort}", Program.connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Panel panel = new Panel();
                panel.Name = reader.GetValue(0).ToString();
                panel.Size = new Size(1064, 198);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Cursor = Cursors.Hand;

                PictureBox picture = new PictureBox();
                picture.Size = new Size(140, 127);
                picture.Location = new Point(23, 38);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;

                string path = reader["productphoto"].ToString();
                if (path != "")
                {
                    path = Environment.CurrentDirectory + "\\Товар_import\\" + reader["productphoto"].ToString();
                    picture.Load(path);
                }
                else
                {
                    picture.Image = Properties.Resources.picture;
                }
                panel.Controls.Add(picture);

                Label labelName = new Label();
                labelName.Name = reader.GetValue(0).ToString();
                labelName.Size = new Size(360, 41);
                labelName.Location = new Point(207, 37);
                labelName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                labelName.Text = $"{reader["productname"].ToString()}";
                panel.Controls.Add(labelName);

                Label labelInfo = new Label();
                labelInfo.Name = reader.GetValue(0).ToString();
                labelInfo.Size = new Size(360, 96);
                labelInfo.Location = new Point(207, 88);
                labelInfo.Font = new Font("Microsoft Sans Serif", 10);
                labelInfo.Text = $"{reader["productdesc"].ToString()}\n" +
                    $"Производитель: {reader["manufacturername"].ToString()}\n" +
                    $"Цена: {reader["productcost"].ToString()}";
                panel.Controls.Add(labelInfo);

                Label labelQuntity = new Label();
                labelQuntity.Name = reader.GetValue(0).ToString();
                labelQuntity.Size = new Size(228,96);
                labelQuntity.Location = new Point(817, 53);
                labelQuntity.Font = new Font("Microsoft Sans Serif", 10);
                labelQuntity.Text = $"В наличии";
                panel.Controls.Add(labelQuntity);

                mainPanel.Controls.Add(panel);
                i++;
                panel.Click += Panel_Click;

            }
            reader.Close();
            cmd.Cancel();

            var cmd2 = new NpgsqlCommand("select count(*) from product", Program.connection);
            count = Convert.ToInt32(cmd2.ExecuteScalar());
            labelCount.Text = $"{i}/{count}";
            cmd2.Cancel();
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            foreach (var control in mainPanel.Controls)
            {
                ((Panel)control).BackColor = Color.White;
            }
            if (idRole == 0 || idRole == 3)
            {

            }
            else
            {
                string idProd = ((Panel)sender).Name;
                ((Panel)sender).BackColor = Color.FromArgb(118, 227, 131);
                if (Application.OpenForms["FormUpdateDeleteProduct"] == null)
                {
                    FormUpdateDeleteProduct form = new FormUpdateDeleteProduct(idProd);
                    form.Tag = this;
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Данная форма уже открыта!");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            fillMainPanel();
        }

        private void comboBoxFiltr_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillMainPanel();
        }

        private void radioButtonAsc_CheckedChanged(object sender, EventArgs e)
        {
            fillMainPanel();
        }

        private void radioButtonDesc_CheckedChanged(object sender, EventArgs e)
        {
            fillMainPanel();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo ) == DialogResult.Yes)
            {
                FormLogin form = new FormLogin();
                Program.connection.Close();
                this.Hide();
                form.Show();
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormInsertProduct"] == null)
            {
                FormInsertProduct form = new FormInsertProduct();
                form.Tag = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Данная форма уже открыта!");
            }
        }

        private void FormProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
