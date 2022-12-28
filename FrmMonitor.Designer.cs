namespace Desenvolvimento_de_Produto
{
    partial class FrmMonitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonitor));
            this.dataGridMonitor = new System.Windows.Forms.DataGridView();
            this.IdSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtinicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dtence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMonitor
            // 
            this.dataGridMonitor.AllowUserToDeleteRows = false;
            this.dataGridMonitor.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMonitor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMonitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSolicitacao,
            this.status,
            this.dtinicio,
            this.descricao,
            this.tipo,
            this.quant,
            this.func,
            this.dtence,
            this.obs});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMonitor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMonitor.Location = new System.Drawing.Point(0, 0);
            this.dataGridMonitor.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridMonitor.Name = "dataGridMonitor";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMonitor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridMonitor.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridMonitor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridMonitor.RowTemplate.Height = 24;
            this.dataGridMonitor.Size = new System.Drawing.Size(1169, 672);
            this.dataGridMonitor.TabIndex = 51;
            this.dataGridMonitor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridMonitor_CellFormatting);
            this.dataGridMonitor.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMonitor_CellValueChanged);
            this.dataGridMonitor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridMonitor_KeyUp);
            // 
            // IdSolicitacao
            // 
            this.IdSolicitacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdSolicitacao.DataPropertyName = "Codigo";
            this.IdSolicitacao.Frozen = true;
            this.IdSolicitacao.HeaderText = "Código";
            this.IdSolicitacao.MinimumWidth = 6;
            this.IdSolicitacao.Name = "IdSolicitacao";
            this.IdSolicitacao.ReadOnly = true;
            this.IdSolicitacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdSolicitacao.Width = 90;
            // 
            // status
            // 
            this.status.DataPropertyName = "StatusTarefa";
            this.status.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.status.HeaderText = "Status";
            this.status.Items.AddRange(new object[] {
            "PENDENTE",
            "EM ANDAMENTO",
            "ATRASADO"});
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.status.Width = 128;
            // 
            // dtinicio
            // 
            this.dtinicio.DataPropertyName = "DataTarefa";
            this.dtinicio.HeaderText = "Data da Tarefa";
            this.dtinicio.Name = "dtinicio";
            this.dtinicio.ReadOnly = true;
            this.dtinicio.Width = 129;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "Descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.Width = 128;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "NomeTipo";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            this.tipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.tipo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tipo.Width = 128;
            // 
            // quant
            // 
            this.quant.DataPropertyName = "Quantidade";
            this.quant.HeaderText = "Quantidade";
            this.quant.Name = "quant";
            this.quant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quant.Width = 128;
            // 
            // func
            // 
            this.func.DataPropertyName = "NomeFuncionario";
            this.func.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.func.HeaderText = "Colaborador";
            this.func.Name = "func";
            this.func.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.func.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.func.Width = 129;
            // 
            // dtence
            // 
            this.dtence.DataPropertyName = "DataEncerramento";
            this.dtence.HeaderText = "Data de Conclusão";
            this.dtence.Name = "dtence";
            this.dtence.Width = 128;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "Obser";
            this.obs.HeaderText = "Observação";
            this.obs.Name = "obs";
            this.obs.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.obs.Width = 128;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 672);
            this.Controls.Add(this.dataGridMonitor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMonitor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Monitor de Tarefas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMonitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMonitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridMonitor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitacao;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtinicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewComboBoxColumn func;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtence;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
    }
}