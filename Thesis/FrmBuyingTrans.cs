using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis
{
    public partial class FrmBuyingTrans : Form
    {
        public FrmBuyingTrans()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain back = new FrmMain();
            back.Show();
            this.Visible = false;
        }
    }
}
