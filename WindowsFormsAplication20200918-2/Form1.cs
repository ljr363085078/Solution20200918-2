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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            for (int i = 1; i <= 127; i++)
            {
                char a = Convert.ToChar(i);
                this.listBox1.Items.Add(i.ToString() + "\t" + a);
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char c;
            string s = "microsoft office";
            this.listBox1.Items.Clear();
            for (int i = 0; i < s.Length; i++)
            {
                c = s[i];
                this.listBox1.Items.Add(c.ToString());
            }
            int p = "microsoft".IndexOf("so");
            MessageBox.Show("F\"1\r换行" + p + @"\1\2");
        }
    }
}
