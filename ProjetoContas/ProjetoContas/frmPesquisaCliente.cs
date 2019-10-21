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
    public partial class frmPesquisaCliente : Form
    {
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.contasDataSet1.tbCliente);

        }
        private void tbUsuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            frmCliente.codigo = int.Parse(tbClienteDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
