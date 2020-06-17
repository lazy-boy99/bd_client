namespace aircraft_client.WinForms
{
    partial class ScientistChooseForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePickEnd = new System.Windows.Forms.DateTimePicker();
            this.DatePickBeg = new System.Windows.Forms.DateTimePicker();
            this.CategoryBox = new System.Windows.Forms.GroupBox();
            this.OtherPrButton = new System.Windows.Forms.RadioButton();
            this.GlidersButton = new System.Windows.Forms.RadioButton();
            this.HangGlidButton = new System.Windows.Forms.RadioButton();
            this.HeliButton = new System.Windows.Forms.RadioButton();
            this.PlanesButton = new System.Windows.Forms.RadioButton();
            this.RocketsButton = new System.Windows.Forms.RadioButton();
            this.AllProducts = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.productBox = new System.Windows.Forms.ComboBox();
            this.CategoryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(231, 179);
            this.CancelButton.Size = new System.Drawing.Size(200, 47);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(8, 179);
            this.ContinueButton.Size = new System.Drawing.Size(200, 47);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Дата окончания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Дата начала";
            // 
            // DatePickEnd
            // 
            this.DatePickEnd.Location = new System.Drawing.Point(231, 153);
            this.DatePickEnd.Name = "DatePickEnd";
            this.DatePickEnd.Size = new System.Drawing.Size(200, 20);
            this.DatePickEnd.TabIndex = 15;
            // 
            // DatePickBeg
            // 
            this.DatePickBeg.Location = new System.Drawing.Point(8, 153);
            this.DatePickBeg.Name = "DatePickBeg";
            this.DatePickBeg.Size = new System.Drawing.Size(200, 20);
            this.DatePickBeg.TabIndex = 14;
            // 
            // CategoryBox
            // 
            this.CategoryBox.Controls.Add(this.productBox);
            this.CategoryBox.Controls.Add(this.radioButton1);
            this.CategoryBox.Controls.Add(this.OtherPrButton);
            this.CategoryBox.Controls.Add(this.GlidersButton);
            this.CategoryBox.Controls.Add(this.HangGlidButton);
            this.CategoryBox.Controls.Add(this.HeliButton);
            this.CategoryBox.Controls.Add(this.PlanesButton);
            this.CategoryBox.Controls.Add(this.RocketsButton);
            this.CategoryBox.Controls.Add(this.AllProducts);
            this.CategoryBox.Location = new System.Drawing.Point(12, 12);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(419, 120);
            this.CategoryBox.TabIndex = 13;
            this.CategoryBox.TabStop = false;
            this.CategoryBox.Text = "Выберете изделия";
            // 
            // OtherPrButton
            // 
            this.OtherPrButton.AutoSize = true;
            this.OtherPrButton.Location = new System.Drawing.Point(287, 52);
            this.OtherPrButton.Name = "OtherPrButton";
            this.OtherPrButton.Size = new System.Drawing.Size(118, 17);
            this.OtherPrButton.TabIndex = 6;
            this.OtherPrButton.TabStop = true;
            this.OtherPrButton.Text = "Другая продукция";
            this.OtherPrButton.UseVisualStyleBackColor = true;
            // 
            // GlidersButton
            // 
            this.GlidersButton.AutoSize = true;
            this.GlidersButton.Location = new System.Drawing.Point(334, 19);
            this.GlidersButton.Name = "GlidersButton";
            this.GlidersButton.Size = new System.Drawing.Size(71, 17);
            this.GlidersButton.TabIndex = 5;
            this.GlidersButton.TabStop = true;
            this.GlidersButton.Text = "Планеры";
            this.GlidersButton.UseVisualStyleBackColor = true;
            // 
            // HangGlidButton
            // 
            this.HangGlidButton.AutoSize = true;
            this.HangGlidButton.Location = new System.Drawing.Point(152, 52);
            this.HangGlidButton.Name = "HangGlidButton";
            this.HangGlidButton.Size = new System.Drawing.Size(95, 17);
            this.HangGlidButton.TabIndex = 4;
            this.HangGlidButton.TabStop = true;
            this.HangGlidButton.Text = "Дельтапланы";
            this.HangGlidButton.UseVisualStyleBackColor = true;
            // 
            // HeliButton
            // 
            this.HeliButton.AutoSize = true;
            this.HeliButton.Location = new System.Drawing.Point(6, 52);
            this.HeliButton.Name = "HeliButton";
            this.HeliButton.Size = new System.Drawing.Size(80, 17);
            this.HeliButton.TabIndex = 3;
            this.HeliButton.TabStop = true;
            this.HeliButton.Text = "Вертолеты";
            this.HeliButton.UseVisualStyleBackColor = true;
            // 
            // PlanesButton
            // 
            this.PlanesButton.AutoSize = true;
            this.PlanesButton.Location = new System.Drawing.Point(230, 19);
            this.PlanesButton.Name = "PlanesButton";
            this.PlanesButton.Size = new System.Drawing.Size(77, 17);
            this.PlanesButton.TabIndex = 2;
            this.PlanesButton.TabStop = true;
            this.PlanesButton.Text = "Самолеты";
            this.PlanesButton.UseVisualStyleBackColor = true;
            // 
            // RocketsButton
            // 
            this.RocketsButton.AutoSize = true;
            this.RocketsButton.Location = new System.Drawing.Point(133, 19);
            this.RocketsButton.Name = "RocketsButton";
            this.RocketsButton.Size = new System.Drawing.Size(63, 17);
            this.RocketsButton.TabIndex = 1;
            this.RocketsButton.TabStop = true;
            this.RocketsButton.Text = "Ракеты";
            this.RocketsButton.UseVisualStyleBackColor = true;
            // 
            // AllProducts
            // 
            this.AllProducts.AutoSize = true;
            this.AllProducts.Location = new System.Drawing.Point(6, 19);
            this.AllProducts.Name = "AllProducts";
            this.AllProducts.Size = new System.Drawing.Size(99, 17);
            this.AllProducts.TabIndex = 0;
            this.AllProducts.TabStop = true;
            this.AllProducts.Text = "Все категории";
            this.AllProducts.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 85);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Указаная продукция";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // productBox
            // 
            this.productBox.FormattingEnabled = true;
            this.productBox.Location = new System.Drawing.Point(152, 85);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(120, 21);
            this.productBox.TabIndex = 8;
            // 
            // ScientistChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DatePickEnd);
            this.Controls.Add(this.DatePickBeg);
            this.Controls.Add(this.CategoryBox);
            this.Name = "ScientistChooseForm";
            this.Text = "ScientistChooseForm";
            this.Controls.SetChildIndex(this.ContinueButton, 0);
            this.Controls.SetChildIndex(this.CancelButton, 0);
            this.Controls.SetChildIndex(this.CategoryBox, 0);
            this.Controls.SetChildIndex(this.DatePickBeg, 0);
            this.Controls.SetChildIndex(this.DatePickEnd, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.CategoryBox.ResumeLayout(false);
            this.CategoryBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DatePickEnd;
        private System.Windows.Forms.DateTimePicker DatePickBeg;
        private System.Windows.Forms.GroupBox CategoryBox;
        private System.Windows.Forms.ComboBox productBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton OtherPrButton;
        private System.Windows.Forms.RadioButton GlidersButton;
        private System.Windows.Forms.RadioButton HangGlidButton;
        private System.Windows.Forms.RadioButton HeliButton;
        private System.Windows.Forms.RadioButton PlanesButton;
        private System.Windows.Forms.RadioButton RocketsButton;
        private System.Windows.Forms.RadioButton AllProducts;
    }
}