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
    public partial class frmContasReceber : Form
    {
        private void Habilita()
        {
            //textbox
            cd_contaTextBox.Enabled = false;
            id_clienteTextBox.Enabled = true;
            dt_emissaoDateTimePicker.Enabled = true;
            vl_contaTextBox.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            dt_pagamentoDateTimePicker.Enabled = true;
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
            id_clienteTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = false;
            vl_contaTextBox.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = false;
            dt_pagamentoDateTimePicker.Enabled = false;
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
        public frmContasReceber()
        {
            InitializeComponent();
            Desabilitar();
        }

        private void tbContasReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void frmContasReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tbContasReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasReceberTableAdapter.Fill(this.contasDataSet1.tbContasReceber);

        }

        private void id_clienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbContasReceberBindingSource.MovePrevious();
        }

        private void Ds_obsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tbContasReceberBindingSource.MoveNext();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            tbContasReceberBindingSource.AddNew();
            Habilita();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (tbContasReceberBindingSource.Count > 0)
            {
                Habilita();
            }
            else
            {
                MessageBox.Show("Não há registros a alterar!");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (tbContasReceberBindingSource.Count > 0)
            {
                tbContasReceberBindingSource.RemoveCurrent();
                tbContasReceberTableAdapter.Update(contasDataSet1.tbContasReceber);
            }
            else
            {
                MessageBox.Show("Não há registros a excluir");
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbContasReceberBindingSource.EndEdit();
            tbContasReceberTableAdapter.Update(contasDataSet1.tbContasReceber);
            Desabilitar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            tbContasReceberBindingSource.CancelEdit();
            Desabilitar();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
