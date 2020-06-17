namespace aircraft_client.WinForms
{
    partial class TechnicsForm
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
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(603, 253);
            this.BackButton.Size = new System.Drawing.Size(185, 185);
            // 
            // TechButton
            // 
            this.TechButton.Location = new System.Drawing.Point(603, 12);
            this.TechButton.Name = "TechButton";
            this.TechButton.Size = new System.Drawing.Size(185, 235);
            this.TechButton.TabIndex = 0;
            this.TechButton.Text = "Выбрать технический персонал";
            this.TechButton.UseVisualStyleBackColor = true;
            // 
            // TechnicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TechButton);
            this.Name = "TechnicsForm";
            this.Text = "TechnicsForm";
            this.Controls.SetChildIndex(this.TechButton, 0);
            this.Controls.SetChildIndex(this.BackButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TechButton;
    }
}