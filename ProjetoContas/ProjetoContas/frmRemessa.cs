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

            int rr = 0;
            DataRowView drc, drcr;
            while (rr < tbContasReceberBindingSource.Count)
            {
                drcr = (DataRowView)tbContasReceberBindingSource.Current;
                int codcli = int.Parse(drcr["id_cliente"].ToString());
                int reg = tbClienteBindingSource.Find("cd_cliente", codcli);
                tbClienteBindingSource.Position = reg;
                drc = (DataRowView)tbClienteBindingSource.Current;

                arq.WriteLine("100000 000000000000 00190161000012345" + drc["cd_conta"].ToString().PadRight(25) + "23720200" +
                    NossoNumero(drcr["cd_conta"].ToString().PadLeft(11, '0') )+ "00000000002N           2  01" +
                    drcr["cd_conta"].ToString().PadLeft(10) + drcr["dt_vencimento"].ToString().Substring(0, 2) +
                    drcr["dt_vencimento"].ToString().Substring(3, 2) + drcr["dt_vencimento"].ToString().Substring(8, 2) +
                    (double.Parse(drcr["vl_conta"].ToString()) * 100).ToString().Substring(8, 2) +
                    "    0000000000000000000000000000000000000000000000000000000000" + drc["sg_tipo"].ToString() == "F" ? "01" +
                    drc["cd_cpf"].ToString().PadLeft(14, '0') : "02" + drc["cd_cnpj"].ToString().PadLeft(14, '0') +
                    drc["nm_cliente"].ToString().PadRight(40) + drc["ds_endereco"].ToString().PadRight(40) + "           " +
                    drc["cd_cep"].ToString().PadLeft(8, '0') + "                                                            " +
                    linha.ToString().PadLeft(6, '0'));
                rr++;
                if (rr < tbContasReceberBindingSource.Count)
                    tbContasReceberBindingSource.MoveNext();
            }
            linha++;
            arq.WriteLine("9                                                                                               " +
                "                                                                                                          " +
                "                                                                                                   " +
                "                                                                                             " + linha.ToString().PadLeft(6, '0'));
            arq.Close();
            

        }

        private string NossoNumero(string nm)
        {
            nm = "19" + nm;


            nm = nm+dig;
            return nm.Substring(2, 12);
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
