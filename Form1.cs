namespace Hasan.Badr.harjoitus9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuunnatBT_Click(object sender, EventArgs e)
        {
            double Vastaus;
            double asteet = Convert.ToDouble(AsteetTB.Text);
            if (CelsiusRB.Checked)
            {
                Vastaus = asteet * 1.8 + 32;
                VastausLB.Text = asteet + " Fehrenheitia on " + Vastaus + " Celsius astetta ";
            }
            else if (FahrenheitRB.Checked)
            {
                Vastaus = (asteet - 32) / 1.8;
                VastausLB.Text = asteet + " Celciusta on " + Vastaus + " Fahrenheit astetta ";
            }
            else
            {
                VastausLB.Text = " ET valinnut muunnettavaa astetta tai antanut oikeaa lukua ";
                VastausLB.Visible = true;
            }
        }
    }
}