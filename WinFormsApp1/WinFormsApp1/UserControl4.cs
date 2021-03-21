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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Random ra = new Random();
            int[] a=new int[10]; 
            for (int i = 0; i < 10; i++)
            {
                a[i] = ra.Next(0, 3);

            }
            Rectangle[] rect = new Rectangle[10];
            Square[] sq = new Square[10];
            Triangle[] tr = new Triangle[10];
            int x, y, z;
            x = y = z = 0;
            for(int i = 0; i < 10; i++)
            {
                int c = a[i];
                switch (c)
                {
                    case 0:
                        double l = ra.Next(1, 20);
                        double w = ra.Next(1, 20);
                        rect[x] =new Rectangle(l, w);
                        x++;
                        break;
                    case 1:
                        double m = ra.Next(1, 20);
                        sq[y] = new Square(m);
                        y++;
                        break;
                    case 2:
                        int m1 = ra.Next(1, 20);
                        int l1= ra.Next(1, 20);
                        int max = m1 + l1;
                        int min = Math.Abs(m1 - l1);
                        int l2 = ra.Next(min+1, max);
                        tr[z] = new Triangle(m1, l1, l2);
                        
                        z++;
                        break;
                }
            }
            double sum = 0;
            if (x != 0)
            {
                for (int i = 0; i < x; i++)
                {
                    textBox1.Text += "长方形：" + " 长：" + rect[i].getL() + " 宽：" + rect[i].getW() + " 面积：" + rect[i].Area + "\r\n";
                    sum += rect[i].Area;
                }
            }
            if (y != 0)
            {
                for (int i = 0; i < y; i++)
                {
                    textBox1.Text += "正方形：" + " 边长：" + sq[i].getS() + " 面积：" + sq[i].Area + "\r\n";
                    sum += sq[i].Area;
                }
            }

            if (z != 0)
            {
                for (int i = 0; i < z; i++)
                {
                    textBox1.Text += "三角形：" + " 第一边：" + tr[i].getM() + " 第二边：" + tr[i].getL1() + " 第三边：" + tr[i].getL2() + " 面积：" + Convert.ToDouble(tr[i].Area).ToString("0.000") + "\r\n";
                    sum += tr[i].Area;
                }
            }
            textBox2.Text = Convert.ToDouble(sum).ToString("0.000");
        }
    }
}
