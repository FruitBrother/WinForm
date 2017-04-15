using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string tx)
        {
            InitializeComponent();
            label1.Text = "用户" + tx + "登录成功";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
