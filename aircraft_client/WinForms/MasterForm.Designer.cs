namespace aircraft_client.WinForms
{
    partial class MasterForm
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
            this.MasterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(603, 254);
            this.BackButton.Size = new System.Drawing.Size(185, 184);
            // 
            // MasterButton
            // 
            this.MasterButton.Location = new System.Drawing.Point(603, 12);
            this.MasterButton.Name = "MasterButton";
            this.MasterButton.Size = new System.Drawing.Size(185, 236);
            this.MasterButton.TabIndex = 2;
            this.MasterButton.Text = "Выбрать мастеров";
            this.MasterButton.UseVisualStyleBackColor = true;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MasterButton);
            this.Name = "MasterForm";
            this.Text = "MasterForm";
            this.Controls.SetChildIndex(this.BackButton, 0);
            this.Controls.SetChildIndex(this.MasterButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MasterButton;
    }
}