﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN01_WFCadastroContato
{
    public class Pessoa
    {
        public Pessoa(string? nomeCompleto, string? dddTelefone, DateTime dataNascmento, string? escolaridade, char sexo, double rendaMensal, bool possuiFilhos)
        {
            NomeCompleto = nomeCompleto;
            DddTelefone = dddTelefone;
            DataNascmento = dataNascmento;
            Escolaridade = escolaridade;
            Sexo = sexo;
            RendaMensal = rendaMensal;
            PossuiFilhos = possuiFilhos;
        }

        public Pessoa()
        {

        }

        public static List<Pessoa> ListaPessoas = new List<Pessoa>();

        public string? NomeCompleto { get; set; }
        public string? DddTelefone { get; set; }
        public DateTime DataNascmento { get; set; }
        public string? Escolaridade { get; set; }
        public char Sexo { get; set; }
        public double RendaMensal { get; set; }
        public bool PossuiFilhos { get; set; }

    }
}
