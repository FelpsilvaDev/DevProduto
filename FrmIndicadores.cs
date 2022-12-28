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
    public partial class FrmIndicadores : Form
    {
        public FrmIndicadores()
        {
            InitializeComponent();
        }
        TarefasADO tarefasADO = new TarefasADO();
        TiposADO tiposADO = new TiposADO();
        FuncionarioADO funcioADO = new FuncionarioADO();
        FaltasADO faltasADO = new FaltasADO();

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (mskData1.Text != "  /  /" && mskData2.Text != "  /  /")
            {
                GerarGrafico();
            }
            else
            {
                MessageBox.Show("Digite um período válido","Erro",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

           
        }

        private void GerarGrafico()
        {
            DateTime dt1;
            DateTime dt2;

            dt1 = Convert.ToDateTime(mskData1.Text);
            dt2 = Convert.ToDateTime(mskData2.Text);

            List<TarefaModel> lstTarefas = tarefasADO.ListarTarefas().Where(x => x.DataTarefa >= dt1 && x.DataTarefa <= dt2).ToList();
            List<TipoModel> lstTipos = tiposADO.ListarTipos();
            List<FuncionarioModel> lstFunc = funcioADO.ListarFuncionarios();
            List<FaltaModel> lstFaltas = faltasADO.ListarFaltas().Where(x => x.DataFalta >= dt1 && x.DataFalta <= dt2).ToList();

            List<IndicadorModel> lstchart1 = new List<IndicadorModel>();
            List<IndicadorModel> lstchart2 = new List<IndicadorModel>();
            List<IndicadorModel> lstchart3 = new List<IndicadorModel>();
            List<IndicadorModel> lstchart4 = new List<IndicadorModel>();


            // Buscando Tarefas por Tipo

            foreach (var item in lstTipos)
            {
                IndicadorModel indic = new IndicadorModel();

                foreach (var tarefa in lstTarefas.Where(x => x.NomeTipo == item.Descricao))
                {
                    indic.Param1 = item.Descricao;
                    indic.Param2 += 1;
                }

                if (indic.Param1 != null)
                {
                    lstchart1.Add(indic);
                }

            }

            //Buscando Quantidade produzida por tipo
            foreach (var item in lstTipos)
            {

                IndicadorModel indic = new IndicadorModel();

                foreach (var tarefa in lstTarefas.Where(x => x.NomeTipo == item.Descricao))
                {
                    indic.Param1 = item.Descricao;
                    indic.Param2 += tarefa.Quantidade;
                }

                if (indic.Param1 != null)
                {
                    lstchart2.Add(indic);
                }

            }

            // Buscando Faltas por funcionarios

            if (lstFaltas.Count > 0)
            {
                foreach (var item in lstFunc)
                {
                    IndicadorModel indic = new IndicadorModel();

                    foreach (var faltas in lstFaltas.Where(x => x.CodigoFuncionario == item.CodigoFunc))
                    {
                        indic.Param1 = item.Nome;
                        indic.Param2 += 1;
                    }

                    if (indic.Param1 != null)
                    {
                        lstchart3.Add(indic);
                    }

                }
            }
            
            // Buscando Produção por funcionarios
            foreach (var item in lstFunc)
            {
                IndicadorModel indic = new IndicadorModel();

                foreach (var tarefas in lstTarefas.Where(x => x.CodigoFuncionario == item.CodigoFunc))
                {
                    indic.Param1 = item.Nome;
                    indic.Param2 += 1;
                }

                if (indic.Param1 != null)
                {
                    lstchart4.Add(indic);
                }

            }

            // Alimentando charts 
            foreach (var item in lstchart1)
            {
                chartTipos.Series["Tipos"].Points.AddXY(item.Param1, item.Param2);
            }
            foreach (var item in lstchart2)
            {
                chartQuant.Series["Quantidade"].Points.AddXY(item.Param1, item.Param2);
            }
            foreach (var item in lstchart3)
            {
                chartFaltas.Series["Faltas"].Points.AddXY(item.Param1, item.Param2);
            }
            foreach (var item in lstchart4)
            {
                chartFunc.Series["Quantidade"].Points.AddXY(item.Param1, item.Param2);
            }
        }

        private void chartFunc_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmIndicadores_Load(object sender, EventArgs e)
        {

        }
    }
}
