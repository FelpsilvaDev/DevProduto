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
    public partial class FrmCalendario : Form
    {
        public FrmCalendario()
        {
            InitializeComponent();

            comboCalendario.DropDownStyle = ComboBoxStyle.DropDownList;
            
            dataGridCalendario.AutoGenerateColumns = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
        }

        List<TarefaModel> listtarefas = new List<TarefaModel>();
        TarefasADO banco = new TarefasADO();
        private class Dates
        {
            public DateTime DataMes { get; set; }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (mskData.Text != "  /  /" && mskData2.Text != "  /  /")
            {
                var listadatas = CalcularTempo(Convert.ToDateTime(mskData.Text), Convert.ToDateTime(mskData2.Text));

                FuncionarioADO funcionarioADO = new FuncionarioADO();
                var listfunc = funcionarioADO.ListarFuncionarios().Where(x => x.Ativo == "S").ToList();

                listtarefas.Clear();

                if (listadatas.Count > 0)
                {
                    foreach (var item in listadatas)
                    {

                        if (comboCalendario.SelectedValue == null || comboCalendario.SelectedValue.Equals(0))
                        {
                            foreach (var func in listfunc)
                            {

                                TarefaModel tarefa = new TarefaModel();

                                tarefa.CodigoFuncionario = func.CodigoFunc;
                                tarefa.NomeFuncionario = func.Nome;
                                tarefa.DataTarefa = item.DataMes;
                                tarefa.CodigoTipo = 11;
                                tarefa.NomeTipo = "PROGRAMAR";
                                tarefa.Quantidade = 1;
                                tarefa.StatusTarefa = "PENDENTE";
                                

                                listtarefas.Add(tarefa);

                            }
                        }
                        else
                        {
                           TarefaModel tarefa = new TarefaModel();

                            tarefa.CodigoFuncionario = Convert.ToInt32(comboCalendario.SelectedValue);
                            tarefa.NomeFuncionario = comboCalendario.Text;
                            tarefa.DataTarefa = item.DataMes;
                            tarefa.CodigoTipo = 11;
                            tarefa.NomeTipo = "PROGRAMAR";
                            tarefa.Quantidade = 1;
                            tarefa.StatusTarefa = "PENDENTE";
                                                        
                            listtarefas.Add(tarefa);

                        }

                    }
                }

                dataGridCalendario.DataSource = null;
                dataGridCalendario.DataSource = listtarefas;
                btnGerar.Enabled = false;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }

        }

        private List<Dates> CalcularTempo(DateTime dt1, DateTime dt2)
        {
            TimeSpan resultado = dt2 - dt1;

            string days = resultado.ToString();

            int pDias = 0;

            pDias = Convert.ToInt32(days.Substring(0, 2).Replace(".", null));


            List<Dates> lstrange = new List<Dates>();


            while (pDias >= 0)
            {
                Dates date = new Dates();

                if (dt1.DayOfWeek != DayOfWeek.Saturday && dt1.DayOfWeek != DayOfWeek.Sunday)
                {
                    date.DataMes = dt1;

                    lstrange.Add(date);

                }
                dt1 = dt1.AddDays(1);
                pDias--;
            }

            return lstrange;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGerar.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            mskData.Focus();

            dataGridCalendario.DataSource = null;
            

            mskData.Clear();
            mskData2.Clear();
            comboCalendario.SelectedIndex = -1;
            
        }        
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja realmente programar essas datas ?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            int controle = 0;
            if (dialog == DialogResult.Yes)
            {
                if (listtarefas.Count > 0)
                {
                    foreach (var item in listtarefas)
                    {
                        try
                        {
                            banco.Adicionar(item);
                        }
                        catch (Exception)
                        {
                            controle = 1;
                            MessageBox.Show("Erro ao incluir tarefas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    if (controle == 1)
                    {
                        MessageBox.Show("Carga finalizada com erros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Carga completamente finalizada sem erros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    btnCancelar.PerformClick();

                }


            }
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {

            FuncionarioADO combocd = new FuncionarioADO();

            List<FuncionarioModel> funcionarios = new List<FuncionarioModel>();
            funcionarios = combocd.ListarFuncionarios().Where(x => x.Ativo == "S").ToList();
            funcionarios.Add(new FuncionarioModel { Nome = "" , CodigoFunc = 0 });

            comboCalendario.DataSource = null;
            comboCalendario.DataSource = funcionarios.OrderBy(x => x.Nome).ToList();
            comboCalendario.DisplayMember = "Nome";
            comboCalendario.ValueMember = "CodigoFunc";
            comboCalendario.SelectedIndex = -1;

                   
        }
       
    }
}