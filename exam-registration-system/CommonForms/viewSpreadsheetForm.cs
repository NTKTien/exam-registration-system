using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_registration_system.CommonForms
{
    public partial class viewSpreadsheetForm : Form
    {
        public viewSpreadsheetForm()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewSpreadsheetForm_Load(object sender, EventArgs e)
        {
            lbID.Padding = new Padding(2);
            lbName.Padding = new Padding(2);
            lbTitle.Padding = new Padding(2);
            lbType.Padding = new Padding(2);
        }
    }
}
