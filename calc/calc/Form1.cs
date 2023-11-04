using System.Linq.Expressions;

namespace calc
{
    public partial class Form1 : Form
    {
        private bool autoClear;
        public Form1()
        {
            InitializeComponent();
            displayCalc.Text = "abo khaled's ";
            autoClear = true;
        }
        private void deleteAfterResult()
        {
            if (autoClear)
            {
                displayCalc.Text = "";
                autoClear = false;
            }
        }

        private void Clear_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            displayCalc.Text = "";
        }

        private void dot_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            displayCalc.Text += '.';
        }

        private void equal_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                displayCalc.Text += "=" + dt.Compute(displayCalc.Text, string.Empty);
            }
            catch
            {
                displayCalc.Text = "error try again";
            }
            autoClear = true;
        }

        private void plus_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            displayCalc.Text += '+';
        }

        private void delete_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            try
            {
                displayCalc.Text = displayCalc.Text.Substring(0, displayCalc.Text.Length - 1);
            }
            catch (ArgumentOutOfRangeException) { }


        }

        private void power_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            displayCalc.Text += '^';
        }

        private void nine_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            displayCalc.Text += '9';
        }
        private void seven_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            displayCalc.Text += '7';
        }
        private void eight_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            displayCalc.Text += '8';

        }

        private void times_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            displayCalc.Text += '*';
        }

        private void one_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            displayCalc.Text += '1';
        }

        private void three_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            displayCalc.Text += '3';
        }

        private void two_click(object sender, EventArgs e)
        {

            deleteAfterResult();
            displayCalc.Text += '2';


        }

        private void five_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            displayCalc.Text += '5';


        }
        private void six_click(object sender, EventArgs e)
        {

            deleteAfterResult();
            displayCalc.Text += '6';
        }

        private void minus_click(object sender, EventArgs e)
        {

            deleteAfterResult();
            displayCalc.Text += '-';
        }

        private void zero_click(object sender, EventArgs e)
        {
            deleteAfterResult();

            displayCalc.Text += '0';
        }

        private void divided_click(object sender, EventArgs e)
        {
            deleteAfterResult();

            displayCalc.Text += '/';
        }

        private void four_click(object sender, EventArgs e)
        {
            deleteAfterResult();

            displayCalc.Text += '4';
        }
        private void plusMinus_click(object sender, EventArgs e)
        {
            deleteAfterResult();
            displayCalc.Text += "00";
        }
    }
}