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
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string wb = System.IO.File.ReadAllText(comboBox1.Text);
            //string bjk = Encoding.Unicode.GetString(Encoding.GetEncoding(wb).GetBytes(wb));
            //  byte[] zf;
            //  zf= System.Text.Encoding.Convert(Encoding.GetEncoding(wb), Encoding.GetEncoding("GB2312"), Encoding.GetEncoding(wb).GetBytes(wb));
            //  richTextBox1.Text = Encoding.Unicode.GetString(zf); 
            // richTextBox1.Text = System.IO.File.ReadAllText(comboBox1.Text);
            if (comboBox1.Text != "")
            {
                string 文本 = System.IO.File.ReadAllText(comboBox1.Text);
                byte[] 整数文本 = System.IO.File.ReadAllBytes(comboBox1.Text);
                string 转码文本 = Encoding.GetEncoding("shift_jis").GetString(整数文本);
                richTextBox1.Text = 转码文本;
            }
            else
            {
                MessageBox.Show("没有输入任何文本文档");


            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form3 form = new Form3();
            // form.Show();
            //this.richTextBox1.AllowDrop = true;

            

        }

        private void comboBox1_DragEnter(object sender, DragEventArgs e)
        {
            string 获取的目录 = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            comboBox1.Text = 获取的目录;
            comboBox1.Items.Add(获取的目录);
            button2_Click(sender, e);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string 文本="";
            if (comboBox1.Text == "")
            {

                if (richTextBox1.Text =="")
                {
                    MessageBox.Show("没有输入任何字符和文本文件");

                }

               else
                {
                   // 文本 = System.IO.File.ReadAllText(richTextBox1.Text);
                }



            }
           else
            {

                文本 = System.IO.File.ReadAllText(comboBox1.Text);
                 richTextBox1.Text = 文本;


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text != "")
            {
                string 文本 = System.IO.File.ReadAllText(comboBox1.Text);
                byte[] 整数文本 = System.IO.File.ReadAllBytes(comboBox1.Text);
                string 转码文本 = Encoding.GetEncoding("gb2312").GetString(整数文本);
                richTextBox1.Text = 转码文本;
            }
            else
            {
                MessageBox.Show("没有输入任何文本文档");


            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }



       //private void richTextBox1_DragEnter(object sender, DragEventArgs e)
       //{
       //     if (e.Data.GetDataPresent(DataFormats.FileDrop))
       //         e.Effect = DragDropEffects.All;

       // }






        
        //private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        //    {

        //        string[] MyPathArray =(string[])e.Data.GetData(DataFormats.FileDrop);
        //        foreach (string MyPath in MyPathArray)
        //        {
        //            this.richTextBox1.LoadFile(MyPath, RichTextBoxStreamType.PlainText);
        //        }
        //    }

        //}
        

    }
}
