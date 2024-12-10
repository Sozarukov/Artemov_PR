namespace pr6
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
            button1 = new Button();
            st1 = new ListBox();
            st2 = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            button1.Location = new Point(212, 529);
            button1.Name = "button1";
            button1.Size = new Size(367, 83);
            button1.TabIndex = 0;
            button1.Text = "Запустить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // st1
            // 
            st1.FormattingEnabled = true;
            st1.Location = new Point(168, 46);
            st1.Name = "st1";
            st1.Size = new Size(210, 444);
            st1.TabIndex = 1;
            st1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // st2
            // 
            st2.FormattingEnabled = true;
            st2.Location = new Point(434, 46);
            st2.Name = "st2";
            st2.Size = new Size(210, 444);
            st2.TabIndex = 3;
            st2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(49, 671);
            label1.Name = "label1";
            label1.Size = new Size(703, 56);
            label1.TabIndex = 7;
            label1.Text = "Задание: Сгенерировать случайный массив из 20 чисел. \r\nНайти наибольший элемент и заменить им первый элемент массива";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 790);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(st2);
            Controls.Add(st1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Практическая работа №6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox st1;
        private ListBox st2;
        private TextBox textBox1;
        private Label label1;
    }
}
