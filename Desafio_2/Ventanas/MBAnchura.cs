using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_2.Ventanas
{
    public partial class MBAnchura : Form
    {
        public MBAnchura(string message, string title)
        {
            InitializeComponent();

            this.Text = title;
            this.lblMsg.Text = message;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MBAnchura_Load(object sender, EventArgs e)
        {

        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        private void ptbDatos_Click(object sender, EventArgs e)
        {

        }
    }
}
