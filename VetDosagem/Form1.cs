using System;
using System.Windows.Forms;

namespace VetDosagem 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // 1. Definição das variáveis
            double peso, dose, concentracao, resultado;

            // 2. Validação: Tenta converter o texto para número
            // Se o usuário digitar letras ou deixar vazio, avisa o erro.
            if (!double.TryParse(txtPeso.Text, out peso))
            {
                MessageBox.Show("Digite um valor válido para o Peso.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPeso.Focus();
                return;
            }

            if (!double.TryParse(txtDose.Text, out dose))
            {
                MessageBox.Show("Digite um valor válido para a Dose.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDose.Focus();
                return;
            }

            if (!double.TryParse(txtConcentracao.Text, out concentracao))
            {
                MessageBox.Show("Digite um valor válido para a Concentração.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConcentracao.Focus();
                return;
            }

            // Evitar divisão por zero
            if (concentracao == 0)
            {
                MessageBox.Show("A concentração não pode ser zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. O Cálculo: (Peso * Dose) / Concentração
            try
            {
                resultado = (peso * dose) / concentracao;
                SalvarNoHistorico(peso, dose, concentracao, resultado);

                // 4. Resultado 
                Form2 telaResultado = new Form2(resultado);
                telaResultado.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no cálculo: " + ex.Message);
            }
        }

        private void btnVerHistorico_Click(object sender, EventArgs e)
        {
            btnLimpar telaHistorico = new btnLimpar();
            telaHistorico.ShowDialog(); // Abre a tela e espera fechar
        }
    

    // SALVAR HISTORICO
        private void SalvarNoHistorico(double peso, double dose, double conc, double resultado)
        {
            try
            {
                string caminhoArquivo = "historico.json";
                System.Collections.Generic.List<Calculo> listaCalculos = new System.Collections.Generic.List<Calculo>();

                // Se já existe arquivo, lê o que tem antes
                if (System.IO.File.Exists(caminhoArquivo))
                {
                    string jsonAntigo = System.IO.File.ReadAllText(caminhoArquivo);
                    listaCalculos = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Collections.Generic.List<Calculo>>(jsonAntigo) ?? new System.Collections.Generic.List<Calculo>();
                }

                // Cria o novo registro
                Calculo novoCalculo = new Calculo
                {
                    Data = DateTime.Now,
                    Peso = peso,
                    Dose = dose,
                    Concentracao = conc,
                    ResultadoMl = resultado
                };

                // Adiciona e salva
                listaCalculos.Add(novoCalculo);
                string jsonNovo = Newtonsoft.Json.JsonConvert.SerializeObject(listaCalculos, Newtonsoft.Json.Formatting.Indented);
                System.IO.File.WriteAllText(caminhoArquivo, jsonNovo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }
    }
}
