using System;
using System.Windows.Forms;

namespace Desafio_2.Ventanas
{
    public partial class MBProfundidad : Form
    {
        public MBProfundidad(string message, string title)
        {
            InitializeComponent();
            this.Text = title;
            this.lblMsg.Text = message;
        }

        private void ptbDatos_Click(object sender, EventArgs e)
        {

        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
