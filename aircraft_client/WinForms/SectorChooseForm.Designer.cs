namespace aircraft_client.WinForms
{
    partial class SectorChooseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.WsBox = new System.Windows.Forms.ComboBox();
            this.WsButton = new System.Windows.Forms.RadioButton();
            this.FactoryButton = new System.Windows.Forms.RadioButton();
            this.ChoosenPlaceBox = new System.Windows.Forms.GroupBox();
            this.ChoosenPlaceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название цеха";
            // 
            // WsBox
            // 
            this.WsBox.FormattingEnabled = true;
            this.WsBox.Location = new System.Drawing.Point(159, 53);
            this.WsBox.Name = "WsBox";
            this.WsBox.Size = new System.Drawing.Size(83, 21);
            this.WsBox.TabIndex = 7;
            // 
            // WsButton
            // 
            this.WsButton.AutoSize = true;
            this.WsButton.Location = new System.Drawing.Point(109, 53);
            this.WsButton.Name = "WsButton";
            this.WsButton.Size = new System.Drawing.Size(44, 17);
            this.WsButton.TabIndex = 6;
            this.WsButton.TabStop = true;
            this.WsButton.Text = "Цех";
            this.WsButton.UseVisualStyleBackColor = true;
            // 
            // FactoryButton
            // 
            this.FactoryButton.AutoSize = true;
            this.FactoryButton.Location = new System.Drawing.Point(11, 52);
            this.FactoryButton.Name = "FactoryButton";
            this.FactoryButton.Size = new System.Drawing.Size(92, 17);
            this.FactoryButton.TabIndex = 5;
            this.FactoryButton.TabStop = true;
            this.FactoryButton.Text = "Предприятие";
            this.FactoryButton.UseVisualStyleBackColor = true;
            // 
            // ChoosenPlaceBox
            // 
            this.ChoosenPlaceBox.Controls.Add(this.WsBox);
            this.ChoosenPlaceBox.Controls.Add(this.label1);
            this.ChoosenPlaceBox.Controls.Add(this.FactoryButton);
            this.ChoosenPlaceBox.Controls.Add(this.WsButton);
            this.ChoosenPlaceBox.Location = new System.Drawing.Point(29, 31);
            this.ChoosenPlaceBox.Name = "ChoosenPlaceBox";
            this.ChoosenPlaceBox.Size = new System.Drawing.Size(248, 100);
            this.ChoosenPlaceBox.TabIndex = 9;
            this.ChoosenPlaceBox.TabStop = false;
            this.ChoosenPlaceBox.Text = "Выберите место выборки";
            // 
            // SectorChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChoosenPlaceBox);
            this.Name = "SectorChooseForm";
            this.Text = "SectorChooseForm";
            this.Controls.SetChildIndex(this.ContinueButton, 0);
            this.Controls.SetChildIndex(this.CancelButton, 0);
            this.Controls.SetChildIndex(this.ChoosenPlaceBox, 0);
            this.ChoosenPlaceBox.ResumeLayout(false);
            this.ChoosenPlaceBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox WsBox;
        protected System.Windows.Forms.RadioButton WsButton;
        protected System.Windows.Forms.RadioButton FactoryButton;
        private System.Windows.Forms.GroupBox ChoosenPlaceBox;
    }
}