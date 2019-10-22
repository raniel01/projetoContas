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
    public partial class frmUsuario : Form
    {
        public static int codigo;
        private void Habilita()
        {
            //textbox
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            nm_usuarioTextBox.Enabled = true;
            ds_senhaTextBox.Enabled = true;

            //butons
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
        private void Desabilitar()
        {
            //textbox
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = false;
            ds_senhaTextBox.Enabled = false;

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

        
        
        public frmUsuario()
        {
            InitializeComponent();
            Desabilitar();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbUsuarioBindingSource.Count > 0)
            {
                tbUsuarioBindingSource.RemoveCurrent();
                tbUsuarioTableAdapter.Update(contasDataSet.tbUsuario);
            }
            else
            {
                MessageBox.Show("Não há registros a excluir!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.CancelEdit();
            Desabilitar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.AddNew();
            Habilita();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tbUsuarioBindingSource.EndEdit();
            tbUsuarioTableAdapter.Update(contasDataSet.tbUsuario);
            Desabilitar();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.MoveNext();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbUsuarioBindingSource.Count > 0)
            {
                Habilita();
            }
            else
            {
                MessageBox.Show("Não há registros para alterar!");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int reg;
            codigo = 0;
            frmPesquisaUsuario fpu = new frmPesquisaUsuario();
            fpu.ShowDialog();
            if (codigo > 0) { 
              reg =  tbUsuarioBindingSource.Find("cd_usuario", codigo);
              tbUsuarioBindingSource.Position = reg;
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void cd_usuarioTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (e.keyChar < '0' || e.keyChar > '9')
               // e.keyChar = (char)0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnImprimir_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;

            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE USUÁRIO \n" + (char)10;
            strDados = strDados + "Código: " + cd_usuarioTextBox.Text + (char)10;
            strDados = strDados + "Nome: " + nm_usuarioTextBox.Text + (char)10;
            strDados = strDados + "Nível: " + sg_nivelTextBox.Text + (char)10;
            strDados = strDados + "Login " + nm_loginTextBox.Text;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 60);
        }
    }
}
