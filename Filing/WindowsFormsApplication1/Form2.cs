using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = "file location";
            this.label2.Text = "file name";
            this.button1.Text = "read";
            this.button2.Text = "file read";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text + textBox2.Text;
            StreamReader sw = new StreamReader(fname);
            this.textBox3.Text = sw.ReadToEnd();
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Byte[] bb = new Byte[100];
            Char[] cc = new Char[100];
            string fname = textBox1.Text+textBox2.Text;
            FileStream fs = new FileStream(fname, FileMode.Open);
            fs.Read(bb,0,100);
            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(bb,0,bb.Length,cc,0);
            foreach (char c in cc)
            {
                this.textBox3.Text += c;
            }

        }
    }
}
