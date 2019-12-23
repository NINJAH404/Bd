namespace WindowsForms
{
    partial class Avtorixetion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // LoginText
            // 
            this.LoginText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginText.BackColor = System.Drawing.SystemColors.Window;
            this.LoginText.Location = new System.Drawing.Point(214, 108);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(266, 22);
            this.LoginText.TabIndex = 2;
            // 
            // PasswordText
            // 
            this.PasswordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordText.Location = new System.Drawing.Point(214, 211);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(266, 22);
            this.PasswordText.TabIndex = 3;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitButton.BackColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Location = new System.Drawing.Point(390, 347);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(212, 87);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // EnterButton
            // 
            this.EnterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterButton.Location = new System.Drawing.Point(77, 346);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(247, 89);
            this.EnterButton.TabIndex = 5;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // Avtorixetion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(669, 473);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Avtorixetion";
            this.Text = "fghjk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button EnterButton;
    }
}