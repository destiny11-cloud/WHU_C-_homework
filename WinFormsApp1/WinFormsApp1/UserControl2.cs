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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = double.Parse(textBox1.Text);
            Square s = new Square(m);
            ISuc isuc = new Square(m);
            bool t = isuc.judge();
            if (t)
            {
                MessageBox.Show("面积为：" + s.Area.ToString());
            }
            else
            {
                MessageBox.Show("形状不合法！");
            }
        }
    }
}
