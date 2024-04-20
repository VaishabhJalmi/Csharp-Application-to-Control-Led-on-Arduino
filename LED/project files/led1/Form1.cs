using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace led1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /* https://www.electronicscuriosities.com/  */

            InitializeComponent();
            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("ON");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("OFF");
        }
    }
}
