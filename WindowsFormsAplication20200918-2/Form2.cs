using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAplication20200918_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Closed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
            //在窗口2的关闭完成事件里，修改窗口的显示属性，窗口2的关闭事件，需要先在属性里面设置
        }
    }
}
