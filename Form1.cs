using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Практика
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
        }
        bool d = false;
        public string id;
        private void button1_Click(object sender, EventArgs e)
        {
            string nick = textBox1.Text;
            string password = textBox2.Text;
            bool valid = false;
            IsLogIn(nick, password, ref valid, ref d);
            if (valid)
            {
                Form2 F2 = new Form2(this, d, id);
                F2.Show();
                this.Hide();
            }
            else MessageBox.Show("Неправильный логин или пароль");
        }
        public void IsLogIn(string l, string p, ref bool valid, ref bool access)
        {
            string myConnection = "Data Source=CLAYMORE\\SQLEXPRESS;Initial Catalog=Сертификаты;Integrated Security=True";
            SqlConnection connection = new SqlConnection(myConnection);
            using (connection)
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Логин_пароль WHERE Логин=@login AND Пароль=@password";
                    command.Parameters.AddWithValue("@login", l);
                    command.Parameters.AddWithValue("@password", p);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        int d = 0;
                        valid = true;
                        command.CommandText = "SELECT Права_доступа FROM Логин_пароль WHERE Логин=@login AND Пароль=@password";
                        d = (Int32)command.ExecuteScalar();
                        command.CommandType = CommandType.Text;
                     
                        if (d == 1)
                        {
                            access = true;
                        }
                        else access = false;
                        command.CommandText = "SELECT id_сотрудника FROM Логин_пароль WHERE Логин=@login AND Пароль=@password";
                        command.CommandType = CommandType.Text;
                        id = (string)command.ExecuteScalar();
                    }
                    else valid = false;
                }
                connection.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
