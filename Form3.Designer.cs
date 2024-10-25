
namespace Практика
{
    partial class Form3
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
            this.сертификатыDataSet = new Практика.МенеджерDataSet();
            this.сертификатBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сертификатTableAdapter = new Практика.МенеджерDataSetTableAdapters.СертификатTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // сертификатBindingSource
            // 
            this.сертификатBindingSource.DataMember = "Сертификат";
            this.сертификатBindingSource.DataSource = this.сертификатыDataSet;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вернутся на главную";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 386);
            this.dataGridView1.TabIndex = 2;
            // 
            // сертификатыDataSet
            // 
            this.сертификатыDataSet.DataSetName = "СертификатыDataSet";
            this.сертификатыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сертификатBindingSource
            // 
            this.сертификатBindingSource.DataMember = "Сертификат";
            this.сертификатBindingSource.DataSource = this.сертификатыDataSet;
            // 
            // сертификатTableAdapter
            // 
            this.сертификатTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 494);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Сертификаты пользователя";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сертификатBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сертификатыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private МенеджерDataSet сертификатыDataSet;
        private System.Windows.Forms.BindingSource сертификатBindingSource;
        private МенеджерDataSetTableAdapters.СертификатTableAdapter сертификатTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;

        
     
    }
}