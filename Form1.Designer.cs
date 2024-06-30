namespace password_generator
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
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            ExitApp = new Button();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Font = new Font("Sitka Display", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(204, 31);
            label1.MaximumSize = new Size(300, 40);
            label1.MinimumSize = new Size(300, 40);
            label1.Name = "label1";
            label1.Size = new Size(300, 40);
            label1.TabIndex = 5;
            label1.Text = "PASSWORD GENERATOR";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.Location = new Point(78, 306);
            button1.Name = "button1";
            button1.Size = new Size(155, 48);
            button1.TabIndex = 6;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuHighlight;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(357, 249);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(347, 31);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Font = new Font("Sitka Display", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(19, 135);
            label2.MaximumSize = new Size(300, 40);
            label2.MinimumSize = new Size(300, 40);
            label2.Name = "label2";
            label2.Size = new Size(300, 40);
            label2.TabIndex = 8;
            label2.Text = "NUMBER OF CHARACTERS";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonShadow;
            label3.Font = new Font("Sitka Display", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 240);
            label3.MaximumSize = new Size(300, 40);
            label3.MinimumSize = new Size(300, 40);
            label3.Name = "label3";
            label3.Size = new Size(300, 40);
            label3.TabIndex = 9;
            label3.Text = "GENERATED PASSWORD";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuHighlight;
            textBox1.Location = new Point(359, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 31);
            textBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Enabled = false;
            label4.Font = new Font("Sitka Display", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(12, 14);
            label4.MaximumSize = new Size(700, 350);
            label4.MinimumSize = new Size(700, 350);
            label4.Name = "label4";
            label4.Size = new Size(700, 350);
            label4.TabIndex = 11;
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // ExitApp
            // 
            ExitApp.Location = new Point(477, 307);
            ExitApp.Name = "ExitApp";
            ExitApp.Size = new Size(142, 48);
            ExitApp.TabIndex = 12;
            ExitApp.Text = "ExitApp";
            ExitApp.UseVisualStyleBackColor = true;
            ExitApp.Click += ExitApp_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(310, 314);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(112, 34);
            ClearButton.TabIndex = 13;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 388);
            Controls.Add(ClearButton);
            Controls.Add(ExitApp);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "Form1";
            Text = "PasswordGenrator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Button ExitApp;
        private Button ClearButton;
    }
}
