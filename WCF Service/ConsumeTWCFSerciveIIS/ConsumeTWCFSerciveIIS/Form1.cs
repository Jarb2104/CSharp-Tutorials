using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumeTWCFSerciveIIS
{
    public partial class frmWCFServiceTest : Form
    {
        TWCFServiceIIS.ServiceClient wsClient = new TWCFServiceIIS.ServiceClient();

        public frmWCFServiceTest()
        {
            InitializeComponent();
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            int iTestNumber;
            if (int.TryParse(tbTest.Text, out iTestNumber))
                lbTestResult.Text = wsClient.GetData(iTestNumber);
            else
                lbTestResult.Text = "error";
        }
    }
}
