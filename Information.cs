using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCDashboard
{
    public partial class Information : MetroFramework.Forms.MetroForm
    {
        public Information()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is vulnerable website ");
        }
    }
}
