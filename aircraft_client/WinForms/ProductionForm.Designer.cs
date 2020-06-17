namespace aircraft_client.WinForms
{
    partial class ProductionForm
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
            this.ProdChooseButton = new System.Windows.Forms.Button();
            this.TeamAssemblingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProdChooseButton
            // 
            this.ProdChooseButton.Location = new System.Drawing.Point(603, 12);
            this.ProdChooseButton.Name = "ProdChooseButton";
            this.ProdChooseButton.Size = new System.Drawing.Size(184, 183);
            this.ProdChooseButton.TabIndex = 2;
            this.ProdChooseButton.Text = "Выборка изделий";
            this.ProdChooseButton.UseVisualStyleBackColor = true;
            // 
            // TeamAssemblingButton
            // 
            this.TeamAssemblingButton.Location = new System.Drawing.Point(604, 202);
            this.TeamAssemblingButton.Name = "TeamAssemblingButton";
            this.TeamAssemblingButton.Size = new System.Drawing.Size(183, 156);
            this.TeamAssemblingButton.TabIndex = 3;
            this.TeamAssemblingButton.Text = "Список бригад,собирающих изделие";
            this.TeamAssemblingButton.UseVisualStyleBackColor = true;
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TeamAssemblingButton);
            this.Controls.Add(this.ProdChooseButton);
            this.Name = "ProductionForm";
            this.Text = "ProductionForm";
            this.Controls.SetChildIndex(this.BackButton, 0);
            this.Controls.SetChildIndex(this.ProdChooseButton, 0);
            this.Controls.SetChildIndex(this.TeamAssemblingButton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProdChooseButton;
        private System.Windows.Forms.Button TeamAssemblingButton;
    }
}