namespace Desenvolvimento_de_Produto
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripbtnCadastros = new System.Windows.Forms.ToolStripSplitButton();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeTarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoDeTarefasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendárioAutomáticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripbtnRelat = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMonitor = new System.Windows.Forms.ToolStripButton();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripbtnAdd,
            this.toolStripSeparator1,
            this.toolStripbtnCadastros,
            this.toolStripSeparator2,
            this.toolStripbtnRelat,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripMonitor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 43);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripbtnAdd
            // 
            this.toolStripbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnAdd.Image")));
            this.toolStripbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnAdd.Name = "toolStripbtnAdd";
            this.toolStripbtnAdd.Size = new System.Drawing.Size(82, 40);
            this.toolStripbtnAdd.Text = "Adicionar";
            this.toolStripbtnAdd.Click += new System.EventHandler(this.toolStripbtnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripbtnCadastros
            // 
            this.toolStripbtnCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.tiposDeTarefasToolStripMenuItem,
            this.administraçãoDeTarefasToolStripMenuItem,
            this.calendárioAutomáticoToolStripMenuItem});
            this.toolStripbtnCadastros.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnCadastros.Image")));
            this.toolStripbtnCadastros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnCadastros.Name = "toolStripbtnCadastros";
            this.toolStripbtnCadastros.Size = new System.Drawing.Size(95, 40);
            this.toolStripbtnCadastros.Text = "Cadastros";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // tiposDeTarefasToolStripMenuItem
            // 
            this.tiposDeTarefasToolStripMenuItem.Name = "tiposDeTarefasToolStripMenuItem";
            this.tiposDeTarefasToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.tiposDeTarefasToolStripMenuItem.Text = "Tipos de Tarefas";
            this.tiposDeTarefasToolStripMenuItem.Click += new System.EventHandler(this.tiposDeTarefasToolStripMenuItem_Click);
            // 
            // administraçãoDeTarefasToolStripMenuItem
            // 
            this.administraçãoDeTarefasToolStripMenuItem.Name = "administraçãoDeTarefasToolStripMenuItem";
            this.administraçãoDeTarefasToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.administraçãoDeTarefasToolStripMenuItem.Text = "Administração de Tarefas";
            this.administraçãoDeTarefasToolStripMenuItem.Click += new System.EventHandler(this.administraçãoDeTarefasToolStripMenuItem_Click);
            // 
            // calendárioAutomáticoToolStripMenuItem
            // 
            this.calendárioAutomáticoToolStripMenuItem.Name = "calendárioAutomáticoToolStripMenuItem";
            this.calendárioAutomáticoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.calendárioAutomáticoToolStripMenuItem.Text = "Calendário Automático";
            this.calendárioAutomáticoToolStripMenuItem.Click += new System.EventHandler(this.calendárioAutomáticoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripbtnRelat
            // 
            this.toolStripbtnRelat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtnRelat.Image")));
            this.toolStripbtnRelat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtnRelat.Name = "toolStripbtnRelat";
            this.toolStripbtnRelat.Size = new System.Drawing.Size(92, 40);
            this.toolStripbtnRelat.Text = "Indicadores";
            this.toolStripbtnRelat.Click += new System.EventHandler(this.toolStripbtnRelat_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 40);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripMonitor
            // 
            this.toolStripMonitor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMonitor.Image")));
            this.toolStripMonitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMonitor.Name = "toolStripMonitor";
            this.toolStripMonitor.Size = new System.Drawing.Size(77, 40);
            this.toolStripMonitor.Text = "Monitor ";
            this.toolStripMonitor.Click += new System.EventHandler(this.toolStripMonitor_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 43);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1028, 566);
            this.panelPrincipal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(444, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 510);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Resize += new System.EventHandler(this.FrmPrincipal_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripbtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripbtnCadastros;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeTarefasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripbtnRelat;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripMonitor;
        private System.Windows.Forms.ToolStripMenuItem administraçãoDeTarefasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendárioAutomáticoToolStripMenuItem;
    }
}