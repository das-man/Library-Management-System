﻿namespace library
{
    partial class Create
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Palatino Linotype", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 114);
            label1.Name = "label1";
            label1.Size = new Size(112, 56);
            label1.TabIndex = 0;
            label1.Text = "Name: ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(276, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 30);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 30);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Palatino Linotype", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(161, 197);
            label2.Name = "label2";
            label2.Size = new Size(112, 56);
            label2.TabIndex = 2;
            label2.Text = "Author: ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(276, 306);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(361, 30);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Palatino Linotype", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(147, 289);
            label3.Name = "label3";
            label3.Size = new Size(135, 57);
            label3.TabIndex = 4;
            label3.Text = "Category: ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Font = new Font("Palatino Linotype", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(316, 426);
            button1.Name = "button1";
            button1.Size = new Size(161, 59);
            button1.TabIndex = 6;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 544);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Create";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
    }
}