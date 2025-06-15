using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;

namespace study_practice
{
    public partial class MainForm : Form
    {
        private AnalysisForm _analysisForm;
        private LoadScreen f;
        private DatabaseService _dbService = new DatabaseService();


        public MainForm()
        {
            InitializeComponent();
        }

        public void Calculate_MonteCarlo_Method(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tb_x0.Text) || string.IsNullOrWhiteSpace(tb_y0.Text) ||
                    string.IsNullOrWhiteSpace(tb_R.Text) || string.IsNullOrWhiteSpace(tb_C.Text) ||
                    string.IsNullOrWhiteSpace(tb_N.Text) || cb_direction.Text == "Выберите вид")
                {
                    MessageBox.Show("Заполните все поля");
                    return;
                }

                double x0 = double.Parse(tb_x0.Text);
                double y0 = double.Parse(tb_y0.Text);
                double R = double.Parse(tb_R.Text);
                double C = double.Parse(tb_C.Text);
                int N = int.Parse(tb_N.Text);

                if (R <= 0 || N <= 0)
                {
                    MessageBox.Show("Радиус и количество точек должны быть положительными");
                    return;
                }

                Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);
                Graphics g = Graphics.FromImage(bmp);
                float scale = Math.Min(canvas.Width / (4 * (float)R), canvas.Height / (4 * (float)R));

                DrawCoordinateSystem(g, bmp.Width, bmp.Height, 0, 0, scale);

                // Рисуем окружность
                PointF circleCenter = LogicalToScreen(x0, y0, scale);
                float radiusPx = (float)R * scale;
                g.DrawEllipse(new Pen(Color.Blue, 2), circleCenter.X - radiusPx, circleCenter.Y - radiusPx, radiusPx * 2, radiusPx * 2);

                if (cb_direction.Text == "Горизонтальная")
                {
                    float screenY = LogicalToScreen(0, C, scale).Y;
                    g.DrawLine(new Pen(Color.Green, 2), new PointF(0, screenY), new PointF(bmp.Width, screenY));
                }
                else
                {
                    float screenX = LogicalToScreen(C, 0, scale).X;
                    g.DrawLine(new Pen(Color.Green, 2), new PointF(screenX, 0), new PointF(screenX, bmp.Height));
                }

                int insideCircle = 0;
                int insideSegment = 0;
                Random random = new Random();

                for (int i = 0; i < N; i++)
                {
                    double x = random.NextDouble() * (2 * R) + (x0 - R);
                    double y = random.NextDouble() * (2 * R) + (y0 - R);

                    double dx = x - x0;
                    double dy = y - y0;
                    double dist = dx * dx + dy * dy;

                    if (dist <= R * R)
                    {
                        insideCircle++;

                        bool inSegment;

                        if (cb_direction.Text == "Горизонтальная")
                            inSegment = y0 < C ? y < C : y > C;
                        else
                            inSegment = x0 < C ? x < C : x > C;

                        if (inSegment) insideSegment++;

                        PointF screenPt = LogicalToScreen(x, y, scale);
                        g.FillEllipse(inSegment ? Brushes.Purple : Brushes.Red,
                                        screenPt.X - 2, screenPt.Y - 2, 4, 4);
                    }
                }

                double segmentArea = (insideSegment / (double)insideCircle) * (Math.PI * R * R);
                result.Text = $"Площадь: {segmentArea.ToString("F4")}\nметод: Монте-Карло";
                canvas.Image = bmp;

                _dbService.InsertResult(x0, y0, C, R, cb_direction.Text, segmentArea, "Монте-Карло");

            }
            catch (FormatException)
            {
                MessageBox.Show("Вводите только числа");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }


        public void Calculate_Analysis_Method(object sender, EventArgs args)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tb_x0.Text) || string.IsNullOrWhiteSpace(tb_y0.Text) ||
                    string.IsNullOrWhiteSpace(tb_R.Text) || string.IsNullOrWhiteSpace(tb_C.Text) ||
                    string.IsNullOrWhiteSpace(cb_direction.Text) || cb_direction.Text == "Выберите вид")
                {
                    MessageBox.Show("Поля не могут быть пустыми");
                    return;
                }

                double x0 = double.Parse(tb_x0.Text);
                double y0 = double.Parse(tb_y0.Text);
                double R = double.Parse(tb_R.Text);
                double C = double.Parse(tb_C.Text);

                if (R <= 0)
                {
                    MessageBox.Show("Радиус должен быть положительным числом.");
                    return;
                }

                Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);
                Graphics g = Graphics.FromImage(bmp);

                float scale = Math.Min(
                    canvas.Width / (4 * (float)R),
                    canvas.Height / (4 * (float)R)
                );
                // scale = Math.Max(10, Math.Min(100, scale));

                DrawCoordinateSystem(g, bmp.Width, bmp.Height, 0, 0, scale);

                float centerX = bmp.Width / 2;
                float centerY = bmp.Height / 2;

                float radiusPx = (float)R * scale;

                Pen circlePen = new Pen(Color.Blue, 2);
                PointF circleCenter = LogicalToScreen(x0, y0, scale);
                g.DrawEllipse(circlePen, circleCenter.X - radiusPx, circleCenter.Y - radiusPx, radiusPx * 2, radiusPx * 2);

                Pen secantPen = new Pen(Color.Green, 2);
                if (cb_direction.Text == "Горизонтальная")
                {
                    float screenY = LogicalToScreen(0, C, scale).Y;
                    PointF p1 = new PointF(0, screenY);
                    PointF p2 = new PointF(bmp.Width, screenY);
                    g.DrawLine(secantPen, p1, p2);
                }
                else
                {
                    float screenX = LogicalToScreen(C, 0, scale).X;
                    PointF p1 = new PointF(screenX, 0);
                    PointF p2 = new PointF(screenX, bmp.Height);
                    g.DrawLine(secantPen, p1, p2);
                }

                double d;
                if (cb_direction.Text == "Горизонтальная")
                {
                    d = Math.Abs(C - y0);
                }
                else
                {
                    d = Math.Abs(C - x0);
                }

                if (d >= R)
                {
                    MessageBox.Show("Секущая не пересекает окружность. Площадь сегмента равна 0.");
                    result.Text = $"Площадь: 0.0000\nметод: Аналитический";
                    return;
                }

                canvas.Image = bmp;

                double smallSegmentArea = (R * R) * Math.Acos(d / R) - d * Math.Sqrt(R * R - d * d);

                double largeSegmentArea = Math.PI * R * R - smallSegmentArea;

                string resultString = $"Площадь: {largeSegmentArea.ToString("F4")}\nметод: Аналитический";
                result.Text = resultString;
                _dbService.InsertResult(x0, y0, C, R, cb_direction.Text, largeSegmentArea, "Аналитический");
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, вводите только числовые значения.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        public void Close_click(object sender, EventArgs args)
        {
            Close();
        }

        private void clearTbs_Click(object sender, EventArgs e)
        {
            tb_x0.Text = "";
            tb_y0.Text = "";
            tb_R.Text = "";
            tb_C.Text = "";
            cb_direction.Text = "Выберите вид";
            result.Text = "";
            tb_N.Text = "";
            InstantiateClearCoordinateSystem();
        }

        private PointF LogicalToScreen(double x, double y, float scale)
        {
            float screenCenterX = canvas.Width / 2;
            float screenCenterY = canvas.Height / 2;

            return new PointF(
                screenCenterX + (float)(x * scale),
                screenCenterY - (float)(y * scale)
            );
        }


        private void DrawCoordinateSystem(Graphics g, int width, int height, float logicalCenterX, float logicalCenterY, float scale)
        {
            g.Clear(Color.White);

            Pen axisPen = new Pen(Color.Black, 2);
            Pen gridPen = new Pen(Color.LightGray, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            Font font = new Font("Arial", 8);
            Brush brush = Brushes.Black;

            float screenCenterX = width / 2;
            float screenCenterY = height / 2;

            float offsetX = screenCenterX - logicalCenterX * scale;
            float offsetY = screenCenterY + logicalCenterY * scale;

            g.DrawLine(axisPen, 0, offsetY, width, offsetY);
            g.DrawLine(axisPen, offsetX, 0, offsetX, height);

            g.DrawLine(axisPen, width - 10, offsetY - 5, width, offsetY);
            g.DrawLine(axisPen, width - 10, offsetY + 5, width, offsetY);
            g.DrawLine(axisPen, offsetX - 5, 10, offsetX, 0);
            g.DrawLine(axisPen, offsetX + 5, 10, offsetX, 0);

            g.DrawString("X", font, brush, width - 15, offsetY - 20);
            g.DrawString("Y", font, brush, offsetX + 10, 5);

            for (int x = (int)((-screenCenterX - logicalCenterX) / scale); x <= (width - screenCenterX - logicalCenterX) / scale; x++)
            {
                float px = offsetX + x * scale;
                g.DrawLine(gridPen, px, 0, px, height);
                if (x != 0 && Math.Abs(x) <= 10)
                    g.DrawString(x.ToString(), font, brush, px - 10, offsetY + 5);
            }

            for (int y = (int)((screenCenterY + logicalCenterY) / scale); y >= (-height + screenCenterY + logicalCenterY) / scale; y--)
            {
                float py = offsetY - y * scale;
                g.DrawLine(gridPen, 0, py, width, py);
                if (y != 0 && Math.Abs(y) <= 10)
                    g.DrawString(y.ToString(), font, brush, offsetX + 5, py - 8);
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            InstantiateClearCoordinateSystem();
        }

        private void InstantiateClearCoordinateSystem()
        {
            Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);
            Graphics g = Graphics.FromImage(bmp);

            float scale = 40;

            DrawCoordinateSystem(g, bmp.Width, bmp.Height, 0, 0, scale);

            canvas.Image = bmp;
        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            var analysisForm = new AnalysisForm();
            analysisForm.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (f == null || f.IsDisposed)
            {
                f = new LoadScreen();
            }

            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultsForm = new DataTableForm();
            resultsForm.ShowDialog();
        }
    }
}
