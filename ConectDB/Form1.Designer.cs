namespace ConectDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.textBox_tt = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.textBox_SQL = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Lime;
            this.btn1.Location = new System.Drawing.Point(986, 24);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(134, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Подключить БД";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_id.Location = new System.Drawing.Point(13, 24);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(184, 23);
            this.textBox_id.TabIndex = 1;
            this.textBox_id.Text = "введи id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 278);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(377, 242);
            this.textBox2.TabIndex = 3;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(411, 77);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(188, 51);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Вывести значения из БД в textBox";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(411, 338);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(188, 49);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Вывести значения из БД в dataGridView";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // textBox_tt
            // 
            this.textBox_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_tt.Location = new System.Drawing.Point(206, 24);
            this.textBox_tt.Name = "textBox_tt";
            this.textBox_tt.Size = new System.Drawing.Size(184, 23);
            this.textBox_tt.TabIndex = 1;
            this.textBox_tt.Text = "введи tt";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(411, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Добавить данные в БД";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Cyan;
            this.btn4.Location = new System.Drawing.Point(411, 593);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(188, 23);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "Обновить данные в БД";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(986, 77);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(134, 23);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "Добавть таблицы";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // textBox_SQL
            // 
            this.textBox_SQL.Location = new System.Drawing.Point(734, 79);
            this.textBox_SQL.Multiline = true;
            this.textBox_SQL.Name = "textBox_SQL";
            this.textBox_SQL.Size = new System.Drawing.Size(215, 84);
            this.textBox_SQL.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(758, 324);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(948, 322);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(146, 23);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "Выбор таблицы";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 628);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_SQL);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_tt);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox textBox_tt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.TextBox textBox_SQL;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn6;
    }
}

