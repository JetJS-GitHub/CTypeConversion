using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTypeConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TestAlias()
        {
            // this.textBox1 是一个文本框，类型为 System.Windows.Forms.TextBox
            // 设计中已经将其 Multiline 属性设置为 true
            byte a = 1; char b = 'a'; short c = 1;
            int d = 2; long e = 3; uint f = 4; bool g = true;
            this.textBox1.Text = "";
            this.textBox1.AppendText("byte -> " + a.GetType().FullName + "\n");
            this.textBox1.AppendText("char -> " + b.GetType().FullName + "\n");
            this.textBox1.AppendText("short -> " + c.GetType().FullName + "\n");
            this.textBox1.AppendText("int -> " + d.GetType().FullName + "\n");
            this.textBox1.AppendText("long -> " + e.GetType().FullName + "\n");
            this.textBox1.AppendText("uint -> " + f.GetType().FullName + "\n");
            this.textBox1.AppendText("bool -> " + g.GetType().FullName + "\n");
        }

        private void TestAutoConversion()
        {
            byte a = 1; short b = a; int c = b;
            long d = c; float e = d; double f = e;
            this.textBox1.Text = "";
            this.textBox1.AppendText("byte a = " + a.ToString("F") + "\n");
            this.textBox1.AppendText("short b = " + b.ToString("F") + "\n");
            this.textBox1.AppendText("int c = " + c.ToString("F") + "\n");
            this.textBox1.AppendText("long d = " + d.ToString("F") + "\n");
            this.textBox1.AppendText("float e = " + e.ToString("F") + "\n");
            this.textBox1.AppendText("double f = " + f.ToString("F") + "\n");
        }

        private void TestChar()
        {
            char ch = 'a'; short ii = 65;
            this.textBox1.Text = "";
            this.textBox1.AppendText("The ASCII code of /'" + ch + "/' is: " + (short)ch + "/n");
            this.textBox1.AppendText("ASCII is " + ii.ToString() + ", the char is: " + (char)ii + "/n");
            char cn = '中'; short uc = 22478;
            this.textBox1.AppendText("The Unicode of /'" + cn + "/' is: " + (short)cn + "/n");
            this.textBox1.AppendText("Unicode is " + uc.ToString() + ", the char is: " + (char)uc + "/n");
        }

        private void ButTestAlias_Click(object sender, EventArgs e)
        {
            TestAlias();

        }

        private void BtnAutoConversion_Click(object sender, EventArgs e)
        {
            TestAutoConversion();
        }

        private void BtnTypeConversion_Click(object sender, EventArgs e)
        {
            int g = 1;
            //short h = g;// Implicitly convert wrong；
            short h = (short)g;
            this.textBox1.AppendText("h = " + h.ToString() + "\n");

            short i = 256; //265 = 255 + 10,shor max 255;
            byte j = (byte)i;
            this.textBox1.AppendText("j("+i.ToString()+") = " + j.ToString() + "\n");

        }

        private void BtnCharConvesrsion_Click(object sender, EventArgs e)
        {
            char ch = 'a';
            short ii = 65;
            this.textBox1.Text = "";
            this.textBox1.AppendText("The ASCII code of /'" + ch + "/' is: " + (short)ch + "\n");
            this.textBox1.AppendText("ASCII is " + ii.ToString() + ", the char is: " + (char)ii + "\n");

            char cn = '中';
            short uc = 22269;
            this.textBox1.AppendText("The Unicode of /'" + cn + "/' is: " + (short)cn + "\n");
            this.textBox1.AppendText("Unicode is " + uc.ToString() + ", the char is: " + (char)uc + "\n");
        }

        private void BtnStringConversion_Click(object sender, EventArgs e)
        {
            float f = 54.321F;
            string str = "123";
            this.textBox1.Text = "";
            this.textBox1.AppendText("f = " + f.ToString() + "\n");
            if (int.Parse(str) == 123)
            {
                this.textBox1.AppendText("str\"123\" convert to int successfully.");
            }
            else
            {
                this.textBox1.AppendText("str convert to int failed.");
            }
        }

        private void BtnStringToCharArray_Click(object sender, EventArgs e)
        {
            //string to char[]
            string str = "mytest";
            char[] chars = str.ToCharArray();
            this.textBox1.Text = "";
            this.textBox1.AppendText("Length of \"mytest \" is " + str.Length + "\n");
            this.textBox1.AppendText("Length of char array is " + chars.Length + "\n");
            this.textBox1.AppendText("char[0] = " + chars[0] + "\n");
            this.textBox1.AppendText("char[1] = " + chars[1] + "\n");
            this.textBox1.AppendText("char[2] = " + chars[2] + "\n");

            //char[] to string
            char[] tcs = { 't', 'e', 's', 't', ' ', 'm', 'e' };
            string tstr = new string(tcs);
            this.textBox1.AppendText("char array to string is " + tstr + "\n");
            this.textBox1.AppendText("char array to string is " + tcs.ToString() + "\n");
            string tstr1 = tcs.ToString();
            this.textBox1.AppendText("char array to string is " + tstr1 + "\n");
            char ch = tstr[3];
            this.textBox1.AppendText("\"" + tstr + " \"[3] = " + ch.ToString());

        }

        private void BtnStringToByteArray_Click(object sender, EventArgs e)
        {
            //string to byte[]
            string s = "C#语言";
            byte[] b1 = System.Text.Encoding.Default.GetBytes(s);
            byte[] b2 = System.Text.Encoding.Unicode.GetBytes(s);
            string t1 = "", t2 = "";
            foreach (byte b in b1)
            {
                t1 += b.ToString("") + " ";
            }
            foreach (byte b in b2)
            {
                t2 += b.ToString("") + " ";
            }
            this.textBox1.Text = "";
            this.textBox1.AppendText("b1.Length = " + b1.Length + "\n");
            this.textBox1.AppendText(t1 + "\n");
            this.textBox1.AppendText("b2.Length = " + b2.Length + "\n");
            this.textBox1.AppendText(t2 + "\n");

            //byte[] to string
            byte[] bs = { 97, 98, 99, 100, 101, 102 };
            string ss = System.Text.Encoding.ASCII.GetString(bs);
            this.textBox1.AppendText("The string is: " + ss + "\n");
        }

        private void BtnToBitArray_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "在第 1 条中我们可以查到各种数值型需要使用多少字节的空间来保存数据。将某种数值类型的数据转换成字节数组的时候，得到的一定是相应大小的字节数组；同样，需要把字节数组转换成数值类型，也需要这个字节数组大于相应数值类型的字节数。\n" +
                "现在介绍此类转换的主角：System.BitConverter。该类提供了 byte[] GetBytes(...) 方法将各种数值类型转换成字节数组，也提供了 ToInt32、ToInt16、ToInt64、ToUInt32、ToSignle、ToBoolean 等方法将字节数组转换成相应的数值类型。\n" +
                "https://blog.csdn.net/gasx/article/details/638717";

         }

        private void BtnToHex_Click(object sender, EventArgs e)
        {
            //Int to Hex String
            int a = 188;
            this.textBox1.Text = "";
            this.textBox1.AppendText("a(10) = " + a.ToString() + "\n");
            this.textBox1.AppendText("a(16) = " + a.ToString("x4") + "\n");
            this.textBox1.AppendText("a(16) = " + a.ToString("X4") + "\n");

            //HexString to Int
            int b = int.Parse("AB", System.Globalization.NumberStyles.HexNumber);
            int c = int.Parse("20", System.Globalization.NumberStyles.HexNumber);
            this.textBox1.AppendText("AB(Hex) = " + b.ToString() + "\n");
            this.textBox1.AppendText("20(Hex) = " + c.ToString() + "\n");
        }

        private void DateTimeToLongInt_Click(object sender, EventArgs e)
        {
            //DateTime  to longint
            long longDate = DateTime.Now.Ticks;
            DateTime DateFromLong = new DateTime(longDate);
            this.textBox1.Text = "";
            this.textBox1.AppendText("Long value of now: " + longDate.ToString() + "\n");
            this.textBox1.AppendText("DateTime from long value: " + DateFromLong.ToString() + "\n");

            // DateTime to double like VB6
            double doubleDate = DateTime.Now.ToOADate();
            DateTime theDate = DateTime.FromOADate(doubleDate);
            this.textBox1.AppendText("Double value of now: " + doubleDate.ToString() + "\n");
            this.textBox1.AppendText("DateTime from double value: " + theDate.ToString() + "\n");
        }

        private void BtnDateTimeToString_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string format;
            this.textBox1.Text = "";
            format = "yyyy-MM-dd HH:mm:ss";
            this.textBox1.AppendText(format + ": " + now.ToString(format) + "\n");
            format = "yy年M日d日";
            this.textBox1.AppendText(format + ": " + now.ToString(format) + "\n");
        }
    }
}
