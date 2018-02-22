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
    public partial class frmSerView : Form
    {
        public frmSerView(String name)
        {
            InitializeComponent();
            this.Text = "Mecânica Sires - Serviços do cliente " + name;
        }
    }
}
