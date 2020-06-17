namespace aircraft_client.WinForms
{
    partial class TeamChooseForm
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
            this.ChoosenPlaceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChoosenPlaceBox
            // 
            this.ChoosenPlaceBox.Location = new System.Drawing.Point(12, 12);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(228, 85);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(12, 85);
            // 
            // TeamChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 144);
            this.Name = "TeamChooseForm";
            this.Text = "TeamChooseForm";
            this.ChoosenPlaceBox.ResumeLayout(false);
            this.ChoosenPlaceBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}