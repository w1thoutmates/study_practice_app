namespace study_practice
{
    partial class LoadScreen
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            toCalculateBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            close = new Button();
            Title = new Label();
            aboutProgramm = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(aboutProgramm);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(toCalculateBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 216);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.Location = new Point(124, 64);
            label4.Name = "label4";
            label4.Size = new Size(19, 18);
            label4.TabIndex = 15;
            label4.Text = "9";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 14F, FontStyle.Bold);
            label3.Location = new Point(-1, 63);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 14;
            label3.Text = "Вариант:";
            // 
            // toCalculateBtn
            // 
            toCalculateBtn.BackColor = SystemColors.GradientActiveCaption;
            toCalculateBtn.FlatStyle = FlatStyle.Popup;
            toCalculateBtn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toCalculateBtn.Location = new Point(6, 182);
            toCalculateBtn.Margin = new Padding(3, 2, 3, 2);
            toCalculateBtn.Name = "toCalculateBtn";
            toCalculateBtn.Size = new Size(113, 22);
            toCalculateBtn.TabIndex = 13;
            toCalculateBtn.Text = "Вычисления";
            toCalculateBtn.UseVisualStyleBackColor = false;
            toCalculateBtn.Click += toCalculateBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.Location = new Point(-1, 35);
            label2.Name = "label2";
            label2.Size = new Size(426, 18);
            label2.TabIndex = 5;
            label2.Text = "Никифоров Денис Андреевич группа ИСП-306";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14F, FontStyle.Bold);
            label1.Location = new Point(-1, 7);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 4;
            label1.Text = "Автор:";
            // 
            // close
            // 
            close.BackColor = Color.Indigo;
            close.Cursor = Cursors.Hand;
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;
            close.Location = new Point(503, -1);
            close.Margin = new Padding(3, 2, 3, 2);
            close.Name = "close";
            close.Size = new Size(34, 25);
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
            Title.Location = new Point(0, 6);
            Title.Name = "Title";
            Title.Size = new Size(69, 14);
            Title.TabIndex = 3;
            Title.Text = "Заставка";
            // 
            // aboutProgramm
            // 
            aboutProgramm.BackColor = SystemColors.GradientActiveCaption;
            aboutProgramm.FlatStyle = FlatStyle.Popup;
            aboutProgramm.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            aboutProgramm.Location = new Point(138, 182);
            aboutProgramm.Margin = new Padding(3, 2, 3, 2);
            aboutProgramm.Name = "aboutProgramm";
            aboutProgramm.Size = new Size(113, 22);
            aboutProgramm.TabIndex = 16;
            aboutProgramm.Text = "О программе";
            aboutProgramm.UseVisualStyleBackColor = false;
            aboutProgramm.Click += aboutProgramm_Click;
            // 
            // LoadScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(536, 238);
            Controls.Add(Title);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoadScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadScreen";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button close;
        private Label Title;
        private Label label2;
        private Label label1;
        private Button toCalculateBtn;
        private Label label3;
        private Label label4;
        private Button aboutProgramm;
    }
}