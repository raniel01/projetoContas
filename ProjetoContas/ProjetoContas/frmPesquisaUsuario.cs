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
    public partial class frmPesquisaUsuario : Form
    {
        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void frmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.contasDataSet1.tbUsuario);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                tbUsuarioTableAdapter.Fill(contasDataSet1.tbUsuario);
            else
                tbUsuarioTableAdapter.FillByNome(contasDataSet1.tbUsuario, "%"+txtNome.Text+"%");
                
        }

        private void tbUsuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            frmUsuario.codigo = int.Parse(tbUsuarioDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                tbUsuarioTableAdapter.Fill(contasDataSet1.tbUsuario);
            else
                tbUsuarioTableAdapter.FillByNome(contasDataSet1.tbUsuario, "%" + txtNome.Text + "%");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
