namespace aircraft_client.WinForms
{
    partial class LoginForm
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
            this.LogField = new System.Windows.Forms.TextBox();
            this.PasField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogField
            // 
            this.LogField.Location = new System.Drawing.Point(12, 36);
            this.LogField.Name = "LogField";
            this.LogField.Size = new System.Drawing.Size(317, 20);
            this.LogField.TabIndex = 0;
            // 
            // PasField
            // 
            this.PasField.Location = new System.Drawing.Point(12, 82);
            this.PasField.Name = "PasField";
            this.PasField.PasswordChar = '*';
            this.PasField.Size = new System.Drawing.Size(317, 20);
            this.PasField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(113, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите пароль";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(257, 108);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(72, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 108);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(106, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Войти";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(124, 108);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(127, 23);
            this.SignUpButton.TabIndex = 7;
            this.SignUpButton.Text = "Зарегистрироваться";
            this.SignUpButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 144);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasField);
            this.Controls.Add(this.LogField);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogField;
        private System.Windows.Forms.TextBox PasField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button SignUpButton;
    }
}