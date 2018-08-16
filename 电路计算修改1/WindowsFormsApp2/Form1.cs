using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{ 
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }




        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

  
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            double V = double.Parse(textBox10.Text);
            double R1 = double.Parse(textBox9.Text);
            double R2 = double.Parse(textBox8.Text);
            double R3 = double.Parse(textBox7.Text);
            double R4 = double.Parse(textBox6.Text);
            Circuit circuit = new Circuit(V, R1, R2, R3, R4);
            double ca1;
            ca1 = Cacu1.Ca1(circuit);
            string output1 = ca1.ToString();
            MessageBox.Show("V= " + textBox10.Text + " R1= " + textBox9.Text + " Ω " + " R2= " + textBox8.Text + " Ω " + " R3= " + textBox7.Text + " Ω " + " R4= " + textBox6.Text + " Ω " + "I = " + output1 + " A");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double V = double.Parse(textBox11.Text);
            double R1 = double.Parse(textBox15.Text);
            double R2 = double.Parse(textBox14.Text);
            double R3 = double.Parse(textBox13.Text);
            double R4 = double.Parse(textBox12.Text);
            Circuit circuit = new Circuit(V, R1, R2, R3, R4);
            double ca2;
            ca2 = Cacu2.Ca2(circuit);
            string output2 = ca2.ToString();
            MessageBox.Show("V= " + textBox11.Text + " R1= " + textBox15.Text + " Ω " + " R2= " + textBox14.Text + " Ω " + " R3= " + textBox13.Text + " Ω " + " R4= " + textBox12.Text + " Ω " + "I = " + output2 + " A");

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
