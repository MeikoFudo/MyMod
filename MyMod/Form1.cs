using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMod
{

    public partial class FormGame : Form
    {
        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text != "")
                if (int.TryParse(textBoxInput.Text, out _))
                    textBoxShow.Text = "4k +" +(int.Parse(textBoxInput.Text) % 4);
                else
                    MessageBox.Show("Введите число");
            else
                MessageBox.Show("Введите число");
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
