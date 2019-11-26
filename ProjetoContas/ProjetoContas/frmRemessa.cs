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
    public partial class frmRemessa : Form
    {
        public frmRemessa()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int remessa = 1, linha = 1;
            string dtInicial, dataHoje, nossoNumero;

            dtInicial = dtpInicial.Text;
            dataHoje = DateTime.Now.ToShortDateString();
            dataHoje = dataHoje.Substring(0, 2) + dataHoje.Substring(3, 2) + dataHoje.Substring(8, 2);
            tbContasReceberBindingSource.Filter="dt_emissao >= '"+dtpInicial+"'";
            tbContasReceberTableAdapter.Fill(contasDataSet1.tbContasReceber);

            StreamWriter arq = new StreamWriter(@"c:\BRADESCO\CB" + dataHoje.PadLeft(4) + "01.REM");
            arq.WriteLine("01REMESSA01COBRANCA       00000000000000123456SAMPAIOEVALENTEPAPELARIALTDA  237BRADESCO       " + dataHoje + "        MX" + remessa.ToString("0000000") + "                                                                                                                                                                                                                                                                                     " + linha.ToString("000000"));
            while (tbContasReceberBindingSource.Position < tbContasReceberBindingSource.Count)
            {
                nossoNumero = contasDataSet1.tbContasReceber.Rows[tbContasReceberBindingSource.Position][contasDataSet1.tbContasReceber.cd_contaColumn].ToString().PadLeft(11, '0');
                arq.WriteLine("100000 000000000000 00190161000012345" + contasDataSet1.tbContasReceber.Rows[tbContasReceberBindingSource.Position][contasDataSet1.tbContasReceber.cd_contaColumn].ToString().PadRight(25)+"23720200"+nossoNumero+)
            }
            

        }

        private void tbContasReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void frmRemessa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.contasDataSet1.tbCliente);
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet1.tbContasReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasReceberTableAdapter.Fill(this.contasDataSet1.tbContasReceber);

        }
    }
}
