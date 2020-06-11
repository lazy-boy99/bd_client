namespace aircraft_client.WinForms
{
    partial class DirectorWorkersForm
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
            this.WorkersButton = new System.Windows.Forms.Button();
            this.TeamsButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WorkersButton
            // 
            this.WorkersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkersButton.Location = new System.Drawing.Point(98, 33);
            this.WorkersButton.Name = "WorkersButton";
            this.WorkersButton.Size = new System.Drawing.Size(628, 110);
            this.WorkersButton.TabIndex = 0;
            this.WorkersButton.Text = "Работники";
            this.WorkersButton.UseVisualStyleBackColor = true;
            // 
            // TeamsButton
            // 
            this.TeamsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeamsButton.Location = new System.Drawing.Point(98, 149);
            this.TeamsButton.Name = "TeamsButton";
            this.TeamsButton.Size = new System.Drawing.Size(628, 110);
            this.TeamsButton.TabIndex = 2;
            this.TeamsButton.Text = "Бригады";
            this.TeamsButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(98, 265);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(314, 110);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(430, 265);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(296, 110);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // DirectorWorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TeamsButton);
            this.Controls.Add(this.WorkersButton);
            this.Name = "DirectorWorkersForm";
            this.Text = "DirectorWorkersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WorkersButton;
        private System.Windows.Forms.Button TeamsButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ExitButton;
    }
}