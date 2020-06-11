namespace aircraft_client.WinForms
{
    partial class DirectorProductionForm
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
            this.ProdButton = new System.Windows.Forms.Button();
            this.JobButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProdButton
            // 
            this.ProdButton.Font = new System.Drawing.Font("Microsoft Sans Serif",15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdButton.Location = new System.Drawing.Point(135, 36);
            this.ProdButton.Name = "ProdButton";
            this.ProdButton.Size = new System.Drawing.Size(545, 112);
            this.ProdButton.TabIndex = 0;
            this.ProdButton.Text = "Продукция";
            this.ProdButton.UseVisualStyleBackColor = true;
            // 
            // JobButton
            // 
            this.JobButton.Font = new System.Drawing.Font("Microsoft Sans Serif",15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JobButton.Location = new System.Drawing.Point(135, 154);
            this.JobButton.Name = "JobButton";
            this.JobButton.Size = new System.Drawing.Size(545, 112);
            this.JobButton.TabIndex = 1;
            this.JobButton.Text = "Работы";
            this.JobButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif",15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(135, 272);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(283, 112);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif",15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(424, 272);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(256, 112);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // DirectorProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 412);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.JobButton);
            this.Controls.Add(this.ProdButton);
            this.Name = "DirectorProductionForm";
            this.Text = "DirectorProductionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProdButton;
        private System.Windows.Forms.Button JobButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ExitButton;
    }
}