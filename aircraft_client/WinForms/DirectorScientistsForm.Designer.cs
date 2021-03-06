﻿namespace aircraft_client.WinForms
{
    partial class DirectorScientistsForm
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
            this.LabsButton = new System.Windows.Forms.Button();
            this.ProdByLabButton = new System.Windows.Forms.Button();
            this.ScientistButton = new System.Windows.Forms.Button();
            this.ToolsByLab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabsButton
            // 
            this.LabsButton.Location = new System.Drawing.Point(604, 13);
            this.LabsButton.Name = "LabsButton";
            this.LabsButton.Size = new System.Drawing.Size(184, 97);
            this.LabsButton.TabIndex = 2;
            this.LabsButton.Text = "Получить список испытательных лабораторий для изделия";
            this.LabsButton.UseVisualStyleBackColor = true;
            // 
            // ProdByLabButton
            // 
            this.ProdByLabButton.Location = new System.Drawing.Point(604, 117);
            this.ProdByLabButton.Name = "ProdByLabButton";
            this.ProdByLabButton.Size = new System.Drawing.Size(184, 77);
            this.ProdByLabButton.TabIndex = 3;
            this.ProdByLabButton.Text = "Изделия испытуемые в лаборатории";
            this.ProdByLabButton.UseVisualStyleBackColor = true;
            // 
            // ScientistButton
            // 
            this.ScientistButton.Location = new System.Drawing.Point(604, 200);
            this.ScientistButton.Name = "ScientistButton";
            this.ScientistButton.Size = new System.Drawing.Size(184, 79);
            this.ScientistButton.TabIndex = 4;
            this.ScientistButton.Text = "Испытатели,участвующие в сборке изделия";
            this.ScientistButton.UseVisualStyleBackColor = true;
            // 
            // ToolsByLab
            // 
            this.ToolsByLab.Location = new System.Drawing.Point(604, 286);
            this.ToolsByLab.Name = "ToolsByLab";
            this.ToolsByLab.Size = new System.Drawing.Size(184, 72);
            this.ToolsByLab.TabIndex = 5;
            this.ToolsByLab.Text = "Состав экспериментального оборудования для выбраных изделий";
            this.ToolsByLab.UseVisualStyleBackColor = true;
            // 
            // DirectorScientistsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToolsByLab);
            this.Controls.Add(this.ScientistButton);
            this.Controls.Add(this.ProdByLabButton);
            this.Controls.Add(this.LabsButton);
            this.Name = "DirectorScientistsForm";
            this.Text = "DirectorScientistsForm";
            this.Controls.SetChildIndex(this.BackButton, 0);
            this.Controls.SetChildIndex(this.LabsButton, 0);
            this.Controls.SetChildIndex(this.ProdByLabButton, 0);
            this.Controls.SetChildIndex(this.ScientistButton, 0);
            this.Controls.SetChildIndex(this.ToolsByLab, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LabsButton;
        private System.Windows.Forms.Button ProdByLabButton;
        private System.Windows.Forms.Button ScientistButton;
        private System.Windows.Forms.Button ToolsByLab;
    }
}