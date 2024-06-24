using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        string allValue = "";
        string symbol = "";
        string previousViewsNumbers = "";
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public Form1()
        {
            InitializeComponent();

            timer.Tick += new EventHandler(timer1_Tick); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = (1000) * (1);              // Timer will tick evert second
            timer.Enabled = true;                       // Enable the timer
            timer.Start();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void chooseColor()
        {

            Random rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(250), rnd.Next(250), rnd.Next(250));
            this.BackColor = randomColor;
            // Create new stopwatch
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chooseColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            allValue = allValue + textBox1.Text;
          
            
            symbol = "+";

            previousViewsNumbers = previousViewsNumbers + textBox1.Text + symbol;
            textBox2.Text = previousViewsNumbers;
            textBox1.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            //int numberDefault = int.Parse(textBox1.Text.ToString());
            //numberDefault = numberDefault + 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try {
                if (symbol.Equals("+")) {

                    double txt = double.Parse(allValue) + double.Parse(textBox1.Text);
                    textBox1.Text = txt.ToString();
                    allValue = "";
                }
                if (symbol.Equals("-"))
                {

                    double txt = double.Parse(allValue) - double.Parse(textBox1.Text);
                    textBox1.Text = txt.ToString();
                    allValue = "";
                }
                if (symbol.Equals("/"))
                {

                    double txt = double.Parse(allValue) / double.Parse(textBox1.Text);
                    textBox1.Text = txt.ToString();
                    allValue = "";
                }
                if (symbol.Equals("*"))
                {

                    double txt = double.Parse(allValue) * double.Parse(textBox1.Text);
                    textBox1.Text = txt.ToString();
                    allValue = "";
                }
            }
            catch (Exception es) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            allValue = allValue + textBox1.Text;
           
            symbol = "-";
            previousViewsNumbers = previousViewsNumbers + textBox1.Text + symbol;
            textBox2.Text = previousViewsNumbers;
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             allValue = allValue + textBox1.Text;
         
            symbol = "/";
            previousViewsNumbers = previousViewsNumbers + textBox1.Text + symbol;
            textBox2.Text = previousViewsNumbers;
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            allValue = allValue + textBox1.Text;
           
            symbol = "*";
            previousViewsNumbers = previousViewsNumbers + textBox1.Text + symbol;
            textBox2.Text = previousViewsNumbers;
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            symbol = "";
            previousViewsNumbers = "";
            allValue = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
