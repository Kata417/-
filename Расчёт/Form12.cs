using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Расчёт
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) label1.Text = "Результат: " + button1.Text + radioButton1.Text;
            if (radioButton2.Checked) label1.Text = "Результат: " + button1.Text + radioButton2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) label1.Text = "Результат: " + button2.Text + radioButton1.Text;
            if (radioButton2.Checked) label1.Text = "Результат: " + button2.Text + radioButton2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 newForm = new Form13();
            newForm.Show();
        }
    }
}
