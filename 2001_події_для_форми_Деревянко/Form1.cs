using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001_події_для_форми_Деревянко
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            Click +=new EventHandler(ClickHandler);
        }
        public void ClickHandler(object sender, EventArgs e)
        {
            counter++;
            label2.Text = "";
            label2.Text = counter.ToString();
        }
            
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
