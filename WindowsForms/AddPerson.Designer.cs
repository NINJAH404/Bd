﻿namespace WindowsForms
{
    partial class AddPerson
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mClient = new WindowsForms.CueTextBox();
            this.nClient = new WindowsForms.CueTextBox();
            this.fClient = new WindowsForms.CueTextBox();
            this.NumberClass = new WindowsForms.CueTextBox();
            this.BackToMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DeletePerson = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(791, 309);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // mClient
            // 
            this.mClient.Cue = "Отчество клиента";
            this.mClient.Location = new System.Drawing.Point(12, 416);
            this.mClient.Name = "mClient";
            this.mClient.Size = new System.Drawing.Size(284, 22);
            this.mClient.TabIndex = 3;
            // 
            // nClient
            // 
            this.nClient.Cue = "Имя клиента";
            this.nClient.Location = new System.Drawing.Point(12, 379);
            this.nClient.Name = "nClient";
            this.nClient.Size = new System.Drawing.Size(284, 22);
            this.nClient.TabIndex = 2;
            // 
            // fClient
            // 
            this.fClient.Cue = "Фамилия клиента";
            this.fClient.Location = new System.Drawing.Point(12, 336);
            this.fClient.Name = "fClient";
            this.fClient.Size = new System.Drawing.Size(284, 22);
            this.fClient.TabIndex = 1;
            // 
            // NumberClass
            // 
            this.NumberClass.Cue = "Класс";
            this.NumberClass.Location = new System.Drawing.Point(504, 336);
            this.NumberClass.Name = "NumberClass";
            this.NumberClass.Size = new System.Drawing.Size(284, 22);
            this.NumberClass.TabIndex = 4;
            this.NumberClass.TextChanged += new System.EventHandler(this.NumberClass_TextChanged);
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackToMenu.Location = new System.Drawing.Point(419, 406);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(257, 31);
            this.BackToMenu.TabIndex = 7;
            this.BackToMenu.Text = "Вернуться в меню";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(564, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DeletePerson
            // 
            this.DeletePerson.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeletePerson.Location = new System.Drawing.Point(353, 367);
            this.DeletePerson.Name = "DeletePerson";
            this.DeletePerson.Size = new System.Drawing.Size(205, 33);
            this.DeletePerson.TabIndex = 9;
            this.DeletePerson.Text = "Удалить";
            this.DeletePerson.UseVisualStyleBackColor = false;
            this.DeletePerson.Click += new System.EventHandler(this.DeletePerson_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeletePerson);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.mClient);
            this.Controls.Add(this.nClient);
            this.Controls.Add(this.fClient);
            this.Controls.Add(this.NumberClass);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddPerson";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CueTextBox NumberClass;
        private CueTextBox fClient;
        private CueTextBox nClient;
        private CueTextBox mClient;
        private System.Windows.Forms.Button BackToMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DeletePerson;
        private System.Windows.Forms.TextBox textBox1;
    }
}

