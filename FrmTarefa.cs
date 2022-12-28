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
    public partial class FrmTarefa : Form
    {
        public FrmTarefa(TarefaModel _tarefa , FrmAdministracao frm)
        {
            InitializeComponent();
            tarefa = _tarefa;
            txtCod.Enabled = false;
            comboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFunc.DropDownStyle = ComboBoxStyle.DropDownList;
            frmadm = frm;
        }
        TarefaModel tarefa;
        FuncionarioADO dbfunc = new FuncionarioADO();
        TiposADO dbtipo = new TiposADO();
        TarefasADO db = new TarefasADO();
        FrmAdministracao frmadm;
        private void FrmTarefa_DoubleClick(object sender, EventArgs e)
        {

        }

        private void FrmTarefa_Load(object sender, EventArgs e)
        {
            comboFunc.DataSource = dbfunc.ListarFuncionarios().Where(x => x.Ativo == "S").ToList();
            comboFunc.DisplayMember = "Nome";
            comboFunc.ValueMember = "CodigoFunc";

            foreach (FuncionarioModel item in comboFunc.Items)
            {
                if (tarefa.NomeFuncionario == item.Nome)
                {
                    comboFunc.SelectedIndex = comboFunc.FindStringExact(tarefa.NomeFuncionario.ToString());
                    break;
                }
            }

            comboTipo.DataSource = dbtipo.ListarTipos();
            comboTipo.DisplayMember = "Descricao";
            comboTipo.ValueMember   = "CodigoTipo";

            foreach (TipoModel item in comboTipo.Items)
            {
                if (tarefa.NomeTipo == item.Descricao)
                {
                    comboTipo.SelectedIndex = comboTipo.FindStringExact(tarefa.NomeTipo.ToString());
                    break;
                }
            }

            comboStatus.Text = tarefa.StatusTarefa;
            mskData.Text = tarefa.DataTarefa.ToString();

            if (tarefa.DataEncerramento.ToString() != "01/01/0001 00:00:00")
            {
                mskDtCon.Text = tarefa.DataEncerramento.ToString();
            }
            txtCod.Text = tarefa.Codigo.ToString();
            txtObservacao.Text = tarefa.Obser;
            txtTarefa.Text = tarefa.Descricao;
            txtQuant.Text  = tarefa.Quantidade.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCod.Text !="" && mskData.Text!= "  /  /")
            {
                TarefaModel model = new TarefaModel();

                model.Codigo = Convert.ToInt32(txtCod.Text);
                model.CodigoFuncionario = Convert.ToInt32(comboFunc.SelectedValue);
                model.CodigoTipo = Convert.ToInt32(comboTipo.SelectedValue);
                if (mskDtCon.Text != "  /  /")
                {
                    model.DataEncerramento = Convert.ToDateTime(mskDtCon.Text);
                }
                model.DataTarefa = Convert.ToDateTime(mskData.Text);
                model.Descricao = txtTarefa.Text.ToUpper();
                model.Obser = txtObservacao.Text.ToUpper();
                model.StatusTarefa = comboStatus.Text;
                model.Quantidade = Convert.ToInt32(txtQuant.Text);

                if (model.DataEncerramento != null)
                {
                    if (model.DataEncerramento > model.DataTarefa)
                    {
                        model.StatusTarefa = "FINALIZADO COM ATRASO";
                    }
                }
                

                try
                {
                    db.Alterar(model);
                    MessageBox.Show("Tarefa modificada com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmadm.Listar();
                    this.Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao modificar tarefa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mskData.Text = "";
            txtTarefa.Text = "";
            txtObservacao.Text = "";
            comboStatus.Text = "";
            txtQuant.Text = "";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text !="")
            {
                try
                {
                    db.DeletarTarefa(Convert.ToInt32(txtCod.Text));
                    MessageBox.Show("Tarefa removida com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmadm.Listar();
                    this.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao deletar tarefa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtObservacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
