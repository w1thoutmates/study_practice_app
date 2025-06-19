namespace study_practice
{
    partial class MainForm
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
            panel1 = new Panel();
            button1 = new Button();
            backBtn = new Button();
            canvas = new PictureBox();
            btnShowChart = new Button();
            clearTbs = new Button();
            result = new Label();
            resultLabel = new Label();
            CalculateLabel = new Label();
            AnalysisBtn = new Button();
            MonteСarloBtn = new Button();
            tb_N = new TextBox();
            cb_direction = new ComboBox();
            tb_C = new TextBox();
            tb_y0 = new TextBox();
            tb_x0 = new TextBox();
            tb_R = new TextBox();
            close = new Button();
            Title = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(canvas);
            panel1.Controls.Add(btnShowChart);
            panel1.Controls.Add(clearTbs);
            panel1.Controls.Add(result);
            panel1.Controls.Add(resultLabel);
            panel1.Controls.Add(CalculateLabel);
            panel1.Controls.Add(AnalysisBtn);
            panel1.Controls.Add(MonteСarloBtn);
            panel1.Controls.Add(tb_N);
            panel1.Controls.Add(cb_direction);
            panel1.Controls.Add(tb_C);
            panel1.Controls.Add(tb_y0);
            panel1.Controls.Add(tb_x0);
            panel1.Controls.Add(tb_R);
            panel1.Location = new Point(1, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 390);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(564, 341);
            button1.Name = "button1";
            button1.Size = new Size(206, 29);
            button1.TabIndex = 13;
            button1.Text = "Открыть базу данных";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.GradientActiveCaption;
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            backBtn.Location = new Point(776, 341);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(112, 29);
            backBtn.TabIndex = 12;
            backBtn.Text = "Назад";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // canvas
            // 
            canvas.Location = new Point(564, 25);
            canvas.Name = "canvas";
            canvas.Size = new Size(324, 303);
            canvas.TabIndex = 11;
            canvas.TabStop = false;
            // 
            // btnShowChart
            // 
            btnShowChart.BackColor = SystemColors.GradientActiveCaption;
            btnShowChart.FlatStyle = FlatStyle.Popup;
            btnShowChart.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShowChart.Location = new Point(288, 299);
            btnShowChart.Name = "btnShowChart";
            btnShowChart.Size = new Size(220, 29);
            btnShowChart.TabIndex = 9;
            btnShowChart.Text = "Анализ результатов\r\n";
            btnShowChart.UseVisualStyleBackColor = false;
            btnShowChart.Click += btnShowChart_Click;
            // 
            // clearTbs
            // 
            clearTbs.BackColor = SystemColors.GradientActiveCaption;
            clearTbs.FlatStyle = FlatStyle.Popup;
            clearTbs.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearTbs.Location = new Point(12, 299);
            clearTbs.Name = "clearTbs";
            clearTbs.Size = new Size(220, 29);
            clearTbs.TabIndex = 8;
            clearTbs.Text = "Очистить";
            clearTbs.UseVisualStyleBackColor = false;
            clearTbs.Click += clearTbs_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            result.Location = new Point(288, 242);
            result.Name = "result";
            result.Size = new Size(0, 18);
            result.TabIndex = 10;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultLabel.Location = new Point(288, 213);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(101, 18);
            resultLabel.TabIndex = 9;
            resultLabel.Text = "Результат:";
            // 
            // CalculateLabel
            // 
            CalculateLabel.AutoSize = true;
            CalculateLabel.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CalculateLabel.Location = new Point(288, 30);
            CalculateLabel.Name = "CalculateLabel";
            CalculateLabel.Size = new Size(168, 18);
            CalculateLabel.TabIndex = 8;
            CalculateLabel.Text = "Расчитать методом";
            // 
            // AnalysisBtn
            // 
            AnalysisBtn.BackColor = SystemColors.GradientActiveCaption;
            AnalysisBtn.FlatStyle = FlatStyle.Popup;
            AnalysisBtn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AnalysisBtn.Location = new Point(288, 112);
            AnalysisBtn.Name = "AnalysisBtn";
            AnalysisBtn.Size = new Size(220, 29);
            AnalysisBtn.TabIndex = 7;
            AnalysisBtn.Text = "Аналитическим";
            AnalysisBtn.UseVisualStyleBackColor = false;
            AnalysisBtn.Click += Calculate_Analysis_Method;
            // 
            // MonteСarloBtn
            // 
            MonteСarloBtn.BackColor = SystemColors.GradientActiveCaption;
            MonteСarloBtn.FlatStyle = FlatStyle.Popup;
            MonteСarloBtn.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MonteСarloBtn.ForeColor = SystemColors.ControlText;
            MonteСarloBtn.Location = new Point(288, 67);
            MonteСarloBtn.Name = "MonteСarloBtn";
            MonteСarloBtn.Size = new Size(220, 29);
            MonteСarloBtn.TabIndex = 6;
            MonteСarloBtn.Text = "Монте-Карло";
            MonteСarloBtn.UseVisualStyleBackColor = false;
            MonteСarloBtn.Click += Calculate_MonteCarlo_Method;
            // 
            // tb_N
            // 
            tb_N.BackColor = SystemColors.GradientActiveCaption;
            tb_N.BorderStyle = BorderStyle.None;
            tb_N.Font = new Font("Verdana", 9F);
            tb_N.Location = new Point(12, 264);
            tb_N.Name = "tb_N";
            tb_N.PlaceholderText = "Введите количество точек (N)";
            tb_N.Size = new Size(220, 19);
            tb_N.TabIndex = 5;
            // 
            // cb_direction
            // 
            cb_direction.BackColor = SystemColors.GradientActiveCaption;
            cb_direction.FlatStyle = FlatStyle.Popup;
            cb_direction.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cb_direction.ForeColor = SystemColors.ControlDarkDark;
            cb_direction.FormattingEnabled = true;
            cb_direction.Items.AddRange(new object[] { "Горизонтальная", "Вертикальная" });
            cb_direction.Location = new Point(12, 213);
            cb_direction.Name = "cb_direction";
            cb_direction.Size = new Size(220, 26);
            cb_direction.TabIndex = 4;
            cb_direction.Text = "Выберите вид";
            // 
            // tb_C
            // 
            tb_C.BackColor = SystemColors.GradientActiveCaption;
            tb_C.BorderStyle = BorderStyle.None;
            tb_C.Font = new Font("Verdana", 9F);
            tb_C.Location = new Point(12, 170);
            tb_C.Name = "tb_C";
            tb_C.PlaceholderText = "Введите координаты секущей (C)";
            tb_C.Size = new Size(220, 19);
            tb_C.TabIndex = 3;
            // 
            // tb_y0
            // 
            tb_y0.BackColor = SystemColors.GradientActiveCaption;
            tb_y0.BorderStyle = BorderStyle.None;
            tb_y0.Font = new Font("Verdana", 9F);
            tb_y0.Location = new Point(12, 75);
            tb_y0.Name = "tb_y0";
            tb_y0.PlaceholderText = "Введите у0";
            tb_y0.Size = new Size(220, 19);
            tb_y0.TabIndex = 1;
            // 
            // tb_x0
            // 
            tb_x0.BackColor = SystemColors.GradientActiveCaption;
            tb_x0.BorderStyle = BorderStyle.None;
            tb_x0.Font = new Font("Verdana", 9F);
            tb_x0.Location = new Point(12, 30);
            tb_x0.Name = "tb_x0";
            tb_x0.PlaceholderText = "Введите х0";
            tb_x0.Size = new Size(220, 19);
            tb_x0.TabIndex = 0;
            // 
            // tb_R
            // 
            tb_R.BackColor = SystemColors.GradientActiveCaption;
            tb_R.BorderStyle = BorderStyle.None;
            tb_R.Font = new Font("Verdana", 9F);
            tb_R.Location = new Point(12, 124);
            tb_R.Name = "tb_R";
            tb_R.PlaceholderText = "Введите радиус (R)";
            tb_R.Size = new Size(220, 19);
            tb_R.TabIndex = 2;
            // 
            // close
            // 
            close.BackColor = Color.Indigo;
            close.Cursor = Cursors.Hand;
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;
            close.Location = new Point(876, 0);
            close.Name = "close";
            close.Size = new Size(39, 33);
            close.TabIndex = 1;
            close.TabStop = false;
            close.Text = "X";
            close.UseVisualStyleBackColor = false;
            close.Click += Close_click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Title.Location = new Point(0, 8);
            Title.Name = "Title";
            Title.Size = new Size(139, 18);
            Title.TabIndex = 2;
            Title.Text = "Главная форма";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(915, 416);
            Controls.Add(Title);
            Controls.Add(close);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button close;
        private Label Title;
        private TextBox tb_C;
        private TextBox tb_y0;
        private TextBox tb_x0;
        private TextBox tb_R;
        private ComboBox cb_direction;
        private Button AnalysisBtn;
        private Button MonteСarloBtn;
        private TextBox tb_N;
        private Label CalculateLabel;
        private Label result;
        private Label resultLabel;
        private Button clearTbs;
        private Button btnShowChart;
        private PictureBox canvas;
        private Button backBtn;
        private Button button1;
    }
}
