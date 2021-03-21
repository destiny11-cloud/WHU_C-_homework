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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = double.Parse(textBox1.Text);
            double l1 = double.Parse(textBox2.Text);
            double l2 = double.Parse(textBox3.Text);
            Triangle t = new Triangle(m, l1, l2);
            ISuc isuc = new Triangle(m,l1,l2);
            bool t1 = isuc.judge();
            if (t1)
            {
                MessageBox.Show("面积为：" + t.Area.ToString());
            }
            else
            {
                MessageBox.Show("形状不合法！");
            }
        }
    }
}
