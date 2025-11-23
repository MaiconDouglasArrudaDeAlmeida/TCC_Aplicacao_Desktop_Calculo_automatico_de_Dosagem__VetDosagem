using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace VetDosagem
{
    public partial class btnLimpar : Form
    {
        public btnLimpar()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            string caminhoArquivo = "historico.json";

            // 1. Verifica se o arquivo existe
            if (File.Exists(caminhoArquivo))
            {
                try
                {
                    // 2. Lê o texto do arquivo
                    string json = File.ReadAllText(caminhoArquivo);

                    // 3. Converte de volta para Lista de Calculo
                    List<Calculo> lista = JsonConvert.DeserializeObject<List<Calculo>>(json);

                    // 4. Joga a lista dentro da Tabela (Grid)
                    dgvHistorico.DataSource = lista;

                    //Ajustes visuais
                    ConfigurarColunas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao ler histórico: " + ex.Message);
                }
            }
            else
            {
                // Se não tiver arquivo, não faz nada (a tabela fica vazia)
                // Ou pode mostrar um aviso: MessageBox.Show("Nenhum histórico encontrado.");
            }
        }

        private void ConfigurarColunas()
        {
            // Só funciona se tiver dados. Renomeia os cabeçalhos para português.
            if (dgvHistorico.Columns.Count > 0)
            {
                dgvHistorico.Columns["ResultadoMl"].HeaderText = "Resultado (ml)";
                dgvHistorico.Columns["Peso"].HeaderText = "Peso (kg)";
                dgvHistorico.Columns["Dose"].HeaderText = "Dose (mg/kg)";
                dgvHistorico.Columns["Concentracao"].HeaderText = "Conc. (mg/ml)";

                // Ajusta a largura para caber tudo
                dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pergunta de segurança
            if (MessageBox.Show("Tem certeza? Isso apagará todo o histórico permanentemente.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string caminhoArquivo = "historico.json";

                    // 1. Apaga o arquivo físico
                    if (System.IO.File.Exists(caminhoArquivo))
                    {
                        System.IO.File.Delete(caminhoArquivo);
                    }

                    // 2. Limpa a tabela 
                    dgvHistorico.DataSource = null;

                    MessageBox.Show("Histórico limpo com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao limpar: " + ex.Message);
                }
            }
        }
    }
}