
namespace Практика
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idсотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяотчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.сертификатыDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сертификатыDataSet = new Практика.МенеджерDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.логинПарольBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.логин_ПарольTableAdapter = new Практика.МенеджерDataSetTableAdapters.Логин_парольTableAdapter();
            this.сотрудникиTableAdapter = new Практика.МенеджерDataSetTableAdapters.СотрудникиTableAdapter();
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиЛогинпарольBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатыDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.логинПарольBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиЛогинпарольBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(609, 118);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(94, 22);
            this.textBox6.TabIndex = 25;
            this.textBox6.Text = "Должность";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(496, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 22);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "Отделение";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(382, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 22);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "Имя отчество";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 22);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Фамилия";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 22);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "id_сотрудника";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 36);
            this.button4.TabIndex = 19;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 36);
            this.button3.TabIndex = 18;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "Вернутся на главную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idсотрудникаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяотчествоDataGridViewTextBoxColumn,
            this.отделениеDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сотрудникиBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 273);
            this.dataGridView1.TabIndex = 15;
            // 
            // idсотрудникаDataGridViewTextBoxColumn
            // 
            this.idсотрудникаDataGridViewTextBoxColumn.DataPropertyName = "id_сотрудника";
            this.idсотрудникаDataGridViewTextBoxColumn.HeaderText = "id_сотрудника";
            this.idсотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idсотрудникаDataGridViewTextBoxColumn.Name = "idсотрудникаDataGridViewTextBoxColumn";
            this.idсотрудникаDataGridViewTextBoxColumn.Width = 131;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 95;
            // 
            // имяотчествоDataGridViewTextBoxColumn
            // 
            this.имяотчествоDataGridViewTextBoxColumn.DataPropertyName = "Имя_отчество";
            this.имяотчествоDataGridViewTextBoxColumn.HeaderText = "Имя_отчество";
            this.имяотчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяотчествоDataGridViewTextBoxColumn.Name = "имяотчествоDataGridViewTextBoxColumn";
            this.имяотчествоDataGridViewTextBoxColumn.Width = 130;
            // 
            // отделениеDataGridViewTextBoxColumn
            // 
            this.отделениеDataGridViewTextBoxColumn.DataPropertyName = "Отделение";
            this.отделениеDataGridViewTextBoxColumn.HeaderText = "Отделение";
            this.отделениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отделениеDataGridViewTextBoxColumn.Name = "отделениеDataGridViewTextBoxColumn";
            this.отделениеDataGridViewTextBoxColumn.Width = 109;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.Width = 107;
            // 
            // сотрудникиBindingSource2
            // 
            this.сотрудникиBindingSource2.DataMember = "Сотрудники";
            this.сотрудникиBindingSource2.DataSource = this.сертификатыDataSetBindingSource;
            // 
            // сертификатыDataSetBindingSource
            // 
            this.сертификатыDataSetBindingSource.DataSource = this.сертификатыDataSet;
            this.сертификатыDataSetBindingSource.Position = 0;
            // 
            // сертификатыDataSet
            // 
            this.сертификатыDataSet.DataSetName = "СертификатыDataSet";
            this.сертификатыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.сертификатыDataSet;
            // 
            // логинПарольBindingSource
            // 
            this.логинПарольBindingSource.DataMember = "Логин_Пароль";
            this.логинПарольBindingSource.DataSource = this.сертификатыDataSet;
            // 
            // логин_ПарольTableAdapter
            // 
            this.логин_ПарольTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this.сертификатыDataSet;
            // 
            // сотрудникиЛогинпарольBindingSource
            // 
            this.сотрудникиЛогинпарольBindingSource.DataMember = "СотрудникиЛогин_пароль";
            this.сотрудникиЛогинпарольBindingSource.DataSource = this.сотрудникиBindingSource1;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 441);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Добавление новых сотрудников";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатыDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.логинПарольBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиЛогинпарольBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private МенеджерDataSet сертификатыDataSet;
        private System.Windows.Forms.BindingSource логинПарольBindingSource;
        private МенеджерDataSetTableAdapters.Логин_парольTableAdapter логин_ПарольTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private МенеджерDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource сертификатыDataSetBindingSource;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idсотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяотчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отделениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource сотрудникиЛогинпарольBindingSource;
    }
}