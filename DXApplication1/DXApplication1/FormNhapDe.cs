using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class FormNhapDe : Form
    {
        public FormNhapDe()
        {
            InitializeComponent();
        }

        private void FormNhapDe_Load(object sender, EventArgs e)
        {
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dS.BODE);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

        }

        private void mAMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void mAMHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dAP_ANLabel_Click(object sender, EventArgs e)
        {

        }

        private void dAP_ANComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
