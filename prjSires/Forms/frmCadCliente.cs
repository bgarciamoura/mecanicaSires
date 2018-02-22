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
    public partial class frmCadCliente : Form
    {
        private Form frmPrincipal;

        public frmCadCliente(Form pai)
        {
            InitializeComponent();
            this.frmPrincipal = pai;
        }

        private void frmCadCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal.Show();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            cmbUf.SelectedItem = "SP";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            setEnable("cad");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            setEnable("sce");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            setEnable("sce");
        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            setEnable("e");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            setEnable("sce");
        }

        private void dgvDadosCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            setEnable("dgv");
        }



        //HABILITA E DESABILITA CONTROLES DO FORM
        private void setEnable(String x)
        {
            int position = 4;
            bool[] inicial = { true, false, false, false, false };
            foreach (Control c in pnlBotoes.Controls)
            {
                switch (x)
                {
                    //SALVAR CANCELAR EXCLUIR
                    case "sce":
                        ((Button)c).Enabled = inicial[position];
                        btnOrcamento.Enabled = false;
                        btnRealizados.Enabled = false;
                        pnlDados.Enabled = false;
                        pnlPesquisa.Enabled = true;
                        dgvDadosCliente.Enabled = true;
                        dgvDadosCliente.ClearSelection();
                        break;

                    //EDITAR
                    case "e":
                        if (position <= 2)
                        {
                            ((Button)c).Enabled = false;
                        }
                        else
                        {
                            ((Button)c).Enabled = true;
                        }
                        btnOrcamento.Enabled = false;
                        btnRealizados.Enabled = false;
                        pnlDados.Enabled = true;
                        pnlPesquisa.Enabled = false;
                        dgvDadosCliente.Enabled = false;
                        break;

                    //DATAGRIDVIEW
                    case "dgv":
                        if (position > 0 && position < 3 || position == 4)
                        {
                            ((Button)c).Enabled = true;
                        }
                        else
                        {
                            ((Button)c).Enabled = false;
                        }
                        btnOrcamento.Enabled = true;
                        btnRealizados.Enabled = true;
                        pnlDados.Enabled = false;
                        pnlPesquisa.Enabled = false;
                        break;

                    //CADASTRAR
                    case "cad":
                        if (position < 3)
                        {
                            ((Button)c).Enabled = false;
                        }
                        else
                        {
                            ((Button)c).Enabled = true;
                        }
                        pnlDados.Enabled = true;
                        pnlPesquisa.Enabled = false;
                        dgvDadosCliente.Enabled = false;
                        dgvDadosCliente.ClearSelection();
                        break;
                    default:
                        break;
                }
                position--;
            }

        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            frmOrcView frm = new frmOrcView("Bruno");
            frm.ShowDialog();
        }

        private void btnRealizados_Click(object sender, EventArgs e)
        {
            frmSerView frm = new frmSerView("Bruno");
            frm.ShowDialog();
        }
    }
}
