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
    public partial class frmOrcView : Form
    {
        public frmOrcView(String name)
        {
            InitializeComponent();
            this.Text = "Mecânica Sires - Orçamentos do cliente " + name;
        }
    }
}
