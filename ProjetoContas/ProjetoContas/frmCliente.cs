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
    public partial class frmCliente : Form
    {
        public static int codigo;
        private void Habilita()
        {
            //textbox
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = true;
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
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = false;
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
        public frmCliente()
        {
            InitializeComponent();
            Desabilitar();
        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void tbClienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void tbClienteBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void ds_telefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbClienteBindingSource.Count > 0)
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
            if (tbClienteBindingSource.Count > 0)
            {
                tbClienteBindingSource.RemoveCurrent();
                tbClienteTableAdapter.Update(contasDataSet1.tbCliente);
            }
            else
            {
                MessageBox.Show("Não há registros a excluir!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbClienteBindingSource.EndEdit();
            tbClienteTableAdapter.Update(contasDataSet1.tbCliente);
            Desabilitar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           tbClienteBindingSource.CancelEdit();
           Desabilitar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int reg;
            codigo = 0;
            frmPesquisaCliente fpc = new frmPesquisaCliente();
            fpc.ShowDialog();
            if (codigo > 0)
            {
                reg = tbClienteBindingSource.Find("cd_cliente", codigo);
                tbClienteBindingSource.Position = reg;
            }
        }
    }
}
