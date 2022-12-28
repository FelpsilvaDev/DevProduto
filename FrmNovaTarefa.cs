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
    public partial class FrmNovaTarefa : Form
    {
        public FrmNovaTarefa()
        {
            InitializeComponent();
            comboFunc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        FuncionarioADO dbfunc = new FuncionarioADO();
        TarefasADO dbtaref = new TarefasADO();
        TiposADO dbtipo = new TiposADO();
        
        private void FrmNovaTarefa_Load(object sender, EventArgs e)
        {
            comboFunc.DataSource = null;
            comboFunc.DataSource = dbfunc.ListarFuncionarios().Where(x => x.Ativo == "S").ToList();
            comboFunc.DisplayMember = "Nome";
            comboFunc.ValueMember = "CodigoFunc";
            comboFunc.SelectedIndex = -1;

            comboTipo.DataSource = null;
            comboTipo.DataSource = dbtipo.ListarTipos();
            comboTipo.DisplayMember = "Descricao";
            comboTipo.ValueMember = "CodigoTipo";
            comboTipo.SelectedIndex = -1;



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mskData.Text != "  /  / " && txtTarefa.Text !="" && comboTipo.Text !="" && comboFunc.Text !="")
            {
                TarefaModel model = new TarefaModel();

                model.CodigoFuncionario = Convert.ToInt32(comboFunc.SelectedValue);
                model.CodigoTipo = Convert.ToInt32(comboTipo.SelectedValue);
                model.DataTarefa = Convert.ToDateTime(mskData.Text);
                model.Descricao = txtTarefa.Text.ToUpper();
                model.Quantidade = Convert.ToInt32(mskQuant.Text);
                model.Obser = txtObservacao.Text.ToUpper();
                model.StatusTarefa = "PENDENTE";

                try
                {
                    dbtaref.Adicionar(model);
                    MessageBox.Show("Tarefa adicionada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao cadastrar tarefa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Preencha os campos obrigatórios " , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            comboFunc.Text = "";
            comboTipo.Text = "";
            mskData.Text = "";
            mskQuant.Text = "";
            txtTarefa.Text = "";
            txtObservacao.Text = "";
            this.Close();
        }

        private void comboFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTarefa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
