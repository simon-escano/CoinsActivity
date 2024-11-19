namespace CoinsActivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pbImage.Image = Image.FromFile(dialog.FileName);
                }
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (pbImage.Image == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            pnResult.Enabled = true;
            showTotal(Coins.Count(new Bitmap(pbImage.Image), pbImage));
        }

        private void showTotal((int c5, int c10, int c25, int p1, int p5, int p10) denominations)
        {
            var (c5, c10, c25, p1, p5, p10) = denominations;
            tbC5.Text = c5.ToString();
            tbC10.Text = c10.ToString();
            tbC25.Text = c25.ToString();
            tbP1.Text = p1.ToString();
            tbP5.Text = p5.ToString();
            tbP10.Text = p10.ToString();

            tbTotal.Text = (c5 * 0.05 + c10 * 0.1 + c25 * 0.25 + p1 + p5 * 5 + p10 * 10).ToString();
        }
    }
}
