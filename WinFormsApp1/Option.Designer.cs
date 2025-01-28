namespace library
{
    partial class Option
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
            Greetings = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Greetings
            // 
            Greetings.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Greetings.Location = new Point(230, 39);
            Greetings.Name = "Greetings";
            Greetings.Size = new Size(644, 152);
            Greetings.TabIndex = 0;
            Greetings.Text = "label1";
            Greetings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(144, 311);
            button1.Name = "button1";
            button1.Size = new Size(251, 129);
            button1.TabIndex = 1;
            button1.Text = "Database";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(704, 311);
            button2.Name = "button2";
            button2.Size = new Size(251, 129);
            button2.TabIndex = 2;
            button2.Text = "Book Loan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Option
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 544);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Greetings);
            Name = "Option";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Option";
            ResumeLayout(false);
        }

        #endregion

        private Label Greetings;
        private Button button1;
        private Button button2;
    }
}