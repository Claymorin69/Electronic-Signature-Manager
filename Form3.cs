using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Практика
{
    public partial class Form3 : Form
    {
        bool d = false;
        string id;
        public Form3(Form2 form2, bool access, string id)
        {
            InitializeComponent();
            this.Owner = form2;
            d = access;
            this.id = id;
        }    

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сертификатыDataSet5.Сертификат". При необходимости она может быть перемещена или удалена.
            this.сертификатTableAdapter.Fill(this.сертификатыDataSet.Сертификат);
            
                string myConnection = "Data Source=CLAYMORE\\SQLEXPRESS;Initial Catalog=Сертификаты;Integrated Security=True";
                SqlConnection connection = new SqlConnection(myConnection);
                connection.Open();
                SqlCommand command1 = new SqlCommand("Select* from Сертификат where id_сотрудника = @id", connection);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command1;
                sda.SelectCommand.Parameters.AddWithValue("@id", id);
                sda.SelectCommand.ExecuteScalar();
                DataTable table = new DataTable();
                sda.Fill(table);
                dataGridView1.DataSource = table;
                this.dataGridView1.Columns["id_сотрудника"].Visible = false;
                connection.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
