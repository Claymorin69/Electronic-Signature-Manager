using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Практика
{
    public partial class Form5 : Form
    {
        bool d = false;
        public Form5(Form2 form2, bool access)
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
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сертификатыDataSet7.Сертификат". При необходимости она может быть перемещена или удалена.
            this.сертификатTableAdapter.Fill(this.сертификатыDataSet.Сертификат);
            string myConnection = "Data Source=CLAYMORE\\SQLEXPRESS;Initial Catalog=Сертификаты;Integrated Security=True";
            SqlConnection connection = new SqlConnection(myConnection);
            connection.Open();
            SqlCommand command = new SqlCommand("Select* from Сертификат", connection);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = command;            
            sda.SelectCommand.ExecuteScalar();
            DataTable table = new DataTable();
            sda.Fill(table);
            dataGridView1.DataSource = table;       
            connection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Сертификат (Серийный_номер, Фамилия, Имя_отчество, Где_выдан, Действителен_до, Сведения, id_сотрудника) VALUES(@Серийный_номер, @Фамилия, @Имя_отчество, @Где_выдан, @Действителен_до, @Сведения, @id_сотрудника)";
            command.Parameters.AddWithValue("@Серийный_номер", Convert.ToInt32(textBox1.Text));
            command.Parameters.AddWithValue("@Фамилия", textBox5.Text);
            command.Parameters.AddWithValue("@Имя_отчество", textBox6.Text);
            command.Parameters.AddWithValue("@Где_выдан", textBox7.Text);
            command.Parameters.AddWithValue("@Действителен_до", Convert.ToDateTime(this.textBox8.Text));
            command.Parameters.AddWithValue("@Сведения", textBox9.Text);
            command.Parameters.AddWithValue("@id_сотрудника", Convert.ToInt32(textBox10.Text));
            command.ExecuteScalar();
            connection.Close();
            string q = "SELECT * FROM Сертификат";
            LoadData(q, dataGridView1);
        }
        private void button3_Click(object sender, EventArgs e)       
        {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE Сертификат SET Действителен_до = @Действителен_до, Где_выдан = @Где_выдан, Сведения = @Сведения, id_сотрудника = @id_сотрудника where Серийный_номер = @Серийный_номер";
            command.Parameters.AddWithValue("@Серийный_номер", Convert.ToInt32(textBox1.Text));
            command.Parameters.AddWithValue("@Фамилия", textBox5.Text);
            command.Parameters.AddWithValue("@Имя_отчество", textBox6.Text);
            command.Parameters.AddWithValue("@Где_выдан", textBox7.Text);
            command.Parameters.AddWithValue("@Действителен_до", Convert.ToDateTime(textBox8.Text));
            command.Parameters.AddWithValue("@Сведения", textBox9.Text);
            command.Parameters.AddWithValue("@id_сотрудника", Convert.ToInt32(textBox10.Text));
            command.ExecuteScalar();
            connection.Close();
            string q = "SELECT * FROM Сертификат";
            LoadData(q, dataGridView1);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Сертификат  WHERE (Серийный_номер = @Серийный_номер)";
            command.Parameters.AddWithValue("@Серийный_номер", textBox1.Text);          
            command.ExecuteScalar();
            connection.Close();
            string q = "SELECT * FROM Сертификат";
            LoadData(q, dataGridView1);
        }
    }
}
