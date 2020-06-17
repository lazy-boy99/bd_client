namespace aircraft_client.WinForms
{
    partial class DirectorTechnicsForm
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
            this.TechButton = new System.Windows.Forms.Button();
            this.MasterButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TechButton
            // 
            this.TechButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TechButton.Location = new System.Drawing.Point(167, 121);
            this.TechButton.Name = "TechButton";
            this.TechButton.Size = new System.Drawing.Size(534, 66);
            this.TechButton.TabIndex = 0;
            this.TechButton.Text = "Технический состав";
            this.TechButton.UseVisualStyleBackColor = true;
            // 
            // MasterButton
            // 
            this.MasterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MasterButton.Location = new System.Drawing.Point(167, 227);
            this.MasterButton.Name = "MasterButton";
            this.MasterButton.Size = new System.Drawing.Size(534, 66);
            this.MasterButton.TabIndex = 1;
            this.MasterButton.Text = "Мастера";
            this.MasterButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(167, 324);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(263, 66);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(436, 324);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(265, 66);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // DirectorTechnicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MasterButton);
            this.Controls.Add(this.TechButton);
            this.Name = "DirectorTechnicsForm";
            this.Text = "DirectorTechnicsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TechButton;
        private System.Windows.Forms.Button MasterButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ExitButton;
    }
}