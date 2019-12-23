namespace WindowsForms
{
    partial class AddUser
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
            this.AddUser1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cPass = new WindowsForms.CueTextBox();
            this.cLog = new WindowsForms.CueTextBox();
            this.BackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUser1
            // 
            this.AddUser1.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddUser1.Location = new System.Drawing.Point(483, 323);
            this.AddUser1.Name = "AddUser1";
            this.AddUser1.Size = new System.Drawing.Size(305, 44);
            this.AddUser1.TabIndex = 2;
            this.AddUser1.Text = "Добавить";
            this.AddUser1.UseVisualStyleBackColor = false;
            this.AddUser1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 262);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // cPass
            // 
            this.cPass.Cue = "Password";
            this.cPass.Location = new System.Drawing.Point(12, 363);
            this.cPass.Name = "cPass";
            this.cPass.Size = new System.Drawing.Size(401, 22);
            this.cPass.TabIndex = 1;
            // 
            // cLog
            // 
            this.cLog.Cue = "Login";
            this.cLog.Location = new System.Drawing.Point(12, 323);
            this.cLog.Name = "cLog";
            this.cLog.Size = new System.Drawing.Size(401, 22);
            this.cLog.TabIndex = 0;
            // 
            // BackToMenu
            // 
            this.BackToMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackToMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackToMenu.Location = new System.Drawing.Point(483, 386);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(305, 38);
            this.BackToMenu.TabIndex = 4;
            this.BackToMenu.Text = "Вернуться в меню";
            this.BackToMenu.UseVisualStyleBackColor = false;
            this.BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddUser1);
            this.Controls.Add(this.cPass);
            this.Controls.Add(this.cLog);
            this.Name = "AddUser";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CueTextBox cLog;
        private CueTextBox cPass;
        private System.Windows.Forms.Button AddUser1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BackToMenu;
    }
}