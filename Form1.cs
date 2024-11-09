namespace BarGraphFinalAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void DrawPieChart(List<int> data)
        {
            Graphics g = panelChart.CreateGraphics();
            g.Clear(Color.White);
            int total = data.Sum();

            int chartWidth = panelChart.Width;
            int chartHeight = panelChart.Height;

            int diameter = Math.Min(chartWidth, chartHeight) - 100;
            Rectangle pieArea = new Rectangle(50, 50, diameter, diameter);

            float startAngle = 0;
            Random rand = new Random(); // For generating random colors

            // Draw the pie chart slices
            for (int i = 0; i < data.Count; i++)
            {
                float sweepAngle = (data[i] / (float)total) * 360f;

                // Generate a random color for each slice
                Brush brush = new SolidBrush(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));//source: google for generating random color func

                g.FillPie(brush, pieArea, startAngle, sweepAngle);

                startAngle += sweepAngle;
            }

            int legendX = chartWidth - 150;
            int legendY = 50;
            for (int i = 0; i < data.Count; i++)
            {
                Brush legendBrush = new SolidBrush(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                g.FillRectangle(legendBrush, legendX, legendY + (i * 30), 20, 20);
                g.DrawString($"Slice {i + 1}: {data[i]}", this.Font, Brushes.Black, legendX + 25, legendY + (i * 30));
            }
        }

        private List<int> ParseInputData(string input)
        {
            var numbers = input.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> result = new List<int>();

            foreach (var item in numbers)
            {
                if (int.TryParse(item, out int value))
                {
                    result.Add(value);
                }
                else
                {
                    MessageBox.Show($"'{item}' is not a number. Please enter only numbers.");
                    return new List<int>();
                }
            }

            return result;
        }

        private void btnDrawChart_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<int> data = ParseInputData(input);
            if (data.Count == 0)
            {
                return;
            }

            DrawPieChart(data);
        }
    }
}
