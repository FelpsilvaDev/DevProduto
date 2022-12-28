using Desenvolvimento_de_Produto.ADONET;
using Desenvolvimento_de_Produto.MODELS;
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
    public partial class FrmMonitor : Form
    {

        public FrmMonitor()
        {
            InitializeComponent();
            dataGridMonitor.AutoGenerateColumns = false;
        }

        TarefasADO db = new TarefasADO();
        List<TarefaModel> lsttasks = new List<TarefaModel>();
        int firstExe = 0;

        private void FrmMonitor_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();

            List<TipoModel> lstTipo = new List<TipoModel>();
            TiposADO dtTipo = new TiposADO();
            lstTipo = dtTipo.ListarTipos();
            tipo.DataSource = null;
            tipo.DataSource = lstTipo;
            tipo.DataPropertyName = "CodigoTipo";
            tipo.DisplayMember = "Descricao";
            tipo.ValueMember = "CodigoTipo";

            List<FuncionarioModel> lstFun = new List<FuncionarioModel>();
            FuncionarioADO dtfun = new FuncionarioADO();
            lstFun = dtfun.ListarFuncionarios();
            func.DataSource = null;
            func.DataSource = lstFun;
            func.DataPropertyName = "CodigoFuncionario";
            func.DisplayMember = "Nome";
            func.ValueMember = "CodigoFunc";


            try
            {
                CarregarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao lista tipos " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarDataGrid()
        {

            try
            {
                LoadTasks();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao consultar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadTasks()
        {
            try
            {
                dataGridMonitor.DataSource = null;
                await Task.Run(() => lsttasks = db.ListarTarefas().Where(x => x.StatusTarefa == "PENDENTE" || x.StatusTarefa == "EM ANDAMENTO" || x.StatusTarefa == "ATRASADO").OrderBy(x => x.StatusTarefa).ToList());
                dataGridMonitor.DataSource = lsttasks;
                dataGridMonitor.AutoResizeColumns();
                dataGridMonitor.AutoResizeRows();

                firstExe = 1;
            }
            catch
            {
                MessageBox.Show("Erro ao consultar Dados");
            }
            
        }

        private void dataGridMonitor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            String value = e.Value as string;
            if ((value != null) && value.Equals(e.CellStyle.DataSourceNullValue))
            {
                e.Value = e.CellStyle.NullValue;
                e.FormattingApplied = true;
            }

            this.dataGridMonitor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            if (e.Value != null && e.ColumnIndex == 4)
            {
                if (e.Value.Equals("AMPLIAÇÃO"))
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                if (e.Value.Equals("BRINDE"))
                {
                    e.CellStyle.BackColor = Color.Green;
                }
                if (e.Value.Equals("PILOTO"))
                {
                    e.CellStyle.BackColor = Color.Blue;
                }
                if (e.Value.Equals("PROVA"))
                {
                    e.CellStyle.BackColor = Color.Beige;
                }
                if (e.Value.Equals("SAC"))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                if (e.Value.Equals("FOTO"))
                {
                    e.CellStyle.BackColor = Color.Magenta;
                }
                if (e.Value.Equals("DESFILE"))
                {
                    e.CellStyle.BackColor = Color.Aquamarine;
                }
                if (e.Value.Equals("CORTE"))
                {
                    e.CellStyle.BackColor = Color.BlueViolet;
                }
                if (e.Value.Equals("LIBERAÇÕES "))
                {
                    e.CellStyle.BackColor = Color.Silver;
                }
                if (e.Value.Equals("TESTE"))
                {
                    e.CellStyle.BackColor = Color.Pink;
                }
            }
            if (e.Value != null && e.ColumnIndex == 1)
            {
                if (e.Value.Equals("ATRASADO"))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                if (e.Value.Equals("PENDENTE"))
                {
                    e.CellStyle.BackColor = Color.Green;
                }
                if (e.Value.Equals("EM ANDAMENTO"))
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void dataGridMonitor_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
            if (firstExe == 1)
            {
                TarefaModel tarefa = new TarefaModel();
                string value = dataGridMonitor.CurrentCell.Value != null ? dataGridMonitor.CurrentCell.Value.ToString() : "";
                int codigo = Convert.ToInt32(dataGridMonitor.CurrentRow.Cells[0].Value);
                tarefa.Descricao = value.ToString();
                tarefa = lsttasks.Where(x => x.Codigo == codigo).FirstOrDefault();
                try
                {
                    db.Alterar(tarefa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Confirmar Alteração " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private void dataGridMonitor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
              
            }
        }
    }
}







