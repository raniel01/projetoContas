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
    
    public partial class pesquisaContaReceber : Form
    {
        public pesquisaContaReceber()
        {
            InitializeComponent();
        }

        private void tbContasReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void pesquisaContaReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tbContasReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasReceberTableAdapter.Fill(this.contasDataSet1.tbContasReceber);

        }

        

        private void dataVencimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged_1(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
                tbContasReceberTableAdapter.Fill(contasDataSet1.tbContasReceber);
            else
                tbContasReceberTableAdapter.FillByCliente(contasDataSet1.tbContasReceber,  int.Parse(txtCliente.Text));
        }
    }
}
