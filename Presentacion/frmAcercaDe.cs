using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAcercaDe : Form
    {
        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void pbMail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:sebastian.gallego@gmail.com");
        }

        private void pbLinkedin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/sebastiangallego-dev/");
        }

        private void pbGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SebastianGallego");
        }

        private void lblMp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://maxiprograma.com/");
        }
    }
}
