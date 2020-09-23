﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;

namespace WindowsFormsAplication20200918_2
{
    public partial class Form1 : Form
    {

        //这里试写一个计算圆柱体体积的函数
        private double V (double r,double h)
        {
            const double pi = 3.14159;
            return pi * r * r * h;
        }
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);                                      //定义窗体加载事件
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

            //列表组件赋值练习
            string list_result = "";
            string[,] list = new string[9, 9];
            int AA, BB;
            this.listBox1.Items.Clear();
            for (int aa = 0; aa < 9; aa++)
            {
                AA = aa + 1;
                for (int bb = aa; bb < 9; bb++)
                {
                    BB = bb + 1;
                    list_result = AA + "*" + BB + "=" + (AA * BB);
                    this.listBox1.Items.Add(list_result);
                }
            }

            //文本练习
            //string str1 =1.23 + "" + "abc";
            //string str2 = str1.Substring(4, 2);
            //string str3 = str1.Replace("1.23", "文本3");
            //string str4 = string.Format("{0}和{2}", str1, str2, str3);
            //int p = "microsoft".IndexOf("so");
            //MessageBox.Show("1、测试\r换行" + p + "\n" + str2 + "\n" + str4);

            //bool flag;
            //flag = !(true && false || true);
            //string result = flag.ToString();
            //MessageBox.Show(result);


            //数组练习
            //int[] n = new int[10];
            //for (int i = 0; i < n.Length; i++)
            //{
            //    n[i] = i+1;
            //}
            //int total = 0;
            //for (int i = 0; i < n.Length; i = i + 2)
            //{
            //    total += n[i];
            //}
            //MessageBox.Show(total.ToString());


            //试写一个斐波那契数列
            //int n = 20;
            //int[] F = new int[n];
            //F[0] = 0;
            //F[1] = 1;
            //for (int i = 2; i < F.Length; i++)
            //{
            //    F[i] = F[i - 1] + F[i - 2];
            //}
            //string result = "";
            //for (int i = 0; i < F.Length; i++)
            //{
            //    result += F[i].ToString() + " ";
            //}
            //MessageBox.Show(result);


            //试用三元运算符号
            //int a = 8, b;
            //b = (a % 2 == 1) ? 0 : 1;
            //MessageBox.Show(b.ToString());


            //试用if语句
            //string result = "", result2 = "";
            //for (int i = -1; i < 2; i++)
            //{
            //    if (i > 0)
            //    {
            //        result = "正";
            //    }
            //    else if (i < 0)
            //    {
            //        result = "负";
            //    }
            //    else
            //    {
            //        result="零";
            //    }
            //    result2 += result;
            //}
            //MessageBox.Show(result2);

            //switch语句

            //int[] arr = new int[3];
            //string result = "", result2 = "";
            //for (int i = 0; i < 3; i++)
            //{
            //    arr[i] = i - 1;
            //    switch (arr[i])
            //    {
            //        case -1:
            //            result = "负";
            //            break;
            //        case 1:
            //            result = "正";
            //            break;
            //        default:
            //            result = "零";
            //            break;
            //    }
            //    result2 += result;
            //}
            //MessageBox.Show(result2);



            //while语句
            //do循环
            //int[] arr = new int[10];
            //int i = 0;
            //do
            //{
            //    arr[i] = i - 1;
            //    i++;
            //}
            //while (i<10);
            //MessageBox.Show(arr[i-1].ToString());


            //for循环


            //foreach循环


            //break语句


            //continue语句



            //goto语句
            //    int result = 0;
            //    for (int i = 0; i < 10; i++)
            //    {
            //        if (i == 10)
            //        {
            //            goto AAA;
            //        }
            //        else
            //        {
            //            result += i;
            //        }
            //    }
            //AAA:
            //    MessageBox.Show(result.ToString(), "修改标题", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);


            //return语句1


            //处理对话框的用户响应
            //DialogResult dialogResult;
            //dialogResult = MessageBox.Show("下面有3个按钮\n看看点了哪个", "处理对话框的用户响应", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    MessageBox.Show("yes");
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    MessageBox.Show("no");
            //}
            //else
            //{
            //    MessageBox.Show("cancel");
            //}


            //调用VB的inputbox
            //string r = VB.Interaction.InputBox("输入半径：", "输入框");
            //string h = VB.Interaction.InputBox("输入高度：", "输入框");
            //double vol;
            //vol = V(double.Parse(r), double.Parse(h));
            //MessageBox.Show(vol.ToString());


            //调用UCase类中的函数，并结合VB中的inputbox，计算输入的文本中有多少个大写字母
            //string source = VB.Interaction.InputBox("输入文本");
            //UCase uCase = new UCase();
            //MessageBox.Show(uCase.coountCapital(source).ToString());


            //try,catch,finally
            //string result = "";
            //try
            //{
            //    int[] i = { 1, 3, 5 };
            //    result = i[3].ToString();        //数组下标越界
            //}
            //catch (SystemException ex)
            //{
            //    result = ex.Message;
            //}
            //finally
            //{
            //    result +="\nfinally";

            //}
            //MessageBox.Show(result);                //messagebox放在finally外面和里面是一样的


            //using system.io 判断文件夹是否存在
            //bool a = File.Exists(@"f:\visualstudio\solution20200918-2\solution20200918-2.sln");     //判断是否存在文件
            //bool b = Directory.Exists(@"f:\visualstudio");                               //判断是否存在路径
            //string result = "";
            //try
            //{
            //    result = a.ToString();
            //    string[] arr = Directory.GetFiles(@"f:\visualstudio\solution20200918-2");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        result += arr[i] + "\n";
            //    }
            //}
            //catch (SystemException ex)
            //{

            //    result = ex.Message;
            //}
            //finally
            //{
            //    result += "\nfinally";
            //}
            //MessageBox.Show(result);

            try
            {
                //创建文本并写入
                string path = @"F:\VisualStudio\Solution20200918-2\a.txt";
                FileStream fileStream = new FileStream(path, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                //开始写入
                streamWriter.WriteLine("hello VSTO");
                streamWriter.WriteLine("second line");
                streamWriter.WriteLine("3th line");
                //清空缓存
                streamWriter.Flush();
                //数据是先被读到了内存中的 ，再把数据写到文件中，当你数据读完的时候不代表你的数据已经写完了，
                //因为还有一部分有可能会留在内存这个缓冲区中。这时候如果你调用了close()方法关闭了读写流，
                //那么这部分数据就会丢失，所以为了防止数据丢失，应该在关闭读写流之前先flush()。
                //关闭流
                streamWriter.Close();
                fileStream.Close();
                //读入内容
                StreamReader streamReader = new StreamReader(path, Encoding.Default);
                bool line;
                string result = "";
                while (line = streamReader.ReadLine() != null)
                {
                    result += line + "\n";
                }
                MessageBox.Show(result);
            }
            catch (SystemException ex)
            {
                string result = ex.Message;
                MessageBox.Show(result);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Counter.times++;
            this.button2.Text = "点击次数" + Counter.times;
        }
    }
}
