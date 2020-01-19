using System;

namespace FolhaDePagamento.auxiliares
{
    public class Messages
    {
         public static void inicio()
         {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Cálculo de folha de pagamento");
            Console.WriteLine("----------------------------------------------------\n");
         }

        public static void operacaoRealizada(ref double salarioBruto, ref double valorHora, ref double valorHoraExtraUnidade, ref double valorHoraExtra, ref double inss, ref double ir, ref double salarioLiquido, ref Pessoa cadastro)
         {
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("\nCalculo concluido!!\n");
            Console.WriteLine("----------------------------------------------------\n");
            Console.WriteLine("Informações do funcionario");
            Console.WriteLine("\n====================================================\n");
            Console.WriteLine($"Nome: {cadastro.nome}\nSalario bruto: R${salarioBruto} \nValor da hora: R${valorHora} \nValor da hora extra: R${valorHoraExtraUnidade} \nValor do total de horas extras: R${valorHoraExtra} \nINSS: R${inss} \nIR: R${ir} \nSalário Líquido: R${salarioLiquido}");
            Console.WriteLine("\n====================================================\n");
         }
    }
}