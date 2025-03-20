using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastro
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }
        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void LimparCampos()
        {
            mskCod.Text = "";
            txtNome.Text = "";
            txtDescrição.Text = "";
            chkAtivo.Checked = false;
            chkInativo.Checked = false;
            dtpDataCadastro.Value = DateTime.Now;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mskCod.Text))
            {
                Erro("Informe o código");
                return;
            }
            else if (string.IsNullOrEmpty(txtNome.Text))
            {
                Erro("Informe o nome");
                return;
            }
            else if (string.IsNullOrEmpty(txtDescrição.Text))
            {
                Erro("Informe a descrição");
                return;
            }
            else if (!chkAtivo.Checked && !chkInativo.Checked)
            {
                Erro("Informe o status");
                return;
            }
            Produtos p = new Produtos();
            p.Codigo = Convert.ToInt32(mskCod.Text);
            p.Nome = txtNome.Text;
            p.Descrição = txtDescrição.Text;
            p.Ativo = chkAtivo.Checked ? "Sim" : "Não";
            p.DataCadastro = DateTime.Now;
            Produtos.ListaProdutos.Add(p);
            LimparCampos();
            Sucesso("Produto cadastrado com sucesso");
        }

        private void chkAtivo_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkAtivo.Checked)
            {
                chkInativo.Checked = false;
            }
        }

        private void chkInativo_CheckedChanged(object sender, EventArgs e)
        {

             if (chkInativo.Checked)
            {
                chkAtivo.Checked = false;
            }
        }
    }
}
