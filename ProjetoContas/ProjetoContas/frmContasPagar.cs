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
    public partial class frmContasPagar : Form
    {
        private void Habilita()
        {
            //textbox
            cd_contaTextBox.Enabled = false;
            id_fornecedorTextBox.Enabled = true;
            dt_emissaoDateTimePicker.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            dt_pagamentoDateTimePicker.Enabled = true;
            vl_contaTextBox.Enabled = true;
            vl_pagoTextBox.Enabled = true;
            ds_obsTextBox.Enabled = true;
            
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
            cd_contaTextBox.Enabled = false;
            id_fornecedorTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = false;
            dt_pagamentoDateTimePicker.Enabled = false;
            vl_contaTextBox.Enabled = false;
            vl_pagoTextBox.Enabled = false;
            ds_obsTextBox.Enabled = false;

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
        public frmContasPagar()
        {
            InitializeComponent();
            Desabilitar();
            
        }

        private void tbContasPagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasPagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void frmContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tbContasPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasPagarTableAdapter.Fill(this.contasDataSet1.tbContasPagar);

        }

        private void cd_contaLabel_Click(object sender, EventArgs e)
        {

        }

        private void dt_vencimentoLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void vl_pagoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vl_pagoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ds_obsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbContasPagarBindingSource.MoveNext();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbContasPagarBindingSource.MovePrevious();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbContasPagarBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(tbContasPagarBindingSource.Count > 0)
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
            if (tbContasPagarBindingSource.Count > 0)
            {
                tbContasPagarBindingSource.RemoveCurrent();
                tbContasPagarTableAdapter.Update(contasDataSet1.tbContasPagar);
            }
            else
            {
                MessageBox.Show("Não há registros a excluir!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbContasPagarBindingSource.EndEdit();
            tbContasPagarTableAdapter.Update(contasDataSet1.tbContasPagar);
            Desabilitar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbContasPagarBindingSource.CancelEdit();
            Desabilitar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vl_contaTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
