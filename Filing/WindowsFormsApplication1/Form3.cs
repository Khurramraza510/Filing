﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.label1.Text = "file location";
            this.label2.Text = "file name";
            this.button1.Text = "write";
            this.button2.Text = "file write";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text + textBox2.Text;
            StreamWriter sw = new StreamWriter(fname);
            sw.Write(this.textBox3.Text);
            MessageBox.Show("file has written");
            sw.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Byte[] bb = new Byte[100];
            Char[] cc = new char[100];
            string fname = textBox1.Text + textBox2.Text;
            FileStream fs = new FileStream(fname, FileMode.OpenOrCreate);
            cc = textBox3.Text.ToCharArray();
            Encoder en = Encoding.UTF8.GetEncoder();
            en.GetBytes(cc, 0, cc.Length, bb, 0, true);
            fs.Write(bb,0,bb.Length);
            MessageBox.Show("file has written");

        }
    }
}
