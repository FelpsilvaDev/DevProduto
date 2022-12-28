namespace Desenvolvimento_de_Produto
{
    partial class FrmAdministracao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministracao));
            this.label1 = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboFunc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskData2 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridMonitor2 = new System.Windows.Forms.DataGridView();
            this.IdSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtinicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbltottarefas = new System.Windows.Forms.Label();
            this.lbltotpecas = new System.Windows.Forms.Label();
            this.lblProva = new System.Windows.Forms.Label();
            this.lblOutros = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnLimpar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonitor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            // 
            // comboStatus
            // 
            this.comboStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "",
            "PENDENTE",
            "EM ANDAMENTO",
            "ATRASADO",
            "FINALIZADO"});
            this.comboStatus.Location = new System.Drawing.Point(15, 139);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(161, 25);
            this.comboStatus.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(184, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo:";
            // 
            // comboTipo
            // 
            this.comboTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(182, 139);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(220, 25);
            this.comboTipo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(408, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Colaborador:";
            // 
            // comboFunc
            // 
            this.comboFunc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFunc.FormattingEnabled = true;
            this.comboFunc.Location = new System.Drawing.Point(408, 139);
            this.comboFunc.Name = "comboFunc";
            this.comboFunc.Size = new System.Drawing.Size(189, 25);
            this.comboFunc.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(603, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "De:";
            // 
            // mskData
            // 
            this.mskData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskData.Location = new System.Drawing.Point(603, 141);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(81, 23);
            this.mskData.TabIndex = 10;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(687, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Até:";
            // 
            // mskData2
            // 
            this.mskData2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskData2.Location = new System.Drawing.Point(690, 141);
            this.mskData2.Mask = "00/00/0000";
            this.mskData2.Name = "mskData2";
            this.mskData2.Size = new System.Drawing.Size(81, 23);
            this.mskData2.TabIndex = 12;
            this.mskData2.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridMonitor2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMonitor2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMonitor2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMonitor2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSolicitacao,
            this.status,
            this.dtinicio,
            this.descricao,
            this.tipo,
            this.quant,
            this.func,
            this.dtence,
            this.obs});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMonitor2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMonitor2.Location = new System.Drawing.Point(11, 199);
            this.dataGridMonitor2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridMonitor2.Name = "dataGridMonitor2";
            this.dataGridMonitor2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMonitor2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridMonitor2.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridMonitor2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridMonitor2.RowTemplate.Height = 24;
            this.dataGridMonitor2.Size = new System.Drawing.Size(1276, 475);
            this.dataGridMonitor2.TabIndex = 52;
            this.dataGridMonitor2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMonitor2_CellContentClick);
            this.dataGridMonitor2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridMonitor2_CellFormatting);
            this.dataGridMonitor2.DoubleClick += new System.EventHandler(this.dataGridMonitor2_DoubleClick);
            // 
            // IdSolicitacao
            // 
            this.IdSolicitacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdSolicitacao.DataPropertyName = "Codigo";
            this.IdSolicitacao.HeaderText = "Código";
            this.IdSolicitacao.MinimumWidth = 6;
            this.IdSolicitacao.Name = "IdSolicitacao";
            this.IdSolicitacao.ReadOnly = true;
            this.IdSolicitacao.Width = 90;
            // 
            // status
            // 
            this.status.DataPropertyName = "StatusTarefa";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // dtinicio
            // 
            this.dtinicio.DataPropertyName = "DataTarefa";
            this.dtinicio.HeaderText = "Data da Tarefa";
            this.dtinicio.MinimumWidth = 6;
            this.dtinicio.Name = "dtinicio";
            this.dtinicio.ReadOnly = true;
            this.dtinicio.Width = 125;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "Descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 6;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 125;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "NomeTipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 6;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 125;
            // 
            // quant
            // 
            this.quant.DataPropertyName = "Quantidade";
            this.quant.HeaderText = "Quantidade";
            this.quant.MinimumWidth = 6;
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            this.quant.Width = 110;
            // 
            // func
            // 
            this.func.DataPropertyName = "NomeFuncionario";
            this.func.HeaderText = "Colaborador";
            this.func.MinimumWidth = 6;
            this.func.Name = "func";
            this.func.ReadOnly = true;
            this.func.Width = 150;
            // 
            // dtence
            // 
            this.dtence.DataPropertyName = "DataEncerramento";
            this.dtence.HeaderText = "Data de Conclusão";
            this.dtence.MinimumWidth = 6;
            this.dtence.Name = "dtence";
            this.dtence.ReadOnly = true;
            this.dtence.Width = 125;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "Obser";
            this.obs.HeaderText = "Observação";
            this.obs.MinimumWidth = 6;
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            this.obs.Width = 250;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Total de Tarefas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(207, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Quantidade de peças:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(539, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 57;
            this.label8.Text = "Quantidade Prova:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(825, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 16);
            this.label9.TabIndex = 58;
            this.label9.Text = "Quantidade Outros:";
            // 
            // lbltottarefas
            // 
            this.lbltottarefas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltottarefas.Location = new System.Drawing.Point(133, 174);
            this.lbltottarefas.Name = "lbltottarefas";
            this.lbltottarefas.Size = new System.Drawing.Size(47, 16);
            this.lbltottarefas.TabIndex = 59;
            // 
            // lbltotpecas
            // 
            this.lbltotpecas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotpecas.Location = new System.Drawing.Point(369, 174);
            this.lbltotpecas.Name = "lbltotpecas";
            this.lbltotpecas.Size = new System.Drawing.Size(47, 16);
            this.lbltotpecas.TabIndex = 60;
            // 
            // lblProva
            // 
            this.lblProva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProva.Location = new System.Drawing.Point(676, 174);
            this.lblProva.Name = "lblProva";
            this.lblProva.Size = new System.Drawing.Size(47, 16);
            this.lblProva.TabIndex = 61;
            // 
            // lblOutros
            // 
            this.lblOutros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutros.Location = new System.Drawing.Point(979, 174);
            this.lblOutros.Name = "lblOutros";
            this.lblOutros.Size = new System.Drawing.Size(47, 16);
            this.lblOutros.TabIndex = 62;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 23;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBuscar.Location = new System.Drawing.Point(777, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 28);
            this.btnBuscar.TabIndex = 63;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnLimpar.IconColor = System.Drawing.Color.Black;
            this.btnLimpar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpar.IconSize = 23;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLimpar.Location = new System.Drawing.Point(858, 138);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 28);
            this.btnLimpar.TabIndex = 64;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(129)))), ((int)(((byte)(26)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 26);
            this.panel2.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(259, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(410, 38);
            this.label10.TabIndex = 0;
            this.label10.Text = "Administração de Tarefas";
            // 
            // FrmAdministracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1028, 682);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblOutros);
            this.Controls.Add(this.lblProva);
            this.Controls.Add(this.lbltotpecas);
            this.Controls.Add(this.lbltottarefas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridMonitor2);
            this.Controls.Add(this.mskData2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdministracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administração de Tarefas";
            this.Load += new System.EventHandler(this.FrmAdministracao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonitor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskData2;
        public System.Windows.Forms.DataGridView dataGridMonitor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtinicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn func;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtence;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbltottarefas;
        private System.Windows.Forms.Label lbltotpecas;
        private System.Windows.Forms.Label lblProva;
        private System.Windows.Forms.Label lblOutros;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
    }
}