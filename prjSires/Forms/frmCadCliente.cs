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
            pnlDados.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            pnlDados.Enabled = true;
            pnlPesquisa.Enabled = false;
            dgvDadosCliente.Enabled = false;
            dgvDadosCliente.ClearSelection();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            pnlDados.Enabled = false;
            pnlPesquisa.Enabled = true;
            dgvDadosCliente.Enabled = true;
            dgvDadosCliente.ClearSelection();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnOrcamento.Enabled = false;
            btnRealizados.Enabled = false;
            pnlDados.Enabled = false;
            pnlPesquisa.Enabled = true;
            dgvDadosCliente.Enabled = true;
            dgvDadosCliente.ClearSelection();
        }

        private void dgvDadosCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnCadastrar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnOrcamento.Enabled = true;
            btnRealizados.Enabled = true;
            pnlDados.Enabled = false;
            pnlPesquisa.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnOrcamento.Enabled = false;
            btnRealizados.Enabled = false;
            pnlDados.Enabled = true;
            pnlPesquisa.Enabled = false;
            dgvDadosCliente.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnOrcamento.Enabled = false;
            btnRealizados.Enabled = false;
            pnlDados.Enabled = false;
            pnlPesquisa.Enabled = true;
            dgvDadosCliente.ClearSelection();
        }
    }
}
