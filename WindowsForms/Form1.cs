using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
namespace WindowsForms
{ 

    public partial class Form1 : Form
    { 
        public MengFiles m=new MengFiles();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            m.CreateFile(10000000, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.CreateThreads();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.CreateAndDelete();
        }
    }
}
