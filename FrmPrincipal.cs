using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desenvolvimento_de_Produto
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point((panelPrincipal.Width / 2) - (pictureBox1.Width / 2),
            (panelPrincipal.Height / 2) - (pictureBox1.Height / 2));
        }

        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point((panelPrincipal.Width / 2) - (pictureBox1.Width / 2),
           (panelPrincipal.Height / 2) - (pictureBox1.Height / 2));
        }

        private void toolStripbtnAdd_Click(object sender, EventArgs e)
        {
            FrmNovaTarefa frmNovaTarefa = new FrmNovaTarefa();

            frmNovaTarefa.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionarios frmFuncionarios = new FrmFuncionarios();
            frmFuncionarios.ShowDialog();
        }

        private void toolStripMonitor_Click(object sender, EventArgs e)
        {
            FrmMonitor frmMonitor = new FrmMonitor();
            frmMonitor.Show();
        }

        private void tiposDeTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDescricoes frm = new FrmDescricoes();
            frm.ShowDialog();
        }

        private void administraçãoDeTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdministracao frm = new FrmAdministracao();
            frm.ShowDialog();
        }

        private void toolStripbtnRelat_Click(object sender, EventArgs e)
        {
            FrmIndicadores obj = new FrmIndicadores();
            obj.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmVersion obj = new FrmVersion();
            obj.ShowDialog();
        }

        private void calendárioAutomáticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalendario obj = new FrmCalendario();
            obj.ShowDialog();
        }

      
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
