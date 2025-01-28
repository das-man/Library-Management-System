namespace library
{
    partial class Loan
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button8 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1270, 375);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Borrowed";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Borrow Date";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Return Date";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // button8
            // 
            button8.Font = new Font("Copperplate Gothic Light", 13F);
            button8.Location = new Point(559, 429);
            button8.Name = "button8";
            button8.Size = new Size(162, 164);
            button8.TabIndex = 12;
            button8.Text = "F5";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Copperplate Gothic Light", 13F);
            button1.Location = new Point(51, 401);
            button1.Name = "button1";
            button1.Size = new Size(205, 86);
            button1.TabIndex = 13;
            button1.Text = "check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Copperplate Gothic Light", 13F);
            button2.Location = new Point(294, 401);
            button2.Name = "button2";
            button2.Size = new Size(205, 86);
            button2.TabIndex = 14;
            button2.Text = "check in";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Copperplate Gothic Light", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(51, 521);
            button3.Name = "button3";
            button3.Size = new Size(205, 86);
            button3.TabIndex = 15;
            button3.Text = "renew";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Copperplate Gothic Light", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(294, 521);
            button4.Name = "button4";
            button4.Size = new Size(205, 86);
            button4.TabIndex = 16;
            button4.Text = "return";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Copperplate Gothic Light", 13F);
            textBox1.Location = new Point(773, 449);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 36);
            textBox1.TabIndex = 17;
            // 
            // button5
            // 
            button5.Font = new Font("Copperplate Gothic Light", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(1018, 443);
            button5.Name = "button5";
            button5.Size = new Size(210, 44);
            button5.TabIndex = 20;
            button5.Text = "search (id)";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Copperplate Gothic Light", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(848, 530);
            button7.Name = "button7";
            button7.Size = new Size(280, 47);
            button7.TabIndex = 22;
            button7.Text = "borrowed";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Loan
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 637);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button8);
            Controls.Add(dataGridView1);
            Name = "Loan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loan";
            Load += Loan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Button button5;
        private Button button7;
    }
}