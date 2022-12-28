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
    public partial class FrmDescricoes : Form
    {
        public FrmDescricoes()
        {
            InitializeComponent();

            dataGridTipos.AutoGenerateColumns = false;
        }

        TiposADO db = new TiposADO();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtDescricao.Text !="")
            {
                try
                {
                    TipoModel tipo = new TipoModel();
                    tipo.Descricao = txtDescricao.Text.ToUpper();
                    
                    if (btnAdd.Text == "Alterar")
                    {
                        tipo.CodigoTipo = Convert.ToInt32(txtCodigo.Text);
                        db.Alterar(tipo);
                        MessageBox.Show("Descrição alterada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        db.Adicionar(tipo);
                        MessageBox.Show("Descrição cadastrada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    CarregarDataGrid();
                    LimparCampos();

                        
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao cadastrar/alterar descrição", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CarregarDataGrid()
        {
            try
            {
                dataGridTipos.DataSource = null;
                dataGridTipos.DataSource = db.ListarTipos();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao consultar descrições", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            btnAdd.Text = "Adicionar";
        }

        private void dataGridTipos_DoubleClick(object sender, EventArgs e)
        {
            int posicao = dataGridTipos.SelectedCells[0].RowIndex;
            DataGridViewRow linha = dataGridTipos.Rows[posicao];
            int codigo = Convert.ToInt32(linha.Cells[0].Value);

            try
            {
                TipoModel tipo = db.ListarTipos().Where(x => x.CodigoTipo == codigo).FirstOrDefault();

                txtCodigo.Text = tipo.CodigoTipo.ToString();
                txtDescricao.Text = tipo.Descricao.ToString();

                btnAdd.Text = "Alterar";
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao consultar descrições", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDescricoes_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            CarregarDataGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            this.Close();
        }
    }
}
