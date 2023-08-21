using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advanced_Combo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.comboBox1.Items.Add("HI");
            /* for(int i=0;i<20;i++)
             {
                 this.comboBox1.Items.Add(i.ToString());
             }*/

            this.comboBox1.Items.Remove(this.comboBox1.SelectedItem);
            this.label4.Text = this.comboBox1.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text=="")
            {
                MessageBox.Show("Hi you can not enter Empty Item");
                return;
            }
            this.comboBox1.Items.Add(this.textBox1.Text);
            this.label4.Text = this.comboBox1.Items.Count.ToString();
            this.textBox1.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // this.button3.Text = comboBox1.SelectedIndex.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Operation Cannot be Undone, Would you like to Continue?");
            this.comboBox1.Items.Clear();
            this.label4.Text = this.comboBox1.Items.Count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.label2.Text = comboBox1.SelectedIndex.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label4.Text = this.comboBox1.Items.Count.ToString();
            MessageBox.Show("Form Loading **********");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int find;
            find =this.comboBox1.FindStringExact(this.textBox2.Text);
            
            if(find==-1)
            {
                MessageBox.Show("Employee Name Not Found Try again");
            }
            else
            {
                this.Text = find.ToString();
                this.comboBox1.SelectedIndex = find;
            }
        }
    }
}
