using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongPairing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //double width = double.Parse(txtWidth.Text);
            //double length = double.Parse(txtLength.Text);
            //Rectangle testRect = new Rectangle(length, width);
            //double area = testRect.getArea();
            //double perimeter = testRect.getPerimeter();

            //MessageBox.Show("Area: " + area.ToString() + "\nPerimeter: " + perimeter.ToString());


            //double radius = double.Parse(txtRadius.Text);
            //Circle testCircle = new Circle(radius);
            //double crcarea = testCircle.getArea();
            //double crcperimeter = testCircle.getPerimeter();

            //MessageBox.Show("Area: " + crcarea.ToString() + "\nPerimeter: " + crcperimeter.ToString());

            //int number = int.Parse(txtNumber.Text);
            //FizzBuzz testFizz = new FizzBuzz();

            //MessageBox.Show(testFizz.Answer(number));


            //string lastName = txtLastName.Text;
            //Random rand = new Random();
            //TeaParty testTea = new TeaParty();
            //int random = (rand.Next(0, 3));
            //if (random == 0)
            //{
            //    string msg = testTea.welcome(lastName, true, false);
            //    MessageBox.Show("Hello " + msg + ".");
            //}
            //else if(random == 1)
            //{
            //    string msg = testTea.welcome(lastName, false, true);
            //    MessageBox.Show("Hello " + msg + ".");
            //}
            //else
            //{
            //    string msg = testTea.welcome(lastName, false, false);
            //    MessageBox.Show("Hello " + msg + ".");
            //}


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
