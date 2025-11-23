# TCC Aplicacao Desktop Calculo_automatico de Dosagem

> Trabalho de Conclusão de Curso (TCC) - Parte Prática

![Status](https://img.shields.io/badge/Status-Concluído-brightgreen)
![Technology](https://img.shields.io/badge/Linguagem-C%23-blue)
![Platform](https://img.shields.io/badge/Plataforma-Windows_Forms-purple)

## 📖 Sobre o Projeto

O **VetDosagem** é uma aplicação desktop desenvolvida para auxiliar profissionais e estudantes de medicina veterinária no cálculo preciso de administração de medicamentos.

O objetivo principal é mitigar erros humanos em cálculos manuais, oferecendo uma interface segura, validação de dados e visualização gráfica dos resultados. O projeto foi desenvolvido com foco em usabilidade e funcionamento *offline* (serverless), ideal para ambientes clínicos sem dependência de internet.

---

## ⚙️ Funcionalidades

- Cálculo Automatizado:** Processa o volume a ser administrado com base no Peso (kg), Dose (mg/kg) e Concentração (mg/ml).
- Segurança e Validação:** Bloqueia entradas inválidas (textos, nulos ou zeros) prevenindo erros aritméticos.
- Visualização Gráfica:** Gera gráficos nativos dinâmicos para conferência visual da dosagem.
- Histórico Local (JSON):** Salva automaticamente todos os cálculos realizados em arquivo local, permitindo consulta posterior.
- Gestão de Dados:** Permite a limpeza do histórico e manutenção dos registros.

---

##  Tecnologias Utilizadas

- Linguagem: C#
- Framework:** .NET 6.0 / 8.0 (Windows Forms App)
- IDE: Visual Studio Community
- Bibliotecas:**
    * `Newtonsoft.Json` (Persistência de dados)
    * `System.Windows.Forms.DataVisualization` (Gráficos Nativos)

---

## Telas do Sistema

### 1. Tela Principal (Cálculo e Validação)
Interface limpa para inserção de dados com tratamento de erros.
<img width="800" height="480" alt="image" src="https://github.com/user-attachments/assets/c3406c1c-e370-4d8c-837e-07b50d09ea04" />


### 2. Resultado e Gráfico
Visualização clara do volume calculado.
<img width="797" height="484" alt="image" src="https://github.com/user-attachments/assets/c62b173f-6f60-4011-a37b-8d1fedbf07a9" />


### 3. Histórico de Atendimentos
Tabela com registro de todos os cálculos salvos.
<img width="797" height="478" alt="image" src="https://github.com/user-attachments/assets/3fb68041-4a23-4dec-baef-8dec1848617e" />


---

## Como Executar o Projeto

### Pré-requisitos
- Sistema Operacional Windows 8 ou superior.
- [.NET Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) instalado (caso vá rodar apenas o executável).
- Visual Studio (caso queira editar o código).

### Passo a Passo
1.  Clone este repositório:
    ```bash
    git clone [https://github.com/SEU-USUARIO/VetDosagem.git](https://github.com/SEU-USUARIO/VetDosagem.git)
    ```
2.  Abra o arquivo `VetDosagem.sln` no Visual Studio.
3.  Restaure os pacotes NuGet (se necessário).
4.  Clique em Iniciar (ou F5) para compilar e rodar.

---

## Estrutura do Código

O projeto segue a arquitetura de eventos do Windows Forms:
* `Calculo.cs`: Modelo de dados (DTO).
* `Form1.cs`: Lógica de entrada, validação e controle principal.
* `Form2.cs`: Renderização gráfica.
* `Form3.cs`: Leitura e manipulação do histórico JSON.

---

## Autor

Desenvolvido por MAICON DOUGLAS ARRUDA DE ALMEIDA como requisito para obtenção de grau no curso de ENGENHARIA DE SOFTWARE.

---
