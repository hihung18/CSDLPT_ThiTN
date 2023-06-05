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
    public partial class FormDangKiThi : Form
    {
        public FormDangKiThi()
        {
            InitializeComponent();
        }

        private void FormDangKiThi_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dS.GIAOVIEN_DANGKY);

        }

       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lANLabel_Click(object sender, EventArgs e)
        {

        }

        private void lANSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void sOCAUTHILabel_Click(object sender, EventArgs e)
        {

        }

        private void sOCAUTHISpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tHOIGIANLabel_Click(object sender, EventArgs e)
        {

        }

        private void tHOIGIANSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tRINHDOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nGAYTHILabel_Click(object sender, EventArgs e)
        {

        }

        private void nGAYTHIDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mAGVTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mAGVLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
