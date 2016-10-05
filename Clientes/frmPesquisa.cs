using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDados;

namespace Clientes
{
    public partial class frmPesquisa : Form
    {
        frmPrincipal FrmPrincipal;
        string Nomes;
        List<Cliente> clientes;

        public frmPesquisa()
        {
            InitializeComponent();
        }

        public frmPesquisa(frmPrincipal frmprincipal, string nome)
        {
            InitializeComponent();

            FrmPrincipal = frmprincipal;

            Nomes = nome;
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            csBaseDados bd = new csBaseDados();

            clientes = bd.getClienteByName(Nomes);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = clientes;
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmPrincipal.txtId.Text = clientes[e.RowIndex].id;
            FrmPrincipal.txtBairro.Text = clientes[e.RowIndex].Bairro;
            FrmPrincipal.txtCep.Text = clientes[e.RowIndex].cep;
            FrmPrincipal.txtCidade.Text = clientes[e.RowIndex].Cidade;
            FrmPrincipal.txtCnpj.Text = clientes[e.RowIndex].CNPJ;
            FrmPrincipal.txtLogradouro.Text = clientes[e.RowIndex].Logradouro;
            FrmPrincipal.txtNome.Text = clientes[e.RowIndex].Nome;

            FrmPrincipal.cboUf.SelectedIndex = Convert.ToInt16(clientes[e.RowIndex].UF);

            Close();
        }
    }
}
