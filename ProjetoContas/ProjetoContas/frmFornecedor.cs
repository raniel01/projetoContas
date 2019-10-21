using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContas
{
    public partial class frmFornecedor : Form
    {
        private void Habilita()
        {
            //textbox
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
            sg_tipoTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = true;
            cd_cnpjTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
            cd_ieTextBox.Enabled = true;

            //buttons
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
        }
        public void Desabilitar()
        {
            //textbox
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
            sg_tipoTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_cnpjTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;

            //buttons
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
        }
        public frmFornecedor()
        {
            InitializeComponent();
            Desabilitar();
        }

        private void tbFornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbFornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.contasDataSet1.tbFornecedor);

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbFornecedorBindingSource.Count > 0)
            {
                Habilita();
            }
            else
            {
                MessageBox.Show("Não há registros para alterar!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbFornecedorBindingSource.Count > 0)
            {
                tbFornecedorBindingSource.RemoveCurrent();
                tbFornecedorTableAdapter.Update(contasDataSet1.tbFornecedor);
            }
            else
            {
                MessageBox.Show("Não há registros a excluir!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbFornecedorBindingSource.EndEdit();
            tbFornecedorTableAdapter.Update(contasDataSet1.tbFornecedor);
            Desabilitar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbFornecedorBindingSource.CancelEdit();
            Desabilitar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ds_enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
