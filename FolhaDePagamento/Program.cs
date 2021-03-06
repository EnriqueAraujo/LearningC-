﻿using System;
using FolhaDePagamento.auxiliares;

namespace FolhaDePagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages.inicio();

            int qtdCadastros;
            double valorHora = 0;
            double valorHoraExtra = 0;
            double valorHoraExtraUnidade = 0;
            double salarioBruto = 0;
            double salarioBrutoAux = 0;
            double inss = 0;
            double ir = 0;
            double salarioLiquido = 0;
            double deducao = 0;

            Console.WriteLine("Digite a quantidade de folhas a serem calculadas");
            qtdCadastros = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("\n====================================================\n");

            Pessoa[] qtdPessoas = new Pessoa[qtdCadastros];


            for (int i = 0; i < qtdCadastros; i++)
            {

                Console.WriteLine("Digite o nome do funcionário");
                Pessoa cadastro = new Pessoa();
                cadastro.nome = Console.ReadLine();
                Console.WriteLine("\n====================================================\n");
                qtdPessoas[i] = cadastro;

                Metodos.coletarInformações(ref cadastro, ref i, ref valorHora, ref valorHoraExtra, ref salarioBruto, ref salarioBrutoAux, ref valorHoraExtraUnidade);

                Metodos.calcInss(ref salarioBrutoAux, ref inss); 

                Metodos.baseCalculo(ref cadastro, ref salarioBrutoAux, ref inss);

                Metodos.calcIr(ref cadastro, ref salarioBrutoAux, ref ir, ref salarioLiquido, ref deducao);

                Messages.operacaoRealizada(ref salarioBruto, ref valorHora, ref valorHoraExtraUnidade, ref valorHoraExtra, ref inss, ref ir, ref salarioLiquido, ref cadastro);
            }

        }

    }
 }
