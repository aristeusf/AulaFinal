using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDados;
using SapRfc;

namespace Clientes
{
    public partial class frmPrincipal : Form
    {

        public string salvar = "";

        csBaseDados bd = new csBaseDados();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboUf.DataSource = bd.getEstados();
        }

        private void LimpaCampos()
        {
            txtBairro.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtCnpj.Text = "";
            txtLogradouro.Text = "";
            txtNome.Text = "";
            txtId.Text = "";

            switch(salvar)
            {
                case "Novo":
                    txtNome.Text = "";
                    break;
            }
        }

        public void HabilitaDesabilita()
        {
            switch (salvar)
            {
                case "Novo":
                    txtId.Enabled = false;
                    txtNome.Enabled = true;
                    bntEditar.Enabled = false;
                    bntSalvar.Enabled = true;
                    bntBuscarId.Enabled = false;
                    bntBuscarNome.Enabled = false;
                    bntNovo.Enabled = false;
                    bntCancelar.Enabled = true;
                    bntSalvar.Enabled = true;
                    HabilitaDesabilitaCampos();
                    break;

                case "Busca":
                    txtId.Enabled = true;
                    txtNome.Enabled = true;
                    bntEditar.Enabled = true;
                    bntSalvar.Enabled = false;
                    bntBuscarId.Enabled = true;
                    bntBuscarNome.Enabled = true;
                    break;

                case "Editar":
                    txtId.Enabled = false;
                    txtNome.Enabled = true;
                    bntEditar.Enabled = false;
                    bntSalvar.Enabled = true;
                    bntBuscarId.Enabled = false;
                    bntBuscarNome.Enabled = false;
                    bntCancelar.Enabled = true;
                    bntNovo.Enabled = false;
                    HabilitaDesabilitaCampos();
                    break;

                default:
                    txtId.Enabled = true;
                    txtNome.Enabled = true;
                    bntBuscarId.Enabled = true;
                    bntBuscarNome.Enabled = true;
                    bntSalvar.Enabled = false;
                    bntNovo.Enabled = true;
                    bntCancelar.Enabled = false;
                    HabilitaDesabilitaCampos();
                    break;
            }
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            salvar = "Novo";
            LimpaCampos();
            HabilitaDesabilita();
            txtNome.Focus();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            salvar = "";
            LimpaCampos();
            HabilitaDesabilita();
        }

        private void bntBuscarId_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    Cliente cliente = bd.getClienteById(txtId.Text);

                    txtBairro.Text = cliente.Bairro;
                    txtCep.Text = cliente.cep;
                    txtCidade.Text = cliente.Cidade;
                    txtCnpj.Text = cliente.CNPJ;
                    txtId.Text = cliente.id;
                    txtLogradouro.Text = cliente.Logradouro;
                    txtNome.Text = cliente.Nome;

                    cboUf.SelectedIndex = Convert.ToInt16(cliente.UF);

                    salvar = "Busca";
                    HabilitaDesabilita();
                }
                else
                {
                    MessageBox.Show("Digite um Id para busca!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exp)
            {
                if (exp.Message == "Sequence contains no elements")
                {
                    MessageBox.Show("Cliente não Encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Erro ao buscar cliente! " + exp.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void bntBuscarNome_Click(object sender, EventArgs e)
        {
            frmPesquisa frm = new frmPesquisa(this, txtNome.Text);

            frm.ShowDialog();

            salvar = "Busca";
            HabilitaDesabilita();
        }

        private void HabilitaDesabilitaCampos()
        {
            txtBairro.Enabled = !txtBairro.Enabled;
            txtCep.Enabled = !txtCep.Enabled;
            txtCidade.Enabled = !txtCidade.Enabled;
            txtCnpj.Enabled = !txtCnpj.Enabled;
            txtLogradouro.Enabled = !txtLogradouro.Enabled;
            cboUf.Enabled = !cboUf.Enabled;
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            salvar = "Editar";
            HabilitaDesabilita();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                rfcOut rfc = new rfcOut();
                switch (salvar)
                {
                    case "Novo":

                        txtId.Text = rfc.SalvaCliente(txtNome.Text, txtCnpj.Text, txtLogradouro.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, cboUf.Text);

                        if (txtId.Text != "")
                        {
                            bd.InsertCliente(txtId.Text, txtNome.Text, txtCnpj.Text, txtLogradouro.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, cboUf.SelectedValue.ToString());
                            MessageBox.Show("Novo cliente criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            salvar = "";
                            LimpaCampos();
                            HabilitaDesabilita();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao Salvar Cliente no SAP", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        break;

                    case "Editar":

                        bd.UpdateCliente(txtId.Text, txtNome.Text, txtCnpj.Text, txtLogradouro.Text, txtBairro.Text, txtCidade.Text, txtCep.Text, cboUf.SelectedValue.ToString());

                        break;

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Erro ao salvar cliente! " + exp.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
