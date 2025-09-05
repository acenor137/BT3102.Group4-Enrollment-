using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.Enrollment.UI
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblEnrollManageSys.Parent = ptgBG;
            lblEnrollManageSys.BackColor = Color.Transparent;
            ptbLogo2.Parent = ptgBG;
            ptbLogo2.BackColor = Color.Transparent;
            btnContinue.Parent = ptgBG;
            btnContinue.BackColor = Color.Transparent;
        }
    }
}
