using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSires.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }
        
        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCliente frm = new frmCadCliente(this);
            this.Hide();
            frm.Show();
        }

        private void timTicks_Tick(object sender, EventArgs e)
        {
            sttTime.Text = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString(); 
        }
    }
}
