using System;

namespace FolhaDePagamento.auxiliares
{
    public class Messages
    {
         public static void inicio()
         {
             Console.WriteLine("\nCálculo de folha de pagamento");
             Console.WriteLine("----------------------------------\n");
         }

        public static void operacaoRealizada(ref double salarioBrutoAux, ref double valorHora, ref double valorHoraExtraUnidade, ref double valorHoraExtra, ref double inss, ref double ir, ref double salarioLiquido)
         {
             Console.WriteLine("\n-------------------------------------------");
             Console.WriteLine("Calculo concluido!!\n");
             Console.WriteLine("Informações do funcionario");
             Console.WriteLine($"\nSalario bruto: R${salarioBrutoAux} \nValor da hora: R${valorHora} \nValor da hora extra: R${valorHoraExtraUnidade} \nValor do total de horas extras: R${valorHoraExtra} \nINSS: R${inss} \nIR: R${ir} \nSalário Líquido: R${salarioLiquido}\n");
         }
    }
}