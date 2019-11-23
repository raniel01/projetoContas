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
    public partial class frmCliente : Form
    {
        public static int codigo;
        private void Habilita()
        {
            //textbox
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoTextBox.Enabled = true;
            cd_cepTextBox.Enabled = true;
            ds_telefoneTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
            sg_tipoTextBox.Enabled = true;
                        
            
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
        private void HabilitaCpf()
        {
            cd_cpfTextBox.Enabled = true;
            cd_rgTextBox.Enabled = true;
            cd_cnpjTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;
        }
        private void HabilitaCnpj()
        {
            cd_cnpjTextBox.Enabled = true;
            cd_ieTextBox.Enabled = true;
            cd_cpfTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
        }

        public void Desabilitar()
        {
            //textbox
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoTextBox.Enabled = false;
            cd_cepTextBox.Enabled = false;
            ds_telefoneTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
            sg_tipoTextBox.Enabled = false;
            cd_cpfTextBox.Enabled = false;
            cd_cnpjTextBox.Enabled = false;
            cd_rgTextBox.Enabled = false;
            cd_ieTextBox.Enabled = false;

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

        public bool ValidaCpf(string cpf)
        {
            bool resp = false;
            int a = int.Parse(cpf.Substring(0, 1));
            int b = int.Parse(cpf.Substring(1, 1));
            int c = int.Parse(cpf.Substring(2, 1));
            int d = int.Parse(cpf.Substring(3, 1));
            int e = int.Parse(cpf.Substring(4, 1));
            int f = int.Parse(cpf.Substring(5, 1));
            int g = int.Parse(cpf.Substring(6, 1));
            int h = int.Parse(cpf.Substring(7, 1));
            int i = int.Parse(cpf.Substring(8, 1));
            int j = int.Parse(cpf.Substring(9, 1));
            int k = int.Parse(cpf.Substring(10, 1));

            int s = a * 10 + b * 9 + c * 8 + d * 7 + e * 6 + f * 5 + g * 4 + h * 3 + i * 2;
            int dig1 = 11 - s % 11;

            dig1 = dig1 > 9 ? 0 : dig1;

            s = a * 11 + b * 10 + c * 9 + d * 8 + e * 7 + f * 6 + g * 5 + h * 4 + i * 3 + j * 2;
            int dig2 = 11 - s % 11;

            dig2 = dig2 > 9 ? 0 : dig2;

            if (dig1 == j && dig2 == k)
                resp = true;
            return resp;

        }
        public frmCliente()
        {
            InitializeComponent();
            Desabilitar();
        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void tbClienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void tbClienteBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet1);

        }

        private void ds_telefoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbClienteBindingSource.AddNew();
            Habilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbClienteBindingSource.Count > 0)
            {
                Habilita();
            }
            else
            {
                MessageBox.Show("Não há registros para alterar!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbClienteBindingSource.Count > 0)
            {
                tbClienteBindingSource.RemoveCurrent();
                tbClienteTableAdapter.Update(contasDataSet1.tbCliente);
            }
            else
            {
                MessageBox.Show("Não há registros a excluir!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbClienteBindingSource.EndEdit();
            tbClienteTableAdapter.Update(contasDataSet1.tbCliente);
            Desabilitar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           tbClienteBindingSource.CancelEdit();
           Desabilitar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int reg;
            codigo = 0;
            frmPesquisaCliente fpc = new frmPesquisaCliente();
            fpc.ShowDialog();
            if (codigo > 0)
            {
                reg = tbClienteBindingSource.Find("cd_cliente", codigo);
                tbClienteBindingSource.Position = reg;
            }
        }

        private void cd_clienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;

            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE CLIENTE \n" + (char)10;
            strDados = strDados + "Código: " + cd_clienteTextBox.Text + (char)10;
            strDados = strDados + "Nome: " + nm_clienteTextBox.Text + (char)10;
            strDados = strDados + "Endereço: " + ds_enderecoTextBox.Text + (char)10;
            strDados = strDados + "Bairro: " + nm_bairroTextBox.Text + "    Cidade: " + nm_cidadeTextBox.Text + "/" + sg_estadoTextBox.Text + (char)10;
            strDados = strDados + "CEP: " + cd_cepTextBox.Text + (char)10;
            strDados = strDados + "Telefone: " + ds_telefoneTextBox.Text + "    E-mail: " + ds_emailTextBox.Text + (char)10;
            strDados = strDados + "Tipo: " + sg_tipoTextBox.Text + "   CPF/CNPJ: " + cd_cpfTextBox.Text + cd_cnpjTextBox.Text + "   IE: " + cd_ieTextBox.Text + (char)10;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 60);
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.tbClienteTableAdapter.Fill(this.contasDataSet1.tbCliente);
        }

        private void cd_cpfTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void sg_tipoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sg_tipoTextBox.Text == "f")
            {
                HabilitaCpf();
            }else if(sg_tipoTextBox.Text == "j")
            {
                HabilitaCnpj();
            }
        }
        
    }
}
