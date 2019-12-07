using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ProjetoContas
{
    public partial class frmRetorno : Form
    {
        public frmRetorno()
        {
            InitializeComponent();
        }

        private void tbContasReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void frmRetorno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tbContasReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasReceberTableAdapter.Fill(this.contasDataSet1.tbContasReceber);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            StreamReader arq = new StreamReader(txtArquivo.Text);
            string linha;

            while (!arq.EndOfStream)
            {
                linha = arq.ReadLine();
                if(linha.Substring(0,1) == "1" && linha.Substring(108,2) == "06")
                {
                    string dtpag = linha.Substring(110, 2) + "/" + linha.Substring(112, 2) + "/" + linha.Substring(114, 2);
                    decimal vlpag = decimal.Parse(linha.Substring(253, 13)) / 100;
                    int coddoc = int.Parse(linha.Substring(116, 10));
                    tbContasReceberTableAdapter.BaixaPagamento(dtpag, vlpag, coddoc);
                }
            }
            arq.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
