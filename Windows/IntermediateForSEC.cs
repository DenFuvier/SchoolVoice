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
    public partial class IntermediateForSEC : Form
    {
        public IntermediateForSEC()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var Entrance = new Entrance();
            Entrance.ShowDialog();
        }

        private void EnterData_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var AddStudent = new AddStudent();
            AddStudent.ShowDialog();
        }

        private void ViewData_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var ViewStudent = new ViewStudent();
            ViewStudent.ShowDialog();
        }
    }
}
