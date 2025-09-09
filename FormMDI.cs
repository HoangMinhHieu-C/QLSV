using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void ngànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNganh F = new FormNganh();
            F.MdiParent = this;
            F.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLop F = new FormLop();
            F.MdiParent = this;
            F.Show();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSinhVien F = new FormSinhVien();
            F.MdiParent = this;
            F.Show();
        }
    }
}
