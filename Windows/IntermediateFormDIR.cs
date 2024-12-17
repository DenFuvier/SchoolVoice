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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var Entrance = new Entrance();
            Entrance.ShowDialog();
        }

   
        private void OpenGemerericForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var GeneratingReports = new GeneratingReports();
            GeneratingReports.ShowDialog();
        }

        private void OpenUsersForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var AddUsersOnBase = new AddUsersOnBase();
            AddUsersOnBase.ShowDialog();
        }

        private void ADDEXX_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var AddEMPloyess = new AddEMPloyess();
            AddEMPloyess.ShowDialog();
        }
    }
}
