namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Greet = new Label();
            label1 = new Label();
            label2 = new Label();
            usernameBox = new TextBox();
            pwdBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Greet
            // 
            Greet.BackColor = SystemColors.Control;
            Greet.Font = new Font("Copperplate Gothic Light", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Greet.Location = new Point(128, 88);
            Greet.Name = "Greet";
            Greet.Size = new Size(830, 115);
            Greet.TabIndex = 0;
            Greet.Text = "Welcome to Online Library System";
            Greet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(349, 251);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 1;
            label1.Text = "name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(265, 337);
            label2.Name = "label2";
            label2.Size = new Size(195, 32);
            label2.TabIndex = 2;
            label2.Text = "password: ";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(475, 256);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(331, 30);
            usernameBox.TabIndex = 3;
            // 
            // pwdBox
            // 
            pwdBox.Location = new Point(475, 342);
            pwdBox.Name = "pwdBox";
            pwdBox.Size = new Size(331, 30);
            pwdBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(442, 439);
            button1.Name = "button1";
            button1.Size = new Size(182, 70);
            button1.TabIndex = 5;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 544);
            Controls.Add(button1);
            Controls.Add(pwdBox);
            Controls.Add(usernameBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Greet);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Greet;
        private Label label1;
        private Label label2;
        private TextBox usernameBox;
        private TextBox pwdBox;
        private Button button1;
    }
}
