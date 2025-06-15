namespace study_practice
{
    partial class DataTableForm
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
            clearHistory = new Button();
            backBtn = new Button();
            dgv1 = new DataGridView();
            close = new Button();
            Title = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(clearHistory);
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(dgv1);
            panel1.Location = new Point(-2, 23);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 316);
            panel1.TabIndex = 0;
            // 
            // clearHistory
            // 
            clearHistory.BackColor = SystemColors.GradientActiveCaption;
            clearHistory.FlatStyle = FlatStyle.Popup;
            clearHistory.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearHistory.Location = new Point(6, 288);
            clearHistory.Margin = new Padding(3, 2, 3, 2);
            clearHistory.Name = "clearHistory";
            clearHistory.Size = new Size(155, 22);
            clearHistory.TabIndex = 14;
            clearHistory.Text = "Очистить историю";
            clearHistory.UseVisualStyleBackColor = false;
            clearHistory.Click += clearHistory_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.GradientActiveCaption;
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backBtn.Location = new Point(831, 288);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(98, 22);
            backBtn.TabIndex = 13;
            backBtn.Text = "Назад";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // dgv1
            // 
            dgv1.BackgroundColor = Color.SlateBlue;
            dgv1.ColumnHeadersHeight = 29;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv1.Location = new Point(6, 4);
            dgv1.Margin = new Padding(3, 2, 3, 2);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.RowHeadersWidth = 51;
            dgv1.Size = new Size(923, 280);
            dgv1.TabIndex = 1;
            // 
            // close
            // 
            close.BackColor = Color.Indigo;
            close.Cursor = Cursors.Hand;
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;
            close.Location = new Point(899, -2);
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
            Title.Location = new Point(0, 4);
            Title.Name = "Title";
            Title.Size = new Size(95, 14);
            Title.TabIndex = 3;
            Title.Text = "База данных";
            // 
            // DataTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(933, 338);
            Controls.Add(Title);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "DataTableForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DataTableForm";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv1;
        private Button close;
        private Button backBtn;
        private Label Title;
        private Button clearHistory;
    }
}