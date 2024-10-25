using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Практика
{
    public partial class Form7 : Form
    {
        bool d = false;
        public Form7(Form2 form2, bool access)
        {
            InitializeComponent();
            this.Owner = form2;
            d = access;
        }
        string connectString = "Data Source=CLAYMORE\\SQLEXPRESS;Initial Catalog=Сертификаты;Integrated Security=True";
        private void LoadData(string q, DataGridView dgv)
        // метод загрузки данных в любую таблицу с любым запросом
        // q - запрос на получение данных из БД
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(connectString);
                myConnection.Open(); //Открываем соединение
                SqlCommand cmd = new SqlCommand(q, myConnection);
                // создание SQL команды с запросом
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // выполнение команды
                DataTable tb = new DataTable(); // создание таблицы
                da.Fill(tb); // загрузка данных в таблицу
                dgv.DataSource = tb; // привязка полученной таблицы к компоненту
                this.ActiveControl = dgv; // активация компонента таблица
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                if (dgv.Rows.Count > 0)
                {
                    dgv.Rows[0].Selected = true;
                }
                myConnection.Close(); // разрываем соединение с БД
            }
            catch
            {
                MessageBox.Show("Данные успешно загружены");
            }
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "сертификатыDataSet4.Сотрудники". При необходимости она может быть перемещена или удалена.
            //this.сотрудникиTableAdapter.Fill(this.сертификатыDataSet.Сотрудники);            
            string myConnection = "Data Source=CLAYMORE\\SQLEXPRESS;Initial Catalog=Сертификаты;Integrated Security=True";
            SqlConnection connection = new SqlConnection(myConnection);
            connection.Open();
            SqlCommand command = new SqlCommand("Select* from Сотрудники", connection);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = command;
            sda.SelectCommand.ExecuteScalar();
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Сотрудники (id_сотрудника, Фамилия, Имя_отчество, Должность, Отделение) VALUES(@id_сотрудника, @Фамилия, @Имя_отчество, @Должность, @Отделение)";
            command.Parameters.AddWithValue("@id_сотрудника", Convert.ToInt32(textBox1.Text));
            command.Parameters.AddWithValue("@Фамилия", textBox2.Text);
            command.Parameters.AddWithValue("@Имя_отчество", textBox3.Text);
            command.Parameters.AddWithValue("@Отделение", this.textBox4.Text);
            command.Parameters.AddWithValue("@Должность", textBox6.Text);
            command.ExecuteScalar();
            connection.Close();
            string q = "SELECT * FROM Сотрудники";
            LoadData(q, dataGridView1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE Сотрудники SET  Фамилия = @Фамилия, Имя_отчество = @Имя_отчество, Должность = @Должность, Отделение = @Отделение where id_сотрудника = @id_сотрудника";
            command.Parameters.AddWithValue("@id_сотрудника", Convert.ToInt32(textBox1.Text));
            command.Parameters.AddWithValue("@Фамилия", textBox2.Text);
            command.Parameters.AddWithValue("@Имя_отчество", textBox3.Text);
            command.Parameters.AddWithValue("@Отделение", this.textBox4.Text);
            command.Parameters.AddWithValue("@Должность", textBox6.Text);
            command.ExecuteScalar();
            connection.Close();
            string q = "SELECT * FROM Сотрудники";
            LoadData(q, dataGridView1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Сотрудники  WHERE (id_сотрудника = @id_сотрудника)";
            command.Parameters.AddWithValue("@id_сотрудника", textBox1.Text);
            command.ExecuteScalar();
            connection.Close();
            string q = "SELECT * FROM Сотрудники";
            LoadData(q, dataGridView1);
        }
    }
}
