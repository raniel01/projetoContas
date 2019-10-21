namespace ProjetoContas
{
    partial class frmContasPagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cd_contaLabel;
            System.Windows.Forms.Label dt_emissaoLabel;
            System.Windows.Forms.Label dt_vencimentoLabel;
            System.Windows.Forms.Label vl_contaLabel;
            System.Windows.Forms.Label id_fornecedorLabel;
            System.Windows.Forms.Label dt_pagamentoLabel;
            System.Windows.Forms.Label vl_pagoLabel;
            System.Windows.Forms.Label ds_obsLabel;
            this.contasDataSet1 = new ProjetoContas.contasDataSet1();
            this.tbContasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbContasPagarTableAdapter = new ProjetoContas.contasDataSet1TableAdapters.tbContasPagarTableAdapter();
            this.tableAdapterManager = new ProjetoContas.contasDataSet1TableAdapters.TableAdapterManager();
            this.cd_contaTextBox = new System.Windows.Forms.TextBox();
            this.dt_emissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dt_vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_contaTextBox = new System.Windows.Forms.TextBox();
            this.id_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.dt_pagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_pagoTextBox = new System.Windows.Forms.TextBox();
            this.ds_obsTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            cd_contaLabel = new System.Windows.Forms.Label();
            dt_emissaoLabel = new System.Windows.Forms.Label();
            dt_vencimentoLabel = new System.Windows.Forms.Label();
            vl_contaLabel = new System.Windows.Forms.Label();
            id_fornecedorLabel = new System.Windows.Forms.Label();
            dt_pagamentoLabel = new System.Windows.Forms.Label();
            vl_pagoLabel = new System.Windows.Forms.Label();
            ds_obsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_contaLabel
            // 
            cd_contaLabel.AutoSize = true;
            cd_contaLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_contaLabel.Location = new System.Drawing.Point(12, 67);
            cd_contaLabel.Name = "cd_contaLabel";
            cd_contaLabel.Size = new System.Drawing.Size(82, 20);
            cd_contaLabel.TabIndex = 1;
            cd_contaLabel.Text = "Cód. Conta:";
            cd_contaLabel.Click += new System.EventHandler(this.cd_contaLabel_Click);
            // 
            // dt_emissaoLabel
            // 
            dt_emissaoLabel.AutoSize = true;
            dt_emissaoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_emissaoLabel.Location = new System.Drawing.Point(12, 94);
            dt_emissaoLabel.Name = "dt_emissaoLabel";
            dt_emissaoLabel.Size = new System.Drawing.Size(115, 20);
            dt_emissaoLabel.TabIndex = 3;
            dt_emissaoLabel.Text = "Data de emissao:";
            // 
            // dt_vencimentoLabel
            // 
            dt_vencimentoLabel.AutoSize = true;
            dt_vencimentoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_vencimentoLabel.Location = new System.Drawing.Point(11, 121);
            dt_vencimentoLabel.Name = "dt_vencimentoLabel";
            dt_vencimentoLabel.Size = new System.Drawing.Size(135, 20);
            dt_vencimentoLabel.TabIndex = 5;
            dt_vencimentoLabel.Text = "Data de vencimento:";
            dt_vencimentoLabel.Click += new System.EventHandler(this.dt_vencimentoLabel_Click);
            // 
            // vl_contaLabel
            // 
            vl_contaLabel.AutoSize = true;
            vl_contaLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_contaLabel.Location = new System.Drawing.Point(383, 96);
            vl_contaLabel.Name = "vl_contaLabel";
            vl_contaLabel.Size = new System.Drawing.Size(130, 20);
            vl_contaLabel.TabIndex = 7;
            vl_contaLabel.Text = "Valor da contaonta:";
            // 
            // id_fornecedorLabel
            // 
            id_fornecedorLabel.AutoSize = true;
            id_fornecedorLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_fornecedorLabel.Location = new System.Drawing.Point(176, 67);
            id_fornecedorLabel.Name = "id_fornecedorLabel";
            id_fornecedorLabel.Size = new System.Drawing.Size(84, 20);
            id_fornecedorLabel.TabIndex = 9;
            id_fornecedorLabel.Text = "Fornecedor:";
            // 
            // dt_pagamentoLabel
            // 
            dt_pagamentoLabel.AutoSize = true;
            dt_pagamentoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_pagamentoLabel.Location = new System.Drawing.Point(13, 148);
            dt_pagamentoLabel.Name = "dt_pagamentoLabel";
            dt_pagamentoLabel.Size = new System.Drawing.Size(132, 20);
            dt_pagamentoLabel.TabIndex = 11;
            dt_pagamentoLabel.Text = "Data de pagamento:";
            // 
            // vl_pagoLabel
            // 
            vl_pagoLabel.AutoSize = true;
            vl_pagoLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vl_pagoLabel.Location = new System.Drawing.Point(404, 149);
            vl_pagoLabel.Name = "vl_pagoLabel";
            vl_pagoLabel.Size = new System.Drawing.Size(81, 20);
            vl_pagoLabel.TabIndex = 13;
            vl_pagoLabel.Text = "Valor pago:";
            vl_pagoLabel.Click += new System.EventHandler(this.vl_pagoLabel_Click);
            // 
            // ds_obsLabel
            // 
            ds_obsLabel.AutoSize = true;
            ds_obsLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_obsLabel.Location = new System.Drawing.Point(16, 175);
            ds_obsLabel.Name = "ds_obsLabel";
            ds_obsLabel.Size = new System.Drawing.Size(38, 20);
            ds_obsLabel.TabIndex = 15;
            ds_obsLabel.Text = "Obs:";
            // 
            // contasDataSet1
            // 
            this.contasDataSet1.DataSetName = "contasDataSet1";
            this.contasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbContasPagarBindingSource
            // 
            this.tbContasPagarBindingSource.DataMember = "tbContasPagar";
            this.tbContasPagarBindingSource.DataSource = this.contasDataSet1;
            // 
            // tbContasPagarTableAdapter
            // 
            this.tbContasPagarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbContasPagarTableAdapter = this.tbContasPagarTableAdapter;
            this.tableAdapterManager.tbContasReceberTableAdapter = null;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.contasDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_contaTextBox
            // 
            this.cd_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbContasPagarBindingSource, "cd_conta", true));
            this.cd_contaTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cd_contaTextBox.Location = new System.Drawing.Point(100, 69);
            this.cd_contaTextBox.Name = "cd_contaTextBox";
            this.cd_contaTextBox.Size = new System.Drawing.Size(70, 22);
            this.cd_contaTextBox.TabIndex = 2;
            // 
            // dt_emissaoDateTimePicker
            // 
            this.dt_emissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbContasPagarBindingSource, "dt_emissao", true));
            this.dt_emissaoDateTimePicker.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_emissaoDateTimePicker.Location = new System.Drawing.Point(132, 94);
            this.dt_emissaoDateTimePicker.Name = "dt_emissaoDateTimePicker";
            this.dt_emissaoDateTimePicker.Size = new System.Drawing.Size(245, 22);
            this.dt_emissaoDateTimePicker.TabIndex = 4;
            // 
            // dt_vencimentoDateTimePicker
            // 
            this.dt_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbContasPagarBindingSource, "dt_vencimento", true));
            this.dt_vencimentoDateTimePicker.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_vencimentoDateTimePicker.Location = new System.Drawing.Point(152, 119);
            this.dt_vencimentoDateTimePicker.Name = "dt_vencimentoDateTimePicker";
            this.dt_vencimentoDateTimePicker.Size = new System.Drawing.Size(245, 22);
            this.dt_vencimentoDateTimePicker.TabIndex = 6;
            // 
            // vl_contaTextBox
            // 
            this.vl_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbContasPagarBindingSource, "vl_conta", true));
            this.vl_contaTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_contaTextBox.Location = new System.Drawing.Point(519, 96);
            this.vl_contaTextBox.MaxLength = 15;
            this.vl_contaTextBox.Name = "vl_contaTextBox";
            this.vl_contaTextBox.Size = new System.Drawing.Size(200, 22);
            this.vl_contaTextBox.TabIndex = 8;
            this.vl_contaTextBox.TextChanged += new System.EventHandler(this.vl_contaTextBox_TextChanged);
            // 
            // id_fornecedorTextBox
            // 
            this.id_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbContasPagarBindingSource, "id_fornecedor", true));
            this.id_fornecedorTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_fornecedorTextBox.Location = new System.Drawing.Point(266, 67);
            this.id_fornecedorTextBox.MaxLength = 50;
            this.id_fornecedorTextBox.Name = "id_fornecedorTextBox";
            this.id_fornecedorTextBox.Size = new System.Drawing.Size(453, 22);
            this.id_fornecedorTextBox.TabIndex = 10;
            // 
            // dt_pagamentoDateTimePicker
            // 
            this.dt_pagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbContasPagarBindingSource, "dt_pagamento", true));
            this.dt_pagamentoDateTimePicker.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_pagamentoDateTimePicker.Location = new System.Drawing.Point(152, 147);
            this.dt_pagamentoDateTimePicker.Name = "dt_pagamentoDateTimePicker";
            this.dt_pagamentoDateTimePicker.Size = new System.Drawing.Size(245, 22);
            this.dt_pagamentoDateTimePicker.TabIndex = 12;
            // 
            // vl_pagoTextBox
            // 
            this.vl_pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbContasPagarBindingSource, "vl_pago", true));
            this.vl_pagoTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vl_pagoTextBox.Location = new System.Drawing.Point(491, 149);
            this.vl_pagoTextBox.MaxLength = 15;
            this.vl_pagoTextBox.Name = "vl_pagoTextBox";
            this.vl_pagoTextBox.Size = new System.Drawing.Size(228, 22);
            this.vl_pagoTextBox.TabIndex = 14;
            this.vl_pagoTextBox.TextChanged += new System.EventHandler(this.vl_pagoTextBox_TextChanged);
            // 
            // ds_obsTextBox
            // 
            this.ds_obsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbContasPagarBindingSource, "ds_obs", true));
            this.ds_obsTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ds_obsTextBox.Location = new System.Drawing.Point(60, 175);
            this.ds_obsTextBox.MaxLength = 200;
            this.ds_obsTextBox.Multiline = true;
            this.ds_obsTextBox.Name = "ds_obsTextBox";
            this.ds_obsTextBox.Size = new System.Drawing.Size(337, 145);
            this.ds_obsTextBox.TabIndex = 16;
            this.ds_obsTextBox.TextChanged += new System.EventHandler(this.ds_obsTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-1, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 10);
            this.panel1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 34);
            this.label1.TabIndex = 50;
            this.label1.Text = "CONTAS A PAGAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(520, 366);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 61;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(438, 366);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 60;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(356, 365);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 59;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(274, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(192, 367);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 57;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(520, 336);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 56;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(438, 335);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 55;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(356, 336);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 54;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(274, 336);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 53;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(192, 337);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 52;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // frmContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(cd_contaLabel);
            this.Controls.Add(this.cd_contaTextBox);
            this.Controls.Add(dt_emissaoLabel);
            this.Controls.Add(this.dt_emissaoDateTimePicker);
            this.Controls.Add(dt_vencimentoLabel);
            this.Controls.Add(this.dt_vencimentoDateTimePicker);
            this.Controls.Add(vl_contaLabel);
            this.Controls.Add(this.vl_contaTextBox);
            this.Controls.Add(id_fornecedorLabel);
            this.Controls.Add(this.id_fornecedorTextBox);
            this.Controls.Add(dt_pagamentoLabel);
            this.Controls.Add(this.dt_pagamentoDateTimePicker);
            this.Controls.Add(vl_pagoLabel);
            this.Controls.Add(this.vl_pagoTextBox);
            this.Controls.Add(ds_obsLabel);
            this.Controls.Add(this.ds_obsTextBox);
            this.Name = "frmContasPagar";
            this.Text = "Contas a pagar";
            this.Load += new System.EventHandler(this.frmContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasPagarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private contasDataSet1 contasDataSet1;
        private System.Windows.Forms.BindingSource tbContasPagarBindingSource;
        private contasDataSet1TableAdapters.tbContasPagarTableAdapter tbContasPagarTableAdapter;
        private contasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_contaTextBox;
        private System.Windows.Forms.DateTimePicker dt_emissaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dt_vencimentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_contaTextBox;
        private System.Windows.Forms.TextBox id_fornecedorTextBox;
        private System.Windows.Forms.DateTimePicker dt_pagamentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_pagoTextBox;
        private System.Windows.Forms.TextBox ds_obsTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
    }
}