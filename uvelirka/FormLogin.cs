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
    public partial class FormLogin : Form
    {
        int idRole = 0;
        string surname;
        string name;
        string patronymic;
        string result = "";
        string s = "qwertyuiopasdfghjklzxcvbnm1234567890";
        private int count = 0;
        Random random = new Random();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Program.connection.Open();
            textBoxPassword.UseSystemPasswordChar = true;
        }
        private void setStringCap()
        {
            result = "";
            char[] chars = s.ToCharArray();
            for (int i = 0; i < 4; i++)
            {
                result += chars[random.Next(0, chars.Length)];
            }
        }
        private void setCap()
        {
            setStringCap();
            Bitmap bitmap = new Bitmap(pictureBoxCap.Width, pictureBoxCap.Height);
            Graphics g = Graphics.FromImage(bitmap);

            g.Clear(Color.White);
            for (int i = 0; i < result.Length; i++)
            {
                g.DrawString(Convert.ToString(result[i]),
                    new Font("Microsoft Sans Serif", 15),
                    Brushes.Black,
                    new PointF(random.Next(i * 40, (i + 1) * 40), random.Next(20)));
                g.DrawBezier(Pens.Blue, 0, random.Next(pictureBoxCap.Height),
                    random.Next(pictureBoxCap.Width / 2), random.Next(pictureBoxCap.Height),
                    random.Next(pictureBoxCap.Width / 2, pictureBoxCap.Width), random.Next(pictureBoxCap.Height),
                    pictureBoxCap.Width, random.Next(pictureBoxCap.Height));
            }
            Color[] colors = { Color.Red, Color.Green, Color.Yellow};
            for (int i = 0; i < pictureBoxCap.Width; i++)
            {
                for (int j = 0; j < pictureBoxCap.Height; j++)
                {
                    if (random.Next(100)<10)
                    {
                        bitmap.SetPixel(i, j, colors[random.Next(colors.Length)]);
                    }
                }
            }
            pictureBoxCap.Image = bitmap;
        }
        private bool checkLog(string l, string p)
        {
            var cmd = new NpgsqlCommand($"select * from users where userlogin = '{l}' and userpassword = '{p}'", Program.connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            bool result;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idRole = reader.GetInt16(6);
                    surname = reader.GetValue(1).ToString();
                    name = reader.GetValue(2).ToString();
                    patronymic =  reader.GetValue(3).ToString();
                }
                result = true;
            }
            else
            {
                result = false;
            }
            reader.Close();
            return result;
        }

        private void startTimer()
        {
            timer1.Start();
            buttonVhod.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            buttonVhod.Enabled = true;
        }

        private void buttonRefreshCap_Click(object sender, EventArgs e)
        {
            setCap();
        }

        private void buttonVhod_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string passw = textBoxPassword.Text;
            count++;

            if (textBoxCap.Text == this.result)
            {
                if (checkLog(login, passw))
                {
                    MessageBox.Show("Добро пожаловать!");
                    FormProduct form = new FormProduct(idRole, surname, name, patronymic);
                    Program.connection.Close();
                    this.Hide();
                    form.Show();

                }
                else
                {
                    if (this.Width == 470 && this.Height == 610)
                    {
                        MessageBox.Show("Верная капча, но неверный логин или пароль!");
                        startTimer();
                        textBoxCap.Clear();
                        setCap();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!");
                        if (count >= 2)
                        {
                            Size = new Size(470, 610);
                            textBoxCap.Clear();
                            setCap();
                        }
                    }
                }

            }
            else if (textBoxCap.Text != this.result)
            {
                MessageBox.Show("Неверная капча!");
                startTimer();
                textBoxCap.Clear();
                setCap();

            }

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelVhod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Добро пожаловать!");
            FormProduct form = new FormProduct(idRole, surname, name, patronymic);
            Program.connection.Close();
            this.Hide();
            form.Show();
        }
    }
}
