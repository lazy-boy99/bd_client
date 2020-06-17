namespace aircraft_client.WinForms
{
    partial class BaseChooseTupleForm
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
            this.ChoosenPlaceBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SectorBox = new System.Windows.Forms.ComboBox();
            this.SectorButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.WsBox = new System.Windows.Forms.ComboBox();
            this.WsButton = new System.Windows.Forms.RadioButton();
            this.FactoryButton = new System.Windows.Forms.RadioButton();
            this.ChoosenPlaceBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(228, 178);
            this.CancelButton.Size = new System.Drawing.Size(180, 42);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(12, 178);
            this.ContinueButton.Size = new System.Drawing.Size(210, 42);
            // 
            // ChoosenPlaceBox
            // 
            this.ChoosenPlaceBox.Controls.Add(this.label2);
            this.ChoosenPlaceBox.Controls.Add(this.SectorBox);
            this.ChoosenPlaceBox.Controls.Add(this.SectorButton);
            this.ChoosenPlaceBox.Controls.Add(this.label1);
            this.ChoosenPlaceBox.Controls.Add(this.WsBox);
            this.ChoosenPlaceBox.Controls.Add(this.WsButton);
            this.ChoosenPlaceBox.Controls.Add(this.FactoryButton);
            this.ChoosenPlaceBox.Location = new System.Drawing.Point(12, 105);
            this.ChoosenPlaceBox.Name = "ChoosenPlaceBox";
            this.ChoosenPlaceBox.Size = new System.Drawing.Size(396, 67);
            this.ChoosenPlaceBox.TabIndex = 8;
            this.ChoosenPlaceBox.TabStop = false;
            this.ChoosenPlaceBox.Text = "Задайте место выборки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название участка";
            // 
            // SectorBox
            // 
            this.SectorBox.FormattingEnabled = true;
            this.SectorBox.Location = new System.Drawing.Point(318, 35);
            this.SectorBox.Name = "SectorBox";
            this.SectorBox.Size = new System.Drawing.Size(72, 21);
            this.SectorBox.TabIndex = 5;
            // 
            // SectorButton
            // 
            this.SectorButton.AutoSize = true;
            this.SectorButton.Location = new System.Drawing.Point(245, 35);
            this.SectorButton.Name = "SectorButton";
            this.SectorButton.Size = new System.Drawing.Size(67, 17);
            this.SectorButton.TabIndex = 4;
            this.SectorButton.TabStop = true;
            this.SectorButton.Text = "Участок";
            this.SectorButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название цеха";
            // 
            // WsBox
            // 
            this.WsBox.FormattingEnabled = true;
            this.WsBox.Location = new System.Drawing.Point(154, 35);
            this.WsBox.Name = "WsBox";
            this.WsBox.Size = new System.Drawing.Size(83, 21);
            this.WsBox.TabIndex = 2;
            // 
            // WsButton
            // 
            this.WsButton.AutoSize = true;
            this.WsButton.Location = new System.Drawing.Point(104, 35);
            this.WsButton.Name = "WsButton";
            this.WsButton.Size = new System.Drawing.Size(44, 17);
            this.WsButton.TabIndex = 1;
            this.WsButton.TabStop = true;
            this.WsButton.Text = "Цех";
            this.WsButton.UseVisualStyleBackColor = true;
            // 
            // FactoryButton
            // 
            this.FactoryButton.AutoSize = true;
            this.FactoryButton.Location = new System.Drawing.Point(6, 34);
            this.FactoryButton.Name = "FactoryButton";
            this.FactoryButton.Size = new System.Drawing.Size(92, 17);
            this.FactoryButton.TabIndex = 0;
            this.FactoryButton.TabStop = true;
            this.FactoryButton.Text = "Предприятие";
            this.FactoryButton.UseVisualStyleBackColor = true;
            // 
            // BaseChooseTupleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 229);
            this.Controls.Add(this.ChoosenPlaceBox);
            this.Name = "BaseChooseTupleForm";
            this.Text = "BaseChooseTupleForm";
            this.Controls.SetChildIndex(this.ContinueButton, 0);
            this.Controls.SetChildIndex(this.CancelButton, 0);
            this.Controls.SetChildIndex(this.ChoosenPlaceBox, 0);
            this.ChoosenPlaceBox.ResumeLayout(false);
            this.ChoosenPlaceBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox ChoosenPlaceBox;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ComboBox SectorBox;
        protected System.Windows.Forms.RadioButton SectorButton;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox WsBox;
        protected System.Windows.Forms.RadioButton WsButton;
        protected System.Windows.Forms.RadioButton FactoryButton;
    }
}