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
    public partial class frmPesquisarContasPagar : Form
    {
        public frmPesquisarContasPagar()
        {
            InitializeComponent();
        }

        private void tbContasPagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasPagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void frmPesquisarContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tbContasPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasPagarTableAdapter.Fill(this.contasDataSet1.tbContasPagar);

        }

        private void txtPequisaContaPagar_TextChanged(object sender, EventArgs e)
        {
            if (txtPequisaContaPagar.Text == "")
                tbContasPagarTableAdapter.Fill(contasDataSet1.tbContasPagar);
            else
                tbContasPagarTableAdapter.FillByFornecedor(contasDataSet1.tbContasPagar, int.Parse(txtPequisaContaPagar.Text));
        }

        private void tbContasPagarDataGridView_DoubleClick(object sender, EventArgs e)
        {
            frmContasPagar.codigo = int.Parse(tbContasPagarDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
