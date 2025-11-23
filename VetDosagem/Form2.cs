using System;
using System.Drawing; // Para cores
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VetDosagem
{
    public partial class Form2 : Form
    {
        // Construtor que recebe o valor da Tela 1
        public Form2(double valorRecebido)
        {
            InitializeComponent();

            // 1. Configura o Texto do Resultado
            lblResultadoFinal.Text = valorRecebido.ToString("F2") + " ml";

            // 2. Chama a função para criar o gráfico
            CriarGrafico(valorRecebido);
        }

        private void CriarGrafico(double valor)
        {
            // Limpa o painel para garantir
            pnlGrafico.Controls.Clear();

            // Cria o objeto do Gráfico
            Chart grafico = new Chart();
            grafico.Dock = DockStyle.Fill; // Preenche todo o painel
            grafico.BackColor = Color.WhiteSmoke;

            // Cria a Área do Gráfico
            ChartArea area = new ChartArea("AreaPrincipal");
            grafico.ChartAreas.Add(area);

            // Cria a Série (Os dados) - Tipo Coluna
            Series serie = new Series("Dose");
            serie.ChartType = SeriesChartType.Column; // Gráfico de Barras Verticais
            serie.IsValueShownAsLabel = true; // Mostra o número em cima da barra

            // Adiciona o ponto (A barra com o valor calculado)
            int ponto = serie.Points.AddXY("Dose Recomendada", valor);

            // Estilizando a barra
            serie.Points[ponto].Color = Color.CornflowerBlue; // Cor Azul
            serie.Points[ponto].Font = new Font("Arial", 12, FontStyle.Bold);

            // Adiciona a série ao gráfico
            grafico.Series.Add(serie);

            // Adiciona o gráfico pronto ao Painel da tela
            pnlGrafico.Controls.Add(grafico);
        }

        // botão de voltar
        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}