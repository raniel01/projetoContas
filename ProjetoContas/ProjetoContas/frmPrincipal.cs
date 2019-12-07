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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fp = new frmUsuario();
            fp.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente fp = new frmCliente();
            fp.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor fp = new frmFornecedor();
            fp.Show();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasReceber fp = new frmContasReceber();
            fp.Show();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasPagar fp = new frmContasPagar();
            fp.Show();
        }

        private void remessaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemessa frm = new frmRemessa();
            frm.Show();
        }

        private void retornoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRetorno frmt = new frmRetorno();
            frmt.Show();
        }
    }
}
