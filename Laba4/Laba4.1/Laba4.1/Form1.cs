using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<double> collection = new List<double>() { };

        private void generation_Click(object sender, EventArgs e)
        {
            collection.Add(Convert.ToDouble(textBox1.Text));
            foreach(double item in collection)
            {
                Console.WriteLine(item);
            }
        }

        private void sortup_Click(object sender, EventArgs e)
        {

        }

        private void sortdown_Click(object sender, EventArgs e)
        {

        }

        private void request1_Click(object sender, EventArgs e)
        {

        }

        private void request2_Click(object sender, EventArgs e)
        {

        }

        private void request3_Click(object sender, EventArgs e)
        {

        }
    }
}
