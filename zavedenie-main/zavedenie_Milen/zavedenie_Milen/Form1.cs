using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavedenie_Milen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (comboBox1.Text == "kesh")
            {
                if (comboBox2.Text == "да")
                {

                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Изчисляване на сумата за всяка поръчка
            double form1 = int.Parse(textBox7.Text) * 5.50;
            double form2 = int.Parse(textBox8.Text) * 3.70;
            double form3 = int.Parse(textBox9.Text) * 4.00;
            double form4 = int.Parse(textBox1.Text) * 3.00;
            double form5 = int.Parse(textBox2.Text) * 10.00;
            double form6 = int.Parse(textBox3.Text) * 25.00;
            double form7 = int.Parse(textBox10.Text) * 3.00;
            double form8 = int.Parse(textBox11.Text) * 2.00;
            double form9 = int.Parse(textBox12.Text) * 2.50;
            double form10 = int.Parse(textBox19.Text) * 1.50;
            double form11 = int.Parse(textBox20.Text) * 1.00;
            double form12 = int.Parse(textBox21.Text) * 0.80;
            double form13 = int.Parse(textBox13.Text) * 3.60;
            double form14 = int.Parse(textBox14.Text) * 5.00;
            double form15 = int.Parse(textBox15.Text) * 3.80;
            double form16 = int.Parse(textBox16.Text) * 2.70;
            double form17 = int.Parse(textBox17.Text) * 1.00;
            double form18 = int.Parse(textBox18.Text) * 4.00;

            // Изчисляване на общата сума за всички поръчки
            double totalSum = form1 + form2 + form3 + form4 + form5 + form6 + form7 + form8 + form9 + form10 + form11 + form12 + form13 + form14 + form15 + form16 + form17 + form18;

            // Добавяне на данни към ListBox
            listBox1.Items.Add("Поръчка 1: " + form1);
            listBox1.Items.Add("Поръчка 2: " + form2);
            listBox1.Items.Add("Поръчка 3: " + form3);
            listBox1.Items.Add("Поръчка 4: " + form4);
            listBox1.Items.Add("Поръчка 5: " + form5);
            listBox1.Items.Add("Поръчка 6: " + form6);
            listBox1.Items.Add("Поръчка 7: " + form7);
            listBox1.Items.Add("Поръчка 8: " + form8);
            listBox1.Items.Add("Поръчка 9: " + form9);
            listBox1.Items.Add("Поръчка 10: " + form10);
            listBox1.Items.Add("Поръчка 11: " + form11);
            listBox1.Items.Add("Поръчка 12: " + form12);
            listBox1.Items.Add("Поръчка 13: " + form13);
            listBox1.Items.Add("Поръчка 14: " + form14);
            listBox1.Items.Add("Поръчка 15: " + form15);
            listBox1.Items.Add("Поръчка 16: " + form16);
            listBox1.Items.Add("Поръчка 17: " + form17);
            listBox1.Items.Add("Поръчка 18: " + form18);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
