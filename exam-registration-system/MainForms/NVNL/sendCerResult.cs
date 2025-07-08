using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_registration_system.MainForms.NVNL
{
    public partial class sendCerResult : Form
    {
        public sendCerResult()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendCerResult_Load(object sender, EventArgs e)
        {
            lbDateSend.Padding = new Padding(2);
            
          
        }
    }
}
