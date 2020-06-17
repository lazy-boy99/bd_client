namespace aircraft_client.WinForms
{
    partial class ProductionChooseForm
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
            this.ChooseModeBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateBegPicker = new System.Windows.Forms.DateTimePicker();
            this.ProdAssemblingButton = new System.Windows.Forms.RadioButton();
            this.ProdAssembledButton = new System.Windows.Forms.RadioButton();
            this.ProdTypeButton = new System.Windows.Forms.RadioButton();
            this.CategoryBox = new System.Windows.Forms.GroupBox();
            this.OtherPrButton = new System.Windows.Forms.RadioButton();
            this.GlidersButton = new System.Windows.Forms.RadioButton();
            this.HangGlidButton = new System.Windows.Forms.RadioButton();
            this.HeliButton = new System.Windows.Forms.RadioButton();
            this.PlanesButton = new System.Windows.Forms.RadioButton();
            this.RocketsButton = new System.Windows.Forms.RadioButton();
            this.AllProducts = new System.Windows.Forms.RadioButton();
            this.DateEndPicker = new System.Windows.Forms.DateTimePicker();
            this.ChoosenPlaceBox.SuspendLayout();
            this.ChooseModeBox.SuspendLayout();
            this.CategoryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChoosenPlaceBox
            // 
            this.ChoosenPlaceBox.Location = new System.Drawing.Point(12, 113);
            this.ChoosenPlaceBox.Size = new System.Drawing.Size(426, 67);
            this.ChoosenPlaceBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(321, 16);
            // 
            // SectorBox
            // 
            this.SectorBox.Location = new System.Drawing.Point(348, 32);
            // 
            // SectorButton
            // 
            this.SectorButton.Location = new System.Drawing.Point(275, 34);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(164, 18);
            // 
            // WsBox
            // 
            this.WsBox.Location = new System.Drawing.Point(162, 32);
            // 
            // WsButton
            // 
            this.WsButton.Location = new System.Drawing.Point(112, 36);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(207, 293);
            this.CancelButton.Size = new System.Drawing.Size(201, 33);
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(12, 293);
            this.ContinueButton.Size = new System.Drawing.Size(189, 33);
            // 
            // ChooseModeBox
            // 
            this.ChooseModeBox.Controls.Add(this.label4);
            this.ChooseModeBox.Controls.Add(this.label3);
            this.ChooseModeBox.Controls.Add(this.DateBegPicker);
            this.ChooseModeBox.Controls.Add(this.ProdAssemblingButton);
            this.ChooseModeBox.Controls.Add(this.ProdAssembledButton);
            this.ChooseModeBox.Controls.Add(this.ProdTypeButton);
            this.ChooseModeBox.Location = new System.Drawing.Point(12, 12);
            this.ChooseModeBox.Name = "ChooseModeBox";
            this.ChooseModeBox.Size = new System.Drawing.Size(426, 95);
            this.ChooseModeBox.TabIndex = 6;
            this.ChooseModeBox.TabStop = false;
            this.ChooseModeBox.Text = "Задайте конфигурацию выборки ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата окончания сборки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата начала сборки";
            // 
            // DateBegPicker
            // 
            this.DateBegPicker.Location = new System.Drawing.Point(133, 60);
            this.DateBegPicker.Name = "DateBegPicker";
            this.DateBegPicker.Size = new System.Drawing.Size(140, 20);
            this.DateBegPicker.TabIndex = 3;
            // 
            // ProdAssemblingButton
            // 
            this.ProdAssemblingButton.AutoSize = true;
            this.ProdAssemblingButton.Location = new System.Drawing.Point(230, 19);
            this.ProdAssemblingButton.Name = "ProdAssemblingButton";
            this.ProdAssemblingButton.Size = new System.Drawing.Size(135, 17);
            this.ProdAssemblingButton.TabIndex = 2;
            this.ProdAssemblingButton.TabStop = true;
            this.ProdAssemblingButton.Text = "Собираемые изделия";
            this.ProdAssemblingButton.UseVisualStyleBackColor = true;
            // 
            // ProdAssembledButton
            // 
            this.ProdAssembledButton.AutoSize = true;
            this.ProdAssembledButton.Location = new System.Drawing.Point(6, 60);
            this.ProdAssembledButton.Name = "ProdAssembledButton";
            this.ProdAssembledButton.Size = new System.Drawing.Size(121, 17);
            this.ProdAssembledButton.TabIndex = 1;
            this.ProdAssembledButton.TabStop = true;
            this.ProdAssembledButton.Text = "Собраные изделия";
            this.ProdAssembledButton.UseVisualStyleBackColor = true;
            // 
            // ProdTypeButton
            // 
            this.ProdTypeButton.AutoSize = true;
            this.ProdTypeButton.Location = new System.Drawing.Point(6, 19);
            this.ProdTypeButton.Name = "ProdTypeButton";
            this.ProdTypeButton.Size = new System.Drawing.Size(97, 17);
            this.ProdTypeButton.TabIndex = 0;
            this.ProdTypeButton.TabStop = true;
            this.ProdTypeButton.Text = "Виды изделий";
            this.ProdTypeButton.UseVisualStyleBackColor = true;
            // 
            // CategoryBox
            // 
            this.CategoryBox.Controls.Add(this.OtherPrButton);
            this.CategoryBox.Controls.Add(this.GlidersButton);
            this.CategoryBox.Controls.Add(this.HangGlidButton);
            this.CategoryBox.Controls.Add(this.HeliButton);
            this.CategoryBox.Controls.Add(this.PlanesButton);
            this.CategoryBox.Controls.Add(this.RocketsButton);
            this.CategoryBox.Controls.Add(this.AllProducts);
            this.CategoryBox.Location = new System.Drawing.Point(12, 206);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(420, 81);
            this.CategoryBox.TabIndex = 7;
            this.CategoryBox.TabStop = false;
            this.CategoryBox.Text = "Выберете категорию";
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
            // DateEndPicker
            // 
            this.DateEndPicker.Location = new System.Drawing.Point(291, 72);
            this.DateEndPicker.Name = "DateEndPicker";
            this.DateEndPicker.Size = new System.Drawing.Size(141, 20);
            this.DateEndPicker.TabIndex = 4;
            // 
            // ProductionChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 334);
            this.Controls.Add(this.DateEndPicker);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.ChooseModeBox);
            this.Name = "ProductionChooseForm";
            this.Text = "ProductionChooseForm";
            this.Controls.SetChildIndex(this.ChooseModeBox, 0);
            this.Controls.SetChildIndex(this.ChoosenPlaceBox, 0);
            this.Controls.SetChildIndex(this.ContinueButton, 0);
            this.Controls.SetChildIndex(this.CancelButton, 0);
            this.Controls.SetChildIndex(this.CategoryBox, 0);
            this.Controls.SetChildIndex(this.DateEndPicker, 0);
            this.ChoosenPlaceBox.ResumeLayout(false);
            this.ChoosenPlaceBox.PerformLayout();
            this.ChooseModeBox.ResumeLayout(false);
            this.ChooseModeBox.PerformLayout();
            this.CategoryBox.ResumeLayout(false);
            this.CategoryBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ChooseModeBox;
        private System.Windows.Forms.RadioButton ProdAssemblingButton;
        private System.Windows.Forms.RadioButton ProdAssembledButton;
        private System.Windows.Forms.RadioButton ProdTypeButton;
        private System.Windows.Forms.GroupBox CategoryBox;
        private System.Windows.Forms.RadioButton OtherPrButton;
        private System.Windows.Forms.RadioButton GlidersButton;
        private System.Windows.Forms.RadioButton HangGlidButton;
        private System.Windows.Forms.RadioButton HeliButton;
        private System.Windows.Forms.RadioButton PlanesButton;
        private System.Windows.Forms.RadioButton RocketsButton;
        private System.Windows.Forms.RadioButton AllProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateBegPicker;
        private System.Windows.Forms.DateTimePicker DateEndPicker;
    }
}