using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static void Prepis(TextBox textbox, ListBox listbox)
        {
            for(int i = 0; i<textbox.Lines.Count();i++)
            {
                int x = int.Parse(textbox.Lines[i].ToString());
                listbox.Items.Add(x);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Form1.Prepis(textBox1, listBox1);
            Random rnd = new Random();
            int n = int.Parse(textBox2.Text);
            for(int i = 0; i <n;i++)
            {
                int x = rnd.Next(2, 16);
                textBox3.Text += x.ToString()+"\r\n";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
