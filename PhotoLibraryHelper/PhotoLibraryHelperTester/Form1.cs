using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoLibraryHelper;

namespace PhotoLibraryHelperTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image output;
            Image input = new Bitmap(@"c:\Mina.jpg");
            WaterMarkManager.AddWaterMark(input, "Testtttt",out output);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = PasswordManager.HashPassword("fgrejkmas");
        }
    }
}
