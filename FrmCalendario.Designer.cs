namespace Desenvolvimento_de_Produto
{
    partial class FrmCalendario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalendario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.mskData2 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridCalendario = new System.Windows.Forms.DataGridView();
            this.IdSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtinicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGerar = new FontAwesome.Sharp.IconButton();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCalendario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCalendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(10, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(105, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "até:";
            // 
            // mskData
            // 
            this.mskData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskData.Location = new System.Drawing.Point(13, 134);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(81, 23);
            this.mskData.TabIndex = 3;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // mskData2
            // 
            this.mskData2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskData2.Location = new System.Drawing.Point(108, 134);
            this.mskData2.Mask = "00/00/0000";
            this.mskData2.Name = "mskData2";
            this.mskData2.Size = new System.Drawing.Size(81, 23);
            this.mskData2.TabIndex = 4;
            this.mskData2.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridCalendario
            // 
            this.dataGridCalendario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCalendario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCalendario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSolicitacao,
            this.status,
            this.dtinicio,
            this.descricao,
            this.tipo,
            this.quant,
            this.func,
            this.dtence,
            this.obs});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCalendario.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridCalendario.Location = new System.Drawing.Point(13, 174);
            this.dataGridCalendario.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridCalendario.Name = "dataGridCalendario";
            this.dataGridCalendario.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCalendario.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridCalendario.RowHeadersWidth = 51;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dataGridCalendario.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridCalendario.RowTemplate.Height = 24;
            this.dataGridCalendario.Size = new System.Drawing.Size(962, 407);
            this.dataGridCalendario.TabIndex = 53;
            // 
            // IdSolicitacao
            // 
            this.IdSolicitacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdSolicitacao.DataPropertyName = "Codigo";
            this.IdSolicitacao.HeaderText = "Código";
            this.IdSolicitacao.MinimumWidth = 6;
            this.IdSolicitacao.Name = "IdSolicitacao";
            this.IdSolicitacao.ReadOnly = true;
            this.IdSolicitacao.Visible = false;
            this.IdSolicitacao.Width = 93;
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
            this.func.Width = 200;
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
            this.obs.Width = 352;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(129)))), ((int)(((byte)(26)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 26);
            this.panel2.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnGerar.IconColor = System.Drawing.Color.Black;
            this.btnGerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGerar.IconSize = 23;
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnGerar.Location = new System.Drawing.Point(450, 132);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(69, 27);
            this.btnGerar.TabIndex = 73;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvar.IconColor = System.Drawing.Color.Black;
            this.btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvar.IconSize = 23;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSalvar.Location = new System.Drawing.Point(525, 132);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(71, 27);
            this.btnSalvar.TabIndex = 74;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 23;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCancelar.Location = new System.Drawing.Point(602, 132);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 27);
            this.btnCancelar.TabIndex = 75;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(300, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 38);
            this.label3.TabIndex = 76;
            this.label3.Text = "Calendário Automático";
            // 
            // comboCalendario
            // 
            this.comboCalendario.FormattingEnabled = true;
            this.comboCalendario.Location = new System.Drawing.Point(195, 134);
            this.comboCalendario.Name = "comboCalendario";
            this.comboCalendario.Size = new System.Drawing.Size(249, 21);
            this.comboCalendario.TabIndex = 77;          
            // 
            // FrmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(988, 592);
            this.Controls.Add(this.comboCalendario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridCalendario);
            this.Controls.Add(this.mskData2);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendário Automático";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCalendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCalendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.MaskedTextBox mskData2;
        public System.Windows.Forms.DataGridView dataGridCalendario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnGerar;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtinicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn func;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtence;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.ComboBox comboCalendario;
    }
}