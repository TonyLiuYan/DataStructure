using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqQueue
{
    public partial class Form1 : Form
    {
        SqQueueClass qu=new SqQueueClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x;
            x = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(x))
            {
                infolabel.Text = "必须输入进队的元素";
            }
            else
            {
                if (qu.enQueue(x))
                {
                    Display();
                    infolabel.Text = "元素进队成功";
                }
                else
                {
                    infolabel.Text = "队满不能进队";
                }
            }
        }

        private void Display()
        {
            string str;
            str = qu.DispQueue();
            queueBox.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = string.Empty;
            if (qu.deQueue(ref x))
            {
                textBox2.Text = x;
                Display();
                infolabel.Text = "元素出队成功";
            }
            else
            {
                infolabel.Text = "对空不能出队";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            queueBox.Text = "空队";
        }
    }
}
