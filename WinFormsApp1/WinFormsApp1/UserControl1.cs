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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double l = double.Parse(length.Text);
            double w = double.Parse(width.Text);
            Rectangle r = new Rectangle(l, w);
            ISuc isuc = new Rectangle(l,w);
            bool t = isuc.judge();
            if (t)
            {
                MessageBox.Show("面积为："+r.Area.ToString());
            }
            else
            {
                MessageBox.Show("形状不合法！");
            }    
        }
    }
}
