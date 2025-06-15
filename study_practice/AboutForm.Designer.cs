namespace study_practice
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            panel1 = new Panel();
            backBtn = new Button();
            textBox1 = new TextBox();
            close = new Button();
            Title = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(-6, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 561);
            panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.GradientActiveCaption;
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backBtn.Location = new Point(802, 532);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(98, 22);
            backBtn.TabIndex = 13;
            backBtn.Text = "Назад";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SlateBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(3, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(900, 557);
            textBox1.TabIndex = 4;
            textBox1.TabStop = false;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // close
            // 
            close.BackColor = Color.Indigo;
            close.Cursor = Cursors.Hand;
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;
            close.Location = new Point(857, 0);
            close.Name = "close";
            close.Size = new Size(44, 30);
            close.TabIndex = 2;
            close.TabStop = false;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Title.Location = new Point(-1, 5);
            Title.Name = "Title";
            Title.Size = new Size(94, 14);
            Title.TabIndex = 3;
            Title.Text = "О программе";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(900, 589);
            Controls.Add(Title);
            Controls.Add(close);
            Controls.Add(panel1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AboutForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button close;
        private Label Title;
        private TextBox textBox1;
        private Button backBtn;
    }
}