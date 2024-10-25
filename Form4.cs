using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Практика
{
    public partial class Form4 : Form
    {
        bool d = false;
        string id;
        public Form4(Form2 form2, bool access, string id)
        {
            InitializeComponent();
            this.Owner = form2;
            d = access;
            this.id = id;
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
                MessageBox.Show("Данные не найдены!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сертификатыDataSet6.Сертификат". При необходимости она может быть перемещена или удалена.
            this.сертификатTableAdapter.Fill(this.сертификатыDataSet.Сертификат);

            string myConnection = "Data Source=CLAYMORE\\SQLEXPRESS;Initial Catalog=Сертификаты;Integrated Security=True";
                SqlConnection connection = new SqlConnection(myConnection);
                connection.Open();
                SqlCommand command = new SqlCommand("Select* from Сертификат where id_сотрудника = @id and convert(date, getdate() + 7) >= Действителен_до", connection);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;
                sda.SelectCommand.Parameters.AddWithValue("@id", id);
                sda.SelectCommand.ExecuteScalar();
                DataTable table = new DataTable();
                sda.Fill(table);
                dataGridView1.DataSource = table;
                this.dataGridView1.Columns["id_Сотрудника"].Visible = false;
                connection.Close();
           
        }
    }
}
