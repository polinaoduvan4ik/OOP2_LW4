using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4
{
    
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValid(textBox1.Text) || !IsValid(textBox2.Text) || !IsValid(textBox3.Text))
            {
                MessageBox.Show("You wrote nothing. Please, write your message.");
            }

            else 
            label1.Text = replace(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!IsValid(textBox1.Text) || !IsValid(textBox2.Text))
            {
                MessageBox.Show("You wrote nothing. Please, write your message.");
            }
            else
            label1.Text = delete(textBox1.Text, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!IsValid(textBox1.Text))
            {
                MessageBox.Show("You wrote nothing. Please, write your message.");
            }
            else
            label1.Text = "The length of the string: " + Convert.ToString(length(textBox1.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!IsValid(textBox1.Text))
            {
                MessageBox.Show("You wrote nothing. Please, write your message.");
            }
            else
            label1.Text = "The count of the vowels in the string: " + Convert.ToString(vowels(textBox1.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!IsValid(textBox1.Text))
            {
                MessageBox.Show("You wrote nothing. Please, write your message.");
            }
            else
            label1.Text = "The count of the consonants in the string: " + Convert.ToString(consonants(textBox1.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!IsValid(textBox1.Text))
            {
                MessageBox.Show("You wrote nothing. Please, write your message.");
            }
            else
            label1.Text = "The count of the words in the string: " + Convert.ToString(words(textBox1.Text));
        }

        public static string replace(string a, string b, string c)
        {
            return a.Replace(b, c);
        }

        public static string delete(string a, string b)
        {
            return a.Replace(b, " ");
        }

        public static int length(string a)
        {
            return a.Length;
        }

        public static int vowels(string a)
        {
            char[] str = a.ToCharArray();
            char[] vowels = { 'a', 'e', 'y', 'u', 'o', 'i', 'A', 'E', 'Y', 'U', 'O', 'I' };

            int count = 0;
            foreach (char vowel in str)
            {
                if (vowels.Contains(vowel))
                    count++;
                return count;
            }
            return count;
        }

        public static int consonants(string a)
        {
            char[] str = a.ToCharArray();
            char[] consonants = { 'q', 'w', 'r', 't', 'p', 's', 'd', 'f', 'g', 'h', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm',
            'Q', 'W', 'R', 'T', 'P', 'S', 'D', 'F', 'G', 'H', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M'};

            int count = 0;
            foreach (char consonant in str)
            {
                if (consonants.Contains(consonant))
                    count++;
                return count;
            }
            return count;
        }

        public static int words(string a)
        {
            a = a.Trim(new char[] { ',', '.' }); //удаление точен и запятых
            string[] aArray = a.Split(new char[] { ' ' }); //разбиваем текст на слова (в массив строк)

            return aArray.Length;
        }


        public static bool IsValid(string str)
        {
            try
            {
                if (String.IsNullOrEmpty(str))
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;

        }
    }
   
}

