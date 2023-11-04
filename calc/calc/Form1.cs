using System.Linq.Expressions;

namespace calc
{
    public partial class Form1 : Form
    {
        private bool done_calculation;
        public Form1()
        {
            InitializeComponent();
            mainDisplay.Text = "abo khaled's ";
            done_calculation = true;
        }
        private void deleteAfterResult()
        {
            if (done_calculation)
            {
                mainDisplay.Text = "";
                done_calculation = false;
            }
        }

        private void Clear_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            mainDisplay.Text = "";
        }

        private void dot_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            mainDisplay.Text += '.';
        }

        private void equal_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                mainDisplay.Text += "=" + dt.Compute(mainDisplay.Text, string.Empty);
            }
            catch
            {
                mainDisplay.Text = "error try again";
            }
            done_calculation = true;
        }

        private void plus_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            mainDisplay.Text += '+';
        }

        private void delete_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            try
            {
                mainDisplay.Text = mainDisplay.Text.Substring(0, mainDisplay.Text.Length - 1);
            }
            catch (ArgumentOutOfRangeException) { }


        }

        private void power_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            mainDisplay.Text += '^';
        }

        private void nine_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            mainDisplay.Text += '9';
        }
        private void seven_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            mainDisplay.Text += '7';
        }
        private void eight_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            mainDisplay.Text += '8';

        }

        private void times_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            mainDisplay.Text += '*';
        }

        private void one_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            mainDisplay.Text += '1';
        }

        private void three_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            mainDisplay.Text += '3';
        }

        private void two_click(object sender, EventArgs e)
        {

            deleteAfterResult();
            mainDisplay.Text += '2';


        }

        private void five_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            mainDisplay.Text += '5';


        }
        private void six_click(object sender, EventArgs e)
        {

            deleteAfterResult();
            mainDisplay.Text += '6';
        }

        private void minus_click(object sender, EventArgs e)
        {

            deleteAfterResult();
            mainDisplay.Text += '-';
        }

        private void zero_click(object sender, EventArgs e)
        {
            deleteAfterResult();

            mainDisplay.Text += '0';
        }

        private void divided_click(object sender, EventArgs e)
        {
            deleteAfterResult();

            mainDisplay.Text += '/';
        }

        private void four_click(object sender, EventArgs e)
        {
            deleteAfterResult();

            mainDisplay.Text += '4';
        }
        private void plusMinus_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            mainDisplay.Text += "00";
        }
    }
}