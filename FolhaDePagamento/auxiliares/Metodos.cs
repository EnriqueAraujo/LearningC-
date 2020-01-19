using System;

namespace FolhaDePagamento.auxiliares
{
    public class Metodos
    {
        public  void metodo(Pessoa[] pessoa)
        {
            Pessoa novaPessoa = new Pessoa();
            novaPessoa.salario = 1500;
            pessoa[0] = novaPessoa;

            Console.WriteLine(pessoa[0].salario);
        }

        public static void coletarInformações(ref Pessoa cadastro, ref int i, ref double valorHora, ref double valorHoraExtra, ref double salarioBruto, ref double salarioBrutoAux, ref double valorHoraExtraUnidade)
        {

            Console.WriteLine($"Digite o salário do {cadastro.nome} ° funcionário");
            cadastro.salario = Convert.ToDouble(Console.ReadLine());

            valorHora = (cadastro.salario/220);

            Console.WriteLine("Informe a quantidade de filhos do funcionário");
            cadastro.filhos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informa a quantidade de horas extras");
            cadastro.qtdHorasExtras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem do valor da hora extra, em %");
            cadastro.percentHoraExtra = Convert.ToInt32(Console.ReadLine());
            cadastro.percentHoraExtra = (1 + (cadastro.percentHoraExtra / 100));
            valorHoraExtra = ((valorHora * cadastro.percentHoraExtra) * cadastro.qtdHorasExtras);

            valorHoraExtraUnidade = (valorHora * cadastro.percentHoraExtra);

            salarioBruto = (cadastro.salario + valorHoraExtra);

            salarioBrutoAux = salarioBruto;
    
         }

        public static void calcInss(ref double salarioBrutoAux, ref double inss)
        {
            if (salarioBrutoAux <= 1751.81)
            {
                inss = (salarioBrutoAux * 0.08);
            }
            
            else if ((salarioBrutoAux > 1752.81) && (salarioBrutoAux <= 2919.72))
            {
                inss = (salarioBrutoAux * 0.9);
            }
            
            else if ((salarioBrutoAux > 2919.72) && (salarioBrutoAux < 5839.45))
            {
                inss = (salarioBrutoAux * 0.11);
            }

            else if (salarioBrutoAux > 5839.45)
            {
                inss = 642.34;
            }
        }

        public static void baseCalculo(ref double salarioBrutoAux, ref double inss)
        {
            salarioBrutoAux -= inss;

            salarioBrutoAux -= inss;
        }

        public static void calcIr(ref double salarioBrutoAux, ref double ir, ref double salarioLiquido, ref double deducao)
        {

            if (salarioBrutoAux < 1903.99)
            {
                ir = 0;
                deducao = 0;
            }
            
            else if ((salarioBrutoAux >= 1903.99) && (salarioBrutoAux < 2826.66))
            {
                ir = (salarioBrutoAux * 0.075);
                deducao = 142.80;
            }
                
            else if ((salarioBrutoAux >= 2826.66) && (salarioBrutoAux < 3751.06))
            {
                ir = (salarioBrutoAux * 0.15);
                deducao = 354.80;
            }
                
            else if ((salarioBrutoAux >= 3751.06) && (salarioBrutoAux < 4664.69))
            {
                ir = (salarioBrutoAux * 0.225);
                deducao = 636.13;
            }
                
            else if (salarioBrutoAux >= 4664.69)
            {
                ir = (salarioBrutoAux * 0.275);
                deducao = 869.36;
            }

            if (salarioBrutoAux >= 1903.99)
            {
                ir -= deducao;
            }
               
            salarioBrutoAux -= ir;

            salarioLiquido = salarioBrutoAux;

        }

    }
}