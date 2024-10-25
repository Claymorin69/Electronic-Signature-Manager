
namespace Практика
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.сертификатBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сертификатыDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сертификатыDataSet = new Практика.МенеджерDataSet();
            this.сертификатTableAdapter = new Практика.МенеджерDataSetTableAdapters.СертификатTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатыDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатыDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вернутся на главную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 341);
            this.dataGridView1.TabIndex = 3;
            // 
            // сертификатBindingSource
            // 
            this.сертификатBindingSource.DataMember = "Сертификат";
            this.сертификатBindingSource.DataSource = this.сертификатыDataSetBindingSource;
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
            // сертификатTableAdapter
            // 
            this.сертификатTableAdapter.ClearBeforeFill = true;
            // 
            // сертификатыDataSet6
            // 
            this.сертификатыDataSet.DataSetName = "СертификатыDataSet";
            this.сертификатыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сертификатBindingSource1
            // 
            this.сертификатBindingSource.DataMember = "Сертификат";
            this.сертификатBindingSource.DataSource = this.сертификатыDataSet;
            // 
            // сертификатTableAdapter1
            // 
            this.сертификатTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.Text = "Сертификаты требующие продления";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатыDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатыDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource сертификатыDataSetBindingSource;
        private МенеджерDataSet сертификатыDataSet;
        private System.Windows.Forms.BindingSource сертификатBindingSource;
        private МенеджерDataSetTableAdapters.СертификатTableAdapter сертификатTableAdapter;
    }
}