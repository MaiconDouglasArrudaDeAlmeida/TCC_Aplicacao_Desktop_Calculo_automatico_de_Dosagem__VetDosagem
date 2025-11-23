using System;

namespace VetDosagem
{
    //  classe serve apenas para transportar os dados
    public class Calculo
    {
        public DateTime Data { get; set; }
        public double Peso { get; set; }
        public double Dose { get; set; }
        public double Concentracao { get; set; }
        public double ResultadoMl { get; set; }
    }
}