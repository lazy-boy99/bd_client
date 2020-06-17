namespace aircraft_client.WinForms
{
    partial class ChooseForm
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
            this.ChooseField = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(185, 83);
            this.CancelButton.Size = new System.Drawing.Size(168, 40);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(11, 83);
            this.ContinueButton.Size = new System.Drawing.Size(168, 40);
            // 
            // ChooseField
            // 
            this.ChooseField.FormattingEnabled = true;
            this.ChooseField.Location = new System.Drawing.Point(12, 56);
            this.ChooseField.Name = "ChooseField";
            this.ChooseField.Size = new System.Drawing.Size(342, 21);
            this.ChooseField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(365, 134);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseField);
            this.Name = "ChooseForm";
            this.Controls.SetChildIndex(this.ChooseField, 0);
            this.Controls.SetChildIndex(this.ContinueButton, 0);
            this.Controls.SetChildIndex(this.CancelButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ComboBox ChooseField;
        protected System.Windows.Forms.Label label1;
    }
}
