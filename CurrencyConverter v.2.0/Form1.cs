using System;
using System.Windows.Forms;

namespace CurrencyConverter_v._2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Conv_Btn_Click(object sender, EventArgs e)
        {
            int i = int.Parse(amount_txt.Text);
            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Dollar")
            {
                int conver = i / 71;
                display_txt.Text = "Converted Amount: " + conver + "\t $";

            }
            if (fromcombo1.SelectedItem == "Rupees" && tocombo2.SelectedItem == "Euro")
            {
                int conver = i / 87;
                display_txt.Text = "Converted Amount: " + conver + "\t Euro";
            }

            if (fromcombo1.SelectedItem == "Dollar" && tocombo2.SelectedItem == "Euro")
            {
                double conver = i * 0.8208;
                display_txt.Text = "Converted Amount: " + conver + "\t Euro";
            }
            if (fromcombo1.SelectedItem == "Euro" && tocombo2.SelectedItem == "Dollar")
            {
                double conver = i * 1.2183;
                display_txt.Text = "Converted Amount: " + conver + "\t $"; ;
            }
            if (fromcombo1.SelectedItem == "Pound Sterling" && tocombo2.SelectedItem == "Dollar")
            {
                double conver = i * 1.4154;
                display_txt.Text = "Converted Amount: " + conver + "\t $";
            }
            if (fromcombo1.SelectedItem == "Dollar" && tocombo2.SelectedItem == "Pound Sterling")
            {
                double conver = i * 0.7065;
                display_txt.Text = "Converted Amount: " + conver + "\t GBP";
            }
        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            amount_txt.Text = "";
            fromcombo1.SelectedIndex = -1;
            tocombo2.SelectedIndex = -1;
            display_txt.Text = "";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Author of the Currency Converter app:  . \n Release date: 20.06.2021", " Attention!!!");
        }
    }
}
