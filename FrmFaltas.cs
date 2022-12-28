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
    public partial class FrmFaltas : Form
    {
        public FrmFaltas(int codigo)
        {
            InitializeComponent();

            codigointerno = codigo;
            dataGridFaltas.AutoGenerateColumns = false;
        }
        int codigointerno;
        int codigofalta;

        FaltasADO db = new FaltasADO();
        private void button2_Click(object sender, EventArgs e)
        {
            if (mskData1.Text !="  /  / " && mskdata2.Text != "  /  / ")
            {
                try
                {
                    BuscarHistorico(Convert.ToDateTime(mskData1.Text), Convert.ToDateTime(mskdata2.Text));
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao buscar histórico " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Informe um período válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmFaltas_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            dataGridFaltas.DataSource = null;
            dataGridFaltas.DataSource = db.ListarFaltas().Where(x => x.CodigoFuncionario == codigointerno).OrderByDescending(x => x.DataFalta).ToList();
            dataGridFaltas.AutoResizeColumns();

            lblfaltas.Text = dataGridFaltas.RowCount.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(codigointerno != 0 && txtMotivo.Text !="" && mskDataFalta.Text !="  /  / ")
            {
                FaltaModel faltaModel = new FaltaModel();

                faltaModel.CodigoFuncionario = codigointerno;
                faltaModel.DataFalta = Convert.ToDateTime(mskDataFalta.Text);
                faltaModel.Motivo = txtMotivo.Text.ToUpper();


                try
                {
                    if (btnAdicionar.Text == "Deletar")
                    {
                        db.Deletar(codigofalta);
                        MessageBox.Show("Falta deletada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        db.Adicionar(faltaModel);
                        MessageBox.Show("Falta adicionada com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    LimparCampos();
                    CarregarDataGrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao incluir falta " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void LimparCampos()
        {
            txtMotivo.Text = "";
            mskDataFalta.Text = "";
            btnAdicionar.Text = "Incluir";
        }

        private void dataGridFaltas_DoubleClick(object sender, EventArgs e)
        {
            int posicao = dataGridFaltas.SelectedCells[0].RowIndex;
            DataGridViewRow linha = dataGridFaltas.Rows[posicao];
            int codigo = Convert.ToInt32(linha.Cells[0].Value);

            try
            {
                FaltaModel falta = new FaltaModel();

                falta = db.ListarFaltas().Where(x => x.Codigo == codigo).FirstOrDefault();
                codigofalta = codigo;

                txtMotivo.Text = falta.Motivo;
                mskDataFalta.Text = falta.DataFalta.ToString();

                btnAdicionar.Text = "Deletar";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao consultar falta " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarHistorico(DateTime dt1 , DateTime dt2)
        {
            dataGridFaltas.DataSource = null;
            dataGridFaltas.DataSource = db.ListarFaltas().Where(x => x.CodigoFuncionario == codigointerno && x.DataFalta >= dt1 && x.DataFalta <= dt2).OrderByDescending(x => x.DataFalta).ToList();
            dataGridFaltas.AutoResizeColumns();

            lblfaltas.Text = dataGridFaltas.RowCount.ToString();
        }
    }
}
