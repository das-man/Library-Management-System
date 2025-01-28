namespace library
{
    partial class Book_db
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button7 = new Button();
            button8 = new Button();
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
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1270, 375);
            dataGridView1.TabIndex = 0;
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
            Column3.HeaderText = "Author";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Category";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HighlightText;
            button1.Font = new Font("Copperplate Gothic Light", 13F);
            button1.Location = new Point(59, 406);
            button1.Name = "button1";
            button1.Size = new Size(165, 61);
            button1.TabIndex = 1;
            button1.Text = "create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HighlightText;
            button2.Font = new Font("Copperplate Gothic Light", 13F);
            button2.Location = new Point(59, 518);
            button2.Name = "button2";
            button2.Size = new Size(165, 61);
            button2.TabIndex = 2;
            button2.Text = "update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HighlightText;
            button3.Font = new Font("Copperplate Gothic Light", 13F);
            button3.Location = new Point(286, 406);
            button3.Name = "button3";
            button3.Size = new Size(165, 61);
            button3.TabIndex = 3;
            button3.Text = "delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HighlightText;
            button4.Font = new Font("Copperplate Gothic Light", 13F);
            button4.Location = new Point(941, 401);
            button4.Name = "button4";
            button4.Size = new Size(290, 42);
            button4.TabIndex = 4;
            button4.Text = "search (ID)";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HighlightText;
            button5.Font = new Font("Copperplate Gothic Light", 13F);
            button5.Location = new Point(286, 518);
            button5.Name = "button5";
            button5.Size = new Size(165, 61);
            button5.TabIndex = 5;
            button5.Text = "return";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.HighlightText;
            button6.Font = new Font("Copperplate Gothic Light", 13F);
            button6.Location = new Point(941, 470);
            button6.Name = "button6";
            button6.Size = new Size(290, 46);
            button6.TabIndex = 6;
            button6.Text = "search (Name)";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Copperplate Gothic Light", 13F);
            textBox1.Location = new Point(667, 411);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 36);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Copperplate Gothic Light", 13F);
            textBox2.Location = new Point(667, 482);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 36);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Copperplate Gothic Light", 13F);
            textBox3.Location = new Point(667, 549);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 36);
            textBox3.TabIndex = 9;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.HighlightText;
            button7.Font = new Font("Copperplate Gothic Light", 13F);
            button7.Location = new Point(941, 545);
            button7.Name = "button7";
            button7.Size = new Size(290, 46);
            button7.TabIndex = 10;
            button7.Text = "search (Category)";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Copperplate Gothic Light", 13F);
            button8.Location = new Point(509, 411);
            button8.Name = "button8";
            button8.Size = new Size(98, 180);
            button8.TabIndex = 11;
            button8.Text = "F5";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Book_db
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1270, 637);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Book_db";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Database";
            Load += Book_db_Load;
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button7;
        private Button button8;
    }
}