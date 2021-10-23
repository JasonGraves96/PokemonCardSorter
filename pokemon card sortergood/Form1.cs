using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_card_sortergood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(textBox1.Text);
            int page = (number / 9)+1;
            int location = number % 9;
            if (location == 0)
                page--;
            string local="";
            switch(location)
            {
                case 0:
                    local = "bottom right";
                    break;
                case 8:
                    local = "bottom mid";
                    break;
                case 7:
                    local = "bottom left";
                    break;
                case 6:
                    local = "mid right";
                    break;
                case 5:
                    local = "center";
                    break;
                case 4:
                    local = "mid left";
                    break;
                case 3:
                    local = "top right";
                    break;
                case 2:
                    local = "top mid";
                    break;
                case 1:
                    local = "top left";
                    break;
            }
            label3.Text = page.ToString();
            label4.Text = local;
        }
    }
}
