using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt2_hft4_8ekim2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";

            lblItemCount.Text = listBox1.Items.Count.ToString();
            lblIndex.Text = listBox1.SelectedIndex.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);

            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 0;

            lblIndex.Text = "";
            lblAd.Text = "";
            lblSoyad.Text = "";
            lblItemCount.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>0)
            {

                listBox2.SelectedIndex = listBox1.SelectedIndex;
                lblAd.Text = listBox1.SelectedItem.ToString();
                lblSoyad.Text = listBox2.SelectedItem.ToString();
                lblItemCount.Text = listBox1.Items.Count.ToString();
                lblIndex.Text = listBox1.SelectedIndex.ToString();
            }
        }
    }
}
