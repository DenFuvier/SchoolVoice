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
    public partial class TheChoiceIsYours : Form
    {
        public TheChoiceIsYours()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void DeleteEmployer_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            this.Close();
            var GeneratingReportsForEMP = new GeneratingReportsForEMP();
            GeneratingReportsForEMP.Show();
        }

        private void OpenFormDeleteStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var GeneratingReportsForStudent = new GeneratingReportsForStudent();
            GeneratingReportsForStudent.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var IntermediateFormDIR = new IntermediateFormDIR();
            IntermediateFormDIR.Show();
        }

        private void openIvanteStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var GeneretingFormForStudentInvate = new GeneretingReportsFormForStudentInvate();
            GeneretingFormForStudentInvate.Show();
        }

        private void openIvanteNPC_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var GeneretingFormForEmploersInvate = new GeneretingReportsFormForEmploersInvate();
            GeneretingFormForEmploersInvate.Show();
        }

        private void LoadStudentAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var GeneretingReportsFormKolVoStudent = new GeneretingReportsFormKolVoANDdannie();
            GeneretingReportsFormKolVoStudent.Show();
        }
    }
}
