using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        public UserControl1 f1; //创建用户控件一变量
        public UserControl2 f2; //创建用户控件二变量
        public UserControl3 f3; //创建用户控件三变量
        public UserControl4 f4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f1 = new UserControl1();    //实例化f1
            f2 = new UserControl2();    //实例化f2
            f3 = new UserControl3();    //实例化f3
            f4 = new UserControl4();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                f1.Show();   //将窗体一进行显示
                panel2.Controls.Clear();    //清空原容器上的控件
                panel2.Controls.Add(f1);    //将窗体一加入容器panel2
            }
            else if (radioButton2.Checked)
            {
                f2.Show();   //将窗体二进行显示
                panel2.Controls.Clear();    //清空原容器上的控件
                panel2.Controls.Add(f2);    //将窗体二加入容器panel2
            }
            else if (radioButton3.Checked)
            {
                f3.Show();   //将窗体三进行显示
                panel2.Controls.Clear();    //清空原容器上的控件
                panel2.Controls.Add(f3);    //将窗体三加入容器panel2
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f4.Show();   //将窗体三进行显示
            panel2.Controls.Clear();    //清空原容器上的控件
            panel2.Controls.Add(f4);    //将窗体三加入容器panel2
        }
    }
}
