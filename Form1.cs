using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 加权平均
{

    public partial class Form1 : Form
    {
        List<double> credit = new List<double>();
        List<double> score = new List<double>();
        List<double> gpa = new List<double>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSub.Text.Trim() == string.Empty || textBoxCredit.Text.Trim() 
                == string.Empty || textBoxScore.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请不要留空格！");
            }
            else
            {
                listBox1.Items.Add(textBoxSub.Text);
                credit.Add(double.Parse(textBoxCredit.Text));
                score.Add(double.Parse(textBoxScore.Text));
                Calculate cal1 = new Calculate(credit, score);
                cal1.calculateSum();
                cal1.calculateGpa();
                cal1.calculateScore();
                labelCalGPA.Text = "GPA：" + cal1.getGpa().ToString("F3");
                labelCalAve.Text = "加权平均值：" + cal1.getScore().ToString("F3");
                textBoxSub.Text = String.Empty;
                textBoxCredit.Text = String.Empty;
                textBoxScore.Text = String.Empty;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("请选择其中的一项！");
            }
            else
            {
                int tempA = 0;
                if (listBox1.Items.Count > 0)
                {
                    tempA = listBox1.SelectedIndex;
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }//从列表框移除所选项。
                credit.RemoveAt(tempA);
                score.RemoveAt(tempA);
                Calculate cal2 = new Calculate(credit, score);
                cal2.calculateSum();
                cal2.calculateGpa();
                cal2.calculateScore();
                labelCalGPA.Text = "GPA：" + cal2.getGpa().ToString("F3");
                labelCalAve.Text = "加权平均值：" + cal2.getScore().ToString("F3");
            }
        }

        private void textBoxScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && ! char.IsDigit (e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path ;
            OpenFileDialog txtFile = new OpenFileDialog();//创建文件选择对话框对象
            txtFile.Multiselect = false;//禁止选择多个文件
            txtFile.Title = "请选择您的目标文件";
            txtFile.Filter = "所有文件(*.txt*)|*.txt*";
            txtFile.InitialDirectory = "c:\\";
            txtFile.ShowDialog();
            path = txtFile.FileName;
            //对话框的属性，包括标题，可选择文件类型，默认文件夹，最后是显示对话框
            //目的是获取选取文件的保存地址
            try
            {
                string line = "";
                FileStream txtFileStream = new FileStream(path,FileMode.Open);//根据地址打开文件
                StreamReader txtFileReader = new StreamReader(txtFileStream,Encoding.Default);
                //对打开的文件进行读取操作，要创建一个读取的对象，打开文件和这个是一起创建对象
                while ((line=txtFileReader.ReadLine())!=null)
                {
                    string[] strs = line.Split(' ');//将读取的一行按空格分成不同部分放在一个数组
                    textBoxSub.Text = strs[0];
                    textBoxCredit.Text = strs[1];
                    textBoxScore.Text = strs[2];
                    button1_Click(sender,e);       
                }

            }
            catch (Exception)
            {
                
                MessageBox.Show("文件打开失败！");
            }
            
        }
    }
    /// <summary>
    /// Calculate 类是包含了score，credit，gpa三个动态数组的类
    /// </summary>
    class Calculate
    {
        List<double> score = new List<double> ();
        List<double> credit = new List<double> ();
        List<double> gpa = new List<double>();
        double sum = 0;
        double weGpa = 0;//加权的GPA  
        double weScore = 0;//加权的平均值分数
        int arrayLength;//数组长度
        public Calculate(List<double> credit, List<double> score)//要public才行，不然这是默认是private
        {
            this.score = score;
            this.credit = credit;
            arrayLength = credit.Count;
        }
        public void calculateSum()//计算总学分
        {
            foreach (var i in credit)
            {
                sum += i;
            }
        }
        public void calculateGpa()//计算加权的GPA
        {
            double temp = 0;
            for (int j = 0; j < arrayLength; j++)
            {
                if (score[j] <= 90 && score[j] >= 60)
                {
                    gpa.Add((score[j] - 50) / 10);
                }
                else if (score[j] > 90 && score[j] <= 100)
                {
                    gpa.Add(4.0);
                }
                else if (score[j] >= 0 && score[j] < 60)
                {
                    gpa.Add(0);
                }
                else
                {
                    MessageBox.Show("请输入正确的数字！");
                }//switch 会好一些
                temp += gpa[j] * credit[j];
            }
            weGpa = temp / sum;


        }
        public void calculateScore()//计算加权平均成绩
        {
            double temp2 = 0;
            for (int k = 0; k < arrayLength; k++)
            {
                temp2 += credit[k] * score[k];
            }
            weScore = temp2 / sum;

        }
        public double getGpa()//GPA接口
        {
            return weGpa;
        }
        public double getScore()//加权平均值接口
        {
            return weScore;
        }
    }
}

