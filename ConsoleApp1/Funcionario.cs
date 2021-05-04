﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double percent)
        {
            Salario += Salario * (percent / 100.0);
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
