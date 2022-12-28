using Desenvolvimento_de_Produto.MODELS;
using Desenvolvimento_de_Produto.ADONET;
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
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
            comoAtivo.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridFuncionarios.AutoGenerateColumns = false;
            txtCodigo.Enabled = false;
        }

        FuncionarioADO db = new FuncionarioADO();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && comoAtivo.Text !="")
            {
                FuncionarioModel model = new FuncionarioModel();

                model.Nome = txtNome.Text.ToUpper();

                if (comoAtivo.Text == "SIM")
                {
                    model.Ativo = "S";
                }
                else
                {
                    model.Ativo = "N";
                }

                model.DtCadastro = DateTime.Now;

                try
                {
                    if (btnAdd.Text == "Alterar")
                    {
                        model.CodigoFunc = Convert.ToInt32(txtCodigo.Text);
                        db.Alterar(model);
                        MessageBox.Show("Funcionário alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        db.Adicionar(model);
                        MessageBox.Show("Funcionário cadastrado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }

                    LimparCampos();
                    CarregarDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar funcionário: "+ ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
            btnFaltas.Enabled = false;
        }

        private void CarregarDataGrid()
        {
            try
            {
                dataGridFuncionarios.DataSource = null;
                dataGridFuncionarios.DataSource = db.ListarFuncionarios();
                dataGridFuncionarios.AutoResizeColumns();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao consultar funcionários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dataGridSolicitacoes_DoubleClick(object sender, EventArgs e)
        {
            int posicao = dataGridFuncionarios.SelectedCells[0].RowIndex;
            DataGridViewRow linha = dataGridFuncionarios.Rows[posicao];
            int codigo = Convert.ToInt32(linha.Cells[0].Value);

            try
            {
                FuncionarioModel funcionario = db.ListarFuncionarios().Where(x => x.CodigoFunc == codigo).FirstOrDefault();

                txtNome.Text = funcionario.Nome;

                if (funcionario.Ativo == "S")
                {
                    comoAtivo.Text = "SIM";
                }
                else
                {
                    comoAtivo.Text = "NÃO";
                }

                btnAdd.Text = "Alterar";
                txtCodigo.Text = funcionario.CodigoFunc.ToString();
                btnFaltas.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao consultar funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            btnAdd.Text = "Adicionar";
            btnFaltas.Enabled = false;
        }

        private void btnFaltas_Click(object sender, EventArgs e)
        {
            FrmFaltas frmFaltas = new FrmFaltas(Convert.ToInt32(txtCodigo.Text));
            frmFaltas.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
