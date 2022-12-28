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
    public partial class FrmAdministracao : Form
    {
        public FrmAdministracao()
        {
            InitializeComponent();
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFunc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridMonitor2.AutoGenerateColumns = false;

        }

        TarefasADO db = new TarefasADO();
        FuncionarioADO dbfunc = new FuncionarioADO();
        TiposADO dbtipo = new TiposADO();

        
        List<TarefaModel> lstTarefas = new List<TarefaModel>();
        private void FrmAdministracao_Load(object sender, EventArgs e)
        {  
            try
            {
                LoadComboBox();
                FirstLoad();
                List<string> historico = db.ResgataHistoricoPesquisa();
                mskData.Text = historico[0];
                mskData2.Text = historico[1];
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao resgatar histórico de pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  

        }

        private void LoadComboBox()
        {
            List<FuncionarioModel> lstTarefa1 = new List<FuncionarioModel>();

            lstTarefa1 = dbfunc.ListarFuncionarios().Where(x => x.Ativo == "S").ToList();
            lstTarefa1.Add(new FuncionarioModel { Nome = "", CodigoFunc = 0 });
            comboFunc.DataSource = lstTarefa1.OrderBy(x => x.Nome).ToList();
            comboFunc.DisplayMember = "Nome";
            comboFunc.ValueMember = "CodigoFunc";
            comboFunc.SelectedIndex = -1;


            List<TipoModel> lstTipo = new List<TipoModel>();
            lstTipo = dbtipo.ListarTipos();
            lstTipo.Add(new TipoModel { Descricao = "", CodigoTipo = 0 });
            comboTipo.DataSource = lstTipo.OrderBy(x => x.Descricao).ToList(); 
            comboTipo.DisplayMember = "Descricao";
            comboTipo.ValueMember = "CodigoTipo";
            comboTipo.SelectedIndex = -1;
        }

        private async void FirstLoad()
        {
            await Task.Run(() => lstTarefas = db.ListarTarefas().Where(x => x.StatusTarefa == "PENDENTE" || x.StatusTarefa == "EM ANDAMENTO" || x.StatusTarefa == "ATRASADO").OrderBy(x => x.DataTarefa).ToList());
            CarregarDataGrid(lstTarefas);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (mskData.Text != "  /  /" && mskData2.Text != "  /  /")
            {
                TarefaModel tarefa = new TarefaModel();
                tarefa.StatusTarefa = comboStatus.Text;
                tarefa.CodigoTipo = Convert.ToInt32(comboTipo.SelectedValue);
                tarefa.CodigoFuncionario = Convert.ToInt32(comboFunc.SelectedValue);

                lstTarefas= db.ListarTarefas(Convert.ToDateTime(mskData.Text),Convert.ToDateTime(mskData2.Text), tarefa);

                CarregarDataGrid(lstTarefas);
                GravarHistorico();

                lbltottarefas.Text = lstTarefas.Count.ToString();
                //desconsiderando os codigos de tarefas 07 e 15 para não serem contabilizados na qtd total de peças produzidas
                lbltotpecas.Text = lstTarefas.Where(x => x.CodigoTipo != 15 && x.CodigoTipo != 7).Sum(x => x.Quantidade).ToString();
                lblProva.Text = lstTarefas.Where(x => x.NomeTipo == "PROVA").Count().ToString();
                lblOutros.Text = lstTarefas.Where(x => x.NomeTipo != "PROVA").Count().ToString();
            }
            else
            {
                MessageBox.Show("Informe um periodo válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            comboTipo.SelectedIndex = -1;
            comboFunc.SelectedIndex = -1;
        }

        private void dataGridMonitor2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
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
            }
            if (e.Value != null && e.ColumnIndex == 1)
            {
                if (e.Value.Equals("ATRASADO"))
                {
                    e.CellStyle.BackColor = Color.Orange;
                }
            }

            if (e.Value != null && e.ColumnIndex == 1)
            {
                if (e.Value.Equals("FINALIZADO COM ATRASO"))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }


        }

        private void dataGridMonitor2_DoubleClick(object sender, EventArgs e)
        {
            int posicao = dataGridMonitor2.SelectedCells[0].RowIndex;
            DataGridViewRow linha = dataGridMonitor2.Rows[posicao];
            int codigo = Convert.ToInt32(linha.Cells[0].Value);

            try
            {
                FrmTarefa frm = new FrmTarefa(lstTarefas.Where(x => x.Codigo == codigo).FirstOrDefault(),this);
                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao consultar tarefa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        public void Listar()
        {
            CarregarDataGrid(db.ListarTarefas().Where(x => x.StatusTarefa == "PENDENTE" || x.StatusTarefa == "EM ANDAMENTO" || x.StatusTarefa == "ATRASADO").OrderBy(x => x.DataTarefa).ToList());
            
        }

        private void CarregarDataGrid(List<TarefaModel> lst) 
        {
            dataGridMonitor2.DataSource = null;
            dataGridMonitor2.DataSource = lst;
            dataGridMonitor2.AutoResizeColumns();
        }

        private async void GravarHistorico()
        {
           await  Task.Run(() => db.GravaHistoricoPesquisa(Convert.ToDateTime(mskData.Text), Convert.ToDateTime(mskData2.Text)));
        }

        private void dataGridMonitor2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
