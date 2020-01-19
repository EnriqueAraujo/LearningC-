using System;

namespace TesteCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            Metodos.inicio();

            var opcaoUsuario = Metodos.menuInput();
            int [] valores = new int[0];
            bool verificaVetor = false;
            bool corrigePrint = false;
            int aux = 0;

            //mantém a aplicação rodando até o usuario sair
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //Carrega vetor
                        Metodos.carregarVetor(ref valores, ref verificaVetor);

                        break;
                    case "2":
                        // Boble sort crescente
                        Metodos.boobleSort(ref valores, ref verificaVetor, ref aux, ref corrigePrint);
    
                        break;
                    case "3":
                        //Boble sort decrescente
                        Metodos.boobleSortInverso(ref valores, ref verificaVetor, ref aux, ref corrigePrint);

                        break;
                    case "4":
                        //Printar vetor
                        Metodos.printaVetor(ref valores, ref verificaVetor, ref corrigePrint);

                        break;
                    default:
                        //Mostra mensagem de erro
                        Console.WriteLine("\n-------------------------------------------");
                        Console.WriteLine("Opção invalida\nPor favor, digite uma opção valida");
                        Console.WriteLine("-------------------------------------------\n");
                        break;
                }
            opcaoUsuario = Metodos.menuInput(); 
            }

            Metodos.encerrar();

        }
        
    }
}
