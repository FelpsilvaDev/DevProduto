namespace Desenvolvimento_de_Produto
{
    partial class FrmFaltas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaltas));
            this.label3 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskDataFalta = new System.Windows.Forms.MaskedTextBox();
            this.dataGridFaltas = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mskData1 = new System.Windows.Forms.MaskedTextBox();
            this.mskdata2 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblfaltas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionar = new FontAwesome.Sharp.IconButton();
            this.button2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFaltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(93, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(92, 112);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(343, 22);
            this.txtMotivo.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(8, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Data Falta:";
            // 
            // mskDataFalta
            // 
            this.mskDataFalta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataFalta.Location = new System.Drawing.Point(11, 112);
            this.mskDataFalta.Mask = "00/00/0000";
            this.mskDataFalta.Name = "mskDataFalta";
            this.mskDataFalta.Size = new System.Drawing.Size(75, 22);
            this.mskDataFalta.TabIndex = 59;
            this.mskDataFalta.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridFaltas
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFaltas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridFaltas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFaltas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.dt,
            this.motivo});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridFaltas.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridFaltas.Location = new System.Drawing.Point(11, 211);
            this.dataGridFaltas.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridFaltas.Name = "dataGridFaltas";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridFaltas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridFaltas.RowHeadersWidth = 51;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dataGridFaltas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridFaltas.RowTemplate.Height = 24;
            this.dataGridFaltas.Size = new System.Drawing.Size(568, 202);
            this.dataGridFaltas.TabIndex = 60;
            this.dataGridFaltas.DoubleClick += new System.EventHandler(this.dataGridFaltas_DoubleClick);
            // 
            // cod
            // 
            this.cod.DataPropertyName = "Codigo";
            this.cod.HeaderText = "Código";
            this.cod.MinimumWidth = 6;
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            this.cod.Width = 125;
            // 
            // dt
            // 
            this.dt.DataPropertyName = "DataFalta";
            this.dt.HeaderText = "Data";
            this.dt.MinimumWidth = 6;
            this.dt.Name = "dt";
            this.dt.Width = 125;
            // 
            // motivo
            // 
            this.motivo.DataPropertyName = "Motivo";
            this.motivo.HeaderText = "Motivo";
            this.motivo.MinimumWidth = 6;
            this.motivo.Name = "motivo";
            this.motivo.ReadOnly = true;
            this.motivo.Width = 125;
            // 
            // mskData1
            // 
            this.mskData1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskData1.Location = new System.Drawing.Point(15, 178);
            this.mskData1.Mask = "00/00/0000";
            this.mskData1.Name = "mskData1";
            this.mskData1.Size = new System.Drawing.Size(75, 22);
            this.mskData1.TabIndex = 62;
            this.mskData1.ValidatingType = typeof(System.DateTime);
            // 
            // mskdata2
            // 
            this.mskdata2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdata2.Location = new System.Drawing.Point(99, 177);
            this.mskdata2.Mask = "00/00/0000";
            this.mskdata2.Name = "mskdata2";
            this.mskdata2.Size = new System.Drawing.Size(75, 22);
            this.mskdata2.TabIndex = 63;
            this.mskdata2.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "De:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(96, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "até:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(449, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 67;
            this.label5.Text = "faltas encontradas";
            // 
            // lblfaltas
            // 
            this.lblfaltas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfaltas.Location = new System.Drawing.Point(414, 184);
            this.lblfaltas.Name = "lblfaltas";
            this.lblfaltas.Size = new System.Drawing.Size(30, 15);
            this.lblfaltas.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(129)))), ((int)(((byte)(26)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 26);
            this.panel2.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(255, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 38);
            this.label6.TabIndex = 71;
            this.label6.Text = "Faltas";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdicionar.IconColor = System.Drawing.Color.Black;
            this.btnAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdicionar.IconSize = 20;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionar.Location = new System.Drawing.Point(441, 111);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(64, 24);
            this.btnAdicionar.TabIndex = 72;
            this.btnAdicionar.Text = "Incluir";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.button2.IconColor = System.Drawing.Color.Black;
            this.button2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button2.IconSize = 25;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(180, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 73;
            this.button2.Text = "Buscar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(591, 424);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblfaltas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskdata2);
            this.Controls.Add(this.mskData1);
            this.Controls.Add(this.dataGridFaltas);
            this.Controls.Add(this.mskDataFalta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFaltas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Faltas ";
            this.Load += new System.EventHandler(this.FrmFaltas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFaltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskDataFalta;
        public System.Windows.Forms.DataGridView dataGridFaltas;
        private System.Windows.Forms.MaskedTextBox mskData1;
        private System.Windows.Forms.MaskedTextBox mskdata2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblfaltas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnAdicionar;
        private FontAwesome.Sharp.IconButton button2;
    }
}