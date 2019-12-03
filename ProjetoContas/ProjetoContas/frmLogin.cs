using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new frmSplashScreen());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.Filter = "nm_login='" + txtLogin.Text + "' and ds_senha='" + txtSenha + "'";
            tbUsuarioTableAdapter.Fill(contasDataSet.tbUsuario);

            if(txtLogin.Text == "adm" && txtSenha.Text == "123" || tbUsuarioBindingSource.Count > 0 )
            {
                frmPrincipal fp = new frmPrincipal();
                fp.Show();
            }
            Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.contasDataSet.tbUsuario);

        }
    }
}
