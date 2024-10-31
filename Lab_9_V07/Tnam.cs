using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9_V07
{
    public partial class Tnam : Form
    {
        public int TNumber { get; private set; }
        public Tnam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TNumber = (int)numericUpDown1.Value;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
