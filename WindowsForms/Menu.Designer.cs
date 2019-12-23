namespace WindowsForms
{
    partial class Menu
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
            this.AddPerson = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.CheckPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPerson
            // 
            this.AddPerson.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddPerson.Location = new System.Drawing.Point(12, 87);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(290, 81);
            this.AddPerson.TabIndex = 0;
            this.AddPerson.Text = "Добавить пользователя";
            this.AddPerson.UseVisualStyleBackColor = false;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddUser.Location = new System.Drawing.Point(498, 87);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(290, 81);
            this.AddUser.TabIndex = 1;
            this.AddUser.Text = "Добавить аккаунт";
            this.AddUser.UseVisualStyleBackColor = false;
            this.AddUser.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CheckPerson
            // 
            this.CheckPerson.BackColor = System.Drawing.SystemColors.Highlight;
            this.CheckPerson.Location = new System.Drawing.Point(12, 239);
            this.CheckPerson.Name = "CheckPerson";
            this.CheckPerson.Size = new System.Drawing.Size(290, 81);
            this.CheckPerson.TabIndex = 2;
            this.CheckPerson.Text = "Просмотр посещаймости ученика";
            this.CheckPerson.UseVisualStyleBackColor = false;
            this.CheckPerson.Click += new System.EventHandler(this.CheckPerson_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckPerson);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.AddPerson);
            this.Name = "Menu";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button CheckPerson;
    }
}