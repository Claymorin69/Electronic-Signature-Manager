using System;
using System.Windows.Forms;

namespace Практика
{
    public partial class Form2 : Form
    {
        bool d = false;
        string id;
        Form3 F3 = null;
        Form4 F4 = null;
        Form5 F5 = null;
        Form6 F6 = null;
        Form7 F7 = null;
        public Form2(Form1 form1, bool access, string id)
        {
            InitializeComponent();
            this.Owner = form1;
            d = access;
            this.id = id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (F3 == null || F3.IsDisposed)
            F3 = new Form3(this, d, id);
            F3.Show();
            this.Hide();            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (F4 == null || F4.IsDisposed)
                F4 = new Form4(this, d, id);
            F4.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (F5 == null || F5.IsDisposed)
                F5 = new Form5(this, d);
            F5.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (F6 == null || F6.IsDisposed)
                F6 = new Form6(this, d);
            F6.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (F7 == null || F7.IsDisposed)
                F7 = new Form7(this, d);
            F7.Show();
            this.Hide();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            button3.Visible = d;
            button4.Visible = d;
            button7.Visible = d;
        }        
    }
}
