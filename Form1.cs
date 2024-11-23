using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CoinsActivity
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png;" };
            if (dialog.ShowDialog() == DialogResult.OK)
                pbImage.Image = Image.FromFile(dialog.FileName);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (pbImage.Image == null) { MessageBox.Show("Please select an image first."); return; }
            pnResult.Enabled = true;

            var coins = new Coins(
                new("c5", 0.05f), new("c10", 0.1f), new("c25", 0.25f),
                new("p1", 1f), new("p5", 5f), new("p10", 10f)
            );

            int denomination = 0;
            var circles = Circles.Detect(pbImage).OrderBy(c => c.Radius).ToList();

            for (int i = 0; i < circles.Count; i++)
            {
                if (i > 0 && Math.Abs(circles[i].Radius - circles[i - 1].Radius) >= 0.8)
                    denomination++;
                coins[denomination].count++;
            }

            showTotal(coins);
        }

        private void showTotal(Coins coins)
        {
            tbC5.Text = coins["c5"].count.ToString();
            tbC10.Text = coins["c10"].count.ToString();
            tbC25.Text = coins["c25"].count.ToString();
            tbP1.Text = coins["p1"].count.ToString();
            tbP5.Text = coins["p5"].count.ToString();
            tbP10.Text = coins["p10"].count.ToString();
            tbTotal.Text = coins.GetTotal().ToString();
        }
    }

    public class Coins : List<Coin>
    {
        public Coins(params Coin[] coins) : base(coins) { }
        public Coin this[string denomination] => this.FirstOrDefault(c => c.Denomination == denomination) ?? new(denomination, 0);
        public float GetTotal() => this.Sum(c => c.Total);
    }

    public class Coin
    {
        public string Denomination { get; }
        public float Amount { get; }
        public int count;

        public Coin(string denomination, float amount) => (Denomination, Amount) = (denomination, amount);
        public float Total => Amount * count;
    }
}
