namespace aircraft_client.WinForms
{
    partial class WorkersForm
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
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(603, 221);
            this.BackButton.Size = new System.Drawing.Size(185, 217);
            // 
            // WorkersButton
            // 
            this.WorkersButton.Location = new System.Drawing.Point(604, 13);
            this.WorkersButton.Name = "WorkersButton";
            this.WorkersButton.Size = new System.Drawing.Size(184, 202);
            this.WorkersButton.TabIndex = 2;
            this.WorkersButton.Text = "Получить выборку рабочих";
            this.WorkersButton.UseVisualStyleBackColor = true;
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WorkersButton);
            this.Name = "WorkersForm";
            this.Text = "WorkersForm";
            this.Controls.SetChildIndex(this.BackButton, 0);
            this.Controls.SetChildIndex(this.WorkersButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WorkersButton;
    }
}