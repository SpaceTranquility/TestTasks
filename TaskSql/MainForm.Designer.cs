namespace TaskSQL
{
    partial class MainForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Found = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.TextBox_Conection = new System.Windows.Forms.TextBox();
            this.comboBox_employ = new System.Windows.Forms.ComboBox();
            this.groupBox_Stat = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Post = new System.Windows.Forms.ComboBox();
            this.comboBox_Dep = new System.Windows.Forms.ComboBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.groupBox_Connect = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox_Stat.SuspendLayout();
            this.groupBox_Connect.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(7, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(604, 186);
            this.dataGridView.TabIndex = 3;
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "Любой"});
            this.comboBox_Status.Location = new System.Drawing.Point(6, 49);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(92, 23);
            this.comboBox_Status.TabIndex = 4;
            this.comboBox_Status.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_From.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker_From.Location = new System.Drawing.Point(104, 49);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker_From.TabIndex = 5;
            this.dateTimePicker_From.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_From.ValueChanged += new System.EventHandler(this.dateTimePickers_ValueChanged);
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_To.Location = new System.Drawing.Point(104, 91);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker_To.TabIndex = 5;
            this.dateTimePicker_To.Value = new System.DateTime(2020, 3, 16, 6, 5, 29, 0);
            this.dateTimePicker_To.ValueChanged += new System.EventHandler(this.dateTimePickers_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Статус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "За период от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(164, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "до";
            // 
            // label_Found
            // 
            this.label_Found.AutoSize = true;
            this.label_Found.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Found.Location = new System.Drawing.Point(261, 93);
            this.label_Found.Name = "label_Found";
            this.label_Found.Size = new System.Drawing.Size(58, 15);
            this.label_Found.TabIndex = 10;
            this.label_Found.Text = "Найдено";
            // 
            // button_Reset
            // 
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Reset.Location = new System.Drawing.Point(521, 85);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(73, 23);
            this.button_Reset.TabIndex = 11;
            this.button_Reset.Text = "Сбросить";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // TextBox_Conection
            // 
            this.TextBox_Conection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBox_Conection.Location = new System.Drawing.Point(60, 28);
            this.TextBox_Conection.Name = "TextBox_Conection";
            this.TextBox_Conection.Size = new System.Drawing.Size(467, 20);
            this.TextBox_Conection.TabIndex = 13;
            this.TextBox_Conection.Text = "Строка подключения";
            this.TextBox_Conection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_Conection.Enter += new System.EventHandler(this.TextBox_Conection_Enter);
            // 
            // comboBox_employ
            // 
            this.comboBox_employ.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_employ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_employ.FormattingEnabled = true;
            this.comboBox_employ.Items.AddRange(new object[] {
            "Не важно",
            "Принят на работу",
            "Уволен"});
            this.comboBox_employ.Location = new System.Drawing.Point(6, 91);
            this.comboBox_employ.Name = "comboBox_employ";
            this.comboBox_employ.Size = new System.Drawing.Size(92, 23);
            this.comboBox_employ.TabIndex = 14;
            this.comboBox_employ.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // groupBox_Stat
            // 
            this.groupBox_Stat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Stat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_Stat.Controls.Add(this.label6);
            this.groupBox_Stat.Controls.Add(this.textBox_Search);
            this.groupBox_Stat.Controls.Add(this.label5);
            this.groupBox_Stat.Controls.Add(this.label4);
            this.groupBox_Stat.Controls.Add(this.button_Reset);
            this.groupBox_Stat.Controls.Add(this.comboBox_employ);
            this.groupBox_Stat.Controls.Add(this.label2);
            this.groupBox_Stat.Controls.Add(this.label_Found);
            this.groupBox_Stat.Controls.Add(this.comboBox_Post);
            this.groupBox_Stat.Controls.Add(this.comboBox_Dep);
            this.groupBox_Stat.Controls.Add(this.comboBox_Status);
            this.groupBox_Stat.Controls.Add(this.label1);
            this.groupBox_Stat.Controls.Add(this.dateTimePicker_From);
            this.groupBox_Stat.Controls.Add(this.dateTimePicker_To);
            this.groupBox_Stat.Controls.Add(this.label3);
            this.groupBox_Stat.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox_Stat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_Stat.Location = new System.Drawing.Point(7, 196);
            this.groupBox_Stat.Name = "groupBox_Stat";
            this.groupBox_Stat.Size = new System.Drawing.Size(604, 121);
            this.groupBox_Stat.TabIndex = 15;
            this.groupBox_Stat.TabStop = false;
            this.groupBox_Stat.Text = "Фильтрация и статистика";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(489, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Поиск по фамилии";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Search.Location = new System.Drawing.Point(492, 48);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(105, 20);
            this.textBox_Search.TabIndex = 17;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(368, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(248, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Отдел";
            // 
            // comboBox_Post
            // 
            this.comboBox_Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Post.FormattingEnabled = true;
            this.comboBox_Post.Items.AddRange(new object[] {
            "Любая"});
            this.comboBox_Post.Location = new System.Drawing.Point(371, 48);
            this.comboBox_Post.Name = "comboBox_Post";
            this.comboBox_Post.Size = new System.Drawing.Size(112, 21);
            this.comboBox_Post.TabIndex = 4;
            this.comboBox_Post.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // comboBox_Dep
            // 
            this.comboBox_Dep.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Dep.FormattingEnabled = true;
            this.comboBox_Dep.Items.AddRange(new object[] {
            "Любой"});
            this.comboBox_Dep.Location = new System.Drawing.Point(251, 48);
            this.comboBox_Dep.Name = "comboBox_Dep";
            this.comboBox_Dep.Size = new System.Drawing.Size(114, 21);
            this.comboBox_Dep.TabIndex = 4;
            this.comboBox_Dep.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(242, 54);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 16;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // groupBox_Connect
            // 
            this.groupBox_Connect.Controls.Add(this.TextBox_Conection);
            this.groupBox_Connect.Controls.Add(this.button_Connect);
            this.groupBox_Connect.Location = new System.Drawing.Point(16, 26);
            this.groupBox_Connect.Name = "groupBox_Connect";
            this.groupBox_Connect.Size = new System.Drawing.Size(583, 100);
            this.groupBox_Connect.TabIndex = 18;
            this.groupBox_Connect.TabStop = false;
            this.groupBox_Connect.Text = "Возможно строка подключения из App.config не корректна. Введите строку подключени" +
    "я вручную.";
            this.groupBox_Connect.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 319);
            this.Controls.Add(this.groupBox_Connect);
            this.Controls.Add(this.groupBox_Stat);
            this.Controls.Add(this.dataGridView);
            this.MinimumSize = new System.Drawing.Size(640, 260);
            this.Name = "Form1";
            this.Text = "Statistic";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox_Stat.ResumeLayout(false);
            this.groupBox_Stat.PerformLayout();
            this.groupBox_Connect.ResumeLayout(false);
            this.groupBox_Connect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Found;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.TextBox TextBox_Conection;
        private System.Windows.Forms.ComboBox comboBox_employ;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.GroupBox groupBox_Stat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Post;
        private System.Windows.Forms.ComboBox comboBox_Dep;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.GroupBox groupBox_Connect;
    }
}

