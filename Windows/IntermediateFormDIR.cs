using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School.Windows
{
    public partial class IntermediateFormDIR : Form
    {
        public IntermediateFormDIR()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var Entrance = new Entrance();
            Entrance.ShowDialog();
        }
    }
}
