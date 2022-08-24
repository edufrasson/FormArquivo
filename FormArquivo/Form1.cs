using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Properties;
using System.IO;

namespace FormArquivo
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        double total;
        double selecao;

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDespesas.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            dgvDespesas.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dgvDespesas.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgvDespesas.Columns.Insert(3, new DataGridViewTextBoxColumn());

            dgvDespesas.Columns[0].Name = "OK";
            dgvDespesas.Columns[1].Name = "CODIGO";
            dgvDespesas.Columns[2].Name = "DESCRICAO";
            dgvDespesas.Columns[3].Name = "VALOR";

            dgvDespesas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDespesas.ReadOnly = true;
            dgvDespesas.AllowUserToAddRows = false;
            dgvDespesas.AllowUserToDeleteRows = false;
            this.dgvDespesas.AllowUserToOrderColumns = true;

            dgvDespesas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDespesas.Columns[3].DefaultCellStyle.Format = "###, ###, ##0.00";
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            dgvDespesas.RowCount = 0;

            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();

            StreamReader arquivo = File.OpenText(ofdArquivo.FileName);

            String linha;

            while((linha = arquivo.ReadLine()) != null)
            {
                string[] dados = linha.Split(';');
                string codigo = dados[0];
                string descricao = dados[1];
                double valor = double.Parse(dados[2]);

                dgvDespesas.Rows.Add(false, codigo, descricao, valor);

                total += valor;
            }

            lblTotal.Text = total.ToString("C");
        }

        private void dgvDespesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDespesas.Rows.Count > 0 && e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dgvDespesas.CurrentRow.Cells[0].Value) == false)
                {
                    dgvDespesas.CurrentRow.Cells[0].Value = true;
                    selecao += Convert.ToDouble(dgvDespesas.CurrentRow.Cells[3].Value);
                }
            }
            else
            {

                dgvDespesas.CurrentRow.Cells[0].Value = false;
                selecao -= Convert.ToDouble(dgvDespesas.CurrentRow.Cells[3].Value);
            }

            lblSelecao.Text = selecao.ToString("C");
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach(DataGridViewRow linha in dgvDespesas.Rows)
            {
                linha.Cells[0].Value = true;
                selecao += Convert.ToDouble(linha.Cells[3].Value);
            }
            lblSelecao.Text = selecao.ToString("C");
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach (DataGridViewRow linha in dgvDespesas.Rows)            
                linha.Cells[0].Value = false;               
            
            lblSelecao.Text = selecao.ToString("C");
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            for(int i = dgvDespesas.RowCount - 1; i >- 0; i--)
            {
                if (Convert.ToBoolean(dgvDespesas.Rows[i].Cells[0].Value) == true)
                {
                    selecao -= Convert.ToDouble(dgvDespesas.Rows[i].Cells[3].Value);
                    total -= Convert.ToDouble(dgvDespesas.Rows[i].Cells[3].Value);
                    dgvDespesas.Rows.Remove(dgvDespesas.Rows[i]);
                }
            }

            lblSelecao.Text = selecao.ToString("C");
            lblTotal.Text = total.ToString("C");
        }
    }
}
