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
    public partial class frmPesquisarFornecedor : Form
    {
        public frmPesquisarFornecedor()
        {
            InitializeComponent();
        }

        private void tbFornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbFornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void frmPesquisarFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.contasDataSet1.tbFornecedor);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                tbFornecedorTableAdapter.Fill(contasDataSet1.tbFornecedor);
            else
                tbFornecedorTableAdapter.FillByCnpj(contasDataSet1.tbFornecedor, "%" + textBox1.Text + "%");
        }

        private void tbFornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            frmFornecedor.codigo = int.Parse(tbFornecedorDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
