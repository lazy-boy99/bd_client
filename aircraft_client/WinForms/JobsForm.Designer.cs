namespace aircraft_client.WinForms
{
    partial class JobsForm
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
            this.JobsByProdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(603, 280);
            this.BackButton.Size = new System.Drawing.Size(185, 158);
            // 
            // JobsByProdButton
            // 
            this.JobsByProdButton.Location = new System.Drawing.Point(603, 12);
            this.JobsByProdButton.Name = "JobsByProdButton";
            this.JobsByProdButton.Size = new System.Drawing.Size(184, 262);
            this.JobsByProdButton.TabIndex = 4;
            this.JobsByProdButton.Text = "Перечень работ изделия";
            this.JobsByProdButton.UseVisualStyleBackColor = true;
            // 
            // JobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JobsByProdButton);
            this.Name = "JobsForm";
            this.Text = "JobsForm";
            this.Controls.SetChildIndex(this.BackButton, 0);
            this.Controls.SetChildIndex(this.JobsByProdButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JobsByProdButton;
    }
}