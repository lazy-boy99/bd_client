namespace aircraft_client.WinForms
{
    partial class DirectorForm
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
            this.SectorListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(603, 255);
            this.BackButton.Size = new System.Drawing.Size(185, 183);
            // 
            // SectorListButton
            // 
            this.SectorListButton.Location = new System.Drawing.Point(604, 13);
            this.SectorListButton.Name = "SectorListButton";
            this.SectorListButton.Size = new System.Drawing.Size(184, 236);
            this.SectorListButton.TabIndex = 2;
            this.SectorListButton.Text = "Получить список участков";
            this.SectorListButton.UseVisualStyleBackColor = true;
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SectorListButton);
            this.Name = "DirectorForm";
            this.Text = "DirectorForm";
            this.Controls.SetChildIndex(this.BackButton, 0);
            this.Controls.SetChildIndex(this.SectorListButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SectorListButton;
    }
}